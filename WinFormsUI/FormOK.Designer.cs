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
            materialLabelTextInfoMessage = new MaterialSkin.Controls.MaterialLabel();
            materialButtonOK = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // materialLabelTextInfoMessage
            // 
            materialLabelTextInfoMessage.Depth = 0;
            materialLabelTextInfoMessage.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelTextInfoMessage.Location = new Point(17, 90);
            materialLabelTextInfoMessage.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelTextInfoMessage.Name = "materialLabelTextInfoMessage";
            materialLabelTextInfoMessage.Size = new Size(357, 65);
            materialLabelTextInfoMessage.TabIndex = 0;
            materialLabelTextInfoMessage.Text = "materialLabelTextInfoMessage";
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
            materialButtonOK.Location = new Point(92, 172);
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
            // FormOK
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 224);
            Controls.Add(materialButtonOK);
            Controls.Add(materialLabelTextInfoMessage);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormOK";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormOK";
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabelTextInfoMessage;
        private MaterialSkin.Controls.MaterialButton materialButtonOK;
    }
}