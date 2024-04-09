using MaterialSkin;
using MaterialSkin.Controls;

namespace WinFormsUI
{
    public partial class FormImageData : MaterialForm
    {
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
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBoxImageData.Image = new Bitmap(open.FileName);
            }
        }
    }
}
