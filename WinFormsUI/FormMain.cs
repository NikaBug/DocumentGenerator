using MaterialSkin;
using MaterialSkin.Controls;
using Presentation.ViewModels;
using Presentation.Views;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms.Design;
using static System.Diagnostics.Activity;

namespace WinFormsUI
{
    public partial class FormMain : MaterialForm, ICommandView, ITemplateView
    {
        List<TemplateViewModel> listTemplates;
        public FormMain()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            this.materialListUploadTemplate.GridLines = true;
            this.listTemplates = new List<TemplateViewModel>();
        }

        public void SetCommandsList(IEnumerable<CommandViewModel> commands)
        {
            materialComboBoxCmdList.Items.Add(commands.First().Name);
        }

        public void SetTemplateList(IEnumerable<TemplateViewModel> templates)
        {
            // materialTextBoxPathFile.Text = templates.First().FileName;

            ListViewItem viewItem = new ListViewItem(templates.First().FileName);
            viewItem.SubItems.Add(templates.First().DateModificationFile);
            viewItem.SubItems.Add(templates.First().SizeFile.ToString());
            materialListUploadTemplate.Items.Add(viewItem);

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
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Word|*.docx;*.doc"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileInfo fileInfo = new FileInfo(ofd.FileName);

                // ListViewItem viewItem = new ListViewItem(fileInfo.Name);
                DateTime modification = File.GetLastWriteTime(fileInfo.FullName);
                double sizeFileKb = fileInfo.Length / 1000;
                //viewItem.SubItems.Add(modification.ToString());
                //viewItem.SubItems.Add(sizeFileKb.ToString());
                //materialListUploadTemplate.Items.Add(viewItem);

                listTemplates.Add(new TemplateViewModel
                { FileName = fileInfo.Name, DateModificationFile = modification.ToString(), SizeFile = sizeFileKb });
                this.SetTemplateList(listTemplates);

            }
        }

        private void materialListUploadTemplate_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = materialListUploadTemplate.FocusedItem.Index;
            string fileName = listTemplates[index].FileName;
            FormEditTemplate formEditTemplate = new FormEditTemplate(fileName);
            formEditTemplate.ShowDialog();
        }
    }
}

