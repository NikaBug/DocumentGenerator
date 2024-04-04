namespace WinFormsUI
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            materialTabControl = new MaterialSkin.Controls.MaterialTabControl();
            tabPageTemplate = new TabPage();
            dataGridViewTableBookmarks = new DataGridView();
            ColumnNumber = new DataGridViewTextBoxColumn();
            ColumnBookmarkName = new DataGridViewTextBoxColumn();
            TypeBookmark = new DataGridViewTextBoxColumn();
            tableLayoutPanelTools = new TableLayoutPanel();
            materialButtonAddTemplate = new MaterialSkin.Controls.MaterialButton();
            materialButtonEditTemplate = new MaterialSkin.Controls.MaterialButton();
            materialButtonReadTemplate = new MaterialSkin.Controls.MaterialButton();
            materialTextBoxSearchTemplate = new MaterialSkin.Controls.MaterialTextBox();
            dataGridViewTableTemplate = new DataGridView();
            NumberRows = new DataGridViewTextBoxColumn();
            NameFile = new DataGridViewTextBoxColumn();
            DateModFile = new DataGridViewTextBoxColumn();
            SizeFile = new DataGridViewTextBoxColumn();
            DeleteTemplate = new DataGridViewImageColumn();
            tabPageGenerateDocument = new TabPage();
            tabPageCommand = new TabPage();
            materialLabelSelCmd = new MaterialSkin.Controls.MaterialLabel();
            materialComboBoxCmdList = new MaterialSkin.Controls.MaterialComboBox();
            materialButtonReadCmd = new MaterialSkin.Controls.MaterialButton();
            materialButtonDeleteCommand = new MaterialSkin.Controls.MaterialButton();
            materialButtonUpdCommand = new MaterialSkin.Controls.MaterialButton();
            materialButtonFillTableBookmarks = new MaterialSkin.Controls.MaterialButton();
            dataGridViewBookmarksForCmd = new DataGridView();
            InputBookmark = new DataGridViewComboBoxColumn();
            dataGridViewComboBoxColumnOB = new DataGridViewComboBoxColumn();
            materialLabelBookmarksTable = new MaterialSkin.Controls.MaterialLabel();
            materialButtonCreateCmd = new MaterialSkin.Controls.MaterialButton();
            materialTextBoxCmdName = new MaterialSkin.Controls.MaterialTextBox();
            materialLabelCmdName = new MaterialSkin.Controls.MaterialLabel();
            materialComboBoxInputTmp = new MaterialSkin.Controls.MaterialComboBox();
            materialLabelOutputTmp = new MaterialSkin.Controls.MaterialLabel();
            materialLabelInputTmp = new MaterialSkin.Controls.MaterialLabel();
            materialComboBoxOutputTmp = new MaterialSkin.Controls.MaterialComboBox();
            imageListMenu = new ImageList(components);
            materialTabControl.SuspendLayout();
            tabPageTemplate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTableBookmarks).BeginInit();
            tableLayoutPanelTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTableTemplate).BeginInit();
            tabPageCommand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBookmarksForCmd).BeginInit();
            SuspendLayout();
            // 
            // materialTabControl
            // 
            materialTabControl.Controls.Add(tabPageTemplate);
            materialTabControl.Controls.Add(tabPageGenerateDocument);
            materialTabControl.Controls.Add(tabPageCommand);
            materialTabControl.Depth = 0;
            materialTabControl.Dock = DockStyle.Fill;
            materialTabControl.ImageList = imageListMenu;
            materialTabControl.Location = new Point(3, 64);
            materialTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl.Multiline = true;
            materialTabControl.Name = "materialTabControl";
            materialTabControl.SelectedIndex = 0;
            materialTabControl.Size = new Size(1278, 765);
            materialTabControl.TabIndex = 0;
            // 
            // tabPageTemplate
            // 
            tabPageTemplate.BackColor = Color.WhiteSmoke;
            tabPageTemplate.Controls.Add(dataGridViewTableBookmarks);
            tabPageTemplate.Controls.Add(tableLayoutPanelTools);
            tabPageTemplate.Controls.Add(dataGridViewTableTemplate);
            tabPageTemplate.ImageKey = "Template.png";
            tabPageTemplate.Location = new Point(4, 39);
            tabPageTemplate.Name = "tabPageTemplate";
            tabPageTemplate.Padding = new Padding(3);
            tabPageTemplate.Size = new Size(1270, 722);
            tabPageTemplate.TabIndex = 0;
            tabPageTemplate.Text = "Шаблони";
            // 
            // dataGridViewTableBookmarks
            // 
            dataGridViewTableBookmarks.AllowUserToAddRows = false;
            dataGridViewTableBookmarks.AllowUserToDeleteRows = false;
            dataGridViewTableBookmarks.AllowUserToResizeColumns = false;
            dataGridViewTableBookmarks.AllowUserToResizeRows = false;
            dataGridViewTableBookmarks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewTableBookmarks.BackgroundColor = Color.White;
            dataGridViewTableBookmarks.BorderStyle = BorderStyle.None;
            dataGridViewTableBookmarks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewTableBookmarks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewTableBookmarks.ColumnHeadersHeight = 35;
            dataGridViewTableBookmarks.Columns.AddRange(new DataGridViewColumn[] { ColumnNumber, ColumnBookmarkName, TypeBookmark });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(100, 100, 180);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewTableBookmarks.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTableBookmarks.EnableHeadersVisualStyles = false;
            dataGridViewTableBookmarks.GridColor = Color.LightGray;
            dataGridViewTableBookmarks.Location = new Point(3, 424);
            dataGridViewTableBookmarks.MultiSelect = false;
            dataGridViewTableBookmarks.Name = "dataGridViewTableBookmarks";
            dataGridViewTableBookmarks.ReadOnly = true;
            dataGridViewTableBookmarks.RowHeadersVisible = false;
            dataGridViewTableBookmarks.RowHeadersWidth = 25;
            dataGridViewTableBookmarks.RowTemplate.Height = 25;
            dataGridViewTableBookmarks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTableBookmarks.Size = new Size(1261, 295);
            dataGridViewTableBookmarks.TabIndex = 14;
            dataGridViewTableBookmarks.RowPostPaint += dataGridViewTableBookmarks_RowPostPaint;
            // 
            // ColumnNumber
            // 
            ColumnNumber.DividerWidth = 1;
            ColumnNumber.HeaderText = "Номер";
            ColumnNumber.MinimumWidth = 8;
            ColumnNumber.Name = "ColumnNumber";
            ColumnNumber.ReadOnly = true;
            ColumnNumber.Width = 150;
            // 
            // ColumnBookmarkName
            // 
            ColumnBookmarkName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnBookmarkName.DividerWidth = 1;
            ColumnBookmarkName.HeaderText = "Назва закладки";
            ColumnBookmarkName.MinimumWidth = 8;
            ColumnBookmarkName.Name = "ColumnBookmarkName";
            ColumnBookmarkName.ReadOnly = true;
            // 
            // TypeBookmark
            // 
            TypeBookmark.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TypeBookmark.HeaderText = "Тип закладки";
            TypeBookmark.MinimumWidth = 8;
            TypeBookmark.Name = "TypeBookmark";
            TypeBookmark.ReadOnly = true;
            // 
            // tableLayoutPanelTools
            // 
            tableLayoutPanelTools.ColumnCount = 4;
            tableLayoutPanelTools.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tableLayoutPanelTools.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tableLayoutPanelTools.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanelTools.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanelTools.Controls.Add(materialButtonAddTemplate, 0, 0);
            tableLayoutPanelTools.Controls.Add(materialButtonEditTemplate, 1, 0);
            tableLayoutPanelTools.Controls.Add(materialButtonReadTemplate, 2, 0);
            tableLayoutPanelTools.Controls.Add(materialTextBoxSearchTemplate, 3, 0);
            tableLayoutPanelTools.Dock = DockStyle.Top;
            tableLayoutPanelTools.Location = new Point(3, 3);
            tableLayoutPanelTools.Name = "tableLayoutPanelTools";
            tableLayoutPanelTools.Padding = new Padding(2);
            tableLayoutPanelTools.RowCount = 1;
            tableLayoutPanelTools.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelTools.Size = new Size(1264, 56);
            tableLayoutPanelTools.TabIndex = 1;
            // 
            // materialButtonAddTemplate
            // 
            materialButtonAddTemplate.AutoSize = false;
            materialButtonAddTemplate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonAddTemplate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonAddTemplate.Depth = 0;
            materialButtonAddTemplate.Dock = DockStyle.Fill;
            materialButtonAddTemplate.HighEmphasis = true;
            materialButtonAddTemplate.Icon = Properties.Resources.create_tmp;
            materialButtonAddTemplate.Location = new Point(6, 8);
            materialButtonAddTemplate.Margin = new Padding(4, 6, 4, 6);
            materialButtonAddTemplate.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonAddTemplate.Name = "materialButtonAddTemplate";
            materialButtonAddTemplate.NoAccentTextColor = Color.Empty;
            materialButtonAddTemplate.RightToLeft = RightToLeft.No;
            materialButtonAddTemplate.Size = new Size(102, 40);
            materialButtonAddTemplate.TabIndex = 0;
            materialButtonAddTemplate.Text = "Додати";
            materialButtonAddTemplate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            materialButtonAddTemplate.UseAccentColor = false;
            materialButtonAddTemplate.UseVisualStyleBackColor = true;
            materialButtonAddTemplate.Click += materialButtonAddTemplate_Click;
            // 
            // materialButtonEditTemplate
            // 
            materialButtonEditTemplate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonEditTemplate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonEditTemplate.Depth = 0;
            materialButtonEditTemplate.Dock = DockStyle.Fill;
            materialButtonEditTemplate.HighEmphasis = true;
            materialButtonEditTemplate.Icon = (Image)resources.GetObject("materialButtonEditTemplate.Icon");
            materialButtonEditTemplate.Location = new Point(116, 8);
            materialButtonEditTemplate.Margin = new Padding(4, 6, 4, 6);
            materialButtonEditTemplate.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonEditTemplate.Name = "materialButtonEditTemplate";
            materialButtonEditTemplate.NoAccentTextColor = Color.Empty;
            materialButtonEditTemplate.Size = new Size(132, 40);
            materialButtonEditTemplate.TabIndex = 1;
            materialButtonEditTemplate.Text = "Редагувати";
            materialButtonEditTemplate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            materialButtonEditTemplate.UseAccentColor = false;
            materialButtonEditTemplate.UseVisualStyleBackColor = true;
            materialButtonEditTemplate.Click += materialButtonEditTemplate_Click;
            // 
            // materialButtonReadTemplate
            // 
            materialButtonReadTemplate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonReadTemplate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonReadTemplate.Depth = 0;
            materialButtonReadTemplate.Dock = DockStyle.Fill;
            materialButtonReadTemplate.HighEmphasis = true;
            materialButtonReadTemplate.Icon = Properties.Resources.file_view;
            materialButtonReadTemplate.Location = new Point(256, 8);
            materialButtonReadTemplate.Margin = new Padding(4, 6, 4, 6);
            materialButtonReadTemplate.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonReadTemplate.Name = "materialButtonReadTemplate";
            materialButtonReadTemplate.NoAccentTextColor = Color.Empty;
            materialButtonReadTemplate.Size = new Size(112, 40);
            materialButtonReadTemplate.TabIndex = 2;
            materialButtonReadTemplate.Text = "Читати";
            materialButtonReadTemplate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            materialButtonReadTemplate.UseAccentColor = false;
            materialButtonReadTemplate.UseVisualStyleBackColor = true;
            materialButtonReadTemplate.Click += materialButtonReadTemplate_Click;
            // 
            // materialTextBoxSearchTemplate
            // 
            materialTextBoxSearchTemplate.AnimateReadOnly = false;
            materialTextBoxSearchTemplate.BackColor = Color.FromArgb(192, 255, 255);
            materialTextBoxSearchTemplate.BorderStyle = BorderStyle.None;
            materialTextBoxSearchTemplate.Depth = 0;
            materialTextBoxSearchTemplate.Font = new Font("Roboto", 8F, FontStyle.Regular, GraphicsUnit.Point);
            materialTextBoxSearchTemplate.Hint = "знайти шаблон";
            materialTextBoxSearchTemplate.ImeMode = ImeMode.NoControl;
            materialTextBoxSearchTemplate.LeadingIcon = null;
            materialTextBoxSearchTemplate.Location = new Point(375, 5);
            materialTextBoxSearchTemplate.MaxLength = 50;
            materialTextBoxSearchTemplate.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxSearchTemplate.Multiline = false;
            materialTextBoxSearchTemplate.Name = "materialTextBoxSearchTemplate";
            materialTextBoxSearchTemplate.Size = new Size(383, 50);
            materialTextBoxSearchTemplate.TabIndex = 15;
            materialTextBoxSearchTemplate.Text = "BookmarkTest.docx";
            materialTextBoxSearchTemplate.TrailingIcon = (Image)resources.GetObject("materialTextBoxSearchTemplate.TrailingIcon");
            materialTextBoxSearchTemplate.TrailingIconClick += materialTextBoxSearchTemplate_TrailingIconClick;
            // 
            // dataGridViewTableTemplate
            // 
            dataGridViewTableTemplate.AllowUserToAddRows = false;
            dataGridViewTableTemplate.AllowUserToDeleteRows = false;
            dataGridViewTableTemplate.AllowUserToResizeColumns = false;
            dataGridViewTableTemplate.AllowUserToResizeRows = false;
            dataGridViewTableTemplate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewTableTemplate.BackgroundColor = Color.White;
            dataGridViewTableTemplate.BorderStyle = BorderStyle.None;
            dataGridViewTableTemplate.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewTableTemplate.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewTableTemplate.ColumnHeadersHeight = 35;
            dataGridViewTableTemplate.Columns.AddRange(new DataGridViewColumn[] { NumberRows, NameFile, DateModFile, SizeFile, DeleteTemplate });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(100, 100, 180);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridViewTableTemplate.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewTableTemplate.EnableHeadersVisualStyles = false;
            dataGridViewTableTemplate.GridColor = Color.LightGray;
            dataGridViewTableTemplate.Location = new Point(3, 65);
            dataGridViewTableTemplate.MultiSelect = false;
            dataGridViewTableTemplate.Name = "dataGridViewTableTemplate";
            dataGridViewTableTemplate.ReadOnly = true;
            dataGridViewTableTemplate.RowHeadersVisible = false;
            dataGridViewTableTemplate.RowHeadersWidth = 25;
            dataGridViewTableTemplate.RowTemplate.Height = 25;
            dataGridViewTableTemplate.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTableTemplate.Size = new Size(1264, 339);
            dataGridViewTableTemplate.TabIndex = 0;
            dataGridViewTableTemplate.CellContentClick += dataGridViewTableTemplate_CellContentClick;
            dataGridViewTableTemplate.RowPostPaint += dataGridViewTableTemplate_RowPostPaint;
            // 
            // NumberRows
            // 
            NumberRows.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            NumberRows.DividerWidth = 1;
            NumberRows.FillWeight = 150F;
            NumberRows.HeaderText = "Номер";
            NumberRows.MinimumWidth = 8;
            NumberRows.Name = "NumberRows";
            NumberRows.ReadOnly = true;
            NumberRows.Width = 107;
            // 
            // NameFile
            // 
            NameFile.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NameFile.DividerWidth = 1;
            NameFile.FillWeight = 150F;
            NameFile.HeaderText = "Назва";
            NameFile.MinimumWidth = 8;
            NameFile.Name = "NameFile";
            NameFile.ReadOnly = true;
            // 
            // DateModFile
            // 
            DateModFile.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DateModFile.DividerWidth = 1;
            DateModFile.FillWeight = 150F;
            DateModFile.HeaderText = "Дата зміни";
            DateModFile.MinimumWidth = 8;
            DateModFile.Name = "DateModFile";
            DateModFile.ReadOnly = true;
            // 
            // SizeFile
            // 
            SizeFile.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SizeFile.DividerWidth = 1;
            SizeFile.FillWeight = 150F;
            SizeFile.HeaderText = "Розмір (КБ)";
            SizeFile.MinimumWidth = 8;
            SizeFile.Name = "SizeFile";
            SizeFile.ReadOnly = true;
            // 
            // DeleteTemplate
            // 
            DeleteTemplate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DeleteTemplate.FillWeight = 90F;
            DeleteTemplate.HeaderText = "Видалити";
            DeleteTemplate.Image = Properties.Resources.delete_doc;
            DeleteTemplate.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DeleteTemplate.MinimumWidth = 8;
            DeleteTemplate.Name = "DeleteTemplate";
            DeleteTemplate.ReadOnly = true;
            DeleteTemplate.Width = 101;
            // 
            // tabPageGenerateDocument
            // 
            tabPageGenerateDocument.BackColor = Color.White;
            tabPageGenerateDocument.ImageKey = "writing.png";
            tabPageGenerateDocument.Location = new Point(4, 39);
            tabPageGenerateDocument.Name = "tabPageGenerateDocument";
            tabPageGenerateDocument.Padding = new Padding(3);
            tabPageGenerateDocument.Size = new Size(1270, 722);
            tabPageGenerateDocument.TabIndex = 1;
            tabPageGenerateDocument.Text = "Генератор";
            // 
            // tabPageCommand
            // 
            tabPageCommand.BackColor = Color.White;
            tabPageCommand.Controls.Add(materialLabelSelCmd);
            tabPageCommand.Controls.Add(materialComboBoxCmdList);
            tabPageCommand.Controls.Add(materialButtonReadCmd);
            tabPageCommand.Controls.Add(materialButtonDeleteCommand);
            tabPageCommand.Controls.Add(materialButtonUpdCommand);
            tabPageCommand.Controls.Add(materialButtonFillTableBookmarks);
            tabPageCommand.Controls.Add(dataGridViewBookmarksForCmd);
            tabPageCommand.Controls.Add(materialLabelBookmarksTable);
            tabPageCommand.Controls.Add(materialButtonCreateCmd);
            tabPageCommand.Controls.Add(materialTextBoxCmdName);
            tabPageCommand.Controls.Add(materialLabelCmdName);
            tabPageCommand.Controls.Add(materialComboBoxInputTmp);
            tabPageCommand.Controls.Add(materialLabelOutputTmp);
            tabPageCommand.Controls.Add(materialLabelInputTmp);
            tabPageCommand.Controls.Add(materialComboBoxOutputTmp);
            tabPageCommand.ImageKey = "command-line.png";
            tabPageCommand.Location = new Point(4, 39);
            tabPageCommand.Name = "tabPageCommand";
            tabPageCommand.Size = new Size(1270, 722);
            tabPageCommand.TabIndex = 2;
            tabPageCommand.Text = "Команди";
            // 
            // materialLabelSelCmd
            // 
            materialLabelSelCmd.AutoSize = true;
            materialLabelSelCmd.Depth = 0;
            materialLabelSelCmd.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelSelCmd.Location = new Point(18, 512);
            materialLabelSelCmd.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelSelCmd.Name = "materialLabelSelCmd";
            materialLabelSelCmd.Size = new Size(137, 19);
            materialLabelSelCmd.TabIndex = 14;
            materialLabelSelCmd.Text = "Виберіть команду";
            // 
            // materialComboBoxCmdList
            // 
            materialComboBoxCmdList.AutoResize = false;
            materialComboBoxCmdList.BackColor = Color.FromArgb(255, 255, 255);
            materialComboBoxCmdList.Depth = 0;
            materialComboBoxCmdList.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBoxCmdList.DropDownHeight = 174;
            materialComboBoxCmdList.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBoxCmdList.DropDownWidth = 121;
            materialComboBoxCmdList.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBoxCmdList.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBoxCmdList.FormattingEnabled = true;
            materialComboBoxCmdList.Hint = "список команд";
            materialComboBoxCmdList.IntegralHeight = false;
            materialComboBoxCmdList.ItemHeight = 43;
            materialComboBoxCmdList.Location = new Point(175, 495);
            materialComboBoxCmdList.MaxDropDownItems = 4;
            materialComboBoxCmdList.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBoxCmdList.Name = "materialComboBoxCmdList";
            materialComboBoxCmdList.Size = new Size(200, 49);
            materialComboBoxCmdList.StartIndex = 0;
            materialComboBoxCmdList.TabIndex = 13;
            // 
            // materialButtonReadCmd
            // 
            materialButtonReadCmd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonReadCmd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonReadCmd.Depth = 0;
            materialButtonReadCmd.HighEmphasis = true;
            materialButtonReadCmd.Icon = Properties.Resources.read_cmd;
            materialButtonReadCmd.Location = new Point(246, 570);
            materialButtonReadCmd.Margin = new Padding(4, 6, 4, 6);
            materialButtonReadCmd.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonReadCmd.Name = "materialButtonReadCmd";
            materialButtonReadCmd.NoAccentTextColor = Color.Empty;
            materialButtonReadCmd.Size = new Size(185, 36);
            materialButtonReadCmd.TabIndex = 12;
            materialButtonReadCmd.Text = "Читати команду";
            materialButtonReadCmd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonReadCmd.UseAccentColor = false;
            materialButtonReadCmd.UseVisualStyleBackColor = true;
            // 
            // materialButtonDeleteCommand
            // 
            materialButtonDeleteCommand.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonDeleteCommand.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonDeleteCommand.Depth = 0;
            materialButtonDeleteCommand.HighEmphasis = true;
            materialButtonDeleteCommand.Icon = Properties.Resources.delete_doc;
            materialButtonDeleteCommand.Location = new Point(246, 618);
            materialButtonDeleteCommand.Margin = new Padding(4, 6, 4, 6);
            materialButtonDeleteCommand.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonDeleteCommand.Name = "materialButtonDeleteCommand";
            materialButtonDeleteCommand.NoAccentTextColor = Color.Empty;
            materialButtonDeleteCommand.Size = new Size(207, 36);
            materialButtonDeleteCommand.TabIndex = 11;
            materialButtonDeleteCommand.Text = "Видалити команду";
            materialButtonDeleteCommand.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonDeleteCommand.UseAccentColor = false;
            materialButtonDeleteCommand.UseVisualStyleBackColor = true;
            // 
            // materialButtonUpdCommand
            // 
            materialButtonUpdCommand.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonUpdCommand.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonUpdCommand.Depth = 0;
            materialButtonUpdCommand.HighEmphasis = true;
            materialButtonUpdCommand.Icon = Properties.Resources.upd_cmd;
            materialButtonUpdCommand.Location = new Point(25, 618);
            materialButtonUpdCommand.Margin = new Padding(4, 6, 4, 6);
            materialButtonUpdCommand.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonUpdCommand.Name = "materialButtonUpdCommand";
            materialButtonUpdCommand.NoAccentTextColor = Color.Empty;
            materialButtonUpdCommand.Size = new Size(196, 36);
            materialButtonUpdCommand.TabIndex = 10;
            materialButtonUpdCommand.Text = "оновити команду";
            materialButtonUpdCommand.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonUpdCommand.UseAccentColor = false;
            materialButtonUpdCommand.UseVisualStyleBackColor = true;
            // 
            // materialButtonFillTableBookmarks
            // 
            materialButtonFillTableBookmarks.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonFillTableBookmarks.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonFillTableBookmarks.Depth = 0;
            materialButtonFillTableBookmarks.HighEmphasis = true;
            materialButtonFillTableBookmarks.Icon = null;
            materialButtonFillTableBookmarks.Location = new Point(277, 450);
            materialButtonFillTableBookmarks.Margin = new Padding(4, 6, 4, 6);
            materialButtonFillTableBookmarks.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonFillTableBookmarks.Name = "materialButtonFillTableBookmarks";
            materialButtonFillTableBookmarks.NoAccentTextColor = Color.Empty;
            materialButtonFillTableBookmarks.Size = new Size(270, 36);
            materialButtonFillTableBookmarks.TabIndex = 9;
            materialButtonFillTableBookmarks.Text = "Заповнити таблицю закладок";
            materialButtonFillTableBookmarks.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonFillTableBookmarks.UseAccentColor = false;
            materialButtonFillTableBookmarks.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBookmarksForCmd
            // 
            dataGridViewCellStyle5.BackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewBookmarksForCmd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewBookmarksForCmd.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridViewBookmarksForCmd.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.MediumPurple;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.Window;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewBookmarksForCmd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewBookmarksForCmd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBookmarksForCmd.Columns.AddRange(new DataGridViewColumn[] { InputBookmark, dataGridViewComboBoxColumnOB });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.Black;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dataGridViewBookmarksForCmd.DefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewBookmarksForCmd.EnableHeadersVisualStyles = false;
            dataGridViewBookmarksForCmd.Location = new Point(33, 221);
            dataGridViewBookmarksForCmd.Name = "dataGridViewBookmarksForCmd";
            dataGridViewBookmarksForCmd.RowHeadersVisible = false;
            dataGridViewBookmarksForCmd.RowHeadersWidth = 62;
            dataGridViewBookmarksForCmd.RowTemplate.Height = 33;
            dataGridViewBookmarksForCmd.Size = new Size(781, 220);
            dataGridViewBookmarksForCmd.TabIndex = 8;
            // 
            // InputBookmark
            // 
            dataGridViewCellStyle7.BackColor = Color.MediumSlateBlue;
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = Color.MediumSlateBlue;
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            InputBookmark.DefaultCellStyle = dataGridViewCellStyle7;
            InputBookmark.FlatStyle = FlatStyle.Flat;
            InputBookmark.HeaderText = "Вхідна закладка";
            InputBookmark.MinimumWidth = 8;
            InputBookmark.Name = "InputBookmark";
            InputBookmark.Width = 150;
            // 
            // dataGridViewComboBoxColumnOB
            // 
            dataGridViewCellStyle8.BackColor = Color.MediumSlateBlue;
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = Color.MediumSlateBlue;
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dataGridViewComboBoxColumnOB.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewComboBoxColumnOB.FlatStyle = FlatStyle.Flat;
            dataGridViewComboBoxColumnOB.HeaderText = "Вихідна закладка";
            dataGridViewComboBoxColumnOB.MinimumWidth = 8;
            dataGridViewComboBoxColumnOB.Name = "dataGridViewComboBoxColumnOB";
            dataGridViewComboBoxColumnOB.Width = 150;
            // 
            // materialLabelBookmarksTable
            // 
            materialLabelBookmarksTable.AutoSize = true;
            materialLabelBookmarksTable.Depth = 0;
            materialLabelBookmarksTable.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelBookmarksTable.Location = new Point(216, 199);
            materialLabelBookmarksTable.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelBookmarksTable.Name = "materialLabelBookmarksTable";
            materialLabelBookmarksTable.Size = new Size(384, 19);
            materialLabelBookmarksTable.TabIndex = 7;
            materialLabelBookmarksTable.Text = "Таблиця закладок вхідного та вихідного шаблонів";
            // 
            // materialButtonCreateCmd
            // 
            materialButtonCreateCmd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonCreateCmd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonCreateCmd.Depth = 0;
            materialButtonCreateCmd.HighEmphasis = true;
            materialButtonCreateCmd.Icon = Properties.Resources.create_cmd;
            materialButtonCreateCmd.Location = new Point(25, 570);
            materialButtonCreateCmd.Margin = new Padding(4, 6, 4, 6);
            materialButtonCreateCmd.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonCreateCmd.Name = "materialButtonCreateCmd";
            materialButtonCreateCmd.NoAccentTextColor = Color.Empty;
            materialButtonCreateCmd.Size = new Size(204, 36);
            materialButtonCreateCmd.TabIndex = 6;
            materialButtonCreateCmd.Text = "Створити команду";
            materialButtonCreateCmd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonCreateCmd.UseAccentColor = false;
            materialButtonCreateCmd.UseVisualStyleBackColor = true;
            // 
            // materialTextBoxCmdName
            // 
            materialTextBoxCmdName.AnimateReadOnly = false;
            materialTextBoxCmdName.BorderStyle = BorderStyle.None;
            materialTextBoxCmdName.Depth = 0;
            materialTextBoxCmdName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxCmdName.Hint = "назва";
            materialTextBoxCmdName.LeadingIcon = null;
            materialTextBoxCmdName.LeaveOnEnterKey = true;
            materialTextBoxCmdName.Location = new Point(163, 9);
            materialTextBoxCmdName.MaxLength = 150;
            materialTextBoxCmdName.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxCmdName.Multiline = false;
            materialTextBoxCmdName.Name = "materialTextBoxCmdName";
            materialTextBoxCmdName.Size = new Size(375, 36);
            materialTextBoxCmdName.TabIndex = 1;
            materialTextBoxCmdName.Text = "";
            materialTextBoxCmdName.TrailingIcon = null;
            materialTextBoxCmdName.UseAccent = false;
            materialTextBoxCmdName.UseTallSize = false;
            // 
            // materialLabelCmdName
            // 
            materialLabelCmdName.AutoSize = true;
            materialLabelCmdName.Depth = 0;
            materialLabelCmdName.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelCmdName.Location = new Point(18, 11);
            materialLabelCmdName.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelCmdName.Name = "materialLabelCmdName";
            materialLabelCmdName.Size = new Size(118, 19);
            materialLabelCmdName.TabIndex = 0;
            materialLabelCmdName.Text = "Назва команди";
            // 
            // materialComboBoxInputTmp
            // 
            materialComboBoxInputTmp.AutoResize = false;
            materialComboBoxInputTmp.BackColor = Color.FromArgb(255, 255, 255);
            materialComboBoxInputTmp.Depth = 0;
            materialComboBoxInputTmp.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBoxInputTmp.DropDownHeight = 174;
            materialComboBoxInputTmp.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBoxInputTmp.DropDownWidth = 121;
            materialComboBoxInputTmp.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBoxInputTmp.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBoxInputTmp.FormattingEnabled = true;
            materialComboBoxInputTmp.Hint = "вхідний шаблон";
            materialComboBoxInputTmp.IntegralHeight = false;
            materialComboBoxInputTmp.ItemHeight = 43;
            materialComboBoxInputTmp.Location = new Point(163, 51);
            materialComboBoxInputTmp.MaxDropDownItems = 4;
            materialComboBoxInputTmp.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBoxInputTmp.Name = "materialComboBoxInputTmp";
            materialComboBoxInputTmp.Size = new Size(375, 49);
            materialComboBoxInputTmp.StartIndex = 0;
            materialComboBoxInputTmp.TabIndex = 3;
            // 
            // materialLabelOutputTmp
            // 
            materialLabelOutputTmp.AutoSize = true;
            materialLabelOutputTmp.Depth = 0;
            materialLabelOutputTmp.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelOutputTmp.Location = new Point(18, 133);
            materialLabelOutputTmp.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelOutputTmp.Name = "materialLabelOutputTmp";
            materialLabelOutputTmp.Size = new Size(131, 19);
            materialLabelOutputTmp.TabIndex = 4;
            materialLabelOutputTmp.Text = "Вихідний шаблон";
            // 
            // materialLabelInputTmp
            // 
            materialLabelInputTmp.AutoSize = true;
            materialLabelInputTmp.Depth = 0;
            materialLabelInputTmp.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelInputTmp.Location = new Point(18, 71);
            materialLabelInputTmp.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelInputTmp.Name = "materialLabelInputTmp";
            materialLabelInputTmp.Size = new Size(122, 19);
            materialLabelInputTmp.TabIndex = 2;
            materialLabelInputTmp.Text = "Вхідний шаблон";
            // 
            // materialComboBoxOutputTmp
            // 
            materialComboBoxOutputTmp.AutoResize = false;
            materialComboBoxOutputTmp.BackColor = Color.FromArgb(255, 255, 255);
            materialComboBoxOutputTmp.Depth = 0;
            materialComboBoxOutputTmp.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBoxOutputTmp.DropDownHeight = 174;
            materialComboBoxOutputTmp.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBoxOutputTmp.DropDownWidth = 121;
            materialComboBoxOutputTmp.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBoxOutputTmp.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBoxOutputTmp.FormattingEnabled = true;
            materialComboBoxOutputTmp.Hint = "вихідний шаблон";
            materialComboBoxOutputTmp.IntegralHeight = false;
            materialComboBoxOutputTmp.ItemHeight = 43;
            materialComboBoxOutputTmp.Location = new Point(163, 119);
            materialComboBoxOutputTmp.MaxDropDownItems = 4;
            materialComboBoxOutputTmp.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBoxOutputTmp.Name = "materialComboBoxOutputTmp";
            materialComboBoxOutputTmp.Size = new Size(375, 49);
            materialComboBoxOutputTmp.StartIndex = 0;
            materialComboBoxOutputTmp.TabIndex = 5;
            // 
            // imageListMenu
            // 
            imageListMenu.ColorDepth = ColorDepth.Depth32Bit;
            imageListMenu.ImageStream = (ImageListStreamer)resources.GetObject("imageListMenu.ImageStream");
            imageListMenu.TransparentColor = Color.Transparent;
            imageListMenu.Images.SetKeyName(0, "command-line.png");
            imageListMenu.Images.SetKeyName(1, "Template.png");
            imageListMenu.Images.SetKeyName(2, "writing.png");
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 832);
            Controls.Add(materialTabControl);
            DrawerTabControl = materialTabControl;
            HelpButton = true;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Document Generator";
            WindowState = FormWindowState.Maximized;
            materialTabControl.ResumeLayout(false);
            tabPageTemplate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTableBookmarks).EndInit();
            tableLayoutPanelTools.ResumeLayout(false);
            tableLayoutPanelTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTableTemplate).EndInit();
            tabPageCommand.ResumeLayout(false);
            tabPageCommand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBookmarksForCmd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl;
        private TabPage tabPageTemplate;
        private TabPage tabPageCommand;
        private ImageList imageListMenu;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxCmdName;
        private MaterialSkin.Controls.MaterialLabel materialLabelCmdName;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxInputTmp;
        private MaterialSkin.Controls.MaterialLabel materialLabelOutputTmp;
        private MaterialSkin.Controls.MaterialLabel materialLabelInputTmp;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxOutputTmp;
        private MaterialSkin.Controls.MaterialButton materialButtonCreateCmd;
        private MaterialSkin.Controls.MaterialLabel materialLabelBookmarksTable;
        private TabPage tabPageGenerateDocument;
        private DataGridView dataGridViewBookmarksForCmd;
        private DataGridViewComboBoxColumn InputBookmark;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumnOB;
        private MaterialSkin.Controls.MaterialButton materialButtonFillTableBookmarks;
        private MaterialSkin.Controls.MaterialButton materialButtonUpdCommand;
        private MaterialSkin.Controls.MaterialButton materialButtonDeleteCommand;
        private MaterialSkin.Controls.MaterialButton materialButtonReadCmd;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxCmdList;
        private MaterialSkin.Controls.MaterialLabel materialLabelSelCmd;
        private DataGridView dataGridViewTableTemplate;
        private TableLayoutPanel tableLayoutPanelTools;
        private MaterialSkin.Controls.MaterialButton materialButtonAddTemplate;
        private MaterialSkin.Controls.MaterialButton materialButtonEditTemplate;
        private MaterialSkin.Controls.MaterialButton materialButtonReadTemplate;
        private DataGridView dataGridViewTableBookmarks;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxSearchTemplate;
        private DataGridViewTextBoxColumn NumberRows;
        private DataGridViewTextBoxColumn NameFile;
        private DataGridViewTextBoxColumn DateModFile;
        private DataGridViewTextBoxColumn SizeFile;
        private DataGridViewImageColumn DeleteTemplate;
        private DataGridViewTextBoxColumn ColumnNumber;
        private DataGridViewTextBoxColumn ColumnBookmarkName;
        private DataGridViewTextBoxColumn TypeBookmark;
    }
}