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
            materialLabelNumbersRows = new MaterialSkin.Controls.MaterialLabel();
            materialLabelNumbersColums = new MaterialSkin.Controls.MaterialLabel();
            materialButtonGenerateTable = new MaterialSkin.Controls.MaterialButton();
            numericUpDownNumberRows = new NumericUpDown();
            numericUpDownNumberColumns = new NumericUpDown();
            materialButtonClearTableData = new MaterialSkin.Controls.MaterialButton();
            materialButtonSaveTableData = new MaterialSkin.Controls.MaterialButton();
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
            dataGridViewTableData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewTableData.BackgroundColor = Color.White;
            dataGridViewTableData.BorderStyle = BorderStyle.None;
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
            dataGridViewTableData.Location = new Point(17, 185);
            dataGridViewTableData.MultiSelect = false;
            dataGridViewTableData.Name = "dataGridViewTableData";
            dataGridViewTableData.RowHeadersWidth = 25;
            dataGridViewTableData.RowTemplate.Height = 25;
            dataGridViewTableData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTableData.Size = new Size(733, 263);
            dataGridViewTableData.TabIndex = 14;
            dataGridViewTableData.CellEndEdit += dataGridViewTableData_CellEndEdit;
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
            materialLabelNumbersColums.Location = new Point(326, 90);
            materialLabelNumbersColums.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelNumbersColums.Name = "materialLabelNumbersColums";
            materialLabelNumbersColums.Size = new Size(140, 19);
            materialLabelNumbersColums.TabIndex = 18;
            materialLabelNumbersColums.Text = "Кількість стовпців";
            // 
            // materialButtonGenerateTable
            // 
            materialButtonGenerateTable.AutoSize = false;
            materialButtonGenerateTable.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonGenerateTable.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonGenerateTable.Depth = 0;
            materialButtonGenerateTable.HighEmphasis = true;
            materialButtonGenerateTable.Icon = null;
            materialButtonGenerateTable.Location = new Point(17, 127);
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
            numericUpDownNumberRows.Location = new Point(175, 84);
            numericUpDownNumberRows.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownNumberRows.Name = "numericUpDownNumberRows";
            numericUpDownNumberRows.Size = new Size(76, 31);
            numericUpDownNumberRows.TabIndex = 20;
            numericUpDownNumberRows.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownNumberColumns
            // 
            numericUpDownNumberColumns.BorderStyle = BorderStyle.FixedSingle;
            numericUpDownNumberColumns.Location = new Point(472, 84);
            numericUpDownNumberColumns.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownNumberColumns.Name = "numericUpDownNumberColumns";
            numericUpDownNumberColumns.Size = new Size(76, 31);
            numericUpDownNumberColumns.TabIndex = 21;
            numericUpDownNumberColumns.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // materialButtonClearTableData
            // 
            materialButtonClearTableData.AutoSize = false;
            materialButtonClearTableData.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonClearTableData.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonClearTableData.Depth = 0;
            materialButtonClearTableData.HighEmphasis = true;
            materialButtonClearTableData.Icon = null;
            materialButtonClearTableData.Location = new Point(212, 127);
            materialButtonClearTableData.Margin = new Padding(4, 6, 4, 6);
            materialButtonClearTableData.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonClearTableData.Name = "materialButtonClearTableData";
            materialButtonClearTableData.NoAccentTextColor = Color.Empty;
            materialButtonClearTableData.Size = new Size(173, 36);
            materialButtonClearTableData.TabIndex = 22;
            materialButtonClearTableData.Text = "Очистити дані";
            materialButtonClearTableData.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonClearTableData.UseAccentColor = false;
            materialButtonClearTableData.UseVisualStyleBackColor = true;
            materialButtonClearTableData.Click += materialButtonClearTableData_Click;
            // 
            // materialButtonSaveTableData
            // 
            materialButtonSaveTableData.AutoSize = false;
            materialButtonSaveTableData.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonSaveTableData.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonSaveTableData.Depth = 0;
            materialButtonSaveTableData.HighEmphasis = true;
            materialButtonSaveTableData.Icon = null;
            materialButtonSaveTableData.Location = new Point(410, 127);
            materialButtonSaveTableData.Margin = new Padding(4, 6, 4, 6);
            materialButtonSaveTableData.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonSaveTableData.Name = "materialButtonSaveTableData";
            materialButtonSaveTableData.NoAccentTextColor = Color.Empty;
            materialButtonSaveTableData.Size = new Size(173, 36);
            materialButtonSaveTableData.TabIndex = 23;
            materialButtonSaveTableData.Text = "Зберегти дані";
            materialButtonSaveTableData.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonSaveTableData.UseAccentColor = false;
            materialButtonSaveTableData.UseVisualStyleBackColor = true;
            materialButtonSaveTableData.Click += materialButtonSaveTableData_Click;
            // 
            // FormTableData
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 479);
            Controls.Add(materialButtonSaveTableData);
            Controls.Add(materialButtonClearTableData);
            Controls.Add(numericUpDownNumberColumns);
            Controls.Add(numericUpDownNumberRows);
            Controls.Add(materialButtonGenerateTable);
            Controls.Add(materialLabelNumbersColums);
            Controls.Add(materialLabelNumbersRows);
            Controls.Add(dataGridViewTableData);
            Name = "FormTableData";
            StartPosition = FormStartPosition.CenterParent;
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
        private NumericUpDown numericUpDownNumberRows;
        private NumericUpDown numericUpDownNumberColumns;
        private MaterialSkin.Controls.MaterialButton materialButtonClearTableData;
        private MaterialSkin.Controls.MaterialButton materialButtonSaveTableData;
    }
}