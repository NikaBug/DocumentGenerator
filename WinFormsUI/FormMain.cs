using MaterialSkin;
using MaterialSkin.Controls;

namespace WinFormsUI
{
    public partial class FormMain : MaterialForm
    {
        public FormMain()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }
    }
}