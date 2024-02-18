using MaterialSkin;
using MaterialSkin.Controls;
using Presentation.ViewModels;
using Presentation.Views;

namespace WinFormsUI
{
    public partial class FormMain : MaterialForm, ICommandView, ITemplateView
    {
        public FormMain()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        public void SetCommandsList(IEnumerable<CommandViewModel> commands)
        {
            materialComboBoxCmdList.Items.Add(commands.First().Name);
        }

        public void SetTemplateList(IEnumerable<TemplateViewModel> templates)
        {
            materialTextBoxPathFile.Text = templates.First().FileName;
        }

        private void materialRadioButtonSaveTmp_CheckedChanged(object sender, EventArgs e)
        {
            if (materialRadioButtonSaveTmp.Checked)
            {
                foreach (Control ctrl in panelUploadTemplate.Controls)
                {
                    ctrl.Enabled = false;
                }

                foreach (Control ctrl in panelSavedTemplate.Controls)
                {
                    ctrl.Enabled = true;
                }
            }
        }

        private void materialRadioButtonIUploadTmp_CheckedChanged(object sender, EventArgs e)
        {
            if (materialRadioButtonIUploadTmp.Checked)
            {
                foreach (Control ctrl in panelUploadTemplate.Controls)
                {
                    ctrl.Enabled = true;
                }

                foreach (Control ctrl in panelSavedTemplate.Controls)
                {
                    ctrl.Enabled = false;
                }
            }
        }

        private void materialSwitchUseCommand_CheckedChanged(object sender, EventArgs e)
        {
            if (materialSwitchUseCommand.Checked)
            {
                materialComboBoxCommandsSelect.Enabled = true;
            }
            else
            {
                materialComboBoxCommandsSelect.Enabled = false;
            }
        }

        private void materialButtonLoadTemplate_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Word|*.docx;*.doc";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
            }
        }
    }
}

