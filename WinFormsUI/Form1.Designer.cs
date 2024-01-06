namespace WinFormsUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            materialTabControl = new MaterialSkin.Controls.MaterialTabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            imageListMenu = new ImageList(components);
            materialTabControl.SuspendLayout();
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
            tabPage1.BackColor = Color.White;
            tabPage1.ImageKey = "template.png";
            tabPage1.Location = new Point(4, 39);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(836, 440);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Шаблони";
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 550);
            Controls.Add(materialTabControl);
            DrawerTabControl = materialTabControl;
            HelpButton = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Document Generator";
            materialTabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ImageList imageListMenu;
    }
}