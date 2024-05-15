using MaterialSkin;
using MaterialSkin.Controls;

namespace WinFormsUI
{
    public partial class FormTextData : MaterialForm
    {
        public string textData { get; set; }

        public FormTextData()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            this.materialLabelMaxLengthSymbol.Text += " " + this.MultiLineTextBoxTextData.MaxLength.ToString();

        }

        private void MultiLineTextBoxTextData_TextChanged(object sender, EventArgs e)
        {
            this.materialLabelCurrentCountSymbols.Text = this.MultiLineTextBoxTextData.Text.Length.ToString();
        }

        private void ButtonClearTextData_Click(object sender, EventArgs e)
        {
            if (this.MultiLineTextBoxTextData.Text.Length > 0)
                this.MultiLineTextBoxTextData.Clear();
            else
                CustomMessageBox.Show("Поле для введення тексту вже очищене!", "Очищення", MessageBoxButtons.OK);
        }

        private void ButtonSaveTextData_Click(object sender, EventArgs e)
        {
            if (this.MultiLineTextBoxTextData.Text.Length > 0)
            {
                textData = this.MultiLineTextBoxTextData.Text;
                CustomMessageBox.Show("Введений текст успішно збережено!", "Збереження", MessageBoxButtons.OK);
            }
            else
            {
                CustomMessageBox.Show("Для збереження заповніть текстове поле!", "Збереження", MessageBoxButtons.OK);
                return;
            }

            this.Close();
        }
    }
}
