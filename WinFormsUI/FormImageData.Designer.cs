namespace WinFormsUI
{
    partial class FormImageData
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
            pictureBoxImageData = new PictureBox();
            materialButtonLoadImage = new MaterialSkin.Controls.MaterialButton();
            materialButtonSaveImage = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImageData).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxImageData
            // 
            pictureBoxImageData.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxImageData.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxImageData.Location = new Point(6, 67);
            pictureBoxImageData.Name = "pictureBoxImageData";
            pictureBoxImageData.Size = new Size(908, 393);
            pictureBoxImageData.TabIndex = 0;
            pictureBoxImageData.TabStop = false;
            // 
            // materialButtonLoadImage
            // 
            materialButtonLoadImage.AutoSize = false;
            materialButtonLoadImage.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonLoadImage.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonLoadImage.Depth = 0;
            materialButtonLoadImage.HighEmphasis = true;
            materialButtonLoadImage.Icon = null;
            materialButtonLoadImage.Location = new Point(166, 482);
            materialButtonLoadImage.Margin = new Padding(4, 6, 4, 6);
            materialButtonLoadImage.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonLoadImage.Name = "materialButtonLoadImage";
            materialButtonLoadImage.NoAccentTextColor = Color.Empty;
            materialButtonLoadImage.Size = new Size(198, 41);
            materialButtonLoadImage.TabIndex = 1;
            materialButtonLoadImage.Text = "Завантажити зображення";
            materialButtonLoadImage.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonLoadImage.UseAccentColor = false;
            materialButtonLoadImage.UseVisualStyleBackColor = true;
            materialButtonLoadImage.Click += materialButtonLoadImage_Click;
            // 
            // materialButtonSaveImage
            // 
            materialButtonSaveImage.AutoSize = false;
            materialButtonSaveImage.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonSaveImage.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonSaveImage.Depth = 0;
            materialButtonSaveImage.HighEmphasis = true;
            materialButtonSaveImage.Icon = null;
            materialButtonSaveImage.Location = new Point(394, 482);
            materialButtonSaveImage.Margin = new Padding(4, 6, 4, 6);
            materialButtonSaveImage.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonSaveImage.Name = "materialButtonSaveImage";
            materialButtonSaveImage.NoAccentTextColor = Color.Empty;
            materialButtonSaveImage.Size = new Size(198, 41);
            materialButtonSaveImage.TabIndex = 2;
            materialButtonSaveImage.Text = "Зберегти зображення";
            materialButtonSaveImage.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonSaveImage.UseAccentColor = false;
            materialButtonSaveImage.UseVisualStyleBackColor = true;
            // 
            // FormImageData
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 536);
            Controls.Add(materialButtonSaveImage);
            Controls.Add(materialButtonLoadImage);
            Controls.Add(pictureBoxImageData);
            Name = "FormImageData";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Завантаження зображення";
            ((System.ComponentModel.ISupportInitialize)pictureBoxImageData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxImageData;
        private MaterialSkin.Controls.MaterialButton materialButtonLoadImage;
        private MaterialSkin.Controls.MaterialButton materialButtonSaveImage;
    }
}