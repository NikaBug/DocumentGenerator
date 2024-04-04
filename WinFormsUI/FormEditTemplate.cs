using Aspose.Words;
using MaterialSkin;
using MaterialSkin.Controls;
using Presentation.ViewModels;

namespace WinFormsUI
{
    public partial class FormEditTemplate : MaterialForm
    {
        public TemplateViewModel Template { get; set; }

        public FormEditTemplate(TemplateViewModel models)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            Template = models;
            this.materialTextBoxTemplateName.Text = Template.FileName;

            DataGridViewComboBoxColumn theColumn = (DataGridViewComboBoxColumn)this.dataGridViewEditTableBookmarks.Columns[2];
            theColumn.Items.Add("Текст");
            theColumn.Items.Add("Зображення");
            theColumn.Items.Add("Таблиця");
            theColumn.DefaultCellStyle.NullValue = "Текст";

            foreach (var itemBookmarks in Template.BookmarksFile)
            {
                // this.dataGridViewEditTableBookmarks.Rows.Add(0, itemBookmarks.Key, itemBookmarks.Value);
                this.dataGridViewEditTableBookmarks.Rows.Add(0, itemBookmarks.Key);
            }

        }

        private void dataGridViewEditTableBookmarks_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridViewEditTableBookmarks.Rows[e.RowIndex].Cells["EditRowNumbers"].Value = (e.RowIndex + 1).ToString();
        }

        private void materialButtonSaveUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.materialTextBoxTemplateName.Text) 
                || Path.GetExtension(this.materialTextBoxTemplateName.Text) != ".docx")
            {
                CustomMessageBox.Show("Перевірте ведення назви шаблону! Назва шаблону " 
                    + this.materialTextBoxTemplateName.Text + " має містити.docx наприкінці.", "Редагування шаблону", MessageBoxButtons.OK);
                return;
            }
            Template.FileName = this.materialTextBoxTemplateName.Text;
            Template.DateModificationFile = DateTime.Now.ToString();
            Dictionary<string, string> newSettingBookmark = new Dictionary<string, string>();

            for (int indexRow = 0; indexRow < this.dataGridViewEditTableBookmarks.Rows.Count; indexRow++)
            {
                string NameBookmark = Convert.ToString(dataGridViewEditTableBookmarks.Rows[indexRow].Cells[1].FormattedValue.ToString());
                string SelectedType = Convert.ToString(dataGridViewEditTableBookmarks.Rows[indexRow].Cells[2].FormattedValue.ToString());
                newSettingBookmark.Add(NameBookmark, SelectedType);
            }

            Template.BookmarksFile = newSettingBookmark;
            Close();

        }


    }
}
