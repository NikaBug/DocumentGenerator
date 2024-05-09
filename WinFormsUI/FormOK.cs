using MaterialSkin;
using MaterialSkin.Controls;

namespace WinFormsUI
{
    public partial class FormOK : MaterialForm
    {
        public FormOK()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        public string Message
        {
            get { return LabelTextInfoMessage.Text; }
            set { LabelTextInfoMessage.Text = value; }
        }
    }
}
