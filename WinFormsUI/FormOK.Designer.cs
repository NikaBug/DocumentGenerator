namespace WinFormsUI
{
    partial class FormOK
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
            materialButtonOK = new MaterialSkin.Controls.MaterialButton();
            LabelTextInfoMessage = new MaterialSkin.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // materialButtonOK
            // 
            materialButtonOK.AutoSize = false;
            materialButtonOK.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonOK.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonOK.Depth = 0;
            materialButtonOK.DialogResult = DialogResult.OK;
            materialButtonOK.HighEmphasis = true;
            materialButtonOK.Icon = null;
            materialButtonOK.Location = new Point(97, 169);
            materialButtonOK.Margin = new Padding(4, 6, 4, 6);
            materialButtonOK.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonOK.Name = "materialButtonOK";
            materialButtonOK.NoAccentTextColor = Color.Empty;
            materialButtonOK.Size = new Size(189, 41);
            materialButtonOK.TabIndex = 1;
            materialButtonOK.Text = "OK";
            materialButtonOK.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonOK.UseAccentColor = false;
            materialButtonOK.UseVisualStyleBackColor = true;
            // 
            // LabelTextInfoMessage
            // 
            LabelTextInfoMessage.Depth = 0;
            LabelTextInfoMessage.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelTextInfoMessage.Location = new Point(13, 79);
            LabelTextInfoMessage.MouseState = MaterialSkin.MouseState.HOVER;
            LabelTextInfoMessage.Name = "LabelTextInfoMessage";
            LabelTextInfoMessage.Size = new Size(375, 84);
            LabelTextInfoMessage.TabIndex = 4;
            LabelTextInfoMessage.Text = "LabelTextInfoMessage";
            // 
            // FormOK
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 218);
            Controls.Add(LabelTextInfoMessage);
            Controls.Add(materialButtonOK);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormOK";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormOK";
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin.Controls.MaterialButton materialButtonOK;
        private MaterialSkin.Controls.MaterialLabel LabelTextInfoMessage;
    }
}