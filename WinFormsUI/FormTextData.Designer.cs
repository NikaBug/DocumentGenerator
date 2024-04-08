namespace WinFormsUI
{
    partial class FormTextData
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
            materialMultiLineTextBoxTextData = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            materialLabelNoteCountSymbols = new MaterialSkin.Controls.MaterialLabel();
            materialLabelCurrentCountSymbols = new MaterialSkin.Controls.MaterialLabel();
            materialLabelMaxLengthSymbol = new MaterialSkin.Controls.MaterialLabel();
            materialButtonSaveTextData = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // materialMultiLineTextBoxTextData
            // 
            materialMultiLineTextBoxTextData.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            materialMultiLineTextBoxTextData.AnimateReadOnly = false;
            materialMultiLineTextBoxTextData.BackgroundImageLayout = ImageLayout.None;
            materialMultiLineTextBoxTextData.CharacterCasing = CharacterCasing.Normal;
            materialMultiLineTextBoxTextData.Depth = 0;
            materialMultiLineTextBoxTextData.HideSelection = true;
            materialMultiLineTextBoxTextData.Hint = "Текст для заповнення";
            materialMultiLineTextBoxTextData.Location = new Point(19, 88);
            materialMultiLineTextBoxTextData.MaxLength = 32767;
            materialMultiLineTextBoxTextData.MouseState = MaterialSkin.MouseState.OUT;
            materialMultiLineTextBoxTextData.Name = "materialMultiLineTextBoxTextData";
            materialMultiLineTextBoxTextData.PasswordChar = '\0';
            materialMultiLineTextBoxTextData.ReadOnly = false;
            materialMultiLineTextBoxTextData.ScrollBars = ScrollBars.None;
            materialMultiLineTextBoxTextData.SelectedText = "";
            materialMultiLineTextBoxTextData.SelectionLength = 0;
            materialMultiLineTextBoxTextData.SelectionStart = 0;
            materialMultiLineTextBoxTextData.ShortcutsEnabled = true;
            materialMultiLineTextBoxTextData.Size = new Size(766, 299);
            materialMultiLineTextBoxTextData.TabIndex = 0;
            materialMultiLineTextBoxTextData.TabStop = false;
            materialMultiLineTextBoxTextData.TextAlign = HorizontalAlignment.Left;
            materialMultiLineTextBoxTextData.UseSystemPasswordChar = false;
            materialMultiLineTextBoxTextData.TextChanged += materialMultiLineTextBoxTextData_TextChanged;
            // 
            // materialLabelNoteCountSymbols
            // 
            materialLabelNoteCountSymbols.AutoSize = true;
            materialLabelNoteCountSymbols.Depth = 0;
            materialLabelNoteCountSymbols.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelNoteCountSymbols.Location = new Point(443, 390);
            materialLabelNoteCountSymbols.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelNoteCountSymbols.Name = "materialLabelNoteCountSymbols";
            materialLabelNoteCountSymbols.Size = new Size(215, 19);
            materialLabelNoteCountSymbols.TabIndex = 1;
            materialLabelNoteCountSymbols.Text = "Поточна кількість символів:";
            // 
            // materialLabelCurrentCountSymbols
            // 
            materialLabelCurrentCountSymbols.AutoSize = true;
            materialLabelCurrentCountSymbols.Depth = 0;
            materialLabelCurrentCountSymbols.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelCurrentCountSymbols.Location = new Point(664, 390);
            materialLabelCurrentCountSymbols.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelCurrentCountSymbols.Name = "materialLabelCurrentCountSymbols";
            materialLabelCurrentCountSymbols.Size = new Size(10, 19);
            materialLabelCurrentCountSymbols.TabIndex = 2;
            materialLabelCurrentCountSymbols.Text = "0";
            // 
            // materialLabelMaxLengthSymbol
            // 
            materialLabelMaxLengthSymbol.AutoSize = true;
            materialLabelMaxLengthSymbol.Depth = 0;
            materialLabelMaxLengthSymbol.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelMaxLengthSymbol.Location = new Point(443, 418);
            materialLabelMaxLengthSymbol.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelMaxLengthSymbol.Name = "materialLabelMaxLengthSymbol";
            materialLabelMaxLengthSymbol.Size = new Size(195, 19);
            materialLabelMaxLengthSymbol.TabIndex = 3;
            materialLabelMaxLengthSymbol.Text = "Макс. кількість символів:";
            // 
            // materialButtonSaveTextData
            // 
            materialButtonSaveTextData.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonSaveTextData.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonSaveTextData.Depth = 0;
            materialButtonSaveTextData.HighEmphasis = true;
            materialButtonSaveTextData.Icon = null;
            materialButtonSaveTextData.Location = new Point(19, 396);
            materialButtonSaveTextData.Margin = new Padding(4, 6, 4, 6);
            materialButtonSaveTextData.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonSaveTextData.Name = "materialButtonSaveTextData";
            materialButtonSaveTextData.NoAccentTextColor = Color.Empty;
            materialButtonSaveTextData.Size = new Size(143, 36);
            materialButtonSaveTextData.TabIndex = 4;
            materialButtonSaveTextData.Text = "Зберегти текст";
            materialButtonSaveTextData.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonSaveTextData.UseAccentColor = false;
            materialButtonSaveTextData.UseVisualStyleBackColor = true;
            // 
            // FormTextData
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 450);
            Controls.Add(materialButtonSaveTextData);
            Controls.Add(materialLabelMaxLengthSymbol);
            Controls.Add(materialLabelCurrentCountSymbols);
            Controls.Add(materialLabelNoteCountSymbols);
            Controls.Add(materialMultiLineTextBoxTextData);
            Name = "FormTextData";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Введення тексту";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialMultiLineTextBox2 materialMultiLineTextBoxTextData;
        private MaterialSkin.Controls.MaterialLabel materialLabelNoteCountSymbols;
        private MaterialSkin.Controls.MaterialLabel materialLabelCurrentCountSymbols;
        private MaterialSkin.Controls.MaterialLabel materialLabelMaxLengthSymbol;
        private MaterialSkin.Controls.MaterialButton materialButtonSaveTextData;
    }
}