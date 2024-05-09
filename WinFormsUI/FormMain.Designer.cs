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
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            materialTabControlMainMenu = new MaterialSkin.Controls.MaterialTabControl();
            tabPageTemplate = new TabPage();
            dataGridViewTableBookmarks = new DataGridView();
            ColumnNumber = new DataGridViewTextBoxColumn();
            ColumnBookmarkName = new DataGridViewTextBoxColumn();
            TypeBookmark = new DataGridViewTextBoxColumn();
            tableLayoutPanelTools = new TableLayoutPanel();
            ButtonAddTemplate = new MaterialSkin.Controls.MaterialButton();
            ButtonEditTemplate = new MaterialSkin.Controls.MaterialButton();
            ButtonReadTemplate = new MaterialSkin.Controls.MaterialButton();
            TextBoxSearchTemplate = new MaterialSkin.Controls.MaterialTextBox();
            dataGridViewTableTemplate = new DataGridView();
            NumberRows = new DataGridViewTextBoxColumn();
            NameFile = new DataGridViewTextBoxColumn();
            PathFile = new DataGridViewTextBoxColumn();
            RemoveTemplate = new DataGridViewImageColumn();
            tabPageGenerateDocument = new TabPage();
            groupBoxGenSetting = new GroupBox();
            materialTextBoxPathForSaveDocument = new MaterialSkin.Controls.MaterialTextBox();
            materialButtonGenerateDocument = new MaterialSkin.Controls.MaterialButton();
            materialLabelPathSaved = new MaterialSkin.Controls.MaterialLabel();
            materialButtonSelectPathForSaved = new MaterialSkin.Controls.MaterialButton();
            materialLabelNameOutputDocument = new MaterialSkin.Controls.MaterialLabel();
            materialTextBoxGenNameOutputDocument = new MaterialSkin.Controls.MaterialTextBox2();
            ComboBoxGenCommandList = new MaterialSkin.Controls.MaterialComboBox();
            materialSwitchUseCommand = new MaterialSkin.Controls.MaterialSwitch();
            dataGridViewGenSettingBookmarks = new DataGridView();
            GenNumberRows = new DataGridViewTextBoxColumn();
            GenNameBookmark = new DataGridViewTextBoxColumn();
            GenDataType = new DataGridViewComboBoxColumn();
            GenEnterData = new DataGridViewImageColumn();
            groupBoxGenChoseTemplate = new GroupBox();
            materialTabControlGenSelectTemplate = new MaterialSkin.Controls.MaterialTabControl();
            tabPageGenSaveTemplate = new TabPage();
            ListBoxGenSavedTemplates = new MaterialSkin.Controls.MaterialListBox();
            tabPageGenLoadTemplate = new TabPage();
            materialTabSelectorGenSelectTemplate = new MaterialSkin.Controls.MaterialTabSelector();
            tabPageCommand = new TabPage();
            groupBoxCmdTable = new GroupBox();
            ButtonEditCommand = new MaterialSkin.Controls.MaterialButton();
            ButtonCreateCommand = new MaterialSkin.Controls.MaterialButton();
            dataGridViewTableCommand = new DataGridView();
            CmdNumberRowCommand = new DataGridViewTextBoxColumn();
            CommandName = new DataGridViewTextBoxColumn();
            CmdInputTemplate = new DataGridViewTextBoxColumn();
            CmdOutputTemplate = new DataGridViewTextBoxColumn();
            CmdDeleteCommand = new DataGridViewImageColumn();
            groupBoxCmdSettingConvert = new GroupBox();
            dataGridViewCmdBookmarkMatch = new DataGridView();
            CmdNumberRow = new DataGridViewTextBoxColumn();
            CmdInputBookmark = new DataGridViewTextBoxColumn();
            CmdOutputBookmark = new DataGridViewComboBoxColumn();
            groupBoxSettingCommand = new GroupBox();
            ButtonCmdViewBookmark = new MaterialSkin.Controls.MaterialButton();
            LabelCmdInputDocument = new MaterialSkin.Controls.MaterialLabel();
            TextBoxCmdInputDocument = new MaterialSkin.Controls.MaterialTextBox();
            TextBoxCmdCommandName = new MaterialSkin.Controls.MaterialTextBox2();
            ComboBoxCmdOutputTemplate = new MaterialSkin.Controls.MaterialComboBox();
            imageListMenu = new ImageList(components);
            materialTabControlMainMenu.SuspendLayout();
            tabPageTemplate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTableBookmarks).BeginInit();
            tableLayoutPanelTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTableTemplate).BeginInit();
            tabPageGenerateDocument.SuspendLayout();
            groupBoxGenSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGenSettingBookmarks).BeginInit();
            groupBoxGenChoseTemplate.SuspendLayout();
            materialTabControlGenSelectTemplate.SuspendLayout();
            tabPageGenSaveTemplate.SuspendLayout();
            tabPageCommand.SuspendLayout();
            groupBoxCmdTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTableCommand).BeginInit();
            groupBoxCmdSettingConvert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCmdBookmarkMatch).BeginInit();
            groupBoxSettingCommand.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControlMainMenu
            // 
            materialTabControlMainMenu.Controls.Add(tabPageTemplate);
            materialTabControlMainMenu.Controls.Add(tabPageGenerateDocument);
            materialTabControlMainMenu.Controls.Add(tabPageCommand);
            materialTabControlMainMenu.Depth = 0;
            materialTabControlMainMenu.Dock = DockStyle.Fill;
            materialTabControlMainMenu.ImageList = imageListMenu;
            materialTabControlMainMenu.Location = new Point(3, 64);
            materialTabControlMainMenu.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControlMainMenu.Multiline = true;
            materialTabControlMainMenu.Name = "materialTabControlMainMenu";
            materialTabControlMainMenu.SelectedIndex = 0;
            materialTabControlMainMenu.Size = new Size(1278, 765);
            materialTabControlMainMenu.TabIndex = 0;
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
            dataGridViewTableBookmarks.Location = new Point(3, 449);
            dataGridViewTableBookmarks.MultiSelect = false;
            dataGridViewTableBookmarks.Name = "dataGridViewTableBookmarks";
            dataGridViewTableBookmarks.ReadOnly = true;
            dataGridViewTableBookmarks.RowHeadersVisible = false;
            dataGridViewTableBookmarks.RowHeadersWidth = 25;
            dataGridViewTableBookmarks.RowTemplate.Height = 25;
            dataGridViewTableBookmarks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTableBookmarks.Size = new Size(1261, 270);
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
            tableLayoutPanelTools.Controls.Add(ButtonAddTemplate, 0, 0);
            tableLayoutPanelTools.Controls.Add(ButtonEditTemplate, 1, 0);
            tableLayoutPanelTools.Controls.Add(ButtonReadTemplate, 2, 0);
            tableLayoutPanelTools.Controls.Add(TextBoxSearchTemplate, 3, 0);
            tableLayoutPanelTools.Dock = DockStyle.Top;
            tableLayoutPanelTools.Location = new Point(3, 3);
            tableLayoutPanelTools.Name = "tableLayoutPanelTools";
            tableLayoutPanelTools.Padding = new Padding(2);
            tableLayoutPanelTools.RowCount = 1;
            tableLayoutPanelTools.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelTools.Size = new Size(1264, 56);
            tableLayoutPanelTools.TabIndex = 1;
            // 
            // ButtonAddTemplate
            // 
            ButtonAddTemplate.AutoSize = false;
            ButtonAddTemplate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonAddTemplate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonAddTemplate.Depth = 0;
            ButtonAddTemplate.Dock = DockStyle.Fill;
            ButtonAddTemplate.HighEmphasis = true;
            ButtonAddTemplate.Icon = Properties.Resources.create_tmp;
            ButtonAddTemplate.Location = new Point(6, 8);
            ButtonAddTemplate.Margin = new Padding(4, 6, 4, 6);
            ButtonAddTemplate.MouseState = MaterialSkin.MouseState.HOVER;
            ButtonAddTemplate.Name = "ButtonAddTemplate";
            ButtonAddTemplate.NoAccentTextColor = Color.Empty;
            ButtonAddTemplate.RightToLeft = RightToLeft.No;
            ButtonAddTemplate.Size = new Size(102, 40);
            ButtonAddTemplate.TabIndex = 0;
            ButtonAddTemplate.Text = "Додати";
            ButtonAddTemplate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            ButtonAddTemplate.UseAccentColor = false;
            ButtonAddTemplate.UseVisualStyleBackColor = true;
            ButtonAddTemplate.Click += materialButtonAddTemplate_Click;
            // 
            // ButtonEditTemplate
            // 
            ButtonEditTemplate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonEditTemplate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonEditTemplate.Depth = 0;
            ButtonEditTemplate.Dock = DockStyle.Fill;
            ButtonEditTemplate.HighEmphasis = true;
            ButtonEditTemplate.Icon = (Image)resources.GetObject("ButtonEditTemplate.Icon");
            ButtonEditTemplate.Location = new Point(116, 8);
            ButtonEditTemplate.Margin = new Padding(4, 6, 4, 6);
            ButtonEditTemplate.MouseState = MaterialSkin.MouseState.HOVER;
            ButtonEditTemplate.Name = "ButtonEditTemplate";
            ButtonEditTemplate.NoAccentTextColor = Color.Empty;
            ButtonEditTemplate.Size = new Size(132, 40);
            ButtonEditTemplate.TabIndex = 1;
            ButtonEditTemplate.Text = "Редагувати";
            ButtonEditTemplate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            ButtonEditTemplate.UseAccentColor = false;
            ButtonEditTemplate.UseVisualStyleBackColor = true;
            ButtonEditTemplate.Click += materialButtonEditTemplate_Click;
            // 
            // ButtonReadTemplate
            // 
            ButtonReadTemplate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonReadTemplate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonReadTemplate.Depth = 0;
            ButtonReadTemplate.Dock = DockStyle.Fill;
            ButtonReadTemplate.HighEmphasis = true;
            ButtonReadTemplate.Icon = Properties.Resources.file_view;
            ButtonReadTemplate.Location = new Point(256, 8);
            ButtonReadTemplate.Margin = new Padding(4, 6, 4, 6);
            ButtonReadTemplate.MouseState = MaterialSkin.MouseState.HOVER;
            ButtonReadTemplate.Name = "ButtonReadTemplate";
            ButtonReadTemplate.NoAccentTextColor = Color.Empty;
            ButtonReadTemplate.Size = new Size(112, 40);
            ButtonReadTemplate.TabIndex = 2;
            ButtonReadTemplate.Text = "Читати";
            ButtonReadTemplate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            ButtonReadTemplate.UseAccentColor = false;
            ButtonReadTemplate.UseVisualStyleBackColor = true;
            ButtonReadTemplate.Click += materialButtonReadTemplate_Click;
            // 
            // TextBoxSearchTemplate
            // 
            TextBoxSearchTemplate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            TextBoxSearchTemplate.AnimateReadOnly = false;
            TextBoxSearchTemplate.BackColor = Color.FromArgb(192, 255, 255);
            TextBoxSearchTemplate.BorderStyle = BorderStyle.None;
            TextBoxSearchTemplate.Depth = 0;
            TextBoxSearchTemplate.Font = new Font("Roboto", 8F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxSearchTemplate.Hint = "знайти шаблон";
            TextBoxSearchTemplate.ImeMode = ImeMode.NoControl;
            TextBoxSearchTemplate.LeadingIcon = null;
            TextBoxSearchTemplate.Location = new Point(375, 5);
            TextBoxSearchTemplate.MaxLength = 100;
            TextBoxSearchTemplate.MinimumSize = new Size(312, 50);
            TextBoxSearchTemplate.MouseState = MaterialSkin.MouseState.OUT;
            TextBoxSearchTemplate.Multiline = false;
            TextBoxSearchTemplate.Name = "TextBoxSearchTemplate";
            TextBoxSearchTemplate.Size = new Size(312, 50);
            TextBoxSearchTemplate.TabIndex = 15;
            TextBoxSearchTemplate.Text = "BookmarkTest.docx";
            TextBoxSearchTemplate.TrailingIcon = (Image)resources.GetObject("TextBoxSearchTemplate.TrailingIcon");
            TextBoxSearchTemplate.TrailingIconClick += materialTextBoxSearchTemplate_TrailingIconClick;
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
            dataGridViewTableTemplate.Columns.AddRange(new DataGridViewColumn[] { NumberRows, NameFile, PathFile, RemoveTemplate });
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
            dataGridViewTableTemplate.Size = new Size(1264, 366);
            dataGridViewTableTemplate.TabIndex = 0;
            dataGridViewTableTemplate.CellContentClick += dataGridViewTableTemplate_CellContentClick;
            dataGridViewTableTemplate.RowPostPaint += dataGridViewTableTemplate_RowPostPaint;
            dataGridViewTableTemplate.SelectionChanged += dataGridViewTableTemplate_SelectionChanged;
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
            // PathFile
            // 
            PathFile.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PathFile.DividerWidth = 1;
            PathFile.FillWeight = 150F;
            PathFile.HeaderText = "Шлях до файлу";
            PathFile.MinimumWidth = 8;
            PathFile.Name = "PathFile";
            PathFile.ReadOnly = true;
            // 
            // RemoveTemplate
            // 
            RemoveTemplate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            RemoveTemplate.FillWeight = 90F;
            RemoveTemplate.HeaderText = "Видалити";
            RemoveTemplate.Image = Properties.Resources.delete_doc;
            RemoveTemplate.ImageLayout = DataGridViewImageCellLayout.Zoom;
            RemoveTemplate.MinimumWidth = 8;
            RemoveTemplate.Name = "RemoveTemplate";
            RemoveTemplate.ReadOnly = true;
            RemoveTemplate.Width = 101;
            // 
            // tabPageGenerateDocument
            // 
            tabPageGenerateDocument.BackColor = Color.White;
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
            // groupBoxGenSetting
            // 
            groupBoxGenSetting.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxGenSetting.Controls.Add(materialTextBoxPathForSaveDocument);
            groupBoxGenSetting.Controls.Add(materialButtonGenerateDocument);
            groupBoxGenSetting.Controls.Add(materialLabelPathSaved);
            groupBoxGenSetting.Controls.Add(materialButtonSelectPathForSaved);
            groupBoxGenSetting.Controls.Add(materialLabelNameOutputDocument);
            groupBoxGenSetting.Controls.Add(materialTextBoxGenNameOutputDocument);
            groupBoxGenSetting.Controls.Add(ComboBoxGenCommandList);
            groupBoxGenSetting.Controls.Add(materialSwitchUseCommand);
            groupBoxGenSetting.Controls.Add(dataGridViewGenSettingBookmarks);
            groupBoxGenSetting.Location = new Point(6, 337);
            groupBoxGenSetting.Name = "groupBoxGenSetting";
            groupBoxGenSetting.Size = new Size(1245, 379);
            groupBoxGenSetting.TabIndex = 17;
            groupBoxGenSetting.TabStop = false;
            groupBoxGenSetting.Text = "Налаштування";
            // 
            // materialTextBoxPathForSaveDocument
            // 
            materialTextBoxPathForSaveDocument.AnimateReadOnly = false;
            materialTextBoxPathForSaveDocument.BorderStyle = BorderStyle.None;
            materialTextBoxPathForSaveDocument.Depth = 0;
            materialTextBoxPathForSaveDocument.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxPathForSaveDocument.LeadingIcon = null;
            materialTextBoxPathForSaveDocument.Location = new Point(798, 66);
            materialTextBoxPathForSaveDocument.MaxLength = 400;
            materialTextBoxPathForSaveDocument.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxPathForSaveDocument.Multiline = false;
            materialTextBoxPathForSaveDocument.Name = "materialTextBoxPathForSaveDocument";
            materialTextBoxPathForSaveDocument.ReadOnly = true;
            materialTextBoxPathForSaveDocument.ScrollBars = RichTextBoxScrollBars.None;
            materialTextBoxPathForSaveDocument.Size = new Size(441, 50);
            materialTextBoxPathForSaveDocument.TabIndex = 25;
            materialTextBoxPathForSaveDocument.Text = "";
            materialTextBoxPathForSaveDocument.TrailingIcon = null;
            // 
            // materialButtonGenerateDocument
            // 
            materialButtonGenerateDocument.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonGenerateDocument.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonGenerateDocument.Depth = 0;
            materialButtonGenerateDocument.HighEmphasis = true;
            materialButtonGenerateDocument.Icon = null;
            materialButtonGenerateDocument.Location = new Point(25, 125);
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
            // materialLabelPathSaved
            // 
            materialLabelPathSaved.AutoSize = true;
            materialLabelPathSaved.Depth = 0;
            materialLabelPathSaved.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelPathSaved.Location = new Point(819, 27);
            materialLabelPathSaved.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelPathSaved.Name = "materialLabelPathSaved";
            materialLabelPathSaved.Size = new Size(108, 19);
            materialLabelPathSaved.TabIndex = 24;
            materialLabelPathSaved.Text = "Куди зберегти";
            // 
            // materialButtonSelectPathForSaved
            // 
            materialButtonSelectPathForSaved.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonSelectPathForSaved.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonSelectPathForSaved.Depth = 0;
            materialButtonSelectPathForSaved.HighEmphasis = true;
            materialButtonSelectPathForSaved.Icon = null;
            materialButtonSelectPathForSaved.Location = new Point(1097, 125);
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
            // materialLabelNameOutputDocument
            // 
            materialLabelNameOutputDocument.AutoSize = true;
            materialLabelNameOutputDocument.Depth = 0;
            materialLabelNameOutputDocument.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelNameOutputDocument.Location = new Point(379, 39);
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
            materialTextBoxGenNameOutputDocument.Location = new Point(379, 68);
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
            materialTextBoxGenNameOutputDocument.Size = new Size(404, 48);
            materialTextBoxGenNameOutputDocument.TabIndex = 20;
            materialTextBoxGenNameOutputDocument.TabStop = false;
            materialTextBoxGenNameOutputDocument.Text = "OutputDocument.docx";
            materialTextBoxGenNameOutputDocument.TextAlign = HorizontalAlignment.Left;
            materialTextBoxGenNameOutputDocument.TrailingIcon = null;
            materialTextBoxGenNameOutputDocument.UseSystemPasswordChar = false;
            // 
            // ComboBoxGenCommandList
            // 
            ComboBoxGenCommandList.AutoResize = false;
            ComboBoxGenCommandList.BackColor = Color.FromArgb(255, 255, 255);
            ComboBoxGenCommandList.Depth = 0;
            ComboBoxGenCommandList.DrawMode = DrawMode.OwnerDrawVariable;
            ComboBoxGenCommandList.DropDownHeight = 174;
            ComboBoxGenCommandList.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxGenCommandList.DropDownWidth = 121;
            ComboBoxGenCommandList.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            ComboBoxGenCommandList.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ComboBoxGenCommandList.FormattingEnabled = true;
            ComboBoxGenCommandList.IntegralHeight = false;
            ComboBoxGenCommandList.ItemHeight = 43;
            ComboBoxGenCommandList.Location = new Point(25, 67);
            ComboBoxGenCommandList.MaxDropDownItems = 4;
            ComboBoxGenCommandList.MouseState = MaterialSkin.MouseState.OUT;
            ComboBoxGenCommandList.Name = "ComboBoxGenCommandList";
            ComboBoxGenCommandList.Size = new Size(334, 49);
            ComboBoxGenCommandList.StartIndex = 0;
            ComboBoxGenCommandList.TabIndex = 18;
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
            dataGridViewGenSettingBookmarks.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            dataGridViewGenSettingBookmarks.Location = new Point(6, 170);
            dataGridViewGenSettingBookmarks.MultiSelect = false;
            dataGridViewGenSettingBookmarks.Name = "dataGridViewGenSettingBookmarks";
            dataGridViewGenSettingBookmarks.RowHeadersVisible = false;
            dataGridViewGenSettingBookmarks.RowHeadersWidth = 25;
            dataGridViewGenSettingBookmarks.RowTemplate.Height = 25;
            dataGridViewGenSettingBookmarks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewGenSettingBookmarks.Size = new Size(1198, 287);
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
            groupBoxGenChoseTemplate.Controls.Add(materialTabControlGenSelectTemplate);
            groupBoxGenChoseTemplate.Controls.Add(materialTabSelectorGenSelectTemplate);
            groupBoxGenChoseTemplate.Location = new Point(6, 6);
            groupBoxGenChoseTemplate.Name = "groupBoxGenChoseTemplate";
            groupBoxGenChoseTemplate.Size = new Size(1261, 325);
            groupBoxGenChoseTemplate.TabIndex = 0;
            groupBoxGenChoseTemplate.TabStop = false;
            groupBoxGenChoseTemplate.Text = "Вибір шаблона";
            // 
            // materialTabControlGenSelectTemplate
            // 
            materialTabControlGenSelectTemplate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            materialTabControlGenSelectTemplate.Controls.Add(tabPageGenSaveTemplate);
            materialTabControlGenSelectTemplate.Controls.Add(tabPageGenLoadTemplate);
            materialTabControlGenSelectTemplate.Depth = 0;
            materialTabControlGenSelectTemplate.Location = new Point(22, 88);
            materialTabControlGenSelectTemplate.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControlGenSelectTemplate.Multiline = true;
            materialTabControlGenSelectTemplate.Name = "materialTabControlGenSelectTemplate";
            materialTabControlGenSelectTemplate.SelectedIndex = 0;
            materialTabControlGenSelectTemplate.Size = new Size(900, 219);
            materialTabControlGenSelectTemplate.TabIndex = 7;
            materialTabControlGenSelectTemplate.SelectedIndexChanged += materialTabControlGenSelectTemplate_SelectedIndexChanged;
            // 
            // tabPageGenSaveTemplate
            // 
            tabPageGenSaveTemplate.BackColor = Color.WhiteSmoke;
            tabPageGenSaveTemplate.BorderStyle = BorderStyle.FixedSingle;
            tabPageGenSaveTemplate.Controls.Add(ListBoxGenSavedTemplates);
            tabPageGenSaveTemplate.ForeColor = SystemColors.ControlText;
            tabPageGenSaveTemplate.Location = new Point(4, 34);
            tabPageGenSaveTemplate.Name = "tabPageGenSaveTemplate";
            tabPageGenSaveTemplate.Padding = new Padding(3);
            tabPageGenSaveTemplate.Size = new Size(892, 181);
            tabPageGenSaveTemplate.TabIndex = 0;
            tabPageGenSaveTemplate.Text = "Збережені шаблони";
            // 
            // ListBoxGenSavedTemplates
            // 
            ListBoxGenSavedTemplates.BackColor = Color.White;
            ListBoxGenSavedTemplates.BorderColor = Color.LightGray;
            ListBoxGenSavedTemplates.Depth = 0;
            ListBoxGenSavedTemplates.Dock = DockStyle.Fill;
            ListBoxGenSavedTemplates.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            ListBoxGenSavedTemplates.Location = new Point(3, 3);
            ListBoxGenSavedTemplates.MouseState = MaterialSkin.MouseState.HOVER;
            ListBoxGenSavedTemplates.Name = "ListBoxGenSavedTemplates";
            ListBoxGenSavedTemplates.SelectedIndex = -1;
            ListBoxGenSavedTemplates.SelectedItem = null;
            ListBoxGenSavedTemplates.Size = new Size(884, 173);
            ListBoxGenSavedTemplates.TabIndex = 3;
            ListBoxGenSavedTemplates.SelectedValueChanged += ListBoxGenSavedTemplates_SelectedValueChanged;
            // 
            // tabPageGenLoadTemplate
            // 
            tabPageGenLoadTemplate.BorderStyle = BorderStyle.FixedSingle;
            tabPageGenLoadTemplate.Location = new Point(4, 34);
            tabPageGenLoadTemplate.Name = "tabPageGenLoadTemplate";
            tabPageGenLoadTemplate.Padding = new Padding(3);
            tabPageGenLoadTemplate.Size = new Size(892, 181);
            tabPageGenLoadTemplate.TabIndex = 1;
            tabPageGenLoadTemplate.Text = "Завантажити шаблон";
            tabPageGenLoadTemplate.UseVisualStyleBackColor = true;
            // 
            // materialTabSelectorGenSelectTemplate
            // 
            materialTabSelectorGenSelectTemplate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            materialTabSelectorGenSelectTemplate.BaseTabControl = materialTabControlGenSelectTemplate;
            materialTabSelectorGenSelectTemplate.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            materialTabSelectorGenSelectTemplate.Depth = 0;
            materialTabSelectorGenSelectTemplate.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTabSelectorGenSelectTemplate.Location = new Point(23, 30);
            materialTabSelectorGenSelectTemplate.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabSelectorGenSelectTemplate.Name = "materialTabSelectorGenSelectTemplate";
            materialTabSelectorGenSelectTemplate.Size = new Size(900, 56);
            materialTabSelectorGenSelectTemplate.TabIndex = 6;
            materialTabSelectorGenSelectTemplate.Text = "materialTabSelector1";
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
            groupBoxCmdTable.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxCmdTable.Controls.Add(ButtonEditCommand);
            groupBoxCmdTable.Controls.Add(ButtonCreateCommand);
            groupBoxCmdTable.Controls.Add(dataGridViewTableCommand);
            groupBoxCmdTable.Location = new Point(17, 362);
            groupBoxCmdTable.Name = "groupBoxCmdTable";
            groupBoxCmdTable.Size = new Size(1238, 346);
            groupBoxCmdTable.TabIndex = 17;
            groupBoxCmdTable.TabStop = false;
            groupBoxCmdTable.Text = "Таблиця команд";
            // 
            // ButtonEditCommand
            // 
            ButtonEditCommand.AutoSize = false;
            ButtonEditCommand.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonEditCommand.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonEditCommand.Depth = 0;
            ButtonEditCommand.Enabled = false;
            ButtonEditCommand.HighEmphasis = true;
            ButtonEditCommand.Icon = (Image)resources.GetObject("ButtonEditCommand.Icon");
            ButtonEditCommand.Location = new Point(170, 42);
            ButtonEditCommand.Margin = new Padding(4, 6, 4, 6);
            ButtonEditCommand.MouseState = MaterialSkin.MouseState.HOVER;
            ButtonEditCommand.Name = "ButtonEditCommand";
            ButtonEditCommand.NoAccentTextColor = Color.Empty;
            ButtonEditCommand.Size = new Size(155, 47);
            ButtonEditCommand.TabIndex = 19;
            ButtonEditCommand.Text = "Редагувати";
            ButtonEditCommand.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            ButtonEditCommand.UseAccentColor = false;
            ButtonEditCommand.UseVisualStyleBackColor = true;
            // 
            // ButtonCreateCommand
            // 
            ButtonCreateCommand.AutoSize = false;
            ButtonCreateCommand.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonCreateCommand.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonCreateCommand.Depth = 0;
            ButtonCreateCommand.Enabled = false;
            ButtonCreateCommand.HighEmphasis = true;
            ButtonCreateCommand.Icon = (Image)resources.GetObject("ButtonCreateCommand.Icon");
            ButtonCreateCommand.Location = new Point(14, 42);
            ButtonCreateCommand.Margin = new Padding(4, 6, 4, 6);
            ButtonCreateCommand.MouseState = MaterialSkin.MouseState.HOVER;
            ButtonCreateCommand.Name = "ButtonCreateCommand";
            ButtonCreateCommand.NoAccentTextColor = Color.Empty;
            ButtonCreateCommand.Size = new Size(134, 47);
            ButtonCreateCommand.TabIndex = 18;
            ButtonCreateCommand.Text = "Створити";
            ButtonCreateCommand.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            ButtonCreateCommand.UseAccentColor = false;
            ButtonCreateCommand.UseVisualStyleBackColor = true;
            ButtonCreateCommand.Click += ButtonCreateCommand_Click;
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
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridViewTableCommand.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewTableCommand.ColumnHeadersHeight = 35;
            dataGridViewTableCommand.Columns.AddRange(new DataGridViewColumn[] { CmdNumberRowCommand, CommandName, CmdInputTemplate, CmdOutputTemplate, CmdDeleteCommand });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(100, 100, 180);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dataGridViewTableCommand.DefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewTableCommand.EnableHeadersVisualStyles = false;
            dataGridViewTableCommand.GridColor = Color.LightGray;
            dataGridViewTableCommand.Location = new Point(6, 107);
            dataGridViewTableCommand.MultiSelect = false;
            dataGridViewTableCommand.Name = "dataGridViewTableCommand";
            dataGridViewTableCommand.ReadOnly = true;
            dataGridViewTableCommand.RowHeadersVisible = false;
            dataGridViewTableCommand.RowHeadersWidth = 25;
            dataGridViewTableCommand.RowTemplate.Height = 25;
            dataGridViewTableCommand.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTableCommand.Size = new Size(1218, 233);
            dataGridViewTableCommand.TabIndex = 16;
            dataGridViewTableCommand.CellContentClick += dataGridViewTableCommand_CellContentClick;
            dataGridViewTableCommand.RowPostPaint += dataGridViewTableCommand_RowPostPaint;
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
            CmdDeleteCommand.ImageLayout = DataGridViewImageCellLayout.Zoom;
            CmdDeleteCommand.MinimumWidth = 8;
            CmdDeleteCommand.Name = "CmdDeleteCommand";
            CmdDeleteCommand.ReadOnly = true;
            CmdDeleteCommand.Width = 102;
            // 
            // groupBoxCmdSettingConvert
            // 
            groupBoxCmdSettingConvert.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxCmdSettingConvert.Controls.Add(dataGridViewCmdBookmarkMatch);
            groupBoxCmdSettingConvert.Location = new Point(474, 15);
            groupBoxCmdSettingConvert.Name = "groupBoxCmdSettingConvert";
            groupBoxCmdSettingConvert.Size = new Size(781, 334);
            groupBoxCmdSettingConvert.TabIndex = 5;
            groupBoxCmdSettingConvert.TabStop = false;
            groupBoxCmdSettingConvert.Text = "Параметри конвертування";
            // 
            // dataGridViewCmdBookmarkMatch
            // 
            dataGridViewCmdBookmarkMatch.AllowUserToAddRows = false;
            dataGridViewCmdBookmarkMatch.AllowUserToDeleteRows = false;
            dataGridViewCmdBookmarkMatch.AllowUserToResizeColumns = false;
            dataGridViewCmdBookmarkMatch.AllowUserToResizeRows = false;
            dataGridViewCmdBookmarkMatch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCmdBookmarkMatch.BackgroundColor = Color.White;
            dataGridViewCmdBookmarkMatch.BorderStyle = BorderStyle.None;
            dataGridViewCmdBookmarkMatch.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle10.SelectionForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dataGridViewCmdBookmarkMatch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCmdBookmarkMatch.ColumnHeadersHeight = 35;
            dataGridViewCmdBookmarkMatch.Columns.AddRange(new DataGridViewColumn[] { CmdNumberRow, CmdInputBookmark, CmdOutputBookmark });
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = Color.White;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle12.SelectionForeColor = Color.FromArgb(100, 100, 180);
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dataGridViewCmdBookmarkMatch.DefaultCellStyle = dataGridViewCellStyle12;
            dataGridViewCmdBookmarkMatch.EnableHeadersVisualStyles = false;
            dataGridViewCmdBookmarkMatch.GridColor = Color.LightGray;
            dataGridViewCmdBookmarkMatch.Location = new Point(20, 30);
            dataGridViewCmdBookmarkMatch.MultiSelect = false;
            dataGridViewCmdBookmarkMatch.Name = "dataGridViewCmdBookmarkMatch";
            dataGridViewCmdBookmarkMatch.RowHeadersVisible = false;
            dataGridViewCmdBookmarkMatch.RowHeadersWidth = 25;
            dataGridViewCmdBookmarkMatch.RowTemplate.Height = 25;
            dataGridViewCmdBookmarkMatch.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCmdBookmarkMatch.Size = new Size(755, 285);
            dataGridViewCmdBookmarkMatch.TabIndex = 15;
            dataGridViewCmdBookmarkMatch.RowPostPaint += dataGridViewCmdBookmarkMatch_RowPostPaint;
            // 
            // CmdNumberRow
            // 
            CmdNumberRow.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CmdNumberRow.HeaderText = "Номер";
            CmdNumberRow.MinimumWidth = 8;
            CmdNumberRow.Name = "CmdNumberRow";
            CmdNumberRow.ReadOnly = true;
            CmdNumberRow.Width = 107;
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
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(192, 192, 255);
            CmdOutputBookmark.DefaultCellStyle = dataGridViewCellStyle11;
            CmdOutputBookmark.FlatStyle = FlatStyle.Flat;
            CmdOutputBookmark.HeaderText = "Вихідна закладка";
            CmdOutputBookmark.MinimumWidth = 8;
            CmdOutputBookmark.Name = "CmdOutputBookmark";
            // 
            // groupBoxSettingCommand
            // 
            groupBoxSettingCommand.Controls.Add(ButtonCmdViewBookmark);
            groupBoxSettingCommand.Controls.Add(LabelCmdInputDocument);
            groupBoxSettingCommand.Controls.Add(TextBoxCmdInputDocument);
            groupBoxSettingCommand.Controls.Add(TextBoxCmdCommandName);
            groupBoxSettingCommand.Controls.Add(ComboBoxCmdOutputTemplate);
            groupBoxSettingCommand.Location = new Point(19, 15);
            groupBoxSettingCommand.Name = "groupBoxSettingCommand";
            groupBoxSettingCommand.Size = new Size(439, 334);
            groupBoxSettingCommand.TabIndex = 4;
            groupBoxSettingCommand.TabStop = false;
            groupBoxSettingCommand.Text = "Налаштування команди";
            // 
            // ButtonCmdViewBookmark
            // 
            ButtonCmdViewBookmark.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonCmdViewBookmark.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonCmdViewBookmark.Depth = 0;
            ButtonCmdViewBookmark.HighEmphasis = true;
            ButtonCmdViewBookmark.Icon = null;
            ButtonCmdViewBookmark.Location = new Point(24, 279);
            ButtonCmdViewBookmark.Margin = new Padding(4, 6, 4, 6);
            ButtonCmdViewBookmark.MouseState = MaterialSkin.MouseState.HOVER;
            ButtonCmdViewBookmark.Name = "ButtonCmdViewBookmark";
            ButtonCmdViewBookmark.NoAccentTextColor = Color.Empty;
            ButtonCmdViewBookmark.Size = new Size(182, 36);
            ButtonCmdViewBookmark.TabIndex = 7;
            ButtonCmdViewBookmark.Text = "Показати закладки";
            ButtonCmdViewBookmark.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonCmdViewBookmark.UseAccentColor = false;
            ButtonCmdViewBookmark.UseVisualStyleBackColor = true;
            ButtonCmdViewBookmark.Click += ButtonCmdViewBookmark_Click;
            // 
            // LabelCmdInputDocument
            // 
            LabelCmdInputDocument.AutoSize = true;
            LabelCmdInputDocument.Depth = 0;
            LabelCmdInputDocument.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelCmdInputDocument.ForeColor = Color.Black;
            LabelCmdInputDocument.Location = new Point(24, 115);
            LabelCmdInputDocument.MouseState = MaterialSkin.MouseState.HOVER;
            LabelCmdInputDocument.Name = "LabelCmdInputDocument";
            LabelCmdInputDocument.Size = new Size(136, 19);
            LabelCmdInputDocument.TabIndex = 6;
            LabelCmdInputDocument.Text = "вхідний документ";
            // 
            // TextBoxCmdInputDocument
            // 
            TextBoxCmdInputDocument.AnimateReadOnly = false;
            TextBoxCmdInputDocument.BorderStyle = BorderStyle.None;
            TextBoxCmdInputDocument.Depth = 0;
            TextBoxCmdInputDocument.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextBoxCmdInputDocument.LeadingIcon = null;
            TextBoxCmdInputDocument.Location = new Point(24, 137);
            TextBoxCmdInputDocument.MaxLength = 50;
            TextBoxCmdInputDocument.MouseState = MaterialSkin.MouseState.OUT;
            TextBoxCmdInputDocument.Multiline = false;
            TextBoxCmdInputDocument.Name = "TextBoxCmdInputDocument";
            TextBoxCmdInputDocument.ReadOnly = true;
            TextBoxCmdInputDocument.Size = new Size(365, 50);
            TextBoxCmdInputDocument.TabIndex = 5;
            TextBoxCmdInputDocument.Text = "";
            TextBoxCmdInputDocument.TrailingIcon = Properties.Resources.upload_big_arrow;
            TextBoxCmdInputDocument.TrailingIconClick += TextBoxCmdInputDocument_TrailingIconClick;
            // 
            // TextBoxCmdCommandName
            // 
            TextBoxCmdCommandName.AnimateReadOnly = false;
            TextBoxCmdCommandName.BackgroundImageLayout = ImageLayout.None;
            TextBoxCmdCommandName.CharacterCasing = CharacterCasing.Normal;
            TextBoxCmdCommandName.Depth = 0;
            TextBoxCmdCommandName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextBoxCmdCommandName.HideSelection = true;
            TextBoxCmdCommandName.Hint = "назва команди";
            TextBoxCmdCommandName.LeadingIcon = null;
            TextBoxCmdCommandName.Location = new Point(24, 43);
            TextBoxCmdCommandName.MaxLength = 300;
            TextBoxCmdCommandName.MouseState = MaterialSkin.MouseState.OUT;
            TextBoxCmdCommandName.Name = "TextBoxCmdCommandName";
            TextBoxCmdCommandName.PasswordChar = '\0';
            TextBoxCmdCommandName.PrefixSuffixText = null;
            TextBoxCmdCommandName.ReadOnly = false;
            TextBoxCmdCommandName.RightToLeft = RightToLeft.No;
            TextBoxCmdCommandName.SelectedText = "";
            TextBoxCmdCommandName.SelectionLength = 0;
            TextBoxCmdCommandName.SelectionStart = 0;
            TextBoxCmdCommandName.ShortcutsEnabled = true;
            TextBoxCmdCommandName.Size = new Size(365, 48);
            TextBoxCmdCommandName.TabIndex = 1;
            TextBoxCmdCommandName.TabStop = false;
            TextBoxCmdCommandName.TextAlign = HorizontalAlignment.Left;
            TextBoxCmdCommandName.TrailingIcon = null;
            TextBoxCmdCommandName.UseSystemPasswordChar = false;
            // 
            // ComboBoxCmdOutputTemplate
            // 
            ComboBoxCmdOutputTemplate.AutoResize = false;
            ComboBoxCmdOutputTemplate.BackColor = Color.FromArgb(255, 255, 255);
            ComboBoxCmdOutputTemplate.Depth = 0;
            ComboBoxCmdOutputTemplate.DrawMode = DrawMode.OwnerDrawVariable;
            ComboBoxCmdOutputTemplate.DropDownHeight = 174;
            ComboBoxCmdOutputTemplate.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxCmdOutputTemplate.DropDownWidth = 121;
            ComboBoxCmdOutputTemplate.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            ComboBoxCmdOutputTemplate.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ComboBoxCmdOutputTemplate.FormattingEnabled = true;
            ComboBoxCmdOutputTemplate.Hint = "вихідний шаблон";
            ComboBoxCmdOutputTemplate.IntegralHeight = false;
            ComboBoxCmdOutputTemplate.ItemHeight = 43;
            ComboBoxCmdOutputTemplate.Location = new Point(24, 209);
            ComboBoxCmdOutputTemplate.MaxDropDownItems = 4;
            ComboBoxCmdOutputTemplate.MouseState = MaterialSkin.MouseState.OUT;
            ComboBoxCmdOutputTemplate.Name = "ComboBoxCmdOutputTemplate";
            ComboBoxCmdOutputTemplate.Size = new Size(365, 49);
            ComboBoxCmdOutputTemplate.StartIndex = 0;
            ComboBoxCmdOutputTemplate.TabIndex = 3;
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
            Controls.Add(materialTabControlMainMenu);
            DrawerTabControl = materialTabControlMainMenu;
            HelpButton = true;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Document Generator";
            WindowState = FormWindowState.Maximized;
            materialTabControlMainMenu.ResumeLayout(false);
            tabPageTemplate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTableBookmarks).EndInit();
            tableLayoutPanelTools.ResumeLayout(false);
            tableLayoutPanelTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTableTemplate).EndInit();
            tabPageGenerateDocument.ResumeLayout(false);
            groupBoxGenSetting.ResumeLayout(false);
            groupBoxGenSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGenSettingBookmarks).EndInit();
            groupBoxGenChoseTemplate.ResumeLayout(false);
            materialTabControlGenSelectTemplate.ResumeLayout(false);
            tabPageGenSaveTemplate.ResumeLayout(false);
            tabPageCommand.ResumeLayout(false);
            groupBoxCmdTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTableCommand).EndInit();
            groupBoxCmdSettingConvert.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCmdBookmarkMatch).EndInit();
            groupBoxSettingCommand.ResumeLayout(false);
            groupBoxSettingCommand.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControlMainMenu;
        private TabPage tabPageTemplate;
        private TabPage tabPageCommand;
        private ImageList imageListMenu;
        private TabPage tabPageGenerateDocument;
        private DataGridView dataGridViewTableTemplate;
        private TableLayoutPanel tableLayoutPanelTools;
        private MaterialSkin.Controls.MaterialButton ButtonAddTemplate;
        private MaterialSkin.Controls.MaterialButton ButtonEditTemplate;
        private MaterialSkin.Controls.MaterialButton ButtonReadTemplate;
        private DataGridView dataGridViewTableBookmarks;
        private MaterialSkin.Controls.MaterialTextBox TextBoxSearchTemplate;
        private DataGridViewTextBoxColumn ColumnNumber;
        private DataGridViewTextBoxColumn ColumnBookmarkName;
        private DataGridViewTextBoxColumn TypeBookmark;
        private MaterialSkin.Controls.MaterialTextBox2 TextBoxCmdCommandName;
        private MaterialSkin.Controls.MaterialComboBox ComboBoxCmdOutputTemplate;
        private GroupBox groupBoxSettingCommand;
        private GroupBox groupBoxCmdSettingConvert;
        private DataGridView dataGridViewCmdBookmarkMatch;
        private DataGridView dataGridViewTableCommand;
        private GroupBox groupBoxCmdTable;
        private DataGridView dataGridViewGenSettingBookmarks;
        private GroupBox groupBoxGenSetting;
        private MaterialSkin.Controls.MaterialSwitch materialSwitchUseCommand;
        private MaterialSkin.Controls.MaterialComboBox ComboBoxGenCommandList;
        private DataGridViewTextBoxColumn GenNumberRows;
        private DataGridViewTextBoxColumn GenNameBookmark;
        private DataGridViewComboBoxColumn GenDataType;
        private DataGridViewImageColumn GenEnterData;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxGenNameOutputDocument;
        private MaterialSkin.Controls.MaterialLabel materialLabelNameOutputDocument;
        private MaterialSkin.Controls.MaterialButton materialButtonSelectPathForSaved;
        private MaterialSkin.Controls.MaterialLabel materialLabelPathSaved;
        private MaterialSkin.Controls.MaterialButton materialButtonGenerateDocument;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxPathForSaveDocument;
        private MaterialSkin.Controls.MaterialButton ButtonCreateCommand;
        private GroupBox groupBoxGenChoseTemplate;
        private MaterialSkin.Controls.MaterialTabControl materialTabControlGenSelectTemplate;
        private TabPage tabPageGenSaveTemplate;
        private MaterialSkin.Controls.MaterialListBox ListBoxGenSavedTemplates;
        private TabPage tabPageGenLoadTemplate;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelectorGenSelectTemplate;
        private MaterialSkin.Controls.MaterialTextBox TextBoxCmdInputDocument;
        private MaterialSkin.Controls.MaterialLabel LabelCmdInputDocument;
        private MaterialSkin.Controls.MaterialButton ButtonCmdViewBookmark;
        private DataGridViewTextBoxColumn CmdNumberRow;
        private DataGridViewTextBoxColumn CmdInputBookmark;
        private DataGridViewComboBoxColumn CmdOutputBookmark;
        private DataGridViewTextBoxColumn CmdNumberRowCommand;
        private DataGridViewTextBoxColumn CommandName;
        private DataGridViewTextBoxColumn CmdInputTemplate;
        private DataGridViewTextBoxColumn CmdOutputTemplate;
        private DataGridViewImageColumn CmdDeleteCommand;
        private MaterialSkin.Controls.MaterialButton ButtonEditCommand;
        private DataGridViewTextBoxColumn NumberRows;
        private DataGridViewTextBoxColumn NameFile;
        private DataGridViewTextBoxColumn PathFile;
        private DataGridViewImageColumn RemoveTemplate;
    }
}