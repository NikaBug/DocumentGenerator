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
        }
    }
}
