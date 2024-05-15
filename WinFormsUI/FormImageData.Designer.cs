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
            ButtonLoadImage = new MaterialSkin.Controls.MaterialButton();
            ButtonSaveImage = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImageData).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxImageData
            // 
            pictureBoxImageData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxImageData.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxImageData.Location = new Point(6, 67);
            pictureBoxImageData.Name = "pictureBoxImageData";
            pictureBoxImageData.Size = new Size(908, 403);
            pictureBoxImageData.TabIndex = 0;
            pictureBoxImageData.TabStop = false;
            // 
            // ButtonLoadImage
            // 
            ButtonLoadImage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonLoadImage.AutoSize = false;
            ButtonLoadImage.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonLoadImage.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonLoadImage.Depth = 0;
            ButtonLoadImage.HighEmphasis = true;
            ButtonLoadImage.Icon = Properties.Resources.icons8_upload_image_50;
            ButtonLoadImage.Location = new Point(190, 482);
            ButtonLoadImage.Margin = new Padding(4, 6, 4, 6);
            ButtonLoadImage.MouseState = MaterialSkin.MouseState.HOVER;
            ButtonLoadImage.Name = "ButtonLoadImage";
            ButtonLoadImage.NoAccentTextColor = Color.Empty;
            ButtonLoadImage.Size = new Size(198, 41);
            ButtonLoadImage.TabIndex = 1;
            ButtonLoadImage.Text = "Завантажити зображення";
            ButtonLoadImage.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonLoadImage.UseAccentColor = false;
            ButtonLoadImage.UseVisualStyleBackColor = true;
            ButtonLoadImage.Click += ButtonLoadImage_Click;
            // 
            // ButtonSaveImage
            // 
            ButtonSaveImage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonSaveImage.AutoSize = false;
            ButtonSaveImage.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonSaveImage.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonSaveImage.Depth = 0;
            ButtonSaveImage.HighEmphasis = true;
            ButtonSaveImage.Icon = Properties.Resources.icons8_save_50;
            ButtonSaveImage.Location = new Point(430, 482);
            ButtonSaveImage.Margin = new Padding(4, 6, 4, 6);
            ButtonSaveImage.MouseState = MaterialSkin.MouseState.HOVER;
            ButtonSaveImage.Name = "ButtonSaveImage";
            ButtonSaveImage.NoAccentTextColor = Color.Empty;
            ButtonSaveImage.Size = new Size(198, 41);
            ButtonSaveImage.TabIndex = 2;
            ButtonSaveImage.Text = "Зберегти зображення";
            ButtonSaveImage.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonSaveImage.UseAccentColor = false;
            ButtonSaveImage.UseVisualStyleBackColor = true;
            ButtonSaveImage.Click += ButtonSaveImage_Click;
            // 
            // FormImageData
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 533);
            Controls.Add(ButtonSaveImage);
            Controls.Add(ButtonLoadImage);
            Controls.Add(pictureBoxImageData);
            Name = "FormImageData";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Завантаження зображення";
            ((System.ComponentModel.ISupportInitialize)pictureBoxImageData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxImageData;
        private MaterialSkin.Controls.MaterialButton ButtonLoadImage;
        private MaterialSkin.Controls.MaterialButton ButtonSaveImage;
    }
}