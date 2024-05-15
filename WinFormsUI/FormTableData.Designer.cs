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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTableData));
            dataGridViewTableData = new DataGridView();
            materialLabelNumbersRows = new MaterialSkin.Controls.MaterialLabel();
            materialLabelNumbersColums = new MaterialSkin.Controls.MaterialLabel();
            ButtonGenerateTable = new MaterialSkin.Controls.MaterialButton();
            numericUpDownNumberRows = new NumericUpDown();
            numericUpDownNumberColumns = new NumericUpDown();
            ButtonClearTableData = new MaterialSkin.Controls.MaterialButton();
            ButtonSaveTableData = new MaterialSkin.Controls.MaterialButton();
            LabelNoteFillTable = new MaterialSkin.Controls.MaterialLabel();
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
            dataGridViewTableData.Location = new Point(6, 267);
            dataGridViewTableData.MultiSelect = false;
            dataGridViewTableData.Name = "dataGridViewTableData";
            dataGridViewTableData.RowHeadersWidth = 25;
            dataGridViewTableData.RowTemplate.Height = 25;
            dataGridViewTableData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTableData.Size = new Size(830, 249);
            dataGridViewTableData.TabIndex = 14;
            dataGridViewTableData.CellEndEdit += dataGridViewTableData_CellEndEdit;
            // 
            // materialLabelNumbersRows
            // 
            materialLabelNumbersRows.AutoSize = true;
            materialLabelNumbersRows.Depth = 0;
            materialLabelNumbersRows.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelNumbersRows.Location = new Point(13, 90);
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
            materialLabelNumbersColums.Location = new Point(6, 146);
            materialLabelNumbersColums.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelNumbersColums.Name = "materialLabelNumbersColums";
            materialLabelNumbersColums.Size = new Size(140, 19);
            materialLabelNumbersColums.TabIndex = 18;
            materialLabelNumbersColums.Text = "Кількість стовпців";
            // 
            // ButtonGenerateTable
            // 
            ButtonGenerateTable.AutoSize = false;
            ButtonGenerateTable.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonGenerateTable.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonGenerateTable.Depth = 0;
            ButtonGenerateTable.HighEmphasis = true;
            ButtonGenerateTable.Icon = (Image)resources.GetObject("ButtonGenerateTable.Icon");
            ButtonGenerateTable.Location = new Point(6, 187);
            ButtonGenerateTable.Margin = new Padding(4, 6, 4, 6);
            ButtonGenerateTable.MouseState = MaterialSkin.MouseState.HOVER;
            ButtonGenerateTable.Name = "ButtonGenerateTable";
            ButtonGenerateTable.NoAccentTextColor = Color.Empty;
            ButtonGenerateTable.Size = new Size(138, 37);
            ButtonGenerateTable.TabIndex = 19;
            ButtonGenerateTable.Text = "Створити";
            ButtonGenerateTable.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            ButtonGenerateTable.UseAccentColor = false;
            ButtonGenerateTable.UseVisualStyleBackColor = true;
            ButtonGenerateTable.Click += ButtonGenerateTable_Click;
            // 
            // numericUpDownNumberRows
            // 
            numericUpDownNumberRows.BorderStyle = BorderStyle.FixedSingle;
            numericUpDownNumberRows.Location = new Point(159, 84);
            numericUpDownNumberRows.Maximum = new decimal(new int[] { 8, 0, 0, 0 });
            numericUpDownNumberRows.Name = "numericUpDownNumberRows";
            numericUpDownNumberRows.Size = new Size(76, 31);
            numericUpDownNumberRows.TabIndex = 20;
            numericUpDownNumberRows.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownNumberColumns
            // 
            numericUpDownNumberColumns.BorderStyle = BorderStyle.FixedSingle;
            numericUpDownNumberColumns.Location = new Point(159, 137);
            numericUpDownNumberColumns.Maximum = new decimal(new int[] { 8, 0, 0, 0 });
            numericUpDownNumberColumns.Name = "numericUpDownNumberColumns";
            numericUpDownNumberColumns.Size = new Size(76, 31);
            numericUpDownNumberColumns.TabIndex = 21;
            numericUpDownNumberColumns.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // ButtonClearTableData
            // 
            ButtonClearTableData.AutoSize = false;
            ButtonClearTableData.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonClearTableData.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonClearTableData.Depth = 0;
            ButtonClearTableData.HighEmphasis = true;
            ButtonClearTableData.Icon = (Image)resources.GetObject("ButtonClearTableData.Icon");
            ButtonClearTableData.Location = new Point(305, 187);
            ButtonClearTableData.Margin = new Padding(4, 6, 4, 6);
            ButtonClearTableData.MouseState = MaterialSkin.MouseState.HOVER;
            ButtonClearTableData.Name = "ButtonClearTableData";
            ButtonClearTableData.NoAccentTextColor = Color.Empty;
            ButtonClearTableData.Size = new Size(138, 36);
            ButtonClearTableData.TabIndex = 22;
            ButtonClearTableData.Text = "Очистити";
            ButtonClearTableData.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonClearTableData.UseAccentColor = false;
            ButtonClearTableData.UseVisualStyleBackColor = true;
            ButtonClearTableData.Click += ButtonClearTableData_Click;
            // 
            // ButtonSaveTableData
            // 
            ButtonSaveTableData.AutoSize = false;
            ButtonSaveTableData.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonSaveTableData.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonSaveTableData.Depth = 0;
            ButtonSaveTableData.HighEmphasis = true;
            ButtonSaveTableData.Icon = (Image)resources.GetObject("ButtonSaveTableData.Icon");
            ButtonSaveTableData.Location = new Point(159, 186);
            ButtonSaveTableData.Margin = new Padding(4, 6, 4, 6);
            ButtonSaveTableData.MouseState = MaterialSkin.MouseState.HOVER;
            ButtonSaveTableData.Name = "ButtonSaveTableData";
            ButtonSaveTableData.NoAccentTextColor = Color.Empty;
            ButtonSaveTableData.Size = new Size(138, 36);
            ButtonSaveTableData.TabIndex = 23;
            ButtonSaveTableData.Text = "Зберегти";
            ButtonSaveTableData.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonSaveTableData.UseAccentColor = false;
            ButtonSaveTableData.UseVisualStyleBackColor = true;
            ButtonSaveTableData.Click += ButtonSaveTableData_Click;
            // 
            // LabelNoteFillTable
            // 
            LabelNoteFillTable.AutoSize = true;
            LabelNoteFillTable.Depth = 0;
            LabelNoteFillTable.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            LabelNoteFillTable.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            LabelNoteFillTable.HighEmphasis = true;
            LabelNoteFillTable.Location = new Point(6, 247);
            LabelNoteFillTable.MouseState = MaterialSkin.MouseState.HOVER;
            LabelNoteFillTable.Name = "LabelNoteFillTable";
            LabelNoteFillTable.Size = new Size(456, 17);
            LabelNoteFillTable.TabIndex = 24;
            LabelNoteFillTable.Text = "Примітка. Перший рядок таблиці — шапка таблиці у Word документі";
            // 
            // FormTableData
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 522);
            Controls.Add(LabelNoteFillTable);
            Controls.Add(ButtonSaveTableData);
            Controls.Add(ButtonClearTableData);
            Controls.Add(numericUpDownNumberColumns);
            Controls.Add(numericUpDownNumberRows);
            Controls.Add(ButtonGenerateTable);
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
        private MaterialSkin.Controls.MaterialButton ButtonGenerateTable;
        private NumericUpDown numericUpDownNumberRows;
        private NumericUpDown numericUpDownNumberColumns;
        private MaterialSkin.Controls.MaterialButton ButtonClearTableData;
        private MaterialSkin.Controls.MaterialButton ButtonSaveTableData;
        private MaterialSkin.Controls.MaterialLabel LabelNoteFillTable;
    }
}