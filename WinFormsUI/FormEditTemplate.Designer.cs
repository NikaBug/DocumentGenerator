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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            materialTextBoxTemplateName = new MaterialSkin.Controls.MaterialTextBox();
            materialLabelTemplateName = new MaterialSkin.Controls.MaterialLabel();
            dataGridViewBookmarksSetting = new DataGridView();
            dataGridViewTextBoxColumnBookmark = new DataGridViewTextBoxColumn();
            dataGridViewComboBoxColumnType = new DataGridViewComboBoxColumn();
            materialLabelSettingBookmark = new MaterialSkin.Controls.MaterialLabel();
            materialButtonSaveUpdate = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBookmarksSetting).BeginInit();
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
            // dataGridViewBookmarksSetting
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewBookmarksSetting.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewBookmarksSetting.BackgroundColor = Color.Gainsboro;
            dataGridViewBookmarksSetting.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.MediumPurple;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewBookmarksSetting.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewBookmarksSetting.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBookmarksSetting.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumnBookmark, dataGridViewComboBoxColumnType });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridViewBookmarksSetting.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewBookmarksSetting.EnableHeadersVisualStyles = false;
            dataGridViewBookmarksSetting.Location = new Point(35, 199);
            dataGridViewBookmarksSetting.Name = "dataGridViewBookmarksSetting";
            dataGridViewBookmarksSetting.RowHeadersVisible = false;
            dataGridViewBookmarksSetting.RowHeadersWidth = 62;
            dataGridViewBookmarksSetting.RowTemplate.Height = 33;
            dataGridViewBookmarksSetting.Size = new Size(466, 125);
            dataGridViewBookmarksSetting.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumnBookmark
            // 
            dataGridViewTextBoxColumnBookmark.HeaderText = "Закладка";
            dataGridViewTextBoxColumnBookmark.MinimumWidth = 8;
            dataGridViewTextBoxColumnBookmark.Name = "dataGridViewTextBoxColumnBookmark";
            dataGridViewTextBoxColumnBookmark.ReadOnly = true;
            dataGridViewTextBoxColumnBookmark.Width = 150;
            // 
            // dataGridViewComboBoxColumnType
            // 
            dataGridViewCellStyle3.BackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewComboBoxColumnType.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewComboBoxColumnType.FlatStyle = FlatStyle.Flat;
            dataGridViewComboBoxColumnType.HeaderText = "Тип даних";
            dataGridViewComboBoxColumnType.MinimumWidth = 8;
            dataGridViewComboBoxColumnType.Name = "dataGridViewComboBoxColumnType";
            dataGridViewComboBoxColumnType.Width = 150;
            // 
            // materialLabelSettingBookmark
            // 
            materialLabelSettingBookmark.AutoSize = true;
            materialLabelSettingBookmark.Depth = 0;
            materialLabelSettingBookmark.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelSettingBookmark.Location = new Point(35, 166);
            materialLabelSettingBookmark.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelSettingBookmark.Name = "materialLabelSettingBookmark";
            materialLabelSettingBookmark.Size = new Size(189, 19);
            materialLabelSettingBookmark.TabIndex = 11;
            materialLabelSettingBookmark.Text = "Налаштування закладок";
            // 
            // materialButtonSaveUpdate
            // 
            materialButtonSaveUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonSaveUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonSaveUpdate.Depth = 0;
            materialButtonSaveUpdate.HighEmphasis = true;
            materialButtonSaveUpdate.Icon = null;
            materialButtonSaveUpdate.Location = new Point(37, 350);
            materialButtonSaveUpdate.Margin = new Padding(4, 6, 4, 6);
            materialButtonSaveUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonSaveUpdate.Name = "materialButtonSaveUpdate";
            materialButtonSaveUpdate.NoAccentTextColor = Color.Empty;
            materialButtonSaveUpdate.Size = new Size(187, 36);
            materialButtonSaveUpdate.TabIndex = 12;
            materialButtonSaveUpdate.Text = "Зберегти оновлення";
            materialButtonSaveUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonSaveUpdate.UseAccentColor = false;
            materialButtonSaveUpdate.UseVisualStyleBackColor = true;
            // 
            // FormEditTemplate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 414);
            Controls.Add(materialButtonSaveUpdate);
            Controls.Add(materialLabelSettingBookmark);
            Controls.Add(dataGridViewBookmarksSetting);
            Controls.Add(materialLabelTemplateName);
            Controls.Add(materialTextBoxTemplateName);
            Name = "FormEditTemplate";
            Text = "Редагування шаблону";
            ((System.ComponentModel.ISupportInitialize)dataGridViewBookmarksSetting).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox materialTextBoxTemplateName;
        private MaterialSkin.Controls.MaterialLabel materialLabelTemplateName;
        private DataGridView dataGridViewBookmarksSetting;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnBookmark;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumnType;
        private MaterialSkin.Controls.MaterialLabel materialLabelSettingBookmark;
        private MaterialSkin.Controls.MaterialButton materialButtonSaveUpdate;
    }
}