using MaterialSkin;
using MaterialSkin.Controls;

namespace WinFormsUI
{
    public partial class FormTableData : MaterialForm
    {
        public TableData tableData { get; set; }

        public FormTableData()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            this.tableData = new TableData(0, 0);
        }

        private void ShowTable()
        {
            // виведення номерів стовпців таблиці і заборона сортування їх змісту
            for (int i = 0; i < this.tableData.numberColumns; i++)
            {
                this.dataGridViewTableData.Columns[i].HeaderCell.Value = "Column" + Convert.ToString(i + 1);
                this.dataGridViewTableData.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                this.dataGridViewTableData.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            for (int i = 0; i < this.tableData.numberRows; i++)
            {
                this.dataGridViewTableData.Rows[i].HeaderCell.Value = Convert.ToString(i + 1);
                for (int j = 0; j < this.tableData.numberColumns; ++j)
                    this.dataGridViewTableData.Rows[i].Cells[j].Value = Convert.ToString(this.tableData.arrayData[i, j]);
            }
        }

        private void materialButtonGenerateTable_Click(object sender, EventArgs e)
        {
            if (this.tableData.arrayData != null)
            {
                Array.Clear(this.tableData.arrayData, 0, this.tableData.arrayData.Length);
            }

            int numberRows = Convert.ToInt32(numericUpDownNumberRows.Value);
            int numberColumns = Convert.ToInt32(numericUpDownNumberColumns.Value);

            this.tableData = new TableData(numberRows, numberColumns);

            this.dataGridViewTableData.RowCount = this.tableData.numberRows;
            this.dataGridViewTableData.ColumnCount = this.tableData.numberColumns;
            //заповнення таблиці
            for (int i = 0; i < this.tableData.numberRows; i++)
                for (int j = 0; j < this.tableData.numberColumns; j++)
                    this.tableData.arrayData[i, j] = "Text" + (i + j).ToString();
            ShowTable();
        }

        private void materialButtonSaveTableData_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewTableData.Rows.Count == 0)
            {
                CustomMessageBox.Show("Створіть таблицю та заповніть її даними!", "Збереження даних таблиці", MessageBoxButtons.OK);
                return;
            }
            else
            {
                CustomMessageBox.Show("Дані таблиці успішно збережені!", "Збереження даних таблиці", MessageBoxButtons.OK);
            }

            this.Close();
        }

        private void dataGridViewTableData_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // індекси елемента матриці для поточной клітки таблиці
            int i = this.dataGridViewTableData.CurrentCell.RowIndex;
            int j = this.dataGridViewTableData.CurrentCell.ColumnIndex;

            if (dataGridViewTableData.CurrentCell.Value == null)
            {
                CustomMessageBox.Show("Значення клітинки таблиці не має бути порожнім!", "Значення клітинок таблиці", MessageBoxButtons.OK);
            }
            else
            {
                string value = Convert.ToString(dataGridViewTableData.CurrentCell.Value);
                this.tableData.arrayData[i, j] = value;
            }

        }

        private void materialButtonClearTableData_Click(object sender, EventArgs e)
        {
            // Array.Clear(this.tableData.arrayData, 0, this.tableData.arrayData.Length);
            if (this.dataGridViewTableData.Rows.Count == 0)
            {
                CustomMessageBox.Show("Таблиця для очищення не створена!", "Очищення", MessageBoxButtons.OK);
                return;
            }
            for (int i = 0; i < this.tableData.numberRows; i++)
                for (int j = 0; j < this.tableData.numberColumns; j++)
                    this.tableData.arrayData[i, j] = "";
            // this.dataGridViewTableData.Rows.Clear();
            ShowTable();
        }
    }
}
