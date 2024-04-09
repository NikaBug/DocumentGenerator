namespace WinFormsUI
{ 
    /// <summary>
    /// Дані таблиці
    /// </summary>
    public class TableData
    {
        public int numberRows { get; set; }
        public int numberColumns { get; set; }
        public string[,] arrayData { get; set; }

        public TableData(int rows, int cols) 
        { 
            this.numberRows = rows;
            this.numberColumns = cols;
            this.arrayData = new string[rows, cols];
        }
    }
}
