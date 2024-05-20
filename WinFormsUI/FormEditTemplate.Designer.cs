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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            TextBoxTemplateName = new MaterialSkin.Controls.MaterialTextBox();
            LabelTemplateName = new MaterialSkin.Controls.MaterialLabel();
            materialLabelSettingBookmark = new MaterialSkin.Controls.MaterialLabel();
            ButtonSaveUpdate = new MaterialSkin.Controls.MaterialButton();
            dataGridViewEditTableBookmarks = new DataGridView();
            EditRowNumbers = new DataGridViewTextBoxColumn();
            EditBookmarkName = new DataGridViewTextBoxColumn();
            EditTypeBookmark = new DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEditTableBookmarks).BeginInit();
            SuspendLayout();
            // 
            // TextBoxTemplateName
            // 
            TextBoxTemplateName.AnimateReadOnly = false;
            TextBoxTemplateName.BorderStyle = BorderStyle.None;
            TextBoxTemplateName.Depth = 0;
            TextBoxTemplateName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextBoxTemplateName.LeadingIcon = null;
            TextBoxTemplateName.Location = new Point(153, 83);
            TextBoxTemplateName.MaxLength = 100;
            TextBoxTemplateName.MouseState = MaterialSkin.MouseState.OUT;
            TextBoxTemplateName.Multiline = false;
            TextBoxTemplateName.Name = "TextBoxTemplateName";
            TextBoxTemplateName.Size = new Size(255, 36);
            TextBoxTemplateName.TabIndex = 0;
            TextBoxTemplateName.Text = "";
            TextBoxTemplateName.TrailingIcon = null;
            TextBoxTemplateName.UseTallSize = false;
            // 
            // LabelTemplateName
            // 
            LabelTemplateName.AutoSize = true;
            LabelTemplateName.Depth = 0;
            LabelTemplateName.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelTemplateName.Location = new Point(19, 85);
            LabelTemplateName.MouseState = MaterialSkin.MouseState.HOVER;
            LabelTemplateName.Name = "LabelTemplateName";
            LabelTemplateName.Size = new Size(117, 19);
            LabelTemplateName.TabIndex = 1;
            LabelTemplateName.Text = "Назва шаблону";
            // 
            // materialLabelSettingBookmark
            // 
            materialLabelSettingBookmark.AutoSize = true;
            materialLabelSettingBookmark.Depth = 0;
            materialLabelSettingBookmark.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelSettingBookmark.Location = new Point(326, 137);
            materialLabelSettingBookmark.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelSettingBookmark.Name = "materialLabelSettingBookmark";
            materialLabelSettingBookmark.Size = new Size(189, 19);
            materialLabelSettingBookmark.TabIndex = 11;
            materialLabelSettingBookmark.Text = "Налаштування закладок";
            // 
            // ButtonSaveUpdate
            // 
            ButtonSaveUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonSaveUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonSaveUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonSaveUpdate.Depth = 0;
            ButtonSaveUpdate.HighEmphasis = true;
            ButtonSaveUpdate.Icon = Properties.Resources.icons8_save_50;
            ButtonSaveUpdate.Location = new Point(6, 424);
            ButtonSaveUpdate.Margin = new Padding(4, 6, 4, 6);
            ButtonSaveUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            ButtonSaveUpdate.Name = "ButtonSaveUpdate";
            ButtonSaveUpdate.NoAccentTextColor = Color.Empty;
            ButtonSaveUpdate.Size = new Size(215, 36);
            ButtonSaveUpdate.TabIndex = 12;
            ButtonSaveUpdate.Text = "Зберегти оновлення";
            ButtonSaveUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonSaveUpdate.UseAccentColor = false;
            ButtonSaveUpdate.UseVisualStyleBackColor = true;
            ButtonSaveUpdate.Click += materialButtonSaveUpdate_Click;
            // 
            // dataGridViewEditTableBookmarks
            // 
            dataGridViewEditTableBookmarks.AllowUserToAddRows = false;
            dataGridViewEditTableBookmarks.AllowUserToDeleteRows = false;
            dataGridViewEditTableBookmarks.AllowUserToResizeColumns = false;
            dataGridViewEditTableBookmarks.AllowUserToResizeRows = false;
            dataGridViewEditTableBookmarks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewEditTableBookmarks.BackgroundColor = Color.White;
            dataGridViewEditTableBookmarks.BorderStyle = BorderStyle.None;
            dataGridViewEditTableBookmarks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewEditTableBookmarks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewEditTableBookmarks.ColumnHeadersHeight = 35;
            dataGridViewEditTableBookmarks.Columns.AddRange(new DataGridViewColumn[] { EditRowNumbers, EditBookmarkName, EditTypeBookmark });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(100, 100, 180);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewEditTableBookmarks.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewEditTableBookmarks.EnableHeadersVisualStyles = false;
            dataGridViewEditTableBookmarks.GridColor = Color.LightGray;
            dataGridViewEditTableBookmarks.Location = new Point(6, 159);
            dataGridViewEditTableBookmarks.MultiSelect = false;
            dataGridViewEditTableBookmarks.Name = "dataGridViewEditTableBookmarks";
            dataGridViewEditTableBookmarks.RowHeadersVisible = false;
            dataGridViewEditTableBookmarks.RowHeadersWidth = 25;
            dataGridViewEditTableBookmarks.RowTemplate.Height = 25;
            dataGridViewEditTableBookmarks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEditTableBookmarks.Size = new Size(897, 256);
            dataGridViewEditTableBookmarks.TabIndex = 13;
            dataGridViewEditTableBookmarks.RowPostPaint += dataGridViewEditTableBookmarks_RowPostPaint;
            // 
            // EditRowNumbers
            // 
            EditRowNumbers.HeaderText = "Номер";
            EditRowNumbers.MinimumWidth = 8;
            EditRowNumbers.Name = "EditRowNumbers";
            EditRowNumbers.ReadOnly = true;
            EditRowNumbers.Width = 150;
            // 
            // EditBookmarkName
            // 
            EditBookmarkName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EditBookmarkName.HeaderText = "Назва закладки";
            EditBookmarkName.MinimumWidth = 8;
            EditBookmarkName.Name = "EditBookmarkName";
            EditBookmarkName.ReadOnly = true;
            // 
            // EditTypeBookmark
            // 
            EditTypeBookmark.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(192, 192, 255);
            EditTypeBookmark.DefaultCellStyle = dataGridViewCellStyle2;
            EditTypeBookmark.FlatStyle = FlatStyle.Flat;
            EditTypeBookmark.HeaderText = "Тип закладки";
            EditTypeBookmark.MinimumWidth = 8;
            EditTypeBookmark.Name = "EditTypeBookmark";
            // 
            // FormEditTemplate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 469);
            Controls.Add(dataGridViewEditTableBookmarks);
            Controls.Add(ButtonSaveUpdate);
            Controls.Add(materialLabelSettingBookmark);
            Controls.Add(LabelTemplateName);
            Controls.Add(TextBoxTemplateName);
            Name = "FormEditTemplate";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Редагування шаблону";
            ((System.ComponentModel.ISupportInitialize)dataGridViewEditTableBookmarks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox TextBoxTemplateName;
        private MaterialSkin.Controls.MaterialLabel LabelTemplateName;
        private MaterialSkin.Controls.MaterialLabel materialLabelSettingBookmark;
        private MaterialSkin.Controls.MaterialButton ButtonSaveUpdate;
        private DataGridView dataGridViewEditTableBookmarks;
        private DataGridViewTextBoxColumn EditRowNumbers;
        private DataGridViewTextBoxColumn EditBookmarkName;
        private DataGridViewComboBoxColumn EditTypeBookmark;
    }
}