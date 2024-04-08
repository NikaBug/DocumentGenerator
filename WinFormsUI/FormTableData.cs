using MaterialSkin;
using MaterialSkin.Controls;

namespace WinFormsUI
{
    public partial class FormTableData : MaterialForm
    {
        public FormTableData()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //this.dataGridViewTableData.
        }

        private void materialButtonGenerateTable_Click(object sender, EventArgs e)
        {
            int numberRows = Convert.ToInt32(numericUpDownNumberRows.Value);
            int numberColumns = Convert.ToInt32(numericUpDownNumberColumns.Value);
            this.dataGridViewTableData.RowCount = numberRows;
            this.dataGridViewTableData.ColumnCount  = numberColumns;

        }
    }
}
