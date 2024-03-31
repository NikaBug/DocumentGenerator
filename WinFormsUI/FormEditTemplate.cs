using MaterialSkin;
using MaterialSkin.Controls;

namespace WinFormsUI
{
    public partial class FormEditTemplate : MaterialForm
    {
       // List<string> typeDataBookmark = new List<string>() { "Текст", "Таблиця", "Зображення" };

        public FormEditTemplate(string fileName)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            this.materialTextBoxTemplateName.Text = fileName;
            //for (int i = 0; i < 3; i++)
            //{
            //    // this.dataGridViewTableBookmarks.Rows.Add("");
            //    string bookmark = "bookmark" + i.ToString();
            //    this.dataGridViewEditTableBookmarks.Rows.Add(bookmark);
            //}

            //DataGridViewComboBoxColumn theColumn = (DataGridViewComboBoxColumn)this.dataGridViewEditTableBookmarks.Columns[1];
            //theColumn.Items.Add(typeDataBookmark[0]);
            //theColumn.Items.Add(typeDataBookmark[1]);
            //theColumn.Items.Add(typeDataBookmark[2]);
            //theColumn.DefaultCellStyle.NullValue = typeDataBookmark[0];

        }

    }
}
