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
            materialTextBoxTemplateName = new MaterialSkin.Controls.MaterialTextBox();
            materialLabelTemplateName = new MaterialSkin.Controls.MaterialLabel();
            materialLabelSettingBookmark = new MaterialSkin.Controls.MaterialLabel();
            materialButtonSaveUpdate = new MaterialSkin.Controls.MaterialButton();
            dataGridViewEditTableBookmarks = new DataGridView();
            EditRowNumbers = new DataGridViewTextBoxColumn();
            EditBookmarkName = new DataGridViewTextBoxColumn();
            EditTypeBookmark = new DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEditTableBookmarks).BeginInit();
            SuspendLayout();
            // 
            // materialTextBoxTemplateName
            // 
            materialTextBoxTemplateName.AnimateReadOnly = false;
            materialTextBoxTemplateName.BorderStyle = BorderStyle.None;
            materialTextBoxTemplateName.Depth = 0;
            materialTextBoxTemplateName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxTemplateName.LeadingIcon = null;
            materialTextBoxTemplateName.Location = new Point(153, 83);
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
            materialLabelTemplateName.Location = new Point(19, 85);
            materialLabelTemplateName.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelTemplateName.Name = "materialLabelTemplateName";
            materialLabelTemplateName.Size = new Size(117, 19);
            materialLabelTemplateName.TabIndex = 1;
            materialLabelTemplateName.Text = "Назва шаблону";
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
            // materialButtonSaveUpdate
            // 
            materialButtonSaveUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonSaveUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonSaveUpdate.Depth = 0;
            materialButtonSaveUpdate.HighEmphasis = true;
            materialButtonSaveUpdate.Icon = null;
            materialButtonSaveUpdate.Location = new Point(6, 424);
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
            materialButtonSaveUpdate.Click += materialButtonSaveUpdate_Click;
            // 
            // dataGridViewEditTableBookmarks
            // 
            dataGridViewEditTableBookmarks.AllowUserToAddRows = false;
            dataGridViewEditTableBookmarks.AllowUserToDeleteRows = false;
            dataGridViewEditTableBookmarks.AllowUserToResizeColumns = false;
            dataGridViewEditTableBookmarks.AllowUserToResizeRows = false;
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
            Controls.Add(materialButtonSaveUpdate);
            Controls.Add(materialLabelSettingBookmark);
            Controls.Add(materialLabelTemplateName);
            Controls.Add(materialTextBoxTemplateName);
            MaximizeBox = false;
            Name = "FormEditTemplate";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Редагування шаблону";
            ((System.ComponentModel.ISupportInitialize)dataGridViewEditTableBookmarks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox materialTextBoxTemplateName;
        private MaterialSkin.Controls.MaterialLabel materialLabelTemplateName;
        private MaterialSkin.Controls.MaterialLabel materialLabelSettingBookmark;
        private MaterialSkin.Controls.MaterialButton materialButtonSaveUpdate;
        private DataGridView dataGridViewEditTableBookmarks;
        private DataGridViewTextBoxColumn EditRowNumbers;
        private DataGridViewTextBoxColumn EditBookmarkName;
        private DataGridViewComboBoxColumn EditTypeBookmark;
    }
}