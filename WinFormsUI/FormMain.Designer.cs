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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            materialTabControl = new MaterialSkin.Controls.MaterialTabControl();
            tabPage1 = new TabPage();
            materialLabelPathFile = new MaterialSkin.Controls.MaterialLabel();
            materialTextBoxPathFile = new MaterialSkin.Controls.MaterialTextBox();
            materialLabelListTemplate = new MaterialSkin.Controls.MaterialLabel();
            materialListViewTemplate = new MaterialSkin.Controls.MaterialListView();
            materialButtonRemoveTemplate = new MaterialSkin.Controls.MaterialButton();
            materialButtonLoadTemplate = new MaterialSkin.Controls.MaterialButton();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            imageListMenu = new ImageList(components);
            materialTabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl
            // 
            materialTabControl.Controls.Add(tabPage1);
            materialTabControl.Controls.Add(tabPage2);
            materialTabControl.Controls.Add(tabPage3);
            materialTabControl.Depth = 0;
            materialTabControl.Dock = DockStyle.Fill;
            materialTabControl.ImageList = imageListMenu;
            materialTabControl.Location = new Point(3, 64);
            materialTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl.Multiline = true;
            materialTabControl.Name = "materialTabControl";
            materialTabControl.SelectedIndex = 0;
            materialTabControl.Size = new Size(844, 483);
            materialTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.WhiteSmoke;
            tabPage1.Controls.Add(materialLabelPathFile);
            tabPage1.Controls.Add(materialTextBoxPathFile);
            tabPage1.Controls.Add(materialLabelListTemplate);
            tabPage1.Controls.Add(materialListViewTemplate);
            tabPage1.Controls.Add(materialButtonRemoveTemplate);
            tabPage1.Controls.Add(materialButtonLoadTemplate);
            tabPage1.ImageKey = "template.png";
            tabPage1.Location = new Point(4, 39);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(836, 440);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Шаблони";
            // 
            // materialLabelPathFile
            // 
            materialLabelPathFile.AutoSize = true;
            materialLabelPathFile.Depth = 0;
            materialLabelPathFile.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelPathFile.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            materialLabelPathFile.HighEmphasis = true;
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
            materialLabelListTemplate.HighEmphasis = true;
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
            materialButtonRemoveTemplate.Icon = null;
            materialButtonRemoveTemplate.Location = new Point(407, 299);
            materialButtonRemoveTemplate.Margin = new Padding(4, 6, 4, 6);
            materialButtonRemoveTemplate.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonRemoveTemplate.Name = "materialButtonRemoveTemplate";
            materialButtonRemoveTemplate.NoAccentTextColor = Color.Empty;
            materialButtonRemoveTemplate.Size = new Size(170, 36);
            materialButtonRemoveTemplate.TabIndex = 1;
            materialButtonRemoveTemplate.Text = "Видалити шаблон";
            materialButtonRemoveTemplate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonRemoveTemplate.UseAccentColor = false;
            materialButtonRemoveTemplate.UseVisualStyleBackColor = true;
            materialButtonRemoveTemplate.Click += materialButtonRemoveTemplate_Click;
            // 
            // materialButtonLoadTemplate
            // 
            materialButtonLoadTemplate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonLoadTemplate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonLoadTemplate.Depth = 0;
            materialButtonLoadTemplate.HighEmphasis = true;
            materialButtonLoadTemplate.Icon = null;
            materialButtonLoadTemplate.Location = new Point(169, 299);
            materialButtonLoadTemplate.Margin = new Padding(4, 6, 4, 6);
            materialButtonLoadTemplate.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonLoadTemplate.Name = "materialButtonLoadTemplate";
            materialButtonLoadTemplate.NoAccentTextColor = Color.Empty;
            materialButtonLoadTemplate.Size = new Size(199, 36);
            materialButtonLoadTemplate.TabIndex = 0;
            materialButtonLoadTemplate.Text = "Завантажити шаблон";
            materialButtonLoadTemplate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonLoadTemplate.UseAccentColor = false;
            materialButtonLoadTemplate.UseVisualStyleBackColor = true;
            materialButtonLoadTemplate.Click += materialButtonLoadTemplate_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.ImageKey = "writing.png";
            tabPage2.Location = new Point(4, 39);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(836, 440);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Генератор";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.White;
            tabPage3.ImageKey = "command-line.png";
            tabPage3.Location = new Point(4, 39);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(836, 440);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Команди";
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
            ClientSize = new Size(850, 550);
            Controls.Add(materialTabControl);
            DrawerTabControl = materialTabControl;
            HelpButton = true;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoadedTemplate Generator";
            materialTabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ImageList imageListMenu;
        private MaterialSkin.Controls.MaterialButton materialButtonLoadTemplate;
        private MaterialSkin.Controls.MaterialButton materialButtonRemoveTemplate;
        private MaterialSkin.Controls.MaterialListView materialListViewTemplate;
        private MaterialSkin.Controls.MaterialLabel materialLabelListTemplate;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxPathFile;
        private MaterialSkin.Controls.MaterialLabel materialLabelPathFile;
    }
}