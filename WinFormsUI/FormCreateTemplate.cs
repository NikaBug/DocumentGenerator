using MaterialSkin;
using MaterialSkin.Controls;

namespace WinFormsUI
{
    public partial class FormCreateTemplate : MaterialForm
    {
        public FormCreateTemplate()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            DataGridViewComboBoxColumn theColumn = (DataGridViewComboBoxColumn)this.dataGridViewBookmarksSetting.Columns[1];
            theColumn.Items.Add("Текст");
            theColumn.Items.Add("Таблиця");
            theColumn.Items.Add("Зображення");
        }
    }
}
