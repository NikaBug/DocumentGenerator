using MaterialSkin;
using MaterialSkin.Controls;

namespace WinFormsUI
{
    public partial class FormYesNo : MaterialForm
    {
        public FormYesNo()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        public string Message
        {
            get { return materialLabelTextMessage.Text; }
            set { materialLabelTextMessage.Text = value; }
        }
    }
}
