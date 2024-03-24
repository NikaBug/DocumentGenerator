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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            materialTextBoxTemplateName = new MaterialSkin.Controls.MaterialTextBox();
            materialLabelTemplateName = new MaterialSkin.Controls.MaterialLabel();
            materialLabelSettingBookmark = new MaterialSkin.Controls.MaterialLabel();
            materialButtonSaveUpdate = new MaterialSkin.Controls.MaterialButton();
            dataGridViewEditTableBookmarks = new DataGridView();
            ColumnBookmarkName = new DataGridViewTextBoxColumn();
            ColumnType = new DataGridViewComboBoxColumn();
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
            // dataGridViewEditTableBookmarks
            // 
            dataGridViewEditTableBookmarks.AllowUserToAddRows = false;
            dataGridViewEditTableBookmarks.AllowUserToDeleteRows = false;
            dataGridViewEditTableBookmarks.AllowUserToResizeColumns = false;
            dataGridViewEditTableBookmarks.AllowUserToResizeRows = false;
            dataGridViewEditTableBookmarks.BackgroundColor = Color.White;
            dataGridViewEditTableBookmarks.BorderStyle = BorderStyle.None;
            dataGridViewEditTableBookmarks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewEditTableBookmarks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewEditTableBookmarks.ColumnHeadersHeight = 35;
            dataGridViewEditTableBookmarks.Columns.AddRange(new DataGridViewColumn[] { ColumnBookmarkName, ColumnType });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(100, 100, 180);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridViewEditTableBookmarks.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewEditTableBookmarks.EnableHeadersVisualStyles = false;
            dataGridViewEditTableBookmarks.GridColor = Color.LightGray;
            dataGridViewEditTableBookmarks.Location = new Point(35, 188);
            dataGridViewEditTableBookmarks.MultiSelect = false;
            dataGridViewEditTableBookmarks.Name = "dataGridViewEditTableBookmarks";
            dataGridViewEditTableBookmarks.RowHeadersVisible = false;
            dataGridViewEditTableBookmarks.RowHeadersWidth = 25;
            dataGridViewEditTableBookmarks.RowTemplate.Height = 25;
            dataGridViewEditTableBookmarks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEditTableBookmarks.Size = new Size(676, 153);
            dataGridViewEditTableBookmarks.TabIndex = 13;
            // 
            // ColumnBookmarkName
            // 
            ColumnBookmarkName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnBookmarkName.HeaderText = "Назва закладки";
            ColumnBookmarkName.MinimumWidth = 8;
            ColumnBookmarkName.Name = "ColumnBookmarkName";
            ColumnBookmarkName.ReadOnly = true;
            // 
            // ColumnType
            // 
            ColumnType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(192, 192, 255);
            ColumnType.DefaultCellStyle = dataGridViewCellStyle5;
            ColumnType.FlatStyle = FlatStyle.Flat;
            ColumnType.HeaderText = "Тип закладки";
            ColumnType.MinimumWidth = 8;
            ColumnType.Name = "ColumnType";
            // 
            // FormEditTemplate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 414);
            Controls.Add(dataGridViewEditTableBookmarks);
            Controls.Add(materialButtonSaveUpdate);
            Controls.Add(materialLabelSettingBookmark);
            Controls.Add(materialLabelTemplateName);
            Controls.Add(materialTextBoxTemplateName);
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
        private DataGridViewTextBoxColumn ColumnBookmarkName;
        private DataGridViewComboBoxColumn ColumnType;
    }
}