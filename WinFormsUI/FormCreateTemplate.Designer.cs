namespace WinFormsUI
{
    partial class FormCreateTemplate
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
            materialLabelNameTemplate = new MaterialSkin.Controls.MaterialLabel();
            materialTextBoxNameTemplate = new MaterialSkin.Controls.MaterialTextBox();
            materialLabelContentTemplate = new MaterialSkin.Controls.MaterialLabel();
            materialButtonOpenFile = new MaterialSkin.Controls.MaterialButton();
            materialButtonCreateTemplate = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // materialLabelNameTemplate
            // 
            materialLabelNameTemplate.AutoSize = true;
            materialLabelNameTemplate.Depth = 0;
            materialLabelNameTemplate.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelNameTemplate.Location = new Point(22, 79);
            materialLabelNameTemplate.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelNameTemplate.Name = "materialLabelNameTemplate";
            materialLabelNameTemplate.Size = new Size(117, 19);
            materialLabelNameTemplate.TabIndex = 0;
            materialLabelNameTemplate.Text = "Назва шаблону";
            // 
            // materialTextBoxNameTemplate
            // 
            materialTextBoxNameTemplate.AnimateReadOnly = false;
            materialTextBoxNameTemplate.BorderStyle = BorderStyle.None;
            materialTextBoxNameTemplate.Depth = 0;
            materialTextBoxNameTemplate.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxNameTemplate.Hint = "введіть назву шаблону";
            materialTextBoxNameTemplate.LeadingIcon = null;
            materialTextBoxNameTemplate.Location = new Point(156, 77);
            materialTextBoxNameTemplate.MaxLength = 50;
            materialTextBoxNameTemplate.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxNameTemplate.Multiline = false;
            materialTextBoxNameTemplate.Name = "materialTextBoxNameTemplate";
            materialTextBoxNameTemplate.Size = new Size(327, 36);
            materialTextBoxNameTemplate.TabIndex = 2;
            materialTextBoxNameTemplate.Text = "";
            materialTextBoxNameTemplate.TrailingIcon = null;
            materialTextBoxNameTemplate.UseTallSize = false;
            // 
            // materialLabelContentTemplate
            // 
            materialLabelContentTemplate.AutoSize = true;
            materialLabelContentTemplate.Depth = 0;
            materialLabelContentTemplate.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelContentTemplate.Location = new Point(22, 139);
            materialLabelContentTemplate.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelContentTemplate.Name = "materialLabelContentTemplate";
            materialLabelContentTemplate.Size = new Size(94, 19);
            materialLabelContentTemplate.TabIndex = 3;
            materialLabelContentTemplate.Text = "Зміст файлу";
            // 
            // materialButtonOpenFile
            // 
            materialButtonOpenFile.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonOpenFile.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonOpenFile.Depth = 0;
            materialButtonOpenFile.HighEmphasis = true;
            materialButtonOpenFile.Icon = null;
            materialButtonOpenFile.Location = new Point(156, 126);
            materialButtonOpenFile.Margin = new Padding(4, 6, 4, 6);
            materialButtonOpenFile.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonOpenFile.Name = "materialButtonOpenFile";
            materialButtonOpenFile.NoAccentTextColor = Color.Empty;
            materialButtonOpenFile.Size = new Size(234, 36);
            materialButtonOpenFile.TabIndex = 4;
            materialButtonOpenFile.Text = "Завантажити зміст файлу";
            materialButtonOpenFile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonOpenFile.UseAccentColor = false;
            materialButtonOpenFile.UseVisualStyleBackColor = true;
            // 
            // materialButtonCreateTemplate
            // 
            materialButtonCreateTemplate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonCreateTemplate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonCreateTemplate.Depth = 0;
            materialButtonCreateTemplate.HighEmphasis = true;
            materialButtonCreateTemplate.Icon = null;
            materialButtonCreateTemplate.Location = new Point(22, 196);
            materialButtonCreateTemplate.Margin = new Padding(4, 6, 4, 6);
            materialButtonCreateTemplate.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonCreateTemplate.Name = "materialButtonCreateTemplate";
            materialButtonCreateTemplate.NoAccentTextColor = Color.Empty;
            materialButtonCreateTemplate.Size = new Size(166, 36);
            materialButtonCreateTemplate.TabIndex = 5;
            materialButtonCreateTemplate.Text = "Створити шаблон";
            materialButtonCreateTemplate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonCreateTemplate.UseAccentColor = false;
            materialButtonCreateTemplate.UseVisualStyleBackColor = true;
            // 
            // FormCreateTemplate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 295);
            Controls.Add(materialButtonCreateTemplate);
            Controls.Add(materialButtonOpenFile);
            Controls.Add(materialLabelContentTemplate);
            Controls.Add(materialTextBoxNameTemplate);
            Controls.Add(materialLabelNameTemplate);
            Name = "FormCreateTemplate";
            Text = "Створити шаблон";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabelNameTemplate;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxNameTemplate;
        private MaterialSkin.Controls.MaterialLabel materialLabelContentTemplate;
        private MaterialSkin.Controls.MaterialButton materialButtonOpenFile;
        private MaterialSkin.Controls.MaterialButton materialButtonCreateTemplate;
    }
}