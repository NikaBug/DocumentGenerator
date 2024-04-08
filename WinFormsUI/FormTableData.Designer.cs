namespace WinFormsUI
{
    partial class FormTableData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dataGridViewTableData = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            materialLabelNumbersRows = new MaterialSkin.Controls.MaterialLabel();
            materialLabelNumbersColums = new MaterialSkin.Controls.MaterialLabel();
            materialButtonGenerateTable = new MaterialSkin.Controls.MaterialButton();
            numericUpDownNumberRows = new NumericUpDown();
            numericUpDownNumberColumns = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTableData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumberRows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumberColumns).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTableData
            // 
            dataGridViewTableData.AllowUserToAddRows = false;
            dataGridViewTableData.AllowUserToDeleteRows = false;
            dataGridViewTableData.AllowUserToResizeColumns = false;
            dataGridViewTableData.AllowUserToResizeRows = false;
            dataGridViewTableData.BackgroundColor = Color.White;
            dataGridViewTableData.BorderStyle = BorderStyle.None;
            dataGridViewTableData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewTableData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewTableData.ColumnHeadersHeight = 35;
            dataGridViewTableData.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(100, 100, 180);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridViewTableData.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewTableData.EnableHeadersVisualStyles = false;
            dataGridViewTableData.GridColor = Color.LightGray;
            dataGridViewTableData.Location = new Point(32, 233);
            dataGridViewTableData.MultiSelect = false;
            dataGridViewTableData.Name = "dataGridViewTableData";
            dataGridViewTableData.RowHeadersWidth = 25;
            dataGridViewTableData.RowTemplate.Height = 25;
            dataGridViewTableData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTableData.Size = new Size(652, 209);
            dataGridViewTableData.TabIndex = 14;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // materialLabelNumbersRows
            // 
            materialLabelNumbersRows.AutoSize = true;
            materialLabelNumbersRows.Depth = 0;
            materialLabelNumbersRows.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelNumbersRows.Location = new Point(32, 90);
            materialLabelNumbersRows.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelNumbersRows.Name = "materialLabelNumbersRows";
            materialLabelNumbersRows.Size = new Size(125, 19);
            materialLabelNumbersRows.TabIndex = 17;
            materialLabelNumbersRows.Text = "Кількість рядків";
            // 
            // materialLabelNumbersColums
            // 
            materialLabelNumbersColums.AutoSize = true;
            materialLabelNumbersColums.Depth = 0;
            materialLabelNumbersColums.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelNumbersColums.Location = new Point(32, 142);
            materialLabelNumbersColums.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelNumbersColums.Name = "materialLabelNumbersColums";
            materialLabelNumbersColums.Size = new Size(140, 19);
            materialLabelNumbersColums.TabIndex = 18;
            materialLabelNumbersColums.Text = "Кількість стовпців";
            // 
            // materialButtonGenerateTable
            // 
            materialButtonGenerateTable.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonGenerateTable.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonGenerateTable.Depth = 0;
            materialButtonGenerateTable.HighEmphasis = true;
            materialButtonGenerateTable.Icon = null;
            materialButtonGenerateTable.Location = new Point(32, 188);
            materialButtonGenerateTable.Margin = new Padding(4, 6, 4, 6);
            materialButtonGenerateTable.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonGenerateTable.Name = "materialButtonGenerateTable";
            materialButtonGenerateTable.NoAccentTextColor = Color.Empty;
            materialButtonGenerateTable.Size = new Size(175, 36);
            materialButtonGenerateTable.TabIndex = 19;
            materialButtonGenerateTable.Text = "Створити таблицю";
            materialButtonGenerateTable.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonGenerateTable.UseAccentColor = false;
            materialButtonGenerateTable.UseVisualStyleBackColor = true;
            materialButtonGenerateTable.Click += materialButtonGenerateTable_Click;
            // 
            // numericUpDownNumberRows
            // 
            numericUpDownNumberRows.BorderStyle = BorderStyle.FixedSingle;
            numericUpDownNumberRows.Location = new Point(212, 84);
            numericUpDownNumberRows.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownNumberRows.Name = "numericUpDownNumberRows";
            numericUpDownNumberRows.Size = new Size(76, 31);
            numericUpDownNumberRows.TabIndex = 20;
            numericUpDownNumberRows.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownNumberColumns
            // 
            numericUpDownNumberColumns.BorderStyle = BorderStyle.FixedSingle;
            numericUpDownNumberColumns.Location = new Point(212, 133);
            numericUpDownNumberColumns.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownNumberColumns.Name = "numericUpDownNumberColumns";
            numericUpDownNumberColumns.Size = new Size(76, 31);
            numericUpDownNumberColumns.TabIndex = 21;
            numericUpDownNumberColumns.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // FormTableData
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 482);
            Controls.Add(numericUpDownNumberColumns);
            Controls.Add(numericUpDownNumberRows);
            Controls.Add(materialButtonGenerateTable);
            Controls.Add(materialLabelNumbersColums);
            Controls.Add(materialLabelNumbersRows);
            Controls.Add(dataGridViewTableData);
            Name = "FormTableData";
            Text = "Заповнити таблицю";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTableData).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumberRows).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumberColumns).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewTableData;
        private MaterialSkin.Controls.MaterialLabel materialLabelNumbersRows;
        private MaterialSkin.Controls.MaterialLabel materialLabelNumbersColums;
        private MaterialSkin.Controls.MaterialButton materialButtonGenerateTable;
        private DataGridViewTextBoxColumn Column1;
        private NumericUpDown numericUpDownNumberRows;
        private NumericUpDown numericUpDownNumberColumns;
    }
}