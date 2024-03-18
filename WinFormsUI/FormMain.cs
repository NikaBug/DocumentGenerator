using Domain;
using MaterialSkin;
using MaterialSkin.Controls;
using Presentation.ViewModels;
using Presentation.Views;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
using System.Windows.Forms.Design;

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

            //dataGridViewTableBookmarks.Rows.Add(new object[] { "закладка1" });
            //dataGridViewTableBookmarks.Rows.Add(new object[] { "закладка2" });
            //dataGridViewTableBookmarks.Rows.Add(new object[] { "закладка3" });

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
            if (templatesViewModel.Count() == 0)
            {
                return;
            }
            else
            {
                dataGridViewTableTemplate.Rows.Insert(IndexRowTemplateTable, templatesViewModel.Last().FileName,
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
                foreach (var item in listTemplates)
                {
                    if (fileInfo.Name == item.FileName)
                    {
                        CustomMessageBox.Show("Шаблон має бути з унікальним іменем.", "Повідомлення", MessageBoxButtons.OK);
                        return;
                    }
                }



        private void materialButtonCreateTemplate_Click(object sender, EventArgs e)
        {
            FormCreateTemplate formCreateTemplate = new FormCreateTemplate();
            formCreateTemplate.ShowDialog();
        }

        private void materialButtonRemoveTemplate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = CustomMessageBox.Show("Ви впевнені, що хочете видалити шаблон? Видалення скасувати неможливо.",
                "Видалення шаблону", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {  // if (materialListViewUploadTemplate.SelectedItems.Count == 0)
                if (dataGridViewTableTemplate.SelectedRows.Count == 0)
                {
                    CustomMessageBox.Show("Для видалення виберіть шаблон зі списку.", "Повідомлення", MessageBoxButtons.OK);
                }
                else
                {
                    int index = dataGridViewTableTemplate.CurrentCell.RowIndex;
                    listTemplates.RemoveAt(index);
                    this.dataGridViewTableTemplate.Rows.RemoveAt(index);
                }
            }
        }

        private void dataGridViewTableTemplate_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = dataGridViewTableTemplate.CurrentCell.RowIndex;
            string fileName = listTemplates[index].FileName;
            FormEditTemplate formEditTemplate = new FormEditTemplate(fileName);
            formEditTemplate.ShowDialog();

        }

        private void dataGridViewTableTemplate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string col = dataGridViewTableTemplate.Columns[e.ColumnIndex].Name;

            if (col == "AddTemplate")
            {
                if (this.dataGridViewTableTemplate.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    CustomMessageBox.Show("РЁР°Р±Р»РѕРЅ РІР¶Рµ РґРѕРґР°РЅРёР№ РґРѕ С†СЊРѕРіРѕ СЂСЏРґРєР°.", "РџРѕРІС–РґРѕРјР»РµРЅРЅСЏ", MessageBoxButtons.OK);
                    return;
                }

                OpenFileDialog ofd = new OpenFileDialog
                {
                    Filter = "Word|*.docx;*.doc"
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
                            CustomMessageBox.Show("РЁР°Р±Р»РѕРЅ РјР°С” Р±СѓС‚Рё Р· СѓРЅС–РєР°Р»СЊРЅРёРј С–РјРµРЅРµРј.", "РџРѕРІС–РґРѕРјР»РµРЅРЅСЏ", MessageBoxButtons.OK);
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
            else if (col == "DeleteTemplate")
            {
                if (this.dataGridViewTableTemplate.Rows[e.RowIndex].Cells[0].Value == null)
                {
                    CustomMessageBox.Show("РЎРїРѕС‡Р°С‚РєСѓ РґРѕРґР°Р№С‚Рµ С€Р°Р±Р»РѕРЅ РґРѕ РїРѕС‚РѕС‡РЅРѕРіРѕ СЂСЏРґРєР° Р°Р±Рѕ РІРёР±РµСЂС–С‚СЊ С–РЅС€РёР№ Р·С– СЃРїРёСЃРєСѓ.",
                        "РџРѕРІС–РґРѕРјР»РµРЅРЅСЏ", MessageBoxButtons.OK);
                    return;
                }

                DialogResult dialogResult = CustomMessageBox.Show("Р’Рё РІРїРµРІРЅРµРЅС–, С‰Рѕ С…РѕС‡РµС‚Рµ РІРёРґР°Р»РёС‚Рё С€Р°Р±Р»РѕРЅ? Р’РёРґР°Р»РµРЅРЅСЏ СЃРєР°СЃСѓРІР°С‚Рё РЅРµРјРѕР¶Р»РёРІРѕ.",
               "Р’РёРґР°Р»РµРЅРЅСЏ С€Р°Р±Р»РѕРЅСѓ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (dataGridViewTableTemplate.SelectedRows.Count == 0)
                    {
                        CustomMessageBox.Show("Р”Р»СЏ РІРёРґР°Р»РµРЅРЅСЏ РІРёР±РµСЂС–С‚СЊ С€Р°Р±Р»РѕРЅ Р·С– СЃРїРёСЃРєСѓ.", "РџРѕРІС–РґРѕРјР»РµРЅРЅСЏ", MessageBoxButtons.OK);
                    }
                    else
                    {
                        int index = dataGridViewTableTemplate.CurrentCell.RowIndex;
                        listTemplates.RemoveAt(index);
                        this.dataGridViewTableTemplate.Rows.RemoveAt(index);
                    }
                }
            }
        }
    }
}

