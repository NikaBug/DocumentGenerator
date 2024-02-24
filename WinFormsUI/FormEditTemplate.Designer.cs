namespace WinFormsUI
{
    partial class FormEditTemplate
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
            materialTextBoxTemplateName = new MaterialSkin.Controls.MaterialTextBox();
            materialLabelTemplateName = new MaterialSkin.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // materialTextBoxTemplateName
            // 
            materialTextBoxTemplateName.AnimateReadOnly = false;
            materialTextBoxTemplateName.BorderStyle = BorderStyle.None;
            materialTextBoxTemplateName.Depth = 0;
            materialTextBoxTemplateName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxTemplateName.LeadingIcon = null;
            materialTextBoxTemplateName.Location = new Point(158, 109);
            materialTextBoxTemplateName.MaxLength = 50;
            materialTextBoxTemplateName.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxTemplateName.Multiline = false;
            materialTextBoxTemplateName.Name = "materialTextBoxTemplateName";
            materialTextBoxTemplateName.Size = new Size(255, 36);
            materialTextBoxTemplateName.TabIndex = 0;
            materialTextBoxTemplateName.Text = "";
            materialTextBoxTemplateName.TrailingIcon = null;
            materialTextBoxTemplateName.UseTallSize = false;
            // 
            // materialLabelTemplateName
            // 
            materialLabelTemplateName.AutoSize = true;
            materialLabelTemplateName.Depth = 0;
            materialLabelTemplateName.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelTemplateName.Location = new Point(35, 111);
            materialLabelTemplateName.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelTemplateName.Name = "materialLabelTemplateName";
            materialLabelTemplateName.Size = new Size(117, 19);
            materialLabelTemplateName.TabIndex = 1;
            materialLabelTemplateName.Text = "Назва шаблону";
            // 
            // FormEditTemplate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(materialLabelTemplateName);
            Controls.Add(materialTextBoxTemplateName);
            Name = "FormEditTemplate";
            Text = "Редагування шаблону";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox materialTextBoxTemplateName;
        private MaterialSkin.Controls.MaterialLabel materialLabelTemplateName;
    }
}