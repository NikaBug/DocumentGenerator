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
            DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle25 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle27 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle26 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            materialTabControl = new MaterialSkin.Controls.MaterialTabControl();
            tabPageTemplate = new TabPage();
            materialButtonUpdateTemplate = new MaterialSkin.Controls.MaterialButton();
            materialButtonReadTemlate = new MaterialSkin.Controls.MaterialButton();
            materialLabelPathFile = new MaterialSkin.Controls.MaterialLabel();
            materialTextBoxPathFile = new MaterialSkin.Controls.MaterialTextBox();
            materialLabelListTemplate = new MaterialSkin.Controls.MaterialLabel();
            materialListViewTemplate = new MaterialSkin.Controls.MaterialListView();
            materialButtonRemoveTemplate = new MaterialSkin.Controls.MaterialButton();
            materialButtonLoadTemplate = new MaterialSkin.Controls.MaterialButton();
            tabPageGenerateDocument = new TabPage();
            materialComboBoxCommandsSelect = new MaterialSkin.Controls.MaterialComboBox();
            materialSwitchUseCommand = new MaterialSkin.Controls.MaterialSwitch();
            materialButtonDownloadDocument = new MaterialSkin.Controls.MaterialButton();
            dataGridViewBookmarks = new DataGridView();
            Bookmark = new DataGridViewTextBoxColumn();
            TypeData = new DataGridViewComboBoxColumn();
            EnterData = new DataGridViewTextBoxColumn();
            materialButtonGenerateDocument = new MaterialSkin.Controls.MaterialButton();
            panelUploadTemplate = new Panel();
            materialLabelUploadTmp = new MaterialSkin.Controls.MaterialLabel();
            materialListBoxUploadTmp = new MaterialSkin.Controls.MaterialListBox();
            materialButtonUploadTemplateGen = new MaterialSkin.Controls.MaterialButton();
            panelSavedTemplate = new Panel();
            materialLabelSavedTmp = new MaterialSkin.Controls.MaterialLabel();
            materialComboBoxSavedTmp = new MaterialSkin.Controls.MaterialComboBox();
            materialRadioButtonIUploadTmp = new MaterialSkin.Controls.MaterialRadioButton();
            materialRadioButtonSaveTmp = new MaterialSkin.Controls.MaterialRadioButton();
            tabPageCommand = new TabPage();
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
            materialButtonUpdCommand = new MaterialSkin.Controls.MaterialButton();
            materialButtonDeleteCommand = new MaterialSkin.Controls.MaterialButton();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            materialComboBoxCmdList = new MaterialSkin.Controls.MaterialComboBox();
            materialTabControl.SuspendLayout();
            tabPageTemplate.SuspendLayout();
            tabPageGenerateDocument.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBookmarks).BeginInit();
            panelUploadTemplate.SuspendLayout();
            panelSavedTemplate.SuspendLayout();
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
            materialTabControl.Size = new Size(953, 723);
            materialTabControl.TabIndex = 0;
            // 
            // tabPageTemplate
            // 
            tabPageTemplate.BackColor = Color.WhiteSmoke;
            tabPageTemplate.Controls.Add(materialButtonUpdateTemplate);
            tabPageTemplate.Controls.Add(materialButtonReadTemlate);
            tabPageTemplate.Controls.Add(materialLabelPathFile);
            tabPageTemplate.Controls.Add(materialTextBoxPathFile);
            tabPageTemplate.Controls.Add(materialLabelListTemplate);
            tabPageTemplate.Controls.Add(materialListViewTemplate);
            tabPageTemplate.Controls.Add(materialButtonRemoveTemplate);
            tabPageTemplate.Controls.Add(materialButtonLoadTemplate);
            tabPageTemplate.ImageKey = "template.png";
            tabPageTemplate.Location = new Point(4, 39);
            tabPageTemplate.Name = "tabPageTemplate";
            tabPageTemplate.Padding = new Padding(3);
            tabPageTemplate.Size = new Size(945, 680);
            tabPageTemplate.TabIndex = 0;
            tabPageTemplate.Text = "Шаблони";
            // 
            // materialButtonUpdateTemplate
            // 
            materialButtonUpdateTemplate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonUpdateTemplate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonUpdateTemplate.Depth = 0;
            materialButtonUpdateTemplate.HighEmphasis = true;
            materialButtonUpdateTemplate.Icon = Properties.Resources.file_upd;
            materialButtonUpdateTemplate.Location = new Point(684, 299);
            materialButtonUpdateTemplate.Margin = new Padding(4, 6, 4, 6);
            materialButtonUpdateTemplate.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonUpdateTemplate.Name = "materialButtonUpdateTemplate";
            materialButtonUpdateTemplate.NoAccentTextColor = Color.Empty;
            materialButtonUpdateTemplate.Size = new Size(187, 36);
            materialButtonUpdateTemplate.TabIndex = 7;
            materialButtonUpdateTemplate.Text = "Оновити шаблон";
            materialButtonUpdateTemplate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonUpdateTemplate.UseAccentColor = false;
            materialButtonUpdateTemplate.UseVisualStyleBackColor = true;
            // 
            // materialButtonReadTemlate
            // 
            materialButtonReadTemlate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonReadTemlate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonReadTemlate.Depth = 0;
            materialButtonReadTemlate.HighEmphasis = true;
            materialButtonReadTemlate.Icon = Properties.Resources.file_view;
            materialButtonReadTemlate.Location = new Point(267, 299);
            materialButtonReadTemlate.Margin = new Padding(4, 6, 4, 6);
            materialButtonReadTemlate.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonReadTemlate.Name = "materialButtonReadTemlate";
            materialButtonReadTemlate.NoAccentTextColor = Color.Empty;
            materialButtonReadTemlate.Size = new Size(176, 36);
            materialButtonReadTemlate.TabIndex = 6;
            materialButtonReadTemlate.Text = "Читати шаблон";
            materialButtonReadTemlate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonReadTemlate.UseAccentColor = false;
            materialButtonReadTemlate.UseVisualStyleBackColor = true;
            // 
            // materialLabelPathFile
            // 
            materialLabelPathFile.AutoSize = true;
            materialLabelPathFile.Depth = 0;
            materialLabelPathFile.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelPathFile.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            materialLabelPathFile.Location = new Point(84, 73);
            materialLabelPathFile.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelPathFile.Name = "materialLabelPathFile";
            materialLabelPathFile.Size = new Size(42, 19);
            materialLabelPathFile.TabIndex = 5;
            materialLabelPathFile.Text = "Шлях";
            // 
            // materialTextBoxPathFile
            // 
            materialTextBoxPathFile.AnimateReadOnly = false;
            materialTextBoxPathFile.BorderStyle = BorderStyle.None;
            materialTextBoxPathFile.Depth = 0;
            materialTextBoxPathFile.Enabled = false;
            materialTextBoxPathFile.Font = new Font("Roboto", 8F, FontStyle.Regular, GraphicsUnit.Point);
            materialTextBoxPathFile.HideSelection = false;
            materialTextBoxPathFile.LeadingIcon = null;
            materialTextBoxPathFile.Location = new Point(141, 56);
            materialTextBoxPathFile.MaxLength = 300;
            materialTextBoxPathFile.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxPathFile.Multiline = false;
            materialTextBoxPathFile.Name = "materialTextBoxPathFile";
            materialTextBoxPathFile.ReadOnly = true;
            materialTextBoxPathFile.Size = new Size(456, 50);
            materialTextBoxPathFile.TabIndex = 4;
            materialTextBoxPathFile.Text = "Шлях до файлу";
            materialTextBoxPathFile.TrailingIcon = null;
            // 
            // materialLabelListTemplate
            // 
            materialLabelListTemplate.AutoSize = true;
            materialLabelListTemplate.Depth = 0;
            materialLabelListTemplate.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabelListTemplate.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabelListTemplate.Location = new Point(224, 20);
            materialLabelListTemplate.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelListTemplate.Name = "materialLabelListTemplate";
            materialLabelListTemplate.Size = new Size(300, 24);
            materialLabelListTemplate.TabIndex = 3;
            materialLabelListTemplate.Text = "Список завантажених шаблонів";
            // 
            // materialListViewTemplate
            // 
            materialListViewTemplate.AutoSizeTable = false;
            materialListViewTemplate.BackColor = Color.FromArgb(255, 255, 255);
            materialListViewTemplate.BorderStyle = BorderStyle.None;
            materialListViewTemplate.Depth = 0;
            materialListViewTemplate.FullRowSelect = true;
            materialListViewTemplate.Location = new Point(23, 112);
            materialListViewTemplate.MinimumSize = new Size(200, 100);
            materialListViewTemplate.MouseLocation = new Point(-1, -1);
            materialListViewTemplate.MouseState = MaterialSkin.MouseState.OUT;
            materialListViewTemplate.Name = "materialListViewTemplate";
            materialListViewTemplate.OwnerDraw = true;
            materialListViewTemplate.Size = new Size(781, 178);
            materialListViewTemplate.TabIndex = 2;
            materialListViewTemplate.UseCompatibleStateImageBehavior = false;
            materialListViewTemplate.View = View.Details;
            // 
            // materialButtonRemoveTemplate
            // 
            materialButtonRemoveTemplate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonRemoveTemplate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonRemoveTemplate.Depth = 0;
            materialButtonRemoveTemplate.HighEmphasis = true;
            materialButtonRemoveTemplate.Icon = Properties.Resources.delete_doc;
            materialButtonRemoveTemplate.Location = new Point(463, 299);
            materialButtonRemoveTemplate.Margin = new Padding(4, 6, 4, 6);
            materialButtonRemoveTemplate.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonRemoveTemplate.Name = "materialButtonRemoveTemplate";
            materialButtonRemoveTemplate.NoAccentTextColor = Color.Empty;
            materialButtonRemoveTemplate.Size = new Size(198, 36);
            materialButtonRemoveTemplate.TabIndex = 1;
            materialButtonRemoveTemplate.Text = "Видалити шаблон";
            materialButtonRemoveTemplate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonRemoveTemplate.UseAccentColor = false;
            materialButtonRemoveTemplate.UseVisualStyleBackColor = true;
            // 
            // materialButtonLoadTemplate
            // 
            materialButtonLoadTemplate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonLoadTemplate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonLoadTemplate.Depth = 0;
            materialButtonLoadTemplate.HighEmphasis = true;
            materialButtonLoadTemplate.Icon = Properties.Resources.file;
            materialButtonLoadTemplate.Location = new Point(15, 299);
            materialButtonLoadTemplate.Margin = new Padding(4, 6, 4, 6);
            materialButtonLoadTemplate.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonLoadTemplate.Name = "materialButtonLoadTemplate";
            materialButtonLoadTemplate.NoAccentTextColor = Color.Empty;
            materialButtonLoadTemplate.Size = new Size(227, 36);
            materialButtonLoadTemplate.TabIndex = 0;
            materialButtonLoadTemplate.Text = "Завантажити шаблон";
            materialButtonLoadTemplate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonLoadTemplate.UseAccentColor = false;
            materialButtonLoadTemplate.UseVisualStyleBackColor = true;
            // 
            // tabPageGenerateDocument
            // 
            tabPageGenerateDocument.BackColor = Color.White;
            tabPageGenerateDocument.Controls.Add(materialComboBoxCommandsSelect);
            tabPageGenerateDocument.Controls.Add(materialSwitchUseCommand);
            tabPageGenerateDocument.Controls.Add(materialButtonDownloadDocument);
            tabPageGenerateDocument.Controls.Add(dataGridViewBookmarks);
            tabPageGenerateDocument.Controls.Add(materialButtonGenerateDocument);
            tabPageGenerateDocument.Controls.Add(panelUploadTemplate);
            tabPageGenerateDocument.Controls.Add(panelSavedTemplate);
            tabPageGenerateDocument.Controls.Add(materialRadioButtonIUploadTmp);
            tabPageGenerateDocument.Controls.Add(materialRadioButtonSaveTmp);
            tabPageGenerateDocument.ImageKey = "writing.png";
            tabPageGenerateDocument.Location = new Point(4, 39);
            tabPageGenerateDocument.Name = "tabPageGenerateDocument";
            tabPageGenerateDocument.Padding = new Padding(3);
            tabPageGenerateDocument.Size = new Size(945, 680);
            tabPageGenerateDocument.TabIndex = 1;
            tabPageGenerateDocument.Text = "Генератор";
            // 
            // materialComboBoxCommandsSelect
            // 
            materialComboBoxCommandsSelect.AutoResize = false;
            materialComboBoxCommandsSelect.BackColor = Color.FromArgb(255, 255, 255);
            materialComboBoxCommandsSelect.Depth = 0;
            materialComboBoxCommandsSelect.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBoxCommandsSelect.DropDownHeight = 174;
            materialComboBoxCommandsSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBoxCommandsSelect.DropDownWidth = 121;
            materialComboBoxCommandsSelect.Enabled = false;
            materialComboBoxCommandsSelect.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBoxCommandsSelect.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBoxCommandsSelect.FormattingEnabled = true;
            materialComboBoxCommandsSelect.IntegralHeight = false;
            materialComboBoxCommandsSelect.ItemHeight = 43;
            materialComboBoxCommandsSelect.Location = new Point(27, 241);
            materialComboBoxCommandsSelect.MaxDropDownItems = 4;
            materialComboBoxCommandsSelect.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBoxCommandsSelect.Name = "materialComboBoxCommandsSelect";
            materialComboBoxCommandsSelect.Size = new Size(197, 49);
            materialComboBoxCommandsSelect.StartIndex = 0;
            materialComboBoxCommandsSelect.TabIndex = 10;
            // 
            // materialSwitchUseCommand
            // 
            materialSwitchUseCommand.AutoSize = true;
            materialSwitchUseCommand.Depth = 0;
            materialSwitchUseCommand.Location = new Point(20, 201);
            materialSwitchUseCommand.Margin = new Padding(0);
            materialSwitchUseCommand.MouseLocation = new Point(-1, -1);
            materialSwitchUseCommand.MouseState = MaterialSkin.MouseState.HOVER;
            materialSwitchUseCommand.Name = "materialSwitchUseCommand";
            materialSwitchUseCommand.Ripple = true;
            materialSwitchUseCommand.Size = new Size(225, 37);
            materialSwitchUseCommand.TabIndex = 9;
            materialSwitchUseCommand.Text = "Використати команду";
            materialSwitchUseCommand.UseVisualStyleBackColor = true;
            materialSwitchUseCommand.CheckedChanged += materialSwitchUseCommand_CheckedChanged;
            // 
            // materialButtonDownloadDocument
            // 
            materialButtonDownloadDocument.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonDownloadDocument.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonDownloadDocument.Depth = 0;
            materialButtonDownloadDocument.HighEmphasis = true;
            materialButtonDownloadDocument.Icon = null;
            materialButtonDownloadDocument.Location = new Point(294, 574);
            materialButtonDownloadDocument.Margin = new Padding(4, 6, 4, 6);
            materialButtonDownloadDocument.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonDownloadDocument.Name = "materialButtonDownloadDocument";
            materialButtonDownloadDocument.NoAccentTextColor = Color.Empty;
            materialButtonDownloadDocument.Size = new Size(220, 36);
            materialButtonDownloadDocument.TabIndex = 8;
            materialButtonDownloadDocument.Text = "Завантажити \r\nсформований документ";
            materialButtonDownloadDocument.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonDownloadDocument.UseAccentColor = false;
            materialButtonDownloadDocument.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBookmarks
            // 
            dataGridViewCellStyle24.BackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle24.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle24.ForeColor = Color.Black;
            dataGridViewCellStyle24.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle24.SelectionForeColor = Color.Black;
            dataGridViewBookmarks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle24;
            dataGridViewBookmarks.BackgroundColor = Color.Gainsboro;
            dataGridViewBookmarks.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle25.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = Color.MediumPurple;
            dataGridViewCellStyle25.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle25.ForeColor = SystemColors.Window;
            dataGridViewCellStyle25.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = DataGridViewTriState.True;
            dataGridViewBookmarks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            dataGridViewBookmarks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBookmarks.Columns.AddRange(new DataGridViewColumn[] { Bookmark, TypeData, EnterData });
            dataGridViewCellStyle27.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle27.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle27.ForeColor = Color.Black;
            dataGridViewCellStyle27.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle27.SelectionForeColor = Color.Black;
            dataGridViewCellStyle27.WrapMode = DataGridViewTriState.False;
            dataGridViewBookmarks.DefaultCellStyle = dataGridViewCellStyle27;
            dataGridViewBookmarks.EnableHeadersVisualStyles = false;
            dataGridViewBookmarks.Location = new Point(27, 309);
            dataGridViewBookmarks.Name = "dataGridViewBookmarks";
            dataGridViewBookmarks.RowHeadersVisible = false;
            dataGridViewBookmarks.RowHeadersWidth = 62;
            dataGridViewBookmarks.RowTemplate.Height = 33;
            dataGridViewBookmarks.Size = new Size(781, 225);
            dataGridViewBookmarks.TabIndex = 7;
            // 
            // Bookmark
            // 
            Bookmark.HeaderText = "Закладка";
            Bookmark.MinimumWidth = 8;
            Bookmark.Name = "Bookmark";
            Bookmark.ReadOnly = true;
            Bookmark.Width = 150;
            // 
            // TypeData
            // 
            dataGridViewCellStyle26.BackColor = Color.MediumSlateBlue;
            dataGridViewCellStyle26.ForeColor = Color.Black;
            dataGridViewCellStyle26.SelectionBackColor = Color.MediumSlateBlue;
            dataGridViewCellStyle26.SelectionForeColor = Color.Black;
            TypeData.DefaultCellStyle = dataGridViewCellStyle26;
            TypeData.FlatStyle = FlatStyle.Flat;
            TypeData.HeaderText = "Тип даних";
            TypeData.MinimumWidth = 8;
            TypeData.Name = "TypeData";
            TypeData.Width = 150;
            // 
            // EnterData
            // 
            EnterData.HeaderText = "Дані";
            EnterData.MinimumWidth = 8;
            EnterData.Name = "EnterData";
            EnterData.Width = 150;
            // 
            // materialButtonGenerateDocument
            // 
            materialButtonGenerateDocument.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonGenerateDocument.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonGenerateDocument.Depth = 0;
            materialButtonGenerateDocument.HighEmphasis = true;
            materialButtonGenerateDocument.Icon = null;
            materialButtonGenerateDocument.Location = new Point(49, 574);
            materialButtonGenerateDocument.Margin = new Padding(4, 6, 4, 6);
            materialButtonGenerateDocument.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonGenerateDocument.Name = "materialButtonGenerateDocument";
            materialButtonGenerateDocument.NoAccentTextColor = Color.Empty;
            materialButtonGenerateDocument.Size = new Size(207, 36);
            materialButtonGenerateDocument.TabIndex = 5;
            materialButtonGenerateDocument.Text = "Сформувати документ";
            materialButtonGenerateDocument.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonGenerateDocument.UseAccentColor = false;
            materialButtonGenerateDocument.UseVisualStyleBackColor = true;
            // 
            // panelUploadTemplate
            // 
            panelUploadTemplate.BorderStyle = BorderStyle.FixedSingle;
            panelUploadTemplate.Controls.Add(materialLabelUploadTmp);
            panelUploadTemplate.Controls.Add(materialListBoxUploadTmp);
            panelUploadTemplate.Controls.Add(materialButtonUploadTemplateGen);
            panelUploadTemplate.Location = new Point(406, 53);
            panelUploadTemplate.Name = "panelUploadTemplate";
            panelUploadTemplate.Size = new Size(481, 159);
            panelUploadTemplate.TabIndex = 3;
            // 
            // materialLabelUploadTmp
            // 
            materialLabelUploadTmp.AutoSize = true;
            materialLabelUploadTmp.Depth = 0;
            materialLabelUploadTmp.Enabled = false;
            materialLabelUploadTmp.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelUploadTmp.Location = new Point(190, 10);
            materialLabelUploadTmp.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelUploadTmp.Name = "materialLabelUploadTmp";
            materialLabelUploadTmp.Size = new Size(166, 19);
            materialLabelUploadTmp.TabIndex = 2;
            materialLabelUploadTmp.Text = "завантажені шаблони";
            // 
            // materialListBoxUploadTmp
            // 
            materialListBoxUploadTmp.BackColor = Color.White;
            materialListBoxUploadTmp.BorderColor = Color.LightGray;
            materialListBoxUploadTmp.Depth = 0;
            materialListBoxUploadTmp.Enabled = false;
            materialListBoxUploadTmp.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialListBoxUploadTmp.Location = new Point(153, 32);
            materialListBoxUploadTmp.MouseState = MaterialSkin.MouseState.HOVER;
            materialListBoxUploadTmp.Name = "materialListBoxUploadTmp";
            materialListBoxUploadTmp.SelectedIndex = -1;
            materialListBoxUploadTmp.SelectedItem = null;
            materialListBoxUploadTmp.Size = new Size(308, 97);
            materialListBoxUploadTmp.TabIndex = 1;
            // 
            // materialButtonUploadTemplateGen
            // 
            materialButtonUploadTemplateGen.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonUploadTemplateGen.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonUploadTemplateGen.Depth = 0;
            materialButtonUploadTemplateGen.Enabled = false;
            materialButtonUploadTemplateGen.HighEmphasis = true;
            materialButtonUploadTemplateGen.Icon = null;
            materialButtonUploadTemplateGen.Location = new Point(15, 78);
            materialButtonUploadTemplateGen.Margin = new Padding(4, 6, 4, 6);
            materialButtonUploadTemplateGen.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonUploadTemplateGen.Name = "materialButtonUploadTemplateGen";
            materialButtonUploadTemplateGen.NoAccentTextColor = Color.Empty;
            materialButtonUploadTemplateGen.Size = new Size(131, 36);
            materialButtonUploadTemplateGen.TabIndex = 0;
            materialButtonUploadTemplateGen.Text = "завантажити";
            materialButtonUploadTemplateGen.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonUploadTemplateGen.UseAccentColor = false;
            materialButtonUploadTemplateGen.UseVisualStyleBackColor = true;
            // 
            // panelSavedTemplate
            // 
            panelSavedTemplate.BackColor = Color.White;
            panelSavedTemplate.BorderStyle = BorderStyle.FixedSingle;
            panelSavedTemplate.Controls.Add(materialLabelSavedTmp);
            panelSavedTemplate.Controls.Add(materialComboBoxSavedTmp);
            panelSavedTemplate.Location = new Point(18, 53);
            panelSavedTemplate.Name = "panelSavedTemplate";
            panelSavedTemplate.Size = new Size(346, 130);
            panelSavedTemplate.TabIndex = 2;
            // 
            // materialLabelSavedTmp
            // 
            materialLabelSavedTmp.AutoSize = true;
            materialLabelSavedTmp.Depth = 0;
            materialLabelSavedTmp.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelSavedTmp.Location = new Point(30, 11);
            materialLabelSavedTmp.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelSavedTmp.Name = "materialLabelSavedTmp";
            materialLabelSavedTmp.Size = new Size(125, 19);
            materialLabelSavedTmp.TabIndex = 1;
            materialLabelSavedTmp.Text = "вибрати шаблон";
            // 
            // materialComboBoxSavedTmp
            // 
            materialComboBoxSavedTmp.AutoResize = false;
            materialComboBoxSavedTmp.BackColor = Color.FromArgb(255, 255, 255);
            materialComboBoxSavedTmp.Depth = 0;
            materialComboBoxSavedTmp.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBoxSavedTmp.DropDownHeight = 174;
            materialComboBoxSavedTmp.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBoxSavedTmp.DropDownWidth = 121;
            materialComboBoxSavedTmp.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBoxSavedTmp.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBoxSavedTmp.FormattingEnabled = true;
            materialComboBoxSavedTmp.IntegralHeight = false;
            materialComboBoxSavedTmp.ItemHeight = 43;
            materialComboBoxSavedTmp.Location = new Point(30, 44);
            materialComboBoxSavedTmp.MaxDropDownItems = 4;
            materialComboBoxSavedTmp.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBoxSavedTmp.Name = "materialComboBoxSavedTmp";
            materialComboBoxSavedTmp.Size = new Size(197, 49);
            materialComboBoxSavedTmp.StartIndex = 0;
            materialComboBoxSavedTmp.TabIndex = 0;
            // 
            // materialRadioButtonIUploadTmp
            // 
            materialRadioButtonIUploadTmp.AutoSize = true;
            materialRadioButtonIUploadTmp.Depth = 0;
            materialRadioButtonIUploadTmp.Location = new Point(443, 13);
            materialRadioButtonIUploadTmp.Margin = new Padding(0);
            materialRadioButtonIUploadTmp.MouseLocation = new Point(-1, -1);
            materialRadioButtonIUploadTmp.MouseState = MaterialSkin.MouseState.HOVER;
            materialRadioButtonIUploadTmp.Name = "materialRadioButtonIUploadTmp";
            materialRadioButtonIUploadTmp.Ripple = true;
            materialRadioButtonIUploadTmp.Size = new Size(196, 37);
            materialRadioButtonIUploadTmp.TabIndex = 1;
            materialRadioButtonIUploadTmp.TabStop = true;
            materialRadioButtonIUploadTmp.Text = "завантажити шаблон";
            materialRadioButtonIUploadTmp.UseVisualStyleBackColor = true;
            materialRadioButtonIUploadTmp.CheckedChanged += materialRadioButtonIUploadTmp_CheckedChanged;
            // 
            // materialRadioButtonSaveTmp
            // 
            materialRadioButtonSaveTmp.AutoSize = true;
            materialRadioButtonSaveTmp.Checked = true;
            materialRadioButtonSaveTmp.Depth = 0;
            materialRadioButtonSaveTmp.Location = new Point(27, 13);
            materialRadioButtonSaveTmp.Margin = new Padding(0);
            materialRadioButtonSaveTmp.MouseLocation = new Point(-1, -1);
            materialRadioButtonSaveTmp.MouseState = MaterialSkin.MouseState.HOVER;
            materialRadioButtonSaveTmp.Name = "materialRadioButtonSaveTmp";
            materialRadioButtonSaveTmp.Ripple = true;
            materialRadioButtonSaveTmp.Size = new Size(186, 37);
            materialRadioButtonSaveTmp.TabIndex = 0;
            materialRadioButtonSaveTmp.TabStop = true;
            materialRadioButtonSaveTmp.Text = "збережений шаблон";
            materialRadioButtonSaveTmp.UseVisualStyleBackColor = true;
            materialRadioButtonSaveTmp.CheckedChanged += materialRadioButtonSaveTmp_CheckedChanged;
            // 
            // tabPageCommand
            // 
            tabPageCommand.BackColor = Color.White;
            tabPageCommand.Controls.Add(materialComboBoxCmdList);
            tabPageCommand.Controls.Add(materialButton1);
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
            tabPageCommand.Size = new Size(945, 680);
            tabPageCommand.TabIndex = 2;
            tabPageCommand.Text = "Команди";
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
            dataGridViewCellStyle19.BackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle19.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle19.ForeColor = Color.Black;
            dataGridViewCellStyle19.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle19.SelectionForeColor = Color.Black;
            dataGridViewBookmarksForCmd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewBookmarksForCmd.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridViewBookmarksForCmd.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = Color.MediumPurple;
            dataGridViewCellStyle20.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle20.ForeColor = SystemColors.Window;
            dataGridViewCellStyle20.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = DataGridViewTriState.True;
            dataGridViewBookmarksForCmd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            dataGridViewBookmarksForCmd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBookmarksForCmd.Columns.AddRange(new DataGridViewColumn[] { InputBookmark, dataGridViewComboBoxColumnOB });
            dataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle23.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle23.ForeColor = Color.Black;
            dataGridViewCellStyle23.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle23.SelectionForeColor = Color.Black;
            dataGridViewCellStyle23.WrapMode = DataGridViewTriState.False;
            dataGridViewBookmarksForCmd.DefaultCellStyle = dataGridViewCellStyle23;
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
            dataGridViewCellStyle21.BackColor = Color.MediumSlateBlue;
            dataGridViewCellStyle21.ForeColor = Color.Black;
            dataGridViewCellStyle21.SelectionBackColor = Color.MediumSlateBlue;
            dataGridViewCellStyle21.SelectionForeColor = Color.Black;
            InputBookmark.DefaultCellStyle = dataGridViewCellStyle21;
            InputBookmark.FlatStyle = FlatStyle.Flat;
            InputBookmark.HeaderText = "Вхідна закладка";
            InputBookmark.MinimumWidth = 8;
            InputBookmark.Name = "InputBookmark";
            InputBookmark.Width = 150;
            // 
            // dataGridViewComboBoxColumnOB
            // 
            dataGridViewCellStyle22.BackColor = Color.MediumSlateBlue;
            dataGridViewCellStyle22.ForeColor = Color.Black;
            dataGridViewCellStyle22.SelectionBackColor = Color.MediumSlateBlue;
            dataGridViewCellStyle22.SelectionForeColor = Color.Black;
            dataGridViewComboBoxColumnOB.DefaultCellStyle = dataGridViewCellStyle22;
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
            materialButtonCreateCmd.Icon = null;
            materialButtonCreateCmd.Location = new Point(25, 570);
            materialButtonCreateCmd.Margin = new Padding(4, 6, 4, 6);
            materialButtonCreateCmd.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonCreateCmd.Name = "materialButtonCreateCmd";
            materialButtonCreateCmd.NoAccentTextColor = Color.Empty;
            materialButtonCreateCmd.Size = new Size(176, 36);
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
            imageListMenu.Images.SetKeyName(1, "template.png");
            imageListMenu.Images.SetKeyName(2, "writing.png");
            // 
            // materialButtonUpdCommand
            // 
            materialButtonUpdCommand.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonUpdCommand.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonUpdCommand.Depth = 0;
            materialButtonUpdCommand.HighEmphasis = true;
            materialButtonUpdCommand.Icon = null;
            materialButtonUpdCommand.Location = new Point(25, 628);
            materialButtonUpdCommand.Margin = new Padding(4, 6, 4, 6);
            materialButtonUpdCommand.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonUpdCommand.Name = "materialButtonUpdCommand";
            materialButtonUpdCommand.NoAccentTextColor = Color.Empty;
            materialButtonUpdCommand.Size = new Size(168, 36);
            materialButtonUpdCommand.TabIndex = 10;
            materialButtonUpdCommand.Text = "оновити команду";
            materialButtonUpdCommand.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonUpdCommand.UseAccentColor = false;
            materialButtonUpdCommand.UseVisualStyleBackColor = true;
            // 
            // materialButtonDeleteCommand
            // 
            materialButtonDeleteCommand.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonDeleteCommand.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonDeleteCommand.Depth = 0;
            materialButtonDeleteCommand.HighEmphasis = true;
            materialButtonDeleteCommand.Icon = null;
            materialButtonDeleteCommand.Location = new Point(225, 570);
            materialButtonDeleteCommand.Margin = new Padding(4, 6, 4, 6);
            materialButtonDeleteCommand.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonDeleteCommand.Name = "materialButtonDeleteCommand";
            materialButtonDeleteCommand.NoAccentTextColor = Color.Empty;
            materialButtonDeleteCommand.Size = new Size(179, 36);
            materialButtonDeleteCommand.TabIndex = 11;
            materialButtonDeleteCommand.Text = "Видалити команду";
            materialButtonDeleteCommand.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonDeleteCommand.UseAccentColor = false;
            materialButtonDeleteCommand.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(225, 628);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(157, 36);
            materialButton1.TabIndex = 12;
            materialButton1.Text = "Читати команду";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
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
            materialComboBoxCmdList.Location = new Point(33, 494);
            materialComboBoxCmdList.MaxDropDownItems = 4;
            materialComboBoxCmdList.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBoxCmdList.Name = "materialComboBoxCmdList";
            materialComboBoxCmdList.Size = new Size(200, 49);
            materialComboBoxCmdList.StartIndex = 0;
            materialComboBoxCmdList.TabIndex = 13;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 790);
            Controls.Add(materialTabControl);
            DrawerTabControl = materialTabControl;
            HelpButton = true;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Document Generator";
            materialTabControl.ResumeLayout(false);
            tabPageTemplate.ResumeLayout(false);
            tabPageTemplate.PerformLayout();
            tabPageGenerateDocument.ResumeLayout(false);
            tabPageGenerateDocument.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBookmarks).EndInit();
            panelUploadTemplate.ResumeLayout(false);
            panelUploadTemplate.PerformLayout();
            panelSavedTemplate.ResumeLayout(false);
            panelSavedTemplate.PerformLayout();
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
        private MaterialSkin.Controls.MaterialButton materialButtonLoadTemplate;
        private MaterialSkin.Controls.MaterialButton materialButtonRemoveTemplate;
        private MaterialSkin.Controls.MaterialListView materialListViewTemplate;
        private MaterialSkin.Controls.MaterialLabel materialLabelListTemplate;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxPathFile;
        private MaterialSkin.Controls.MaterialLabel materialLabelPathFile;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxCmdName;
        private MaterialSkin.Controls.MaterialLabel materialLabelCmdName;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxInputTmp;
        private MaterialSkin.Controls.MaterialLabel materialLabelOutputTmp;
        private MaterialSkin.Controls.MaterialLabel materialLabelInputTmp;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxOutputTmp;
        private MaterialSkin.Controls.MaterialButton materialButtonCreateCmd;
        private MaterialSkin.Controls.MaterialLabel materialLabelBookmarksTable;
        private TabPage tabPageGenerateDocument;
        private MaterialSkin.Controls.MaterialButton materialButtonGenerateDocument;
        private Panel panelUploadTemplate;
        private MaterialSkin.Controls.MaterialLabel materialLabelUploadTmp;
        private MaterialSkin.Controls.MaterialListBox materialListBoxUploadTmp;
        private MaterialSkin.Controls.MaterialButton materialButtonUploadTemplateGen;
        private Panel panelSavedTemplate;
        private MaterialSkin.Controls.MaterialLabel materialLabelSavedTmp;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxSavedTmp;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButtonIUploadTmp;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButtonSaveTmp;
        private DataGridView dataGridViewBookmarks;
        private DataGridViewTextBoxColumn Bookmark;
        private DataGridViewComboBoxColumn TypeData;
        private DataGridViewTextBoxColumn EnterData;
        private DataGridView dataGridViewBookmarksForCmd;
        private DataGridViewComboBoxColumn InputBookmark;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumnOB;
        private MaterialSkin.Controls.MaterialButton materialButtonFillTableBookmarks;
        private MaterialSkin.Controls.MaterialButton materialButtonDownloadDocument;
        private MaterialSkin.Controls.MaterialButton materialButtonReadTemlate;
        private MaterialSkin.Controls.MaterialButton materialButtonUpdateTemplate;
        private MaterialSkin.Controls.MaterialSwitch materialSwitchUseCommand;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxCommandsSelect;
        private MaterialSkin.Controls.MaterialButton materialButtonUpdCommand;
        private MaterialSkin.Controls.MaterialButton materialButtonDeleteCommand;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxCmdList;
    }
}