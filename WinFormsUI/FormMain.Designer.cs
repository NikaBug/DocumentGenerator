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
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            materialTabControl = new MaterialSkin.Controls.MaterialTabControl();
            tabPageTemplate = new TabPage();
            dataGridViewTableBookmarks = new DataGridView();
            ColumnNumber = new DataGridViewTextBoxColumn();
            ColumnBookmarkName = new DataGridViewTextBoxColumn();
            TypeBookmark = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
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
            dataGridViewGeneratorSettingBookmark = new DataGridView();
            GenNameBookmark = new DataGridViewTextBoxColumn();
            GenTypeBookmark = new DataGridViewComboBoxColumn();
            GenEnterData = new DataGridViewButtonColumn();
            materialComboBoxCommandsSelect = new MaterialSkin.Controls.MaterialComboBox();
            materialSwitchUseCommand = new MaterialSkin.Controls.MaterialSwitch();
            materialButtonDownloadDocument = new MaterialSkin.Controls.MaterialButton();
            materialButtonGenerateDocument = new MaterialSkin.Controls.MaterialButton();
            panelUploadTemplate = new Panel();
            materialLabelUploadTmp = new MaterialSkin.Controls.MaterialLabel();
            materialListBoxUploadGenTmp = new MaterialSkin.Controls.MaterialListBox();
            materialButtonUploadTemplateGen = new MaterialSkin.Controls.MaterialButton();
            panelSavedTemplate = new Panel();
            materialLabelSavedTmp = new MaterialSkin.Controls.MaterialLabel();
            materialComboBoxSavedTmp = new MaterialSkin.Controls.MaterialComboBox();
            materialRadioButtonIUploadTmp = new MaterialSkin.Controls.MaterialRadioButton();
            materialRadioButtonSaveTmp = new MaterialSkin.Controls.MaterialRadioButton();
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
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTableTemplate).BeginInit();
            tabPageGenerateDocument.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGeneratorSettingBookmark).BeginInit();
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
            materialTabControl.Size = new Size(1269, 723);
            materialTabControl.TabIndex = 0;
            // 
            // tabPageTemplate
            // 
            tabPageTemplate.BackColor = Color.WhiteSmoke;
            tabPageTemplate.Controls.Add(dataGridViewTableBookmarks);
            tabPageTemplate.Controls.Add(tableLayoutPanel1);
            tabPageTemplate.Controls.Add(dataGridViewTableTemplate);
            tabPageTemplate.ImageKey = "template.png";
            tabPageTemplate.Location = new Point(4, 39);
            tabPageTemplate.Name = "tabPageTemplate";
            tabPageTemplate.Padding = new Padding(3);
            tabPageTemplate.Size = new Size(1261, 680);
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
            dataGridViewTableBookmarks.Location = new Point(3, 450);
            dataGridViewTableBookmarks.MultiSelect = false;
            dataGridViewTableBookmarks.Name = "dataGridViewTableBookmarks";
            dataGridViewTableBookmarks.ReadOnly = true;
            dataGridViewTableBookmarks.RowHeadersVisible = false;
            dataGridViewTableBookmarks.RowHeadersWidth = 25;
            dataGridViewTableBookmarks.RowTemplate.Height = 25;
            dataGridViewTableBookmarks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTableBookmarks.Size = new Size(1252, 227);
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.Controls.Add(materialButtonAddTemplate, 0, 0);
            tableLayoutPanel1.Controls.Add(materialButtonEditTemplate, 1, 0);
            tableLayoutPanel1.Controls.Add(materialButtonReadTemplate, 2, 0);
            tableLayoutPanel1.Controls.Add(materialTextBoxSearchTemplate, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(2);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1255, 56);
            tableLayoutPanel1.TabIndex = 1;
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
            dataGridViewTableTemplate.Size = new Size(1255, 354);
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
            tabPageGenerateDocument.Controls.Add(dataGridViewGeneratorSettingBookmark);
            tabPageGenerateDocument.Controls.Add(materialComboBoxCommandsSelect);
            tabPageGenerateDocument.Controls.Add(materialSwitchUseCommand);
            tabPageGenerateDocument.Controls.Add(materialButtonDownloadDocument);
            tabPageGenerateDocument.Controls.Add(materialButtonGenerateDocument);
            tabPageGenerateDocument.Controls.Add(panelUploadTemplate);
            tabPageGenerateDocument.Controls.Add(panelSavedTemplate);
            tabPageGenerateDocument.Controls.Add(materialRadioButtonIUploadTmp);
            tabPageGenerateDocument.Controls.Add(materialRadioButtonSaveTmp);
            tabPageGenerateDocument.ImageKey = "writing.png";
            tabPageGenerateDocument.Location = new Point(4, 39);
            tabPageGenerateDocument.Name = "tabPageGenerateDocument";
            tabPageGenerateDocument.Padding = new Padding(3);
            tabPageGenerateDocument.Size = new Size(1261, 680);
            tabPageGenerateDocument.TabIndex = 1;
            tabPageGenerateDocument.Text = "Генератор";
            // 
            // dataGridViewGeneratorSettingBookmark
            // 
            dataGridViewGeneratorSettingBookmark.AllowUserToAddRows = false;
            dataGridViewGeneratorSettingBookmark.AllowUserToDeleteRows = false;
            dataGridViewGeneratorSettingBookmark.AllowUserToResizeColumns = false;
            dataGridViewGeneratorSettingBookmark.AllowUserToResizeRows = false;
            dataGridViewGeneratorSettingBookmark.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewGeneratorSettingBookmark.BackgroundColor = Color.White;
            dataGridViewGeneratorSettingBookmark.BorderStyle = BorderStyle.None;
            dataGridViewGeneratorSettingBookmark.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewGeneratorSettingBookmark.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewGeneratorSettingBookmark.ColumnHeadersHeight = 35;
            dataGridViewGeneratorSettingBookmark.Columns.AddRange(new DataGridViewColumn[] { GenNameBookmark, GenTypeBookmark, GenEnterData });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(100, 100, 180);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dataGridViewGeneratorSettingBookmark.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewGeneratorSettingBookmark.EnableHeadersVisualStyles = false;
            dataGridViewGeneratorSettingBookmark.GridColor = Color.LightGray;
            dataGridViewGeneratorSettingBookmark.Location = new Point(6, 296);
            dataGridViewGeneratorSettingBookmark.MultiSelect = false;
            dataGridViewGeneratorSettingBookmark.Name = "dataGridViewGeneratorSettingBookmark";
            dataGridViewGeneratorSettingBookmark.RowHeadersVisible = false;
            dataGridViewGeneratorSettingBookmark.RowHeadersWidth = 25;
            dataGridViewGeneratorSettingBookmark.RowTemplate.Height = 25;
            dataGridViewGeneratorSettingBookmark.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewGeneratorSettingBookmark.Size = new Size(1252, 227);
            dataGridViewGeneratorSettingBookmark.TabIndex = 15;
            dataGridViewGeneratorSettingBookmark.CellContentClick += dataGridViewGeneratorSettingBookmark_CellContentClick;
            // 
            // GenNameBookmark
            // 
            GenNameBookmark.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GenNameBookmark.HeaderText = "Назва закладки";
            GenNameBookmark.MinimumWidth = 8;
            GenNameBookmark.Name = "GenNameBookmark";
            // 
            // GenTypeBookmark
            // 
            GenTypeBookmark.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(192, 192, 255);
            GenTypeBookmark.DefaultCellStyle = dataGridViewCellStyle6;
            GenTypeBookmark.FlatStyle = FlatStyle.Flat;
            GenTypeBookmark.HeaderText = "Тип закладки";
            GenTypeBookmark.MinimumWidth = 8;
            GenTypeBookmark.Name = "GenTypeBookmark";
            // 
            // GenEnterData
            // 
            GenEnterData.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            GenEnterData.HeaderText = "Дані";
            GenEnterData.MinimumWidth = 8;
            GenEnterData.Name = "GenEnterData";
            GenEnterData.Text = "Ввести дані";
            GenEnterData.UseColumnTextForButtonValue = true;
            GenEnterData.Width = 56;
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
            materialButtonDownloadDocument.Location = new Point(274, 558);
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
            // materialButtonGenerateDocument
            // 
            materialButtonGenerateDocument.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonGenerateDocument.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonGenerateDocument.Depth = 0;
            materialButtonGenerateDocument.HighEmphasis = true;
            materialButtonGenerateDocument.Icon = null;
            materialButtonGenerateDocument.Location = new Point(20, 558);
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
            panelUploadTemplate.Controls.Add(materialLabelUploadTmp);
            panelUploadTemplate.Controls.Add(materialListBoxUploadGenTmp);
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
            // materialListBoxUploadGenTmp
            // 
            materialListBoxUploadGenTmp.BackColor = Color.White;
            materialListBoxUploadGenTmp.BorderColor = Color.LightGray;
            materialListBoxUploadGenTmp.Depth = 0;
            materialListBoxUploadGenTmp.Enabled = false;
            materialListBoxUploadGenTmp.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialListBoxUploadGenTmp.Location = new Point(153, 32);
            materialListBoxUploadGenTmp.MouseState = MaterialSkin.MouseState.HOVER;
            materialListBoxUploadGenTmp.Name = "materialListBoxUploadGenTmp";
            materialListBoxUploadGenTmp.SelectedIndex = -1;
            materialListBoxUploadGenTmp.SelectedItem = null;
            materialListBoxUploadGenTmp.Size = new Size(308, 97);
            materialListBoxUploadGenTmp.TabIndex = 1;
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
            tabPageCommand.Size = new Size(1261, 680);
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
            dataGridViewCellStyle8.BackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dataGridViewBookmarksForCmd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewBookmarksForCmd.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridViewBookmarksForCmd.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.MediumPurple;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.Window;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridViewBookmarksForCmd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewBookmarksForCmd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBookmarksForCmd.Columns.AddRange(new DataGridViewColumn[] { InputBookmark, dataGridViewComboBoxColumnOB });
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle12.SelectionForeColor = Color.Black;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dataGridViewBookmarksForCmd.DefaultCellStyle = dataGridViewCellStyle12;
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
            dataGridViewCellStyle10.BackColor = Color.MediumSlateBlue;
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = Color.MediumSlateBlue;
            dataGridViewCellStyle10.SelectionForeColor = Color.Black;
            InputBookmark.DefaultCellStyle = dataGridViewCellStyle10;
            InputBookmark.FlatStyle = FlatStyle.Flat;
            InputBookmark.HeaderText = "Вхідна закладка";
            InputBookmark.MinimumWidth = 8;
            InputBookmark.Name = "InputBookmark";
            InputBookmark.Width = 150;
            // 
            // dataGridViewComboBoxColumnOB
            // 
            dataGridViewCellStyle11.BackColor = Color.MediumSlateBlue;
            dataGridViewCellStyle11.ForeColor = Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = Color.MediumSlateBlue;
            dataGridViewCellStyle11.SelectionForeColor = Color.Black;
            dataGridViewComboBoxColumnOB.DefaultCellStyle = dataGridViewCellStyle11;
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
            imageListMenu.Images.SetKeyName(1, "template.png");
            imageListMenu.Images.SetKeyName(2, "writing.png");
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1275, 790);
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
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTableTemplate).EndInit();
            tabPageGenerateDocument.ResumeLayout(false);
            tabPageGenerateDocument.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGeneratorSettingBookmark).EndInit();
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
        private MaterialSkin.Controls.MaterialListBox materialListBoxUploadGenTmp;
        private MaterialSkin.Controls.MaterialButton materialButtonUploadTemplateGen;
        private Panel panelSavedTemplate;
        private MaterialSkin.Controls.MaterialLabel materialLabelSavedTmp;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxSavedTmp;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButtonIUploadTmp;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButtonSaveTmp;
        private DataGridView dataGridViewBookmarksForCmd;
        private DataGridViewComboBoxColumn InputBookmark;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumnOB;
        private MaterialSkin.Controls.MaterialButton materialButtonFillTableBookmarks;
        private MaterialSkin.Controls.MaterialButton materialButtonDownloadDocument;
        private MaterialSkin.Controls.MaterialSwitch materialSwitchUseCommand;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxCommandsSelect;
        private MaterialSkin.Controls.MaterialButton materialButtonUpdCommand;
        private MaterialSkin.Controls.MaterialButton materialButtonDeleteCommand;
        private MaterialSkin.Controls.MaterialButton materialButtonReadCmd;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxCmdList;
        private MaterialSkin.Controls.MaterialLabel materialLabelSelCmd;
        private DataGridView dataGridViewTableTemplate;
        private TableLayoutPanel tableLayoutPanel1;
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
        private DataGridView dataGridViewGeneratorSettingBookmark;
        private DataGridViewTextBoxColumn GenNameBookmark;
        private DataGridViewComboBoxColumn GenTypeBookmark;
        private DataGridViewButtonColumn GenEnterData;
        private DataGridViewTextBoxColumn ColumnNumber;
        private DataGridViewTextBoxColumn ColumnBookmarkName;
        private DataGridViewTextBoxColumn TypeBookmark;
    }
}