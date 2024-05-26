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
            TabControlMainMenu = new MaterialSkin.Controls.MaterialTabControl();
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
            groupBoxGenSettingOutput = new GroupBox();
            TextBoxGenPathSaveDocument = new MaterialSkin.Controls.MaterialTextBox();
            materialButtonSelectPathForSaved = new MaterialSkin.Controls.MaterialButton();
            materialLabelNameOutputDocument = new MaterialSkin.Controls.MaterialLabel();
            TextBoxGenNameOutputDocument = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabelPathSaved = new MaterialSkin.Controls.MaterialLabel();
            groupBoxGenSetDataBookmarks = new GroupBox();
            ButtonGenerateDocument = new MaterialSkin.Controls.MaterialButton();
            ComboBoxGenCommandList = new MaterialSkin.Controls.MaterialComboBox();
            SwitchGenUseCommand = new MaterialSkin.Controls.MaterialSwitch();
            dataGridViewGenSettingBookmarks = new DataGridView();
            GenNumberRows = new DataGridViewTextBoxColumn();
            GenNameBookmark = new DataGridViewTextBoxColumn();
            GenDataType = new DataGridViewComboBoxColumn();
            GenEnterData = new DataGridViewImageColumn();
            groupBoxGenChoseTemplate = new GroupBox();
            TabControlGenSelectTemplate = new MaterialSkin.Controls.MaterialTabControl();
            tabPageGenSaveTemplate = new TabPage();
            ListBoxGenSavedTemplates = new MaterialSkin.Controls.MaterialListBox();
            tabPageGenLoadTemplate = new TabPage();
            LabelGenNoteUploadTmp = new MaterialSkin.Controls.MaterialLabel();
            LabelGenUploadTemplate = new MaterialSkin.Controls.MaterialLabel();
            TextBoxGenUploadTemplate = new MaterialSkin.Controls.MaterialTextBox();
            TabSelectorGenSelectTemplate = new MaterialSkin.Controls.MaterialTabSelector();
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
            CmdOutputBookmark = new DataGridViewTextBoxColumn();
            CmdInputBookmark = new DataGridViewComboBoxColumn();
            groupBoxSettingCommand = new GroupBox();
            ButtonCmdViewBookmark = new MaterialSkin.Controls.MaterialButton();
            LabelCmdInputDocument = new MaterialSkin.Controls.MaterialLabel();
            TextBoxCmdInputDocument = new MaterialSkin.Controls.MaterialTextBox();
            TextBoxCmdCommandName = new MaterialSkin.Controls.MaterialTextBox2();
            ComboBoxCmdOutputTemplate = new MaterialSkin.Controls.MaterialComboBox();
            imageListMenu = new ImageList(components);
            TabControlMainMenu.SuspendLayout();
            tabPageTemplate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTableBookmarks).BeginInit();
            tableLayoutPanelTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTableTemplate).BeginInit();
            tabPageGenerateDocument.SuspendLayout();
            groupBoxGenSettingOutput.SuspendLayout();
            groupBoxGenSetDataBookmarks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGenSettingBookmarks).BeginInit();
            groupBoxGenChoseTemplate.SuspendLayout();
            TabControlGenSelectTemplate.SuspendLayout();
            tabPageGenSaveTemplate.SuspendLayout();
            tabPageGenLoadTemplate.SuspendLayout();
            tabPageCommand.SuspendLayout();
            groupBoxCmdTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTableCommand).BeginInit();
            groupBoxCmdSettingConvert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCmdBookmarkMatch).BeginInit();
            groupBoxSettingCommand.SuspendLayout();
            SuspendLayout();
            // 
            // TabControlMainMenu
            // 
            TabControlMainMenu.Controls.Add(tabPageTemplate);
            TabControlMainMenu.Controls.Add(tabPageGenerateDocument);
            TabControlMainMenu.Controls.Add(tabPageCommand);
            TabControlMainMenu.Depth = 0;
            TabControlMainMenu.Dock = DockStyle.Fill;
            TabControlMainMenu.ImageList = imageListMenu;
            TabControlMainMenu.Location = new Point(3, 64);
            TabControlMainMenu.MouseState = MaterialSkin.MouseState.HOVER;
            TabControlMainMenu.Multiline = true;
            TabControlMainMenu.Name = "TabControlMainMenu";
            TabControlMainMenu.SelectedIndex = 0;
            TabControlMainMenu.Size = new Size(1278, 765);
            TabControlMainMenu.TabIndex = 0;
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
            dataGridViewTableBookmarks.Size = new Size(1252, 250);
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
            ButtonAddTemplate.Click += ButtonAddTemplate_Click;
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
            ButtonEditTemplate.Click += ButtonEditTemplate_Click;
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
            ButtonReadTemplate.Click += ButtonReadTemplate_Click;
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
            TextBoxSearchTemplate.TrailingIconClick += TextBoxSearchTemplate_TrailingIconClick;
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
            dataGridViewTableTemplate.Size = new Size(1255, 366);
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
            tabPageGenerateDocument.Controls.Add(groupBoxGenSettingOutput);
            tabPageGenerateDocument.Controls.Add(groupBoxGenSetDataBookmarks);
            tabPageGenerateDocument.Controls.Add(groupBoxGenChoseTemplate);
            tabPageGenerateDocument.ImageKey = "writing.png";
            tabPageGenerateDocument.Location = new Point(4, 39);
            tabPageGenerateDocument.Name = "tabPageGenerateDocument";
            tabPageGenerateDocument.Padding = new Padding(3);
            tabPageGenerateDocument.Size = new Size(1270, 722);
            tabPageGenerateDocument.TabIndex = 1;
            tabPageGenerateDocument.Text = "Генератор";
            // 
            // groupBoxGenSettingOutput
            // 
            groupBoxGenSettingOutput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxGenSettingOutput.Controls.Add(TextBoxGenPathSaveDocument);
            groupBoxGenSettingOutput.Controls.Add(materialButtonSelectPathForSaved);
            groupBoxGenSettingOutput.Controls.Add(materialLabelNameOutputDocument);
            groupBoxGenSettingOutput.Controls.Add(TextBoxGenNameOutputDocument);
            groupBoxGenSettingOutput.Controls.Add(materialLabelPathSaved);
            groupBoxGenSettingOutput.Location = new Point(783, 6);
            groupBoxGenSettingOutput.Name = "groupBoxGenSettingOutput";
            groupBoxGenSettingOutput.Size = new Size(475, 315);
            groupBoxGenSettingOutput.TabIndex = 18;
            groupBoxGenSettingOutput.TabStop = false;
            groupBoxGenSettingOutput.Text = "Налаштування";
            // 
            // TextBoxGenPathSaveDocument
            // 
            TextBoxGenPathSaveDocument.AnimateReadOnly = false;
            TextBoxGenPathSaveDocument.BorderStyle = BorderStyle.None;
            TextBoxGenPathSaveDocument.Depth = 0;
            TextBoxGenPathSaveDocument.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextBoxGenPathSaveDocument.LeadingIcon = null;
            TextBoxGenPathSaveDocument.Location = new Point(24, 180);
            TextBoxGenPathSaveDocument.MaxLength = 400;
            TextBoxGenPathSaveDocument.MouseState = MaterialSkin.MouseState.OUT;
            TextBoxGenPathSaveDocument.Multiline = false;
            TextBoxGenPathSaveDocument.Name = "TextBoxGenPathSaveDocument";
            TextBoxGenPathSaveDocument.ReadOnly = true;
            TextBoxGenPathSaveDocument.ScrollBars = RichTextBoxScrollBars.None;
            TextBoxGenPathSaveDocument.Size = new Size(441, 50);
            TextBoxGenPathSaveDocument.TabIndex = 25;
            TextBoxGenPathSaveDocument.Text = "";
            TextBoxGenPathSaveDocument.TrailingIcon = null;
            // 
            // materialButtonSelectPathForSaved
            // 
            materialButtonSelectPathForSaved.AutoSize = false;
            materialButtonSelectPathForSaved.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonSelectPathForSaved.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonSelectPathForSaved.Depth = 0;
            materialButtonSelectPathForSaved.HighEmphasis = true;
            materialButtonSelectPathForSaved.Icon = Properties.Resources.icons8_folder_50;
            materialButtonSelectPathForSaved.Location = new Point(295, 239);
            materialButtonSelectPathForSaved.Margin = new Padding(4, 6, 4, 6);
            materialButtonSelectPathForSaved.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonSelectPathForSaved.Name = "materialButtonSelectPathForSaved";
            materialButtonSelectPathForSaved.NoAccentTextColor = Color.Empty;
            materialButtonSelectPathForSaved.Size = new Size(170, 36);
            materialButtonSelectPathForSaved.TabIndex = 23;
            materialButtonSelectPathForSaved.Text = "Вибрати папку";
            materialButtonSelectPathForSaved.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonSelectPathForSaved.UseAccentColor = false;
            materialButtonSelectPathForSaved.UseVisualStyleBackColor = true;
            materialButtonSelectPathForSaved.Click += ButtonSelectPathForSaved_Click;
            // 
            // materialLabelNameOutputDocument
            // 
            materialLabelNameOutputDocument.AutoSize = true;
            materialLabelNameOutputDocument.Depth = 0;
            materialLabelNameOutputDocument.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelNameOutputDocument.Location = new Point(24, 49);
            materialLabelNameOutputDocument.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelNameOutputDocument.Name = "materialLabelNameOutputDocument";
            materialLabelNameOutputDocument.Size = new Size(211, 19);
            materialLabelNameOutputDocument.TabIndex = 21;
            materialLabelNameOutputDocument.Text = "Назва вихідного документа";
            // 
            // TextBoxGenNameOutputDocument
            // 
            TextBoxGenNameOutputDocument.AnimateReadOnly = false;
            TextBoxGenNameOutputDocument.BackgroundImageLayout = ImageLayout.None;
            TextBoxGenNameOutputDocument.CharacterCasing = CharacterCasing.Normal;
            TextBoxGenNameOutputDocument.Depth = 0;
            TextBoxGenNameOutputDocument.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextBoxGenNameOutputDocument.HideSelection = true;
            TextBoxGenNameOutputDocument.LeadingIcon = null;
            TextBoxGenNameOutputDocument.Location = new Point(24, 74);
            TextBoxGenNameOutputDocument.MaxLength = 300;
            TextBoxGenNameOutputDocument.MouseState = MaterialSkin.MouseState.OUT;
            TextBoxGenNameOutputDocument.Name = "TextBoxGenNameOutputDocument";
            TextBoxGenNameOutputDocument.PasswordChar = '\0';
            TextBoxGenNameOutputDocument.PrefixSuffixText = null;
            TextBoxGenNameOutputDocument.ReadOnly = false;
            TextBoxGenNameOutputDocument.RightToLeft = RightToLeft.No;
            TextBoxGenNameOutputDocument.SelectedText = "";
            TextBoxGenNameOutputDocument.SelectionLength = 0;
            TextBoxGenNameOutputDocument.SelectionStart = 0;
            TextBoxGenNameOutputDocument.ShortcutsEnabled = true;
            TextBoxGenNameOutputDocument.Size = new Size(441, 48);
            TextBoxGenNameOutputDocument.TabIndex = 20;
            TextBoxGenNameOutputDocument.TabStop = false;
            TextBoxGenNameOutputDocument.Text = "OutputDocument.docx";
            TextBoxGenNameOutputDocument.TextAlign = HorizontalAlignment.Left;
            TextBoxGenNameOutputDocument.TrailingIcon = null;
            TextBoxGenNameOutputDocument.UseSystemPasswordChar = false;
            // 
            // materialLabelPathSaved
            // 
            materialLabelPathSaved.AutoSize = true;
            materialLabelPathSaved.Depth = 0;
            materialLabelPathSaved.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelPathSaved.Location = new Point(24, 144);
            materialLabelPathSaved.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelPathSaved.Name = "materialLabelPathSaved";
            materialLabelPathSaved.Size = new Size(167, 19);
            materialLabelPathSaved.TabIndex = 24;
            materialLabelPathSaved.Text = "Шлях для збереження";
            // 
            // groupBoxGenSetDataBookmarks
            // 
            groupBoxGenSetDataBookmarks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxGenSetDataBookmarks.Controls.Add(ButtonGenerateDocument);
            groupBoxGenSetDataBookmarks.Controls.Add(ComboBoxGenCommandList);
            groupBoxGenSetDataBookmarks.Controls.Add(SwitchGenUseCommand);
            groupBoxGenSetDataBookmarks.Controls.Add(dataGridViewGenSettingBookmarks);
            groupBoxGenSetDataBookmarks.Location = new Point(6, 327);
            groupBoxGenSetDataBookmarks.Name = "groupBoxGenSetDataBookmarks";
            groupBoxGenSetDataBookmarks.Size = new Size(1252, 389);
            groupBoxGenSetDataBookmarks.TabIndex = 17;
            groupBoxGenSetDataBookmarks.TabStop = false;
            groupBoxGenSetDataBookmarks.Text = "Задання даних";
            // 
            // ButtonGenerateDocument
            // 
            ButtonGenerateDocument.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonGenerateDocument.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonGenerateDocument.Depth = 0;
            ButtonGenerateDocument.HighEmphasis = true;
            ButtonGenerateDocument.Icon = Properties.Resources.icons8_document_50;
            ButtonGenerateDocument.Location = new Point(382, 77);
            ButtonGenerateDocument.Margin = new Padding(4, 6, 4, 6);
            ButtonGenerateDocument.MouseState = MaterialSkin.MouseState.HOVER;
            ButtonGenerateDocument.Name = "ButtonGenerateDocument";
            ButtonGenerateDocument.NoAccentTextColor = Color.Empty;
            ButtonGenerateDocument.Size = new Size(235, 36);
            ButtonGenerateDocument.TabIndex = 18;
            ButtonGenerateDocument.Text = "Сформувати документ";
            ButtonGenerateDocument.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonGenerateDocument.UseAccentColor = false;
            ButtonGenerateDocument.UseVisualStyleBackColor = true;
            ButtonGenerateDocument.Click += ButtonGenerateDocument_Click;
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
            // SwitchGenUseCommand
            // 
            SwitchGenUseCommand.AutoSize = true;
            SwitchGenUseCommand.Depth = 0;
            SwitchGenUseCommand.Location = new Point(15, 27);
            SwitchGenUseCommand.Margin = new Padding(0);
            SwitchGenUseCommand.MouseLocation = new Point(-1, -1);
            SwitchGenUseCommand.MouseState = MaterialSkin.MouseState.HOVER;
            SwitchGenUseCommand.Name = "SwitchGenUseCommand";
            SwitchGenUseCommand.Ripple = true;
            SwitchGenUseCommand.Size = new Size(261, 37);
            SwitchGenUseCommand.TabIndex = 17;
            SwitchGenUseCommand.Text = "використати дані команди";
            SwitchGenUseCommand.UseVisualStyleBackColor = true;
            SwitchGenUseCommand.CheckedChanged += SwitchGenUseCommand_CheckedChanged;
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
            dataGridViewGenSettingBookmarks.Location = new Point(15, 122);
            dataGridViewGenSettingBookmarks.MultiSelect = false;
            dataGridViewGenSettingBookmarks.Name = "dataGridViewGenSettingBookmarks";
            dataGridViewGenSettingBookmarks.RowHeadersVisible = false;
            dataGridViewGenSettingBookmarks.RowHeadersWidth = 25;
            dataGridViewGenSettingBookmarks.RowTemplate.Height = 25;
            dataGridViewGenSettingBookmarks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewGenSettingBookmarks.Size = new Size(1224, 261);
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
            GenNameBookmark.ReadOnly = true;
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
            groupBoxGenChoseTemplate.Controls.Add(TabControlGenSelectTemplate);
            groupBoxGenChoseTemplate.Controls.Add(TabSelectorGenSelectTemplate);
            groupBoxGenChoseTemplate.Location = new Point(6, 6);
            groupBoxGenChoseTemplate.Name = "groupBoxGenChoseTemplate";
            groupBoxGenChoseTemplate.Size = new Size(771, 315);
            groupBoxGenChoseTemplate.TabIndex = 0;
            groupBoxGenChoseTemplate.TabStop = false;
            groupBoxGenChoseTemplate.Text = "Вибір шаблона";
            // 
            // TabControlGenSelectTemplate
            // 
            TabControlGenSelectTemplate.Controls.Add(tabPageGenSaveTemplate);
            TabControlGenSelectTemplate.Controls.Add(tabPageGenLoadTemplate);
            TabControlGenSelectTemplate.Depth = 0;
            TabControlGenSelectTemplate.Location = new Point(17, 88);
            TabControlGenSelectTemplate.MouseState = MaterialSkin.MouseState.HOVER;
            TabControlGenSelectTemplate.Multiline = true;
            TabControlGenSelectTemplate.Name = "TabControlGenSelectTemplate";
            TabControlGenSelectTemplate.SelectedIndex = 0;
            TabControlGenSelectTemplate.Size = new Size(687, 219);
            TabControlGenSelectTemplate.TabIndex = 7;
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
            tabPageGenSaveTemplate.Size = new Size(679, 181);
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
            ListBoxGenSavedTemplates.Size = new Size(671, 173);
            ListBoxGenSavedTemplates.TabIndex = 3;
            ListBoxGenSavedTemplates.SelectedValueChanged += ListBoxGenSavedTemplates_SelectedValueChanged;
            // 
            // tabPageGenLoadTemplate
            // 
            tabPageGenLoadTemplate.BackColor = Color.WhiteSmoke;
            tabPageGenLoadTemplate.BorderStyle = BorderStyle.FixedSingle;
            tabPageGenLoadTemplate.Controls.Add(LabelGenNoteUploadTmp);
            tabPageGenLoadTemplate.Controls.Add(LabelGenUploadTemplate);
            tabPageGenLoadTemplate.Controls.Add(TextBoxGenUploadTemplate);
            tabPageGenLoadTemplate.Location = new Point(4, 34);
            tabPageGenLoadTemplate.Name = "tabPageGenLoadTemplate";
            tabPageGenLoadTemplate.Padding = new Padding(3);
            tabPageGenLoadTemplate.Size = new Size(679, 181);
            tabPageGenLoadTemplate.TabIndex = 1;
            tabPageGenLoadTemplate.Text = "Завантажити шаблон";
            // 
            // LabelGenNoteUploadTmp
            // 
            LabelGenNoteUploadTmp.Depth = 0;
            LabelGenNoteUploadTmp.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelGenNoteUploadTmp.HighEmphasis = true;
            LabelGenNoteUploadTmp.Location = new Point(16, 120);
            LabelGenNoteUploadTmp.MouseState = MaterialSkin.MouseState.HOVER;
            LabelGenNoteUploadTmp.Name = "LabelGenNoteUploadTmp";
            LabelGenNoteUploadTmp.Size = new Size(476, 44);
            LabelGenNoteUploadTmp.TabIndex = 10;
            LabelGenNoteUploadTmp.Text = "Примітка. Завантаження нового шаблона видаляє попередній\r\nзавантажений шаблон";
            // 
            // LabelGenUploadTemplate
            // 
            LabelGenUploadTemplate.AutoSize = true;
            LabelGenUploadTemplate.BackColor = Color.Transparent;
            LabelGenUploadTemplate.Depth = 0;
            LabelGenUploadTemplate.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelGenUploadTemplate.Location = new Point(16, 16);
            LabelGenUploadTemplate.MouseState = MaterialSkin.MouseState.HOVER;
            LabelGenUploadTemplate.Name = "LabelGenUploadTemplate";
            LabelGenUploadTemplate.Size = new Size(171, 19);
            LabelGenUploadTemplate.TabIndex = 9;
            LabelGenUploadTemplate.Text = "завантажений шаблон";
            // 
            // TextBoxGenUploadTemplate
            // 
            TextBoxGenUploadTemplate.AnimateReadOnly = false;
            TextBoxGenUploadTemplate.BorderStyle = BorderStyle.None;
            TextBoxGenUploadTemplate.Depth = 0;
            TextBoxGenUploadTemplate.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextBoxGenUploadTemplate.LeadingIcon = null;
            TextBoxGenUploadTemplate.Location = new Point(16, 50);
            TextBoxGenUploadTemplate.MaxLength = 50;
            TextBoxGenUploadTemplate.MouseState = MaterialSkin.MouseState.OUT;
            TextBoxGenUploadTemplate.Multiline = false;
            TextBoxGenUploadTemplate.Name = "TextBoxGenUploadTemplate";
            TextBoxGenUploadTemplate.ReadOnly = true;
            TextBoxGenUploadTemplate.Size = new Size(392, 50);
            TextBoxGenUploadTemplate.TabIndex = 8;
            TextBoxGenUploadTemplate.Text = "";
            TextBoxGenUploadTemplate.TrailingIcon = Properties.Resources.upload_big_arrow;
            TextBoxGenUploadTemplate.TrailingIconClick += TextBoxGenUploadTemplate_TrailingIconClick;
            // 
            // TabSelectorGenSelectTemplate
            // 
            TabSelectorGenSelectTemplate.BaseTabControl = TabControlGenSelectTemplate;
            TabSelectorGenSelectTemplate.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            TabSelectorGenSelectTemplate.Depth = 0;
            TabSelectorGenSelectTemplate.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            TabSelectorGenSelectTemplate.Location = new Point(17, 30);
            TabSelectorGenSelectTemplate.MouseState = MaterialSkin.MouseState.HOVER;
            TabSelectorGenSelectTemplate.Name = "TabSelectorGenSelectTemplate";
            TabSelectorGenSelectTemplate.Size = new Size(687, 56);
            TabSelectorGenSelectTemplate.TabIndex = 6;
            TabSelectorGenSelectTemplate.Text = "materialTabSelector1";
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
            groupBoxCmdTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxCmdTable.Controls.Add(ButtonEditCommand);
            groupBoxCmdTable.Controls.Add(ButtonCreateCommand);
            groupBoxCmdTable.Controls.Add(dataGridViewTableCommand);
            groupBoxCmdTable.Location = new Point(17, 362);
            groupBoxCmdTable.Name = "groupBoxCmdTable";
            groupBoxCmdTable.Size = new Size(1247, 346);
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
            ButtonEditCommand.HighEmphasis = true;
            ButtonEditCommand.Icon = (Image)resources.GetObject("ButtonEditCommand.Icon");
            ButtonEditCommand.Location = new Point(170, 33);
            ButtonEditCommand.Margin = new Padding(4, 6, 4, 6);
            ButtonEditCommand.MouseState = MaterialSkin.MouseState.HOVER;
            ButtonEditCommand.Name = "ButtonEditCommand";
            ButtonEditCommand.NoAccentTextColor = Color.Empty;
            ButtonEditCommand.Size = new Size(160, 47);
            ButtonEditCommand.TabIndex = 19;
            ButtonEditCommand.Text = "Редагувати";
            ButtonEditCommand.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            ButtonEditCommand.UseAccentColor = false;
            ButtonEditCommand.UseVisualStyleBackColor = true;
            ButtonEditCommand.Click += ButtonEditCommand_Click;
            // 
            // ButtonCreateCommand
            // 
            ButtonCreateCommand.AutoSize = false;
            ButtonCreateCommand.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonCreateCommand.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonCreateCommand.Depth = 0;
            ButtonCreateCommand.HighEmphasis = true;
            ButtonCreateCommand.Icon = (Image)resources.GetObject("ButtonCreateCommand.Icon");
            ButtonCreateCommand.Location = new Point(7, 33);
            ButtonCreateCommand.Margin = new Padding(4, 6, 4, 6);
            ButtonCreateCommand.MouseState = MaterialSkin.MouseState.HOVER;
            ButtonCreateCommand.Name = "ButtonCreateCommand";
            ButtonCreateCommand.NoAccentTextColor = Color.Empty;
            ButtonCreateCommand.Size = new Size(155, 47);
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
            dataGridViewTableCommand.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            dataGridViewTableCommand.Location = new Point(6, 89);
            dataGridViewTableCommand.MultiSelect = false;
            dataGridViewTableCommand.Name = "dataGridViewTableCommand";
            dataGridViewTableCommand.ReadOnly = true;
            dataGridViewTableCommand.RowHeadersVisible = false;
            dataGridViewTableCommand.RowHeadersWidth = 25;
            dataGridViewTableCommand.RowTemplate.Height = 25;
            dataGridViewTableCommand.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTableCommand.Size = new Size(1227, 251);
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
            groupBoxCmdSettingConvert.Size = new Size(790, 334);
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
            dataGridViewCmdBookmarkMatch.Columns.AddRange(new DataGridViewColumn[] { CmdNumberRow, CmdOutputBookmark, CmdInputBookmark });
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
            dataGridViewCmdBookmarkMatch.Size = new Size(764, 285);
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
            // CmdOutputBookmark
            // 
            CmdOutputBookmark.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CmdOutputBookmark.HeaderText = "Вихідна закладка (шаблон)";
            CmdOutputBookmark.MinimumWidth = 8;
            CmdOutputBookmark.Name = "CmdOutputBookmark";
            CmdOutputBookmark.ReadOnly = true;
            // 
            // CmdInputBookmark
            // 
            CmdInputBookmark.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(192, 192, 255);
            CmdInputBookmark.DefaultCellStyle = dataGridViewCellStyle11;
            CmdInputBookmark.FlatStyle = FlatStyle.Flat;
            CmdInputBookmark.HeaderText = "Вхідна закладка (документ)";
            CmdInputBookmark.MinimumWidth = 8;
            CmdInputBookmark.Name = "CmdInputBookmark";
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
            ButtonCmdViewBookmark.Icon = Properties.Resources.icons8_bookmark_50;
            ButtonCmdViewBookmark.Location = new Point(24, 279);
            ButtonCmdViewBookmark.Margin = new Padding(4, 6, 4, 6);
            ButtonCmdViewBookmark.MouseState = MaterialSkin.MouseState.HOVER;
            ButtonCmdViewBookmark.Name = "ButtonCmdViewBookmark";
            ButtonCmdViewBookmark.NoAccentTextColor = Color.Empty;
            ButtonCmdViewBookmark.Size = new Size(210, 36);
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
            Controls.Add(TabControlMainMenu);
            DrawerTabControl = TabControlMainMenu;
            HelpButton = true;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Document Generator";
            WindowState = FormWindowState.Maximized;
            TabControlMainMenu.ResumeLayout(false);
            tabPageTemplate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTableBookmarks).EndInit();
            tableLayoutPanelTools.ResumeLayout(false);
            tableLayoutPanelTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTableTemplate).EndInit();
            tabPageGenerateDocument.ResumeLayout(false);
            groupBoxGenSettingOutput.ResumeLayout(false);
            groupBoxGenSettingOutput.PerformLayout();
            groupBoxGenSetDataBookmarks.ResumeLayout(false);
            groupBoxGenSetDataBookmarks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGenSettingBookmarks).EndInit();
            groupBoxGenChoseTemplate.ResumeLayout(false);
            TabControlGenSelectTemplate.ResumeLayout(false);
            tabPageGenSaveTemplate.ResumeLayout(false);
            tabPageGenLoadTemplate.ResumeLayout(false);
            tabPageGenLoadTemplate.PerformLayout();
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

        private MaterialSkin.Controls.MaterialTabControl TabControlMainMenu;
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
        private GroupBox groupBoxGenSetDataBookmarks;
        private MaterialSkin.Controls.MaterialSwitch SwitchGenUseCommand;
        private MaterialSkin.Controls.MaterialComboBox ComboBoxGenCommandList;
        private MaterialSkin.Controls.MaterialTextBox2 TextBoxGenNameOutputDocument;
        private MaterialSkin.Controls.MaterialLabel materialLabelNameOutputDocument;
        private MaterialSkin.Controls.MaterialButton materialButtonSelectPathForSaved;
        private MaterialSkin.Controls.MaterialLabel materialLabelPathSaved;
        private MaterialSkin.Controls.MaterialButton ButtonGenerateDocument;
        private MaterialSkin.Controls.MaterialTextBox TextBoxGenPathSaveDocument;
        private MaterialSkin.Controls.MaterialButton ButtonCreateCommand;
        private GroupBox groupBoxGenChoseTemplate;
        private MaterialSkin.Controls.MaterialTabControl TabControlGenSelectTemplate;
        private TabPage tabPageGenSaveTemplate;
        private MaterialSkin.Controls.MaterialListBox ListBoxGenSavedTemplates;
        private TabPage tabPageGenLoadTemplate;
        private MaterialSkin.Controls.MaterialTabSelector TabSelectorGenSelectTemplate;
        private MaterialSkin.Controls.MaterialTextBox TextBoxCmdInputDocument;
        private MaterialSkin.Controls.MaterialLabel LabelCmdInputDocument;
        private MaterialSkin.Controls.MaterialButton ButtonCmdViewBookmark;
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
        private DataGridViewTextBoxColumn GenNumberRows;
        private DataGridViewTextBoxColumn GenNameBookmark;
        private DataGridViewComboBoxColumn GenDataType;
        private DataGridViewImageColumn GenEnterData;
        private DataGridViewTextBoxColumn CmdNumberRow;
        private DataGridViewTextBoxColumn CmdOutputBookmark;
        private DataGridViewComboBoxColumn CmdInputBookmark;
        private MaterialSkin.Controls.MaterialTextBox TextBoxGenUploadTemplate;
        private MaterialSkin.Controls.MaterialLabel LabelGenUploadTemplate;
        private MaterialSkin.Controls.MaterialLabel LabelGenNoteUploadTmp;
        private GroupBox groupBoxGenSettingOutput;
    }
}