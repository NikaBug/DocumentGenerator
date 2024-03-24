using MaterialSkin;
using MaterialSkin.Controls;
using Presentation.Presenters;
using Presentation.ViewModels;
using Presentation.Views;
using System.Diagnostics;

namespace WinFormsUI
{
    public partial class FormMain : MaterialForm, ICommandView, ITemplateView
    {
        List<TemplateViewModel> listTemplates;
        static public int IndexRowTemplateTable = 0;

        public FormMain()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            // this.materialListViewUploadTemplate.GridLines = true;
            this.listTemplates = new List<TemplateViewModel>();
            // dataGridViewTableTemplate.Rows.Insert(0);
            this.WindowState = FormWindowState.Maximized;

        }

        public void SetCommandsList(IEnumerable<CommandViewModel> commands)
        {
            materialComboBoxCmdList.Items.Add(commands.First().Name);
        }

        public void SetTemplateList(IEnumerable<TemplateViewModel> templatesViewModel)
        {

            if (templatesViewModel.Count() == 0)
            {
                return;
            }
            else
            {
                dataGridViewTableTemplate.Rows.Insert(IndexRowTemplateTable, 0, templatesViewModel.Last().FileName,
                templatesViewModel.Last().DateModificationFile, templatesViewModel.Last().SizeFile);
                IndexRowTemplateTable++;

            }

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

        private void dataGridViewTableTemplate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string col = dataGridViewTableTemplate.Columns[e.ColumnIndex].Name;

            if (col == "DeleteTemplate")
            {
                if (this.dataGridViewTableTemplate.Rows[e.RowIndex].Cells[0].Value == null)
                {
                    CustomMessageBox.Show("Спочатку додайте шаблон до поточного рядка або виберіть інший зі списку.",
                        "Повідомлення", MessageBoxButtons.OK);
                    return;
                }

                DialogResult dialogResult = CustomMessageBox.Show("Ви впевнені, що хочете видалити шаблон? Видалення скасувати неможливо.",
               "Видалення шаблону", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (dataGridViewTableTemplate.SelectedRows.Count == 0)
                    {
                        CustomMessageBox.Show("Для видалення виберіть шаблон зі списку.", "Повідомлення", MessageBoxButtons.OK);
                    }
                    else
                    {
                        int index = dataGridViewTableTemplate.CurrentCell.RowIndex;
                        listTemplates.RemoveAt(index);
                        this.dataGridViewTableTemplate.Rows.RemoveAt(index);
                           IndexRowTemplateTable--;
                    }
                }
            }
        }

        private void materialButtonAddTemplate_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Word|*.docx"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileInfo fileInfo = new FileInfo(ofd.FileName);
                DateTime modification = File.GetLastWriteTime(fileInfo.FullName);
                double sizeFileKb = fileInfo.Length / 1000;
                foreach (var item in listTemplates)
                {
                    if (fileInfo.Name == item.FileName)
                    {
                        CustomMessageBox.Show("Шаблон має бути з унікальним іменем.", "Повідомлення", MessageBoxButtons.OK);
                        return;
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

        private void materialButtonEditTemplate_Click(object sender, EventArgs e)
        {
            if (dataGridViewTableTemplate.SelectedRows.Count == 0)
            {
                CustomMessageBox.Show("Для редагування виберіть шаблон зі списку.", "Повідомлення", MessageBoxButtons.OK);
            }
            else
            {
                int index = dataGridViewTableTemplate.CurrentCell.RowIndex;
                string fileName = listTemplates[index].FileName;
                FormEditTemplate formEditTemplate = new FormEditTemplate(fileName);
                formEditTemplate.ShowDialog();

            }

        }

        private void materialButtonReadTemplate_Click(object sender, EventArgs e)
        {

        }

        private void materialTextBoxSearchTemplate_TrailingIconClick(object sender, EventArgs e)
        {
            string nameTemplate = this.materialTextBoxSearchTemplate.Text;

            if (string.IsNullOrEmpty(nameTemplate) || Path.GetExtension(nameTemplate) != ".docx")
            {
                CustomMessageBox.Show("Перевірте ведення назви шаблону! Назва шаблону " + nameTemplate + " має містити .docx наприкінці.",
                    "Пошук шаблону", MessageBoxButtons.OK);
                return;
            }
            else
            {
                if (this.dataGridViewTableTemplate.Rows.Count == 0)
                {
                    CustomMessageBox.Show("Шаблони для пошуку відсутні! Додайте шаблони.", "Пошук шаблону", MessageBoxButtons.OK);
                    return;
                }

                for (int i = 0; i < this.dataGridViewTableTemplate.RowCount - 1; i++)
                {
                    if (dataGridViewTableTemplate.Rows[i].Cells["NameFile"].Value.ToString() == nameTemplate)
                    {
                        dataGridViewTableTemplate.CurrentCell = dataGridViewTableTemplate.Rows[i].Cells[0];
                        return;
                    }
                    else
                    {
                        CustomMessageBox.Show("Шаблон з назвою " + nameTemplate + " НЕ знайдено!", "Пошук шаблону", MessageBoxButtons.OK);
                        return;

                    }

                }



            }




        }

        private void dataGridViewTableTemplate_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridViewTableTemplate.Rows[e.RowIndex].Cells["NumberRows"].Value = (e.RowIndex + 1).ToString();
        }
    }
}

