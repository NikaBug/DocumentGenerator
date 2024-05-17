namespace WinFormsUI
{
    partial class FormEditCommand
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
            LabelEditNameCmd = new MaterialSkin.Controls.MaterialLabel();
            TextBoxNewNameCommand = new MaterialSkin.Controls.MaterialTextBox();
            ButtonSaveChangeCommand = new MaterialSkin.Controls.MaterialButton();
            dataGridViewEditBookmarkMatch = new DataGridView();
            CmdEditNumberRow = new DataGridViewTextBoxColumn();
            CmdEditOutputBookmark = new DataGridViewTextBoxColumn();
            CmdEditInputBookmark = new DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEditBookmarkMatch).BeginInit();
            SuspendLayout();
            // 
            // LabelEditNameCmd
            // 
            LabelEditNameCmd.AutoSize = true;
            LabelEditNameCmd.Depth = 0;
            LabelEditNameCmd.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelEditNameCmd.Location = new Point(33, 114);
            LabelEditNameCmd.MouseState = MaterialSkin.MouseState.HOVER;
            LabelEditNameCmd.Name = "LabelEditNameCmd";
            LabelEditNameCmd.Size = new Size(118, 19);
            LabelEditNameCmd.TabIndex = 0;
            LabelEditNameCmd.Text = "Назва команди";
            // 
            // TextBoxNewNameCommand
            // 
            TextBoxNewNameCommand.AnimateReadOnly = false;
            TextBoxNewNameCommand.BorderStyle = BorderStyle.None;
            TextBoxNewNameCommand.Depth = 0;
            TextBoxNewNameCommand.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextBoxNewNameCommand.LeadingIcon = null;
            TextBoxNewNameCommand.Location = new Point(173, 97);
            TextBoxNewNameCommand.MaxLength = 50;
            TextBoxNewNameCommand.MouseState = MaterialSkin.MouseState.OUT;
            TextBoxNewNameCommand.Multiline = false;
            TextBoxNewNameCommand.Name = "TextBoxNewNameCommand";
            TextBoxNewNameCommand.Size = new Size(389, 50);
            TextBoxNewNameCommand.TabIndex = 1;
            TextBoxNewNameCommand.Text = "";
            TextBoxNewNameCommand.TrailingIcon = null;
            // 
            // ButtonSaveChangeCommand
            // 
            ButtonSaveChangeCommand.AutoSize = false;
            ButtonSaveChangeCommand.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonSaveChangeCommand.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonSaveChangeCommand.Depth = 0;
            ButtonSaveChangeCommand.HighEmphasis = true;
            ButtonSaveChangeCommand.Icon = Properties.Resources.icons8_save_50;
            ButtonSaveChangeCommand.Location = new Point(33, 501);
            ButtonSaveChangeCommand.Margin = new Padding(4, 6, 4, 6);
            ButtonSaveChangeCommand.MouseState = MaterialSkin.MouseState.HOVER;
            ButtonSaveChangeCommand.Name = "ButtonSaveChangeCommand";
            ButtonSaveChangeCommand.NoAccentTextColor = Color.Empty;
            ButtonSaveChangeCommand.Size = new Size(155, 41);
            ButtonSaveChangeCommand.TabIndex = 17;
            ButtonSaveChangeCommand.Text = "Зберегти зміни";
            ButtonSaveChangeCommand.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonSaveChangeCommand.UseAccentColor = false;
            ButtonSaveChangeCommand.UseVisualStyleBackColor = true;
            ButtonSaveChangeCommand.Click += ButtonSaveChangeCommand_Click;
            // 
            // dataGridViewEditBookmarkMatch
            // 
            dataGridViewEditBookmarkMatch.AllowUserToAddRows = false;
            dataGridViewEditBookmarkMatch.AllowUserToDeleteRows = false;
            dataGridViewEditBookmarkMatch.AllowUserToResizeColumns = false;
            dataGridViewEditBookmarkMatch.AllowUserToResizeRows = false;
            dataGridViewEditBookmarkMatch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewEditBookmarkMatch.BackgroundColor = Color.White;
            dataGridViewEditBookmarkMatch.BorderStyle = BorderStyle.None;
            dataGridViewEditBookmarkMatch.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewEditBookmarkMatch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewEditBookmarkMatch.ColumnHeadersHeight = 35;
            dataGridViewEditBookmarkMatch.Columns.AddRange(new DataGridViewColumn[] { CmdEditNumberRow, CmdEditOutputBookmark, CmdEditInputBookmark });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(100, 100, 180);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewEditBookmarkMatch.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewEditBookmarkMatch.EnableHeadersVisualStyles = false;
            dataGridViewEditBookmarkMatch.GridColor = Color.LightGray;
            dataGridViewEditBookmarkMatch.Location = new Point(21, 153);
            dataGridViewEditBookmarkMatch.MultiSelect = false;
            dataGridViewEditBookmarkMatch.Name = "dataGridViewEditBookmarkMatch";
            dataGridViewEditBookmarkMatch.RowHeadersVisible = false;
            dataGridViewEditBookmarkMatch.RowHeadersWidth = 25;
            dataGridViewEditBookmarkMatch.RowTemplate.Height = 25;
            dataGridViewEditBookmarkMatch.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEditBookmarkMatch.Size = new Size(862, 339);
            dataGridViewEditBookmarkMatch.TabIndex = 18;
            dataGridViewEditBookmarkMatch.RowPostPaint += dataGridViewEditBookmarkMatch_RowPostPaint;
            // 
            // CmdEditNumberRow
            // 
            CmdEditNumberRow.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CmdEditNumberRow.HeaderText = "Номер";
            CmdEditNumberRow.MinimumWidth = 8;
            CmdEditNumberRow.Name = "CmdEditNumberRow";
            CmdEditNumberRow.ReadOnly = true;
            CmdEditNumberRow.Width = 107;
            // 
            // CmdEditOutputBookmark
            // 
            CmdEditOutputBookmark.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CmdEditOutputBookmark.HeaderText = "Вихідна закладка (шаблон)";
            CmdEditOutputBookmark.MinimumWidth = 8;
            CmdEditOutputBookmark.Name = "CmdEditOutputBookmark";
            CmdEditOutputBookmark.ReadOnly = true;
            // 
            // CmdEditInputBookmark
            // 
            CmdEditInputBookmark.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(192, 192, 255);
            CmdEditInputBookmark.DefaultCellStyle = dataGridViewCellStyle2;
            CmdEditInputBookmark.FlatStyle = FlatStyle.Flat;
            CmdEditInputBookmark.HeaderText = "Вхідна закладка (документ)";
            CmdEditInputBookmark.MinimumWidth = 8;
            CmdEditInputBookmark.Name = "CmdEditInputBookmark";
            // 
            // FormEditCommand
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 560);
            Controls.Add(dataGridViewEditBookmarkMatch);
            Controls.Add(ButtonSaveChangeCommand);
            Controls.Add(TextBoxNewNameCommand);
            Controls.Add(LabelEditNameCmd);
            Name = "FormEditCommand";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Редагування команди";
            ((System.ComponentModel.ISupportInitialize)dataGridViewEditBookmarkMatch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel LabelEditNameCmd;
        private MaterialSkin.Controls.MaterialTextBox TextBoxNewNameCommand;
        private MaterialSkin.Controls.MaterialButton ButtonSaveChangeCommand;
        private DataGridView dataGridViewEditBookmarkMatch;
        private DataGridViewTextBoxColumn CmdEditNumberRow;
        private DataGridViewTextBoxColumn CmdEditOutputBookmark;
        private DataGridViewComboBoxColumn CmdEditInputBookmark;
    }
}