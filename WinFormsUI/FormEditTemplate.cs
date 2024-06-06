using MaterialSkin;
using MaterialSkin.Controls;

namespace WinFormsUI
{
    public partial class FormEditTemplate : MaterialForm
    {
        private string _oldNameTemplate;
        private Dictionary<string, string> _newBookmarksTemplate;
        private List<string> namesSavedTemplates;
        public string oldNameTemplate { get => _oldNameTemplate; set => _oldNameTemplate = value; }
        public string newNameTemplate { get => TextBoxTemplateName.Text; set => TextBoxTemplateName.Text = value; }
        public Dictionary<string, string> newBookmarksTemplate { get => _newBookmarksTemplate; set => _newBookmarksTemplate = value; }

        private bool flagSave;
        public bool SavedChanges { get => flagSave; }

        public FormEditTemplate(string templateName, Dictionary<string, string> templateBookmarks, List<string> namesSavedTemplates)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            this.TextBoxTemplateName.Text = templateName;
            oldNameTemplate = TextBoxTemplateName.Text;
            flagSave = false;
            DataGridViewComboBoxColumn theColumn = (DataGridViewComboBoxColumn)this.dataGridViewEditTableBookmarks.Columns[2];
            theColumn.Items.Add("Текст");
            theColumn.Items.Add("Зображення");
            theColumn.Items.Add("Таблиця");
            theColumn.DefaultCellStyle.NullValue = "Текст";
            foreach (var itemBookmarks in templateBookmarks)
            {
                this.dataGridViewEditTableBookmarks.Rows.Add(0, itemBookmarks.Key);
            }

            this.namesSavedTemplates = namesSavedTemplates;
        }

        private void dataGridViewEditTableBookmarks_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridViewEditTableBookmarks.Rows[e.RowIndex].Cells["EditRowNumbers"].Value = (e.RowIndex + 1).ToString();
        }

        private void materialButtonSaveUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.TextBoxTemplateName.Text)
                || Path.GetExtension(this.TextBoxTemplateName.Text) != ".docx")
            {
                CustomMessageBox.Show("Перевірте ведення назви шаблону! Назва шаблону "
                    + this.TextBoxTemplateName.Text + " має містити.docx наприкінці.",
                    "Редагування шаблону", MessageBoxButtons.OK);
                return;
            }
            else
            {
                foreach (var name in namesSavedTemplates)
                {
                    if (name == this.TextBoxTemplateName.Text)
                    {
                        CustomMessageBox.Show("Назва шаблону "
                         + this.TextBoxTemplateName.Text + " немає співпадати зі вже збереженими шаблонами!",
                         "Редагування шаблону", MessageBoxButtons.OK);
                        return;
                    }
                }
            }
            _newBookmarksTemplate = new Dictionary<string, string>();
            for (int indexRow = 0; indexRow < this.dataGridViewEditTableBookmarks.Rows.Count; indexRow++)
            {
                string NameBookmark = dataGridViewEditTableBookmarks.Rows[indexRow].Cells[1].FormattedValue.ToString();
                string SelectedType = dataGridViewEditTableBookmarks.Rows[indexRow].Cells[2].FormattedValue.ToString();
                _newBookmarksTemplate.Add(NameBookmark, SelectedType);
            }
            flagSave = true;
            this.Close();
        }
    }
}
