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
            materialLabelListTemplate = new MaterialSkin.Controls.MaterialLabel();
            materialListViewTemplate = new MaterialSkin.Controls.MaterialListView();
            materialButtonRemoveTemplate = new MaterialSkin.Controls.MaterialButton();
            materialButtonAddTemplate = new MaterialSkin.Controls.MaterialButton();
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
            tabPage1.Controls.Add(materialLabelListTemplate);
            tabPage1.Controls.Add(materialListViewTemplate);
            tabPage1.Controls.Add(materialButtonRemoveTemplate);
            tabPage1.Controls.Add(materialButtonAddTemplate);
            tabPage1.ImageKey = "template.png";
            tabPage1.Location = new Point(4, 39);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(836, 440);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Шаблони";
            // 
            // materialLabelListTemplate
            // 
            materialLabelListTemplate.AutoSize = true;
            materialLabelListTemplate.Depth = 0;
            materialLabelListTemplate.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Pixel);
            materialLabelListTemplate.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabelListTemplate.HighEmphasis = true;
            materialLabelListTemplate.Location = new Point(263, 20);
            materialLabelListTemplate.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelListTemplate.Name = "materialLabelListTemplate";
            materialLabelListTemplate.Size = new Size(244, 24);
            materialLabelListTemplate.TabIndex = 3;
            materialLabelListTemplate.Text = "Список доданих шаблонів";
            // 
            // materialListViewTemplate
            // 
            materialListViewTemplate.AutoSizeTable = false;
            materialListViewTemplate.BackColor = Color.FromArgb(255, 255, 255);
            materialListViewTemplate.BorderStyle = BorderStyle.None;
            materialListViewTemplate.Depth = 0;
            materialListViewTemplate.FullRowSelect = true;
            materialListViewTemplate.Location = new Point(23, 58);
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
            materialButtonRemoveTemplate.Location = new Point(385, 245);
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
            // 
            // materialButtonAddTemplate
            // 
            materialButtonAddTemplate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonAddTemplate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonAddTemplate.Depth = 0;
            materialButtonAddTemplate.HighEmphasis = true;
            materialButtonAddTemplate.Icon = null;
            materialButtonAddTemplate.Location = new Point(198, 245);
            materialButtonAddTemplate.Margin = new Padding(4, 6, 4, 6);
            materialButtonAddTemplate.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonAddTemplate.Name = "materialButtonAddTemplate";
            materialButtonAddTemplate.NoAccentTextColor = Color.Empty;
            materialButtonAddTemplate.Size = new Size(151, 36);
            materialButtonAddTemplate.TabIndex = 0;
            materialButtonAddTemplate.Text = "Додати шаблон";
            materialButtonAddTemplate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonAddTemplate.UseAccentColor = false;
            materialButtonAddTemplate.UseVisualStyleBackColor = true;
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
            Text = "Document Generator";
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
        private MaterialSkin.Controls.MaterialButton materialButtonAddTemplate;
        private MaterialSkin.Controls.MaterialButton materialButtonRemoveTemplate;
        private MaterialSkin.Controls.MaterialListView materialListViewTemplate;
        private MaterialSkin.Controls.MaterialLabel materialLabelListTemplate;
    }
}