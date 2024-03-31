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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridViewTableData = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            numericUpDownRowsTable = new NumericUpDown();
            numericUpDownNumbersColumns = new NumericUpDown();
            materialLabelNumbersRows = new MaterialSkin.Controls.MaterialLabel();
            materialLabelNumbersColums = new MaterialSkin.Controls.MaterialLabel();
            materialButtonGenerateTable = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTableData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRowsTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumbersColumns).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTableData
            // 
            dataGridViewTableData.AllowUserToAddRows = false;
            dataGridViewTableData.AllowUserToDeleteRows = false;
            dataGridViewTableData.AllowUserToResizeColumns = false;
            dataGridViewTableData.AllowUserToResizeRows = false;
            dataGridViewTableData.BackgroundColor = Color.White;
            dataGridViewTableData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewTableData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewTableData.ColumnHeadersHeight = 35;
            dataGridViewTableData.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(100, 100, 180);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewTableData.DefaultCellStyle = dataGridViewCellStyle2;
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
            // numericUpDownRowsTable
            // 
            numericUpDownRowsTable.BackColor = Color.MediumSlateBlue;
            numericUpDownRowsTable.BorderStyle = BorderStyle.FixedSingle;
            numericUpDownRowsTable.ForeColor = SystemColors.Window;
            numericUpDownRowsTable.Location = new Point(186, 90);
            numericUpDownRowsTable.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownRowsTable.Name = "numericUpDownRowsTable";
            numericUpDownRowsTable.Size = new Size(77, 31);
            numericUpDownRowsTable.TabIndex = 15;
            numericUpDownRowsTable.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownNumbersColumns
            // 
            numericUpDownNumbersColumns.BackColor = Color.MediumSlateBlue;
            numericUpDownNumbersColumns.BorderStyle = BorderStyle.FixedSingle;
            numericUpDownNumbersColumns.ForeColor = SystemColors.Window;
            numericUpDownNumbersColumns.Location = new Point(186, 133);
            numericUpDownNumbersColumns.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownNumbersColumns.Name = "numericUpDownNumbersColumns";
            numericUpDownNumbersColumns.Size = new Size(77, 31);
            numericUpDownNumbersColumns.TabIndex = 16;
            numericUpDownNumbersColumns.Value = new decimal(new int[] { 1, 0, 0, 0 });
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
            // 
            // FormTableData
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 482);
            Controls.Add(materialButtonGenerateTable);
            Controls.Add(materialLabelNumbersColums);
            Controls.Add(materialLabelNumbersRows);
            Controls.Add(numericUpDownNumbersColumns);
            Controls.Add(numericUpDownRowsTable);
            Controls.Add(dataGridViewTableData);
            Name = "FormTableData";
            Text = "Заповнити таблицю";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTableData).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRowsTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumbersColumns).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewTableData;
        private NumericUpDown numericUpDownRowsTable;
        private NumericUpDown numericUpDownNumbersColumns;
        private MaterialSkin.Controls.MaterialLabel materialLabelNumbersRows;
        private MaterialSkin.Controls.MaterialLabel materialLabelNumbersColums;
        private MaterialSkin.Controls.MaterialButton materialButtonGenerateTable;
        private DataGridViewTextBoxColumn Column1;
    }
}