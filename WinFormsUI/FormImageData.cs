using MaterialSkin;
using MaterialSkin.Controls;

namespace WinFormsUI
{
    public partial class FormImageData : MaterialForm
    {
        public Image imageData { get; set; }

        public FormImageData()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void materialButtonLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp)";

            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBoxImageData.Image = new Bitmap(open.FileName);
                pictureBoxImageData.Tag = "imageData";
            }
        }

        private void materialButtonSaveImage_Click(object sender, EventArgs e)
        {
            if ((string)pictureBoxImageData.Tag != "imageData")
            {
                CustomMessageBox.Show("Завантажте зображення!", "Збереження зображення", MessageBoxButtons.OK);
                return;
            }
            else
            {
                this.imageData = pictureBoxImageData.Image;
                CustomMessageBox.Show("Зображення збережене успішно!", "Збереження зображення", MessageBoxButtons.OK);
            }

            this.Close();
        }
    }
}
