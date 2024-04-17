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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
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
            materialButtonGenerateDocument = new MaterialSkin.Controls.MaterialButton();
            groupBoxGenSetting = new GroupBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialButtonSelectPathForSaved = new MaterialSkin.Controls.MaterialButton();
            materialTextBoxPathForSaveDocument = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabelNameOutputDocument = new MaterialSkin.Controls.MaterialLabel();
            materialTextBoxGenNameOutputDocument = new MaterialSkin.Controls.MaterialTextBox2();
            materialComboBoxGenCommandList = new MaterialSkin.Controls.MaterialComboBox();
            materialSwitchUseCommand = new MaterialSkin.Controls.MaterialSwitch();
            dataGridViewGenSettingBookmarks = new DataGridView();
            GenNumberRows = new DataGridViewTextBoxColumn();
            GenNameBookmark = new DataGridViewTextBoxColumn();
            GenDataType = new DataGridViewComboBoxColumn();
            GenEnterData = new DataGridViewImageColumn();
            groupBoxGenChoseTemplate = new GroupBox();
            dataGridViewGenLoadTemplateTable = new DataGridView();
            GenTmpRowNumber = new DataGridViewTextBoxColumn();
            GenTmpNameBookmark = new DataGridViewTextBoxColumn();
            GenTmpDateModification = new DataGridViewTextBoxColumn();
            GenTmpSize = new DataGridViewTextBoxColumn();
            GenTmpDelete = new DataGridViewImageColumn();
            materialComboBoxGenSavedTemplate = new MaterialSkin.Controls.MaterialComboBox();
            materialRadioButtonGenLoadTemplate = new MaterialSkin.Controls.MaterialRadioButton();
            materialRadioButtonGenSavedTemplate = new MaterialSkin.Controls.MaterialRadioButton();
            tabPageCommand = new TabPage();
            groupBoxCmdTable = new GroupBox();
            dataGridViewTableCommand = new DataGridView();
            CmdNumberRowCommand = new DataGridViewTextBoxColumn();
            CommandName = new DataGridViewTextBoxColumn();
            CmdInputTemplate = new DataGridViewTextBoxColumn();
            CmdOutputTemplate = new DataGridViewTextBoxColumn();
            CmdDeleteCommand = new DataGridViewImageColumn();
            groupBoxCmdSettingConvert = new GroupBox();
            dataGridViewCmdTemplateTable = new DataGridView();
            CmdNumberRowTmp = new DataGridViewTextBoxColumn();
            CmdInputBookmark = new DataGridViewComboBoxColumn();
            CmdOutputBookmark = new DataGridViewComboBoxColumn();
            groupBoxSettingCommand = new GroupBox();
            materialTextBoxCmdCommandName = new MaterialSkin.Controls.MaterialTextBox2();
            materialComboBoxCmdOutputTemplate = new MaterialSkin.Controls.MaterialComboBox();
            materialComboBoxCmdInputTemplate = new MaterialSkin.Controls.MaterialComboBox();
            imageListMenu = new ImageList(components);
            materialTabControl.SuspendLayout();
            tabPageTemplate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTableBookmarks).BeginInit();
            tableLayoutPanelTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTableTemplate).BeginInit();
            tabPageGenerateDocument.SuspendLayout();
            groupBoxGenSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGenSettingBookmarks).BeginInit();
            groupBoxGenChoseTemplate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGenLoadTemplateTable).BeginInit();
            tabPageCommand.SuspendLayout();
            groupBoxCmdTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTableCommand).BeginInit();
            groupBoxCmdSettingConvert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCmdTemplateTable).BeginInit();
            groupBoxSettingCommand.SuspendLayout();
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
            materialTextBoxSearchTemplate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            materialTextBoxSearchTemplate.AnimateReadOnly = false;
            materialTextBoxSearchTemplate.BackColor = Color.FromArgb(192, 255, 255);
            materialTextBoxSearchTemplate.BorderStyle = BorderStyle.None;
            materialTextBoxSearchTemplate.Depth = 0;
            materialTextBoxSearchTemplate.Font = new Font("Roboto", 8F, FontStyle.Regular, GraphicsUnit.Point);
            materialTextBoxSearchTemplate.Hint = "знайти шаблон";
            materialTextBoxSearchTemplate.ImeMode = ImeMode.NoControl;
            materialTextBoxSearchTemplate.LeadingIcon = null;
            materialTextBoxSearchTemplate.Location = new Point(375, 5);
            materialTextBoxSearchTemplate.MaxLength = 100;
            materialTextBoxSearchTemplate.MinimumSize = new Size(312, 50);
            materialTextBoxSearchTemplate.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxSearchTemplate.Multiline = false;
            materialTextBoxSearchTemplate.Name = "materialTextBoxSearchTemplate";
            materialTextBoxSearchTemplate.Size = new Size(312, 50);
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
            tabPageGenerateDocument.Controls.Add(materialButtonGenerateDocument);
            tabPageGenerateDocument.Controls.Add(groupBoxGenSetting);
            tabPageGenerateDocument.Controls.Add(groupBoxGenChoseTemplate);
            tabPageGenerateDocument.ImageKey = "writing.png";
            tabPageGenerateDocument.Location = new Point(4, 39);
            tabPageGenerateDocument.Name = "tabPageGenerateDocument";
            tabPageGenerateDocument.Padding = new Padding(3);
            tabPageGenerateDocument.Size = new Size(1270, 722);
            tabPageGenerateDocument.TabIndex = 1;
            tabPageGenerateDocument.Text = "Генератор";
            // 
            // materialButtonGenerateDocument
            // 
            materialButtonGenerateDocument.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonGenerateDocument.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonGenerateDocument.Depth = 0;
            materialButtonGenerateDocument.HighEmphasis = true;
            materialButtonGenerateDocument.Icon = null;
            materialButtonGenerateDocument.Location = new Point(21, 659);
            materialButtonGenerateDocument.Margin = new Padding(4, 6, 4, 6);
            materialButtonGenerateDocument.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonGenerateDocument.Name = "materialButtonGenerateDocument";
            materialButtonGenerateDocument.NoAccentTextColor = Color.Empty;
            materialButtonGenerateDocument.Size = new Size(207, 36);
            materialButtonGenerateDocument.TabIndex = 18;
            materialButtonGenerateDocument.Text = "Сформувати документ";
            materialButtonGenerateDocument.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonGenerateDocument.UseAccentColor = false;
            materialButtonGenerateDocument.UseVisualStyleBackColor = true;
            materialButtonGenerateDocument.Click += materialButtonGenerateDocument_Click;
            // 
            // groupBoxGenSetting
            // 
            groupBoxGenSetting.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxGenSetting.Controls.Add(materialLabel1);
            groupBoxGenSetting.Controls.Add(materialButtonSelectPathForSaved);
            groupBoxGenSetting.Controls.Add(materialTextBoxPathForSaveDocument);
            groupBoxGenSetting.Controls.Add(materialLabelNameOutputDocument);
            groupBoxGenSetting.Controls.Add(materialTextBoxGenNameOutputDocument);
            groupBoxGenSetting.Controls.Add(materialComboBoxGenCommandList);
            groupBoxGenSetting.Controls.Add(materialSwitchUseCommand);
            groupBoxGenSetting.Controls.Add(dataGridViewGenSettingBookmarks);
            groupBoxGenSetting.Location = new Point(6, 270);
            groupBoxGenSetting.Name = "groupBoxGenSetting";
            groupBoxGenSetting.Size = new Size(1261, 361);
            groupBoxGenSetting.TabIndex = 17;
            groupBoxGenSetting.TabStop = false;
            groupBoxGenSetting.Text = "Налаштування";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(18, 226);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(108, 19);
            materialLabel1.TabIndex = 24;
            materialLabel1.Text = "Куди зберегти";
            // 
            // materialButtonSelectPathForSaved
            // 
            materialButtonSelectPathForSaved.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonSelectPathForSaved.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonSelectPathForSaved.Depth = 0;
            materialButtonSelectPathForSaved.HighEmphasis = true;
            materialButtonSelectPathForSaved.Icon = null;
            materialButtonSelectPathForSaved.Location = new Point(15, 305);
            materialButtonSelectPathForSaved.Margin = new Padding(4, 6, 4, 6);
            materialButtonSelectPathForSaved.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonSelectPathForSaved.Name = "materialButtonSelectPathForSaved";
            materialButtonSelectPathForSaved.NoAccentTextColor = Color.Empty;
            materialButtonSelectPathForSaved.Size = new Size(142, 36);
            materialButtonSelectPathForSaved.TabIndex = 23;
            materialButtonSelectPathForSaved.Text = "Вибрати папку";
            materialButtonSelectPathForSaved.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonSelectPathForSaved.UseAccentColor = false;
            materialButtonSelectPathForSaved.UseVisualStyleBackColor = true;
            materialButtonSelectPathForSaved.Click += materialButtonSelectPathForSaved_Click;
            // 
            // materialTextBoxPathForSaveDocument
            // 
            materialTextBoxPathForSaveDocument.AnimateReadOnly = false;
            materialTextBoxPathForSaveDocument.BackgroundImageLayout = ImageLayout.None;
            materialTextBoxPathForSaveDocument.CharacterCasing = CharacterCasing.Normal;
            materialTextBoxPathForSaveDocument.Depth = 0;
            materialTextBoxPathForSaveDocument.Enabled = false;
            materialTextBoxPathForSaveDocument.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxPathForSaveDocument.HideSelection = true;
            materialTextBoxPathForSaveDocument.Hint = "шлях";
            materialTextBoxPathForSaveDocument.LeadingIcon = null;
            materialTextBoxPathForSaveDocument.Location = new Point(15, 248);
            materialTextBoxPathForSaveDocument.MaxLength = 300;
            materialTextBoxPathForSaveDocument.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxPathForSaveDocument.Name = "materialTextBoxPathForSaveDocument";
            materialTextBoxPathForSaveDocument.PasswordChar = '\0';
            materialTextBoxPathForSaveDocument.PrefixSuffixText = null;
            materialTextBoxPathForSaveDocument.ReadOnly = false;
            materialTextBoxPathForSaveDocument.RightToLeft = RightToLeft.No;
            materialTextBoxPathForSaveDocument.SelectedText = "";
            materialTextBoxPathForSaveDocument.SelectionLength = 0;
            materialTextBoxPathForSaveDocument.SelectionStart = 0;
            materialTextBoxPathForSaveDocument.ShortcutsEnabled = true;
            materialTextBoxPathForSaveDocument.Size = new Size(300, 48);
            materialTextBoxPathForSaveDocument.TabIndex = 22;
            materialTextBoxPathForSaveDocument.TabStop = false;
            materialTextBoxPathForSaveDocument.TextAlign = HorizontalAlignment.Left;
            materialTextBoxPathForSaveDocument.TrailingIcon = null;
            materialTextBoxPathForSaveDocument.UseSystemPasswordChar = false;
            // 
            // materialLabelNameOutputDocument
            // 
            materialLabelNameOutputDocument.AutoSize = true;
            materialLabelNameOutputDocument.Depth = 0;
            materialLabelNameOutputDocument.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelNameOutputDocument.Location = new Point(18, 142);
            materialLabelNameOutputDocument.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelNameOutputDocument.Name = "materialLabelNameOutputDocument";
            materialLabelNameOutputDocument.Size = new Size(211, 19);
            materialLabelNameOutputDocument.TabIndex = 21;
            materialLabelNameOutputDocument.Text = "Назва вихідного документа";
            // 
            // materialTextBoxGenNameOutputDocument
            // 
            materialTextBoxGenNameOutputDocument.AnimateReadOnly = false;
            materialTextBoxGenNameOutputDocument.BackgroundImageLayout = ImageLayout.None;
            materialTextBoxGenNameOutputDocument.CharacterCasing = CharacterCasing.Normal;
            materialTextBoxGenNameOutputDocument.Depth = 0;
            materialTextBoxGenNameOutputDocument.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxGenNameOutputDocument.HideSelection = true;
            materialTextBoxGenNameOutputDocument.LeadingIcon = null;
            materialTextBoxGenNameOutputDocument.Location = new Point(18, 164);
            materialTextBoxGenNameOutputDocument.MaxLength = 300;
            materialTextBoxGenNameOutputDocument.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxGenNameOutputDocument.Name = "materialTextBoxGenNameOutputDocument";
            materialTextBoxGenNameOutputDocument.PasswordChar = '\0';
            materialTextBoxGenNameOutputDocument.PrefixSuffixText = null;
            materialTextBoxGenNameOutputDocument.ReadOnly = false;
            materialTextBoxGenNameOutputDocument.RightToLeft = RightToLeft.No;
            materialTextBoxGenNameOutputDocument.SelectedText = "";
            materialTextBoxGenNameOutputDocument.SelectionLength = 0;
            materialTextBoxGenNameOutputDocument.SelectionStart = 0;
            materialTextBoxGenNameOutputDocument.ShortcutsEnabled = true;
            materialTextBoxGenNameOutputDocument.Size = new Size(297, 48);
            materialTextBoxGenNameOutputDocument.TabIndex = 20;
            materialTextBoxGenNameOutputDocument.TabStop = false;
            materialTextBoxGenNameOutputDocument.Text = "OutputDocument.docx";
            materialTextBoxGenNameOutputDocument.TextAlign = HorizontalAlignment.Left;
            materialTextBoxGenNameOutputDocument.TrailingIcon = null;
            materialTextBoxGenNameOutputDocument.UseSystemPasswordChar = false;
            // 
            // materialComboBoxGenCommandList
            // 
            materialComboBoxGenCommandList.AutoResize = false;
            materialComboBoxGenCommandList.BackColor = Color.FromArgb(255, 255, 255);
            materialComboBoxGenCommandList.Depth = 0;
            materialComboBoxGenCommandList.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBoxGenCommandList.DropDownHeight = 174;
            materialComboBoxGenCommandList.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBoxGenCommandList.DropDownWidth = 121;
            materialComboBoxGenCommandList.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBoxGenCommandList.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBoxGenCommandList.FormattingEnabled = true;
            materialComboBoxGenCommandList.IntegralHeight = false;
            materialComboBoxGenCommandList.ItemHeight = 43;
            materialComboBoxGenCommandList.Location = new Point(25, 67);
            materialComboBoxGenCommandList.MaxDropDownItems = 4;
            materialComboBoxGenCommandList.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBoxGenCommandList.Name = "materialComboBoxGenCommandList";
            materialComboBoxGenCommandList.Size = new Size(290, 49);
            materialComboBoxGenCommandList.StartIndex = 0;
            materialComboBoxGenCommandList.TabIndex = 18;
            // 
            // materialSwitchUseCommand
            // 
            materialSwitchUseCommand.AutoSize = true;
            materialSwitchUseCommand.Depth = 0;
            materialSwitchUseCommand.Location = new Point(15, 27);
            materialSwitchUseCommand.Margin = new Padding(0);
            materialSwitchUseCommand.MouseLocation = new Point(-1, -1);
            materialSwitchUseCommand.MouseState = MaterialSkin.MouseState.HOVER;
            materialSwitchUseCommand.Name = "materialSwitchUseCommand";
            materialSwitchUseCommand.Ripple = true;
            materialSwitchUseCommand.Size = new Size(261, 37);
            materialSwitchUseCommand.TabIndex = 17;
            materialSwitchUseCommand.Text = "використати дані команди";
            materialSwitchUseCommand.UseVisualStyleBackColor = true;
            // 
            // dataGridViewGenSettingBookmarks
            // 
            dataGridViewGenSettingBookmarks.AllowUserToAddRows = false;
            dataGridViewGenSettingBookmarks.AllowUserToDeleteRows = false;
            dataGridViewGenSettingBookmarks.AllowUserToResizeColumns = false;
            dataGridViewGenSettingBookmarks.AllowUserToResizeRows = false;
            dataGridViewGenSettingBookmarks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewGenSettingBookmarks.BackgroundColor = Color.White;
            dataGridViewGenSettingBookmarks.BorderStyle = BorderStyle.None;
            dataGridViewGenSettingBookmarks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewGenSettingBookmarks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewGenSettingBookmarks.ColumnHeadersHeight = 35;
            dataGridViewGenSettingBookmarks.Columns.AddRange(new DataGridViewColumn[] { GenNumberRows, GenNameBookmark, GenDataType, GenEnterData });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(100, 100, 180);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dataGridViewGenSettingBookmarks.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewGenSettingBookmarks.EnableHeadersVisualStyles = false;
            dataGridViewGenSettingBookmarks.GridColor = Color.LightGray;
            dataGridViewGenSettingBookmarks.Location = new Point(391, 27);
            dataGridViewGenSettingBookmarks.MultiSelect = false;
            dataGridViewGenSettingBookmarks.Name = "dataGridViewGenSettingBookmarks";
            dataGridViewGenSettingBookmarks.RowHeadersVisible = false;
            dataGridViewGenSettingBookmarks.RowHeadersWidth = 25;
            dataGridViewGenSettingBookmarks.RowTemplate.Height = 25;
            dataGridViewGenSettingBookmarks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewGenSettingBookmarks.Size = new Size(867, 314);
            dataGridViewGenSettingBookmarks.TabIndex = 16;
            dataGridViewGenSettingBookmarks.CellContentClick += dataGridViewGenSettingBookmarks_CellContentClick;
            dataGridViewGenSettingBookmarks.RowPostPaint += dataGridViewGenSettingBookmarks_RowPostPaint;
            // 
            // GenNumberRows
            // 
            GenNumberRows.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            GenNumberRows.HeaderText = "Номер";
            GenNumberRows.MinimumWidth = 8;
            GenNumberRows.Name = "GenNumberRows";
            GenNumberRows.Width = 107;
            // 
            // GenNameBookmark
            // 
            GenNameBookmark.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GenNameBookmark.HeaderText = "Закладка";
            GenNameBookmark.MinimumWidth = 8;
            GenNameBookmark.Name = "GenNameBookmark";
            // 
            // GenDataType
            // 
            GenDataType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(192, 192, 255);
            GenDataType.DefaultCellStyle = dataGridViewCellStyle6;
            GenDataType.FlatStyle = FlatStyle.Flat;
            GenDataType.HeaderText = "Тип даних";
            GenDataType.MinimumWidth = 8;
            GenDataType.Name = "GenDataType";
            // 
            // GenEnterData
            // 
            GenEnterData.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            GenEnterData.HeaderText = "Дані";
            GenEnterData.Image = Properties.Resources.create_cmd;
            GenEnterData.ImageLayout = DataGridViewImageCellLayout.Zoom;
            GenEnterData.MinimumWidth = 8;
            GenEnterData.Name = "GenEnterData";
            GenEnterData.Width = 57;
            // 
            // groupBoxGenChoseTemplate
            // 
            groupBoxGenChoseTemplate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxGenChoseTemplate.Controls.Add(dataGridViewGenLoadTemplateTable);
            groupBoxGenChoseTemplate.Controls.Add(materialComboBoxGenSavedTemplate);
            groupBoxGenChoseTemplate.Controls.Add(materialRadioButtonGenLoadTemplate);
            groupBoxGenChoseTemplate.Controls.Add(materialRadioButtonGenSavedTemplate);
            groupBoxGenChoseTemplate.Location = new Point(6, 6);
            groupBoxGenChoseTemplate.Name = "groupBoxGenChoseTemplate";
            groupBoxGenChoseTemplate.Size = new Size(1261, 258);
            groupBoxGenChoseTemplate.TabIndex = 0;
            groupBoxGenChoseTemplate.TabStop = false;
            groupBoxGenChoseTemplate.Text = "Вибір шаблона";
            // 
            // dataGridViewGenLoadTemplateTable
            // 
            dataGridViewGenLoadTemplateTable.AllowUserToAddRows = false;
            dataGridViewGenLoadTemplateTable.AllowUserToDeleteRows = false;
            dataGridViewGenLoadTemplateTable.AllowUserToResizeColumns = false;
            dataGridViewGenLoadTemplateTable.AllowUserToResizeRows = false;
            dataGridViewGenLoadTemplateTable.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewGenLoadTemplateTable.BackgroundColor = Color.White;
            dataGridViewGenLoadTemplateTable.BorderStyle = BorderStyle.None;
            dataGridViewGenLoadTemplateTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridViewGenLoadTemplateTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewGenLoadTemplateTable.ColumnHeadersHeight = 35;
            dataGridViewGenLoadTemplateTable.Columns.AddRange(new DataGridViewColumn[] { GenTmpRowNumber, GenTmpNameBookmark, GenTmpDateModification, GenTmpSize, GenTmpDelete });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(100, 100, 180);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dataGridViewGenLoadTemplateTable.DefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewGenLoadTemplateTable.EnableHeadersVisualStyles = false;
            dataGridViewGenLoadTemplateTable.GridColor = Color.LightGray;
            dataGridViewGenLoadTemplateTable.Location = new Point(362, 56);
            dataGridViewGenLoadTemplateTable.MultiSelect = false;
            dataGridViewGenLoadTemplateTable.Name = "dataGridViewGenLoadTemplateTable";
            dataGridViewGenLoadTemplateTable.ReadOnly = true;
            dataGridViewGenLoadTemplateTable.RowHeadersVisible = false;
            dataGridViewGenLoadTemplateTable.RowHeadersWidth = 25;
            dataGridViewGenLoadTemplateTable.RowTemplate.Height = 25;
            dataGridViewGenLoadTemplateTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewGenLoadTemplateTable.Size = new Size(896, 190);
            dataGridViewGenLoadTemplateTable.TabIndex = 3;
            // 
            // GenTmpRowNumber
            // 
            GenTmpRowNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            GenTmpRowNumber.DividerWidth = 1;
            GenTmpRowNumber.FillWeight = 150F;
            GenTmpRowNumber.HeaderText = "Номер";
            GenTmpRowNumber.MinimumWidth = 8;
            GenTmpRowNumber.Name = "GenTmpRowNumber";
            GenTmpRowNumber.ReadOnly = true;
            GenTmpRowNumber.Width = 107;
            // 
            // GenTmpNameBookmark
            // 
            GenTmpNameBookmark.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GenTmpNameBookmark.DividerWidth = 1;
            GenTmpNameBookmark.FillWeight = 150F;
            GenTmpNameBookmark.HeaderText = "Назва";
            GenTmpNameBookmark.MinimumWidth = 8;
            GenTmpNameBookmark.Name = "GenTmpNameBookmark";
            GenTmpNameBookmark.ReadOnly = true;
            // 
            // GenTmpDateModification
            // 
            GenTmpDateModification.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GenTmpDateModification.DividerWidth = 1;
            GenTmpDateModification.FillWeight = 150F;
            GenTmpDateModification.HeaderText = "Дата зміни";
            GenTmpDateModification.MinimumWidth = 8;
            GenTmpDateModification.Name = "GenTmpDateModification";
            GenTmpDateModification.ReadOnly = true;
            // 
            // GenTmpSize
            // 
            GenTmpSize.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GenTmpSize.DividerWidth = 1;
            GenTmpSize.FillWeight = 150F;
            GenTmpSize.HeaderText = "Розмір (КБ)";
            GenTmpSize.MinimumWidth = 8;
            GenTmpSize.Name = "GenTmpSize";
            GenTmpSize.ReadOnly = true;
            // 
            // GenTmpDelete
            // 
            GenTmpDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            GenTmpDelete.FillWeight = 90F;
            GenTmpDelete.HeaderText = "Видалити";
            GenTmpDelete.Image = Properties.Resources.delete_doc;
            GenTmpDelete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            GenTmpDelete.MinimumWidth = 8;
            GenTmpDelete.Name = "GenTmpDelete";
            GenTmpDelete.ReadOnly = true;
            GenTmpDelete.Width = 101;
            // 
            // materialComboBoxGenSavedTemplate
            // 
            materialComboBoxGenSavedTemplate.AutoResize = false;
            materialComboBoxGenSavedTemplate.BackColor = Color.FromArgb(255, 255, 255);
            materialComboBoxGenSavedTemplate.Depth = 0;
            materialComboBoxGenSavedTemplate.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBoxGenSavedTemplate.DropDownHeight = 174;
            materialComboBoxGenSavedTemplate.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBoxGenSavedTemplate.DropDownWidth = 121;
            materialComboBoxGenSavedTemplate.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBoxGenSavedTemplate.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBoxGenSavedTemplate.FormattingEnabled = true;
            materialComboBoxGenSavedTemplate.IntegralHeight = false;
            materialComboBoxGenSavedTemplate.ItemHeight = 43;
            materialComboBoxGenSavedTemplate.Location = new Point(25, 75);
            materialComboBoxGenSavedTemplate.MaxDropDownItems = 4;
            materialComboBoxGenSavedTemplate.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBoxGenSavedTemplate.Name = "materialComboBoxGenSavedTemplate";
            materialComboBoxGenSavedTemplate.Size = new Size(290, 49);
            materialComboBoxGenSavedTemplate.StartIndex = 0;
            materialComboBoxGenSavedTemplate.TabIndex = 2;
            materialComboBoxGenSavedTemplate.SelectedValueChanged += materialComboBoxGenSavedTemplate_SelectedValueChanged;
            // 
            // materialRadioButtonGenLoadTemplate
            // 
            materialRadioButtonGenLoadTemplate.AutoSize = true;
            materialRadioButtonGenLoadTemplate.Depth = 0;
            materialRadioButtonGenLoadTemplate.Location = new Point(535, 25);
            materialRadioButtonGenLoadTemplate.Margin = new Padding(0);
            materialRadioButtonGenLoadTemplate.MouseLocation = new Point(-1, -1);
            materialRadioButtonGenLoadTemplate.MouseState = MaterialSkin.MouseState.HOVER;
            materialRadioButtonGenLoadTemplate.Name = "materialRadioButtonGenLoadTemplate";
            materialRadioButtonGenLoadTemplate.Ripple = true;
            materialRadioButtonGenLoadTemplate.Size = new Size(200, 37);
            materialRadioButtonGenLoadTemplate.TabIndex = 1;
            materialRadioButtonGenLoadTemplate.TabStop = true;
            materialRadioButtonGenLoadTemplate.Text = "завантажені шаблони";
            materialRadioButtonGenLoadTemplate.UseVisualStyleBackColor = true;
            // 
            // materialRadioButtonGenSavedTemplate
            // 
            materialRadioButtonGenSavedTemplate.AutoSize = true;
            materialRadioButtonGenSavedTemplate.Checked = true;
            materialRadioButtonGenSavedTemplate.Depth = 0;
            materialRadioButtonGenSavedTemplate.Location = new Point(25, 35);
            materialRadioButtonGenSavedTemplate.Margin = new Padding(0);
            materialRadioButtonGenSavedTemplate.MouseLocation = new Point(-1, -1);
            materialRadioButtonGenSavedTemplate.MouseState = MaterialSkin.MouseState.HOVER;
            materialRadioButtonGenSavedTemplate.Name = "materialRadioButtonGenSavedTemplate";
            materialRadioButtonGenSavedTemplate.Ripple = true;
            materialRadioButtonGenSavedTemplate.Size = new Size(181, 37);
            materialRadioButtonGenSavedTemplate.TabIndex = 0;
            materialRadioButtonGenSavedTemplate.TabStop = true;
            materialRadioButtonGenSavedTemplate.Text = "збережені шаблони";
            materialRadioButtonGenSavedTemplate.UseVisualStyleBackColor = true;
            // 
            // tabPageCommand
            // 
            tabPageCommand.BackColor = Color.White;
            tabPageCommand.Controls.Add(groupBoxCmdTable);
            tabPageCommand.Controls.Add(groupBoxCmdSettingConvert);
            tabPageCommand.Controls.Add(groupBoxSettingCommand);
            tabPageCommand.ImageKey = "command-line.png";
            tabPageCommand.Location = new Point(4, 39);
            tabPageCommand.Name = "tabPageCommand";
            tabPageCommand.Size = new Size(1270, 722);
            tabPageCommand.TabIndex = 2;
            tabPageCommand.Text = "Команди";
            // 
            // groupBoxCmdTable
            // 
            groupBoxCmdTable.Controls.Add(dataGridViewTableCommand);
            groupBoxCmdTable.Location = new Point(30, 314);
            groupBoxCmdTable.Name = "groupBoxCmdTable";
            groupBoxCmdTable.Size = new Size(1170, 274);
            groupBoxCmdTable.TabIndex = 17;
            groupBoxCmdTable.TabStop = false;
            groupBoxCmdTable.Text = "Таблиця команд";
            // 
            // dataGridViewTableCommand
            // 
            dataGridViewTableCommand.AllowUserToAddRows = false;
            dataGridViewTableCommand.AllowUserToDeleteRows = false;
            dataGridViewTableCommand.AllowUserToResizeColumns = false;
            dataGridViewTableCommand.AllowUserToResizeRows = false;
            dataGridViewTableCommand.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewTableCommand.BackgroundColor = Color.White;
            dataGridViewTableCommand.BorderStyle = BorderStyle.None;
            dataGridViewTableCommand.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle10.SelectionForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dataGridViewTableCommand.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewTableCommand.ColumnHeadersHeight = 35;
            dataGridViewTableCommand.Columns.AddRange(new DataGridViewColumn[] { CmdNumberRowCommand, CommandName, CmdInputTemplate, CmdOutputTemplate, CmdDeleteCommand });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = Color.White;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle11.SelectionForeColor = Color.FromArgb(100, 100, 180);
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dataGridViewTableCommand.DefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewTableCommand.EnableHeadersVisualStyles = false;
            dataGridViewTableCommand.GridColor = Color.LightGray;
            dataGridViewTableCommand.Location = new Point(14, 30);
            dataGridViewTableCommand.MultiSelect = false;
            dataGridViewTableCommand.Name = "dataGridViewTableCommand";
            dataGridViewTableCommand.ReadOnly = true;
            dataGridViewTableCommand.RowHeadersVisible = false;
            dataGridViewTableCommand.RowHeadersWidth = 25;
            dataGridViewTableCommand.RowTemplate.Height = 25;
            dataGridViewTableCommand.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTableCommand.Size = new Size(1150, 218);
            dataGridViewTableCommand.TabIndex = 16;
            // 
            // CmdNumberRowCommand
            // 
            CmdNumberRowCommand.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CmdNumberRowCommand.HeaderText = "Номер";
            CmdNumberRowCommand.MinimumWidth = 8;
            CmdNumberRowCommand.Name = "CmdNumberRowCommand";
            CmdNumberRowCommand.ReadOnly = true;
            CmdNumberRowCommand.Width = 107;
            // 
            // CommandName
            // 
            CommandName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CommandName.HeaderText = "Назва команди";
            CommandName.MinimumWidth = 8;
            CommandName.Name = "CommandName";
            CommandName.ReadOnly = true;
            // 
            // CmdInputTemplate
            // 
            CmdInputTemplate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CmdInputTemplate.HeaderText = "Вхідний шаблон";
            CmdInputTemplate.MinimumWidth = 8;
            CmdInputTemplate.Name = "CmdInputTemplate";
            CmdInputTemplate.ReadOnly = true;
            // 
            // CmdOutputTemplate
            // 
            CmdOutputTemplate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CmdOutputTemplate.HeaderText = "Вихідний шаблон";
            CmdOutputTemplate.MinimumWidth = 8;
            CmdOutputTemplate.Name = "CmdOutputTemplate";
            CmdOutputTemplate.ReadOnly = true;
            // 
            // CmdDeleteCommand
            // 
            CmdDeleteCommand.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CmdDeleteCommand.HeaderText = "Видалити";
            CmdDeleteCommand.Image = Properties.Resources.delete_doc;
            CmdDeleteCommand.ImageLayout = DataGridViewImageCellLayout.Stretch;
            CmdDeleteCommand.MinimumWidth = 8;
            CmdDeleteCommand.Name = "CmdDeleteCommand";
            CmdDeleteCommand.ReadOnly = true;
            CmdDeleteCommand.Width = 102;
            // 
            // groupBoxCmdSettingConvert
            // 
            groupBoxCmdSettingConvert.Controls.Add(dataGridViewCmdTemplateTable);
            groupBoxCmdSettingConvert.Location = new Point(442, 15);
            groupBoxCmdSettingConvert.Name = "groupBoxCmdSettingConvert";
            groupBoxCmdSettingConvert.Size = new Size(751, 259);
            groupBoxCmdSettingConvert.TabIndex = 5;
            groupBoxCmdSettingConvert.TabStop = false;
            groupBoxCmdSettingConvert.Text = "Параметри конвертування";
            // 
            // dataGridViewCmdTemplateTable
            // 
            dataGridViewCmdTemplateTable.AllowUserToAddRows = false;
            dataGridViewCmdTemplateTable.AllowUserToDeleteRows = false;
            dataGridViewCmdTemplateTable.AllowUserToResizeColumns = false;
            dataGridViewCmdTemplateTable.AllowUserToResizeRows = false;
            dataGridViewCmdTemplateTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCmdTemplateTable.BackgroundColor = Color.White;
            dataGridViewCmdTemplateTable.BorderStyle = BorderStyle.None;
            dataGridViewCmdTemplateTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle12.SelectionForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dataGridViewCmdTemplateTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dataGridViewCmdTemplateTable.ColumnHeadersHeight = 35;
            dataGridViewCmdTemplateTable.Columns.AddRange(new DataGridViewColumn[] { CmdNumberRowTmp, CmdInputBookmark, CmdOutputBookmark });
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = Color.White;
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle13.SelectionForeColor = Color.FromArgb(100, 100, 180);
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.False;
            dataGridViewCmdTemplateTable.DefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewCmdTemplateTable.EnableHeadersVisualStyles = false;
            dataGridViewCmdTemplateTable.GridColor = Color.LightGray;
            dataGridViewCmdTemplateTable.Location = new Point(6, 30);
            dataGridViewCmdTemplateTable.MultiSelect = false;
            dataGridViewCmdTemplateTable.Name = "dataGridViewCmdTemplateTable";
            dataGridViewCmdTemplateTable.ReadOnly = true;
            dataGridViewCmdTemplateTable.RowHeadersVisible = false;
            dataGridViewCmdTemplateTable.RowHeadersWidth = 25;
            dataGridViewCmdTemplateTable.RowTemplate.Height = 25;
            dataGridViewCmdTemplateTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCmdTemplateTable.Size = new Size(739, 223);
            dataGridViewCmdTemplateTable.TabIndex = 15;
            // 
            // CmdNumberRowTmp
            // 
            CmdNumberRowTmp.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CmdNumberRowTmp.HeaderText = "Номер";
            CmdNumberRowTmp.MinimumWidth = 8;
            CmdNumberRowTmp.Name = "CmdNumberRowTmp";
            CmdNumberRowTmp.ReadOnly = true;
            CmdNumberRowTmp.Width = 107;
            // 
            // CmdInputBookmark
            // 
            CmdInputBookmark.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CmdInputBookmark.HeaderText = "Вхідна закладка";
            CmdInputBookmark.MinimumWidth = 8;
            CmdInputBookmark.Name = "CmdInputBookmark";
            CmdInputBookmark.ReadOnly = true;
            // 
            // CmdOutputBookmark
            // 
            CmdOutputBookmark.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CmdOutputBookmark.HeaderText = "Вихідна закладка";
            CmdOutputBookmark.MinimumWidth = 8;
            CmdOutputBookmark.Name = "CmdOutputBookmark";
            CmdOutputBookmark.ReadOnly = true;
            // 
            // groupBoxSettingCommand
            // 
            groupBoxSettingCommand.Controls.Add(materialTextBoxCmdCommandName);
            groupBoxSettingCommand.Controls.Add(materialComboBoxCmdOutputTemplate);
            groupBoxSettingCommand.Controls.Add(materialComboBoxCmdInputTemplate);
            groupBoxSettingCommand.Location = new Point(19, 15);
            groupBoxSettingCommand.Name = "groupBoxSettingCommand";
            groupBoxSettingCommand.Size = new Size(406, 259);
            groupBoxSettingCommand.TabIndex = 4;
            groupBoxSettingCommand.TabStop = false;
            groupBoxSettingCommand.Text = "Налаштування команди";
            // 
            // materialTextBoxCmdCommandName
            // 
            materialTextBoxCmdCommandName.AnimateReadOnly = false;
            materialTextBoxCmdCommandName.BackgroundImageLayout = ImageLayout.None;
            materialTextBoxCmdCommandName.CharacterCasing = CharacterCasing.Normal;
            materialTextBoxCmdCommandName.Depth = 0;
            materialTextBoxCmdCommandName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxCmdCommandName.HideSelection = true;
            materialTextBoxCmdCommandName.Hint = "назва команди";
            materialTextBoxCmdCommandName.LeadingIcon = null;
            materialTextBoxCmdCommandName.Location = new Point(35, 43);
            materialTextBoxCmdCommandName.MaxLength = 300;
            materialTextBoxCmdCommandName.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxCmdCommandName.Name = "materialTextBoxCmdCommandName";
            materialTextBoxCmdCommandName.PasswordChar = '\0';
            materialTextBoxCmdCommandName.PrefixSuffixText = null;
            materialTextBoxCmdCommandName.ReadOnly = false;
            materialTextBoxCmdCommandName.RightToLeft = RightToLeft.No;
            materialTextBoxCmdCommandName.SelectedText = "";
            materialTextBoxCmdCommandName.SelectionLength = 0;
            materialTextBoxCmdCommandName.SelectionStart = 0;
            materialTextBoxCmdCommandName.ShortcutsEnabled = true;
            materialTextBoxCmdCommandName.Size = new Size(297, 48);
            materialTextBoxCmdCommandName.TabIndex = 1;
            materialTextBoxCmdCommandName.TabStop = false;
            materialTextBoxCmdCommandName.TextAlign = HorizontalAlignment.Left;
            materialTextBoxCmdCommandName.TrailingIcon = null;
            materialTextBoxCmdCommandName.UseSystemPasswordChar = false;
            // 
            // materialComboBoxCmdOutputTemplate
            // 
            materialComboBoxCmdOutputTemplate.AutoResize = false;
            materialComboBoxCmdOutputTemplate.BackColor = Color.FromArgb(255, 255, 255);
            materialComboBoxCmdOutputTemplate.Depth = 0;
            materialComboBoxCmdOutputTemplate.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBoxCmdOutputTemplate.DropDownHeight = 174;
            materialComboBoxCmdOutputTemplate.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBoxCmdOutputTemplate.DropDownWidth = 121;
            materialComboBoxCmdOutputTemplate.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBoxCmdOutputTemplate.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBoxCmdOutputTemplate.FormattingEnabled = true;
            materialComboBoxCmdOutputTemplate.Hint = "вихідний шаблон";
            materialComboBoxCmdOutputTemplate.IntegralHeight = false;
            materialComboBoxCmdOutputTemplate.ItemHeight = 43;
            materialComboBoxCmdOutputTemplate.Location = new Point(35, 175);
            materialComboBoxCmdOutputTemplate.MaxDropDownItems = 4;
            materialComboBoxCmdOutputTemplate.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBoxCmdOutputTemplate.Name = "materialComboBoxCmdOutputTemplate";
            materialComboBoxCmdOutputTemplate.Size = new Size(297, 49);
            materialComboBoxCmdOutputTemplate.StartIndex = 0;
            materialComboBoxCmdOutputTemplate.TabIndex = 3;
            // 
            // materialComboBoxCmdInputTemplate
            // 
            materialComboBoxCmdInputTemplate.AutoResize = false;
            materialComboBoxCmdInputTemplate.BackColor = Color.FromArgb(255, 255, 255);
            materialComboBoxCmdInputTemplate.Depth = 0;
            materialComboBoxCmdInputTemplate.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBoxCmdInputTemplate.DropDownHeight = 174;
            materialComboBoxCmdInputTemplate.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBoxCmdInputTemplate.DropDownWidth = 121;
            materialComboBoxCmdInputTemplate.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBoxCmdInputTemplate.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBoxCmdInputTemplate.FormattingEnabled = true;
            materialComboBoxCmdInputTemplate.Hint = "вхідний шаблон";
            materialComboBoxCmdInputTemplate.IntegralHeight = false;
            materialComboBoxCmdInputTemplate.ItemHeight = 43;
            materialComboBoxCmdInputTemplate.Location = new Point(35, 111);
            materialComboBoxCmdInputTemplate.MaxDropDownItems = 4;
            materialComboBoxCmdInputTemplate.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBoxCmdInputTemplate.Name = "materialComboBoxCmdInputTemplate";
            materialComboBoxCmdInputTemplate.Size = new Size(297, 49);
            materialComboBoxCmdInputTemplate.StartIndex = 0;
            materialComboBoxCmdInputTemplate.TabIndex = 2;
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
            tabPageGenerateDocument.ResumeLayout(false);
            tabPageGenerateDocument.PerformLayout();
            groupBoxGenSetting.ResumeLayout(false);
            groupBoxGenSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGenSettingBookmarks).EndInit();
            groupBoxGenChoseTemplate.ResumeLayout(false);
            groupBoxGenChoseTemplate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGenLoadTemplateTable).EndInit();
            tabPageCommand.ResumeLayout(false);
            groupBoxCmdTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTableCommand).EndInit();
            groupBoxCmdSettingConvert.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCmdTemplateTable).EndInit();
            groupBoxSettingCommand.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl;
        private TabPage tabPageTemplate;
        private TabPage tabPageCommand;
        private ImageList imageListMenu;
        private TabPage tabPageGenerateDocument;
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
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxCmdCommandName;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxCmdInputTemplate;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxCmdOutputTemplate;
        private GroupBox groupBoxSettingCommand;
        private GroupBox groupBoxCmdSettingConvert;
        private DataGridView dataGridViewCmdTemplateTable;
        private DataGridView dataGridViewTableCommand;
        private DataGridViewTextBoxColumn CmdNumberRowTmp;
        private DataGridViewComboBoxColumn CmdInputBookmark;
        private DataGridViewComboBoxColumn CmdOutputBookmark;
        private DataGridViewTextBoxColumn CmdNumberRowCommand;
        private DataGridViewTextBoxColumn CommandName;
        private DataGridViewTextBoxColumn CmdInputTemplate;
        private DataGridViewTextBoxColumn CmdOutputTemplate;
        private DataGridViewImageColumn CmdDeleteCommand;
        private GroupBox groupBoxCmdTable;
        private GroupBox groupBoxGenChoseTemplate;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButtonGenSavedTemplate;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButtonGenLoadTemplate;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxGenSavedTemplate;
        private DataGridView dataGridViewGenSettingBookmarks;
        private DataGridView dataGridViewGenLoadTemplateTable;
        private GroupBox groupBoxGenSetting;
        private MaterialSkin.Controls.MaterialSwitch materialSwitchUseCommand;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxGenCommandList;
        private DataGridViewTextBoxColumn GenTmpRowNumber;
        private DataGridViewTextBoxColumn GenTmpNameBookmark;
        private DataGridViewTextBoxColumn GenTmpDateModification;
        private DataGridViewTextBoxColumn GenTmpSize;
        private DataGridViewImageColumn GenTmpDelete;
        private DataGridViewTextBoxColumn GenNumberRows;
        private DataGridViewTextBoxColumn GenNameBookmark;
        private DataGridViewComboBoxColumn GenDataType;
        private DataGridViewImageColumn GenEnterData;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxGenNameOutputDocument;
        private MaterialSkin.Controls.MaterialLabel materialLabelNameOutputDocument;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxPathForSaveDocument;
        private MaterialSkin.Controls.MaterialButton materialButtonSelectPathForSaved;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton materialButtonGenerateDocument;
    }
}