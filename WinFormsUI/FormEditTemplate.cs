using MaterialSkin;
using MaterialSkin.Controls;

namespace WinFormsUI
{
    public partial class FormEditTemplate : MaterialForm
    {
        public FormEditTemplate(string fileName)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            this.materialTextBoxTemplateName.Text = fileName;

            DataGridViewComboBoxColumn theColumn = (DataGridViewComboBoxColumn)this.dataGridViewBookmarksSetting.Columns[1];
            theColumn.Items.Add("Текст");
            theColumn.Items.Add("Таблиця");
            theColumn.Items.Add("Зображення");
        }
    }
}
