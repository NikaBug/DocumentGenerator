using MaterialSkin;
using MaterialSkin.Controls;

namespace WinFormsUI
{
    public partial class FormTextData : MaterialForm
    {
        public string TextData { get; set; }

        public FormTextData()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            this.materialLabelMaxLengthSymbol.Text += " " + this.materialMultiLineTextBoxTextData.MaxLength.ToString();

        }

        private void materialMultiLineTextBoxTextData_TextChanged(object sender, EventArgs e)
        {
            this.materialLabelCurrentCountSymbols.Text = this.materialMultiLineTextBoxTextData.Text.Length.ToString();
        }

        private void materialButtonClearTextData_Click(object sender, EventArgs e)
        {
            if (this.materialMultiLineTextBoxTextData.Text.Length > 0)
                this.materialMultiLineTextBoxTextData.Clear();
            else
                CustomMessageBox.Show("Поле для введення тексту вже очищене!", "Очищення", MessageBoxButtons.OK);
        }

        private void materialButtonSaveTextData_Click(object sender, EventArgs e)
        {
            if (this.materialMultiLineTextBoxTextData.Text.Length > 0)
            {
                TextData = this.materialMultiLineTextBoxTextData.Text;
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
