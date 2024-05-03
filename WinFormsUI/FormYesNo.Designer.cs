namespace WinFormsUI
{
    partial class FormYesNo
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
            materialButtonYes = new MaterialSkin.Controls.MaterialButton();
            materialButtonNo = new MaterialSkin.Controls.MaterialButton();
            LabelTextMessage = new MaterialSkin.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // materialButtonYes
            // 
            materialButtonYes.AutoSize = false;
            materialButtonYes.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonYes.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonYes.Depth = 0;
            materialButtonYes.DialogResult = DialogResult.Yes;
            materialButtonYes.HighEmphasis = true;
            materialButtonYes.Icon = null;
            materialButtonYes.Location = new Point(41, 177);
            materialButtonYes.Margin = new Padding(4, 6, 4, 6);
            materialButtonYes.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonYes.Name = "materialButtonYes";
            materialButtonYes.NoAccentTextColor = Color.Empty;
            materialButtonYes.Size = new Size(147, 36);
            materialButtonYes.TabIndex = 1;
            materialButtonYes.Text = "Так";
            materialButtonYes.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonYes.UseAccentColor = false;
            materialButtonYes.UseVisualStyleBackColor = true;
            // 
            // materialButtonNo
            // 
            materialButtonNo.AutoSize = false;
            materialButtonNo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonNo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonNo.Depth = 0;
            materialButtonNo.DialogResult = DialogResult.No;
            materialButtonNo.HighEmphasis = true;
            materialButtonNo.Icon = null;
            materialButtonNo.Location = new Point(224, 177);
            materialButtonNo.Margin = new Padding(4, 6, 4, 6);
            materialButtonNo.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonNo.Name = "materialButtonNo";
            materialButtonNo.NoAccentTextColor = Color.Empty;
            materialButtonNo.Size = new Size(147, 36);
            materialButtonNo.TabIndex = 2;
            materialButtonNo.Text = "Ні";
            materialButtonNo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonNo.UseAccentColor = false;
            materialButtonNo.UseVisualStyleBackColor = true;
            // 
            // LabelTextMessage
            // 
            LabelTextMessage.Depth = 0;
            LabelTextMessage.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelTextMessage.Location = new Point(18, 73);
            LabelTextMessage.MouseState = MaterialSkin.MouseState.HOVER;
            LabelTextMessage.Name = "LabelTextMessage";
            LabelTextMessage.Size = new Size(402, 89);
            LabelTextMessage.TabIndex = 3;
            LabelTextMessage.Text = "materialLabelTextMessage";
            // 
            // FormYesNo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 225);
            Controls.Add(LabelTextMessage);
            Controls.Add(materialButtonNo);
            Controls.Add(materialButtonYes);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormYesNo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormYesNo";
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin.Controls.MaterialButton materialButtonYes;
        private MaterialSkin.Controls.MaterialButton materialButtonNo;
        private MaterialSkin.Controls.MaterialLabel LabelTextMessage;
    }
}