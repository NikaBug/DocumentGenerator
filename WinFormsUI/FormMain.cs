using MaterialSkin;
using MaterialSkin.Controls;
using Presentation.ViewModels;
using Presentation.Views;
using System.Diagnostics.Eventing.Reader;

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
            // this.materialListViewUploadTemplate.GridLines = true;
            this.listTemplates = new List<TemplateViewModel>();
            // dataGridViewTableTemplate.Rows.Add();

            dataGridViewTableBookmarks.Rows.Add(new object[] { "закладка1" });
            dataGridViewTableBookmarks.Rows.Add(new object[] { "закладка2" });
            dataGridViewTableBookmarks.Rows.Add(new object[] { "закладка3" });

            DataGridViewComboBoxColumn theColumn = (DataGridViewComboBoxColumn)this.dataGridViewTableBookmarks.Columns[1];
            theColumn.Items.Add("Текст");
            theColumn.Items.Add("Таблиця");
            theColumn.Items.Add("Зображення");

        }

        public void SetCommandsList(IEnumerable<CommandViewModel> commands)
        {
            materialComboBoxCmdList.Items.Add(commands.First().Name);
        }

        public void SetTemplateList(IEnumerable<TemplateViewModel> templatesViewModel)
        {
          
              
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
                DateTime modification = File.GetLastWriteTime(fileInfo.FullName);
                double sizeFileKb = fileInfo.Length / 1000;
                // add check uniquness
                // if(fileInfo.Name == listTemplates.)
                foreach (var item in listTemplates)
                {
                    if (fileInfo.Name == item.FileName)
                    {
                        CustomMessageBox.Show("Для видалення виберіть шаблон зі списку.", "Повідомлення", MessageBoxButtons.OK);
                    }
                }

                listTemplates.Add(new TemplateViewModel
                {
                    FileName = fileInfo.Name,
                    DateModificationFile = modification.ToString(),
                    SizeFile = sizeFileKb
                });
                this.SetTemplateList(listTemplates);

            }
        }


        private void materialButtonCreateTemplate_Click(object sender, EventArgs e)
        {
            FormCreateTemplate formCreateTemplate = new FormCreateTemplate();
            formCreateTemplate.ShowDialog();
        }

        private void materialButtonRemoveTemplate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = CustomMessageBox.Show("�� �������, �� ������ �������� ������? ��������� ��������� ���������.",
                "��������� �������", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (materialListViewUploadTemplate.SelectedItems.Count == 0)
                {
                    CustomMessageBox.Show("��� ��������� ������� ������ � ������.", "�����������", MessageBoxButtons.OK);
                }
                else
                {
                    //int index = materialListViewUploadTemplate.FocusedItem.Index;
                    //listTemplates.RemoveAt(index);
                    //materialListViewUploadTemplate.Items.RemoveAt(index);
                    int index = dataGridView2.CurrentCell.RowIndex;
                    listTemplates.RemoveAt(index);
                    materialListViewUploadTemplate.Items.RemoveAt(index);
                }
            }

        private void dataGridViewTableTemplate_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = dataGridViewTableTemplate.CurrentCell.RowIndex;
            string fileName = listTemplates[index].FileName;
            FormEditTemplate formEditTemplate = new FormEditTemplate(fileName);
            formEditTemplate.ShowDialog();

        }
    }
}

