using MaterialSkin;
using MaterialSkin.Controls;

namespace WinFormsUI
{
    public partial class FormTextData : MaterialForm
    {
        public FormTextData()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //string text = this.materialMultiLineTextBoxTextData.Text;
            this.materialLabelMaxLengthSymbol.Text += " " +  this.materialMultiLineTextBoxTextData.MaxLength.ToString();
        
        }

        private void materialMultiLineTextBoxTextData_TextChanged(object sender, EventArgs e)
        {
            this.materialLabelCurrentCountSymbols.Text = this.materialMultiLineTextBoxTextData.Text.Length.ToString();
        }
    }
}
