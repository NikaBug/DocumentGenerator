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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTextData));
            materialLabelNoteCountSymbols = new MaterialSkin.Controls.MaterialLabel();
            materialLabelCurrentCountSymbols = new MaterialSkin.Controls.MaterialLabel();
            materialLabelMaxLengthSymbol = new MaterialSkin.Controls.MaterialLabel();
            ButtonSaveTextData = new MaterialSkin.Controls.MaterialButton();
            ButtonClearTextData = new MaterialSkin.Controls.MaterialButton();
            MultiLineTextBoxTextData = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            SuspendLayout();
            // 
            // materialLabelNoteCountSymbols
            // 
            materialLabelNoteCountSymbols.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            materialLabelNoteCountSymbols.AutoSize = true;
            materialLabelNoteCountSymbols.Depth = 0;
            materialLabelNoteCountSymbols.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelNoteCountSymbols.Location = new Point(388, 451);
            materialLabelNoteCountSymbols.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelNoteCountSymbols.Name = "materialLabelNoteCountSymbols";
            materialLabelNoteCountSymbols.Size = new Size(215, 19);
            materialLabelNoteCountSymbols.TabIndex = 1;
            materialLabelNoteCountSymbols.Text = "Поточна кількість символів:";
            // 
            // materialLabelCurrentCountSymbols
            // 
            materialLabelCurrentCountSymbols.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            materialLabelCurrentCountSymbols.AutoSize = true;
            materialLabelCurrentCountSymbols.Depth = 0;
            materialLabelCurrentCountSymbols.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelCurrentCountSymbols.Location = new Point(609, 451);
            materialLabelCurrentCountSymbols.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelCurrentCountSymbols.Name = "materialLabelCurrentCountSymbols";
            materialLabelCurrentCountSymbols.Size = new Size(10, 19);
            materialLabelCurrentCountSymbols.TabIndex = 2;
            materialLabelCurrentCountSymbols.Text = "0";
            // 
            // materialLabelMaxLengthSymbol
            // 
            materialLabelMaxLengthSymbol.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            materialLabelMaxLengthSymbol.AutoSize = true;
            materialLabelMaxLengthSymbol.Depth = 0;
            materialLabelMaxLengthSymbol.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelMaxLengthSymbol.Location = new Point(388, 485);
            materialLabelMaxLengthSymbol.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelMaxLengthSymbol.Name = "materialLabelMaxLengthSymbol";
            materialLabelMaxLengthSymbol.Size = new Size(195, 19);
            materialLabelMaxLengthSymbol.TabIndex = 3;
            materialLabelMaxLengthSymbol.Text = "Макс. кількість символів:";
            // 
            // ButtonSaveTextData
            // 
            ButtonSaveTextData.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonSaveTextData.AutoSize = false;
            ButtonSaveTextData.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonSaveTextData.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonSaveTextData.Depth = 0;
            ButtonSaveTextData.HighEmphasis = true;
            ButtonSaveTextData.Icon = (Image)resources.GetObject("ButtonSaveTextData.Icon");
            ButtonSaveTextData.Location = new Point(17, 457);
            ButtonSaveTextData.Margin = new Padding(4, 6, 4, 6);
            ButtonSaveTextData.MouseState = MaterialSkin.MouseState.HOVER;
            ButtonSaveTextData.Name = "ButtonSaveTextData";
            ButtonSaveTextData.NoAccentTextColor = Color.Empty;
            ButtonSaveTextData.Size = new Size(141, 36);
            ButtonSaveTextData.TabIndex = 4;
            ButtonSaveTextData.Text = "Зберегти";
            ButtonSaveTextData.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonSaveTextData.UseAccentColor = false;
            ButtonSaveTextData.UseVisualStyleBackColor = true;
            ButtonSaveTextData.Click += ButtonSaveTextData_Click;
            // 
            // ButtonClearTextData
            // 
            ButtonClearTextData.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonClearTextData.AutoSize = false;
            ButtonClearTextData.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonClearTextData.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonClearTextData.Depth = 0;
            ButtonClearTextData.HighEmphasis = true;
            ButtonClearTextData.Icon = (Image)resources.GetObject("ButtonClearTextData.Icon");
            ButtonClearTextData.Location = new Point(166, 457);
            ButtonClearTextData.Margin = new Padding(4, 6, 4, 6);
            ButtonClearTextData.MouseState = MaterialSkin.MouseState.HOVER;
            ButtonClearTextData.Name = "ButtonClearTextData";
            ButtonClearTextData.NoAccentTextColor = Color.Empty;
            ButtonClearTextData.Size = new Size(143, 36);
            ButtonClearTextData.TabIndex = 5;
            ButtonClearTextData.Text = "Очистити";
            ButtonClearTextData.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonClearTextData.UseAccentColor = false;
            ButtonClearTextData.UseVisualStyleBackColor = true;
            ButtonClearTextData.Click += ButtonClearTextData_Click;
            // 
            // MultiLineTextBoxTextData
            // 
            MultiLineTextBoxTextData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MultiLineTextBoxTextData.AnimateReadOnly = false;
            MultiLineTextBoxTextData.BackgroundImageLayout = ImageLayout.None;
            MultiLineTextBoxTextData.CharacterCasing = CharacterCasing.Normal;
            MultiLineTextBoxTextData.Depth = 0;
            MultiLineTextBoxTextData.HideSelection = true;
            MultiLineTextBoxTextData.Hint = "Текст для заповнення";
            MultiLineTextBoxTextData.Location = new Point(6, 74);
            MultiLineTextBoxTextData.MaxLength = 5000;
            MultiLineTextBoxTextData.MouseState = MaterialSkin.MouseState.OUT;
            MultiLineTextBoxTextData.Name = "MultiLineTextBoxTextData";
            MultiLineTextBoxTextData.PasswordChar = '\0';
            MultiLineTextBoxTextData.ReadOnly = false;
            MultiLineTextBoxTextData.ScrollBars = ScrollBars.None;
            MultiLineTextBoxTextData.SelectedText = "";
            MultiLineTextBoxTextData.SelectionLength = 0;
            MultiLineTextBoxTextData.SelectionStart = 0;
            MultiLineTextBoxTextData.ShortcutsEnabled = true;
            MultiLineTextBoxTextData.Size = new Size(801, 374);
            MultiLineTextBoxTextData.TabIndex = 7;
            MultiLineTextBoxTextData.TabStop = false;
            MultiLineTextBoxTextData.TextAlign = HorizontalAlignment.Left;
            MultiLineTextBoxTextData.UseSystemPasswordChar = false;
            MultiLineTextBoxTextData.TextChanged += MultiLineTextBoxTextData_TextChanged;
            // 
            // FormTextData
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 513);
            Controls.Add(materialLabelCurrentCountSymbols);
            Controls.Add(materialLabelMaxLengthSymbol);
            Controls.Add(MultiLineTextBoxTextData);
            Controls.Add(ButtonClearTextData);
            Controls.Add(materialLabelNoteCountSymbols);
            Controls.Add(ButtonSaveTextData);
            Name = "FormTextData";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Введення тексту";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabelNoteCountSymbols;
        private MaterialSkin.Controls.MaterialLabel materialLabelCurrentCountSymbols;
        private MaterialSkin.Controls.MaterialLabel materialLabelMaxLengthSymbol;
        private MaterialSkin.Controls.MaterialButton ButtonSaveTextData;
        private MaterialSkin.Controls.MaterialButton ButtonClearTextData;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 MultiLineTextBoxTextData;
    }
}