using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.WindowsAPICodePack.Dialogs;
using Presentation.ViewModels;
using Presentation.Views;
using System.IO;
using Document = Aspose.Words.Document;
//using Syncfusion.DocIO;
//using Syncfusion.DocIO.DLS;

namespace WinFormsUI
{
    public partial class FormMain : MaterialForm, IMainView
    {
        private List<TemplateViewModel> listTemplates; // ������ �������
        static public int IndexRowTemplateTable = 0; // ������ ����� ������� �������
        private DataGridViewComboBoxColumn cmbGenSetBookmark;
        private TemplateViewModel cmdInputDoc;
        public FormMain()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            this.WindowState = FormWindowState.Maximized;
            this.listTemplates = new List<TemplateViewModel>();

            //
            cmbGenSetBookmark = (DataGridViewComboBoxColumn)this.dataGridViewGenSettingBookmarks.Columns[2];
            cmbGenSetBookmark.Items.Add("�����");
            cmbGenSetBookmark.Items.Add("����������");
            cmbGenSetBookmark.Items.Add("�������");
            //this.materialButtonGenLoadTemplate.Enabled = false;
            //this.materialButtonGenRemoveLoadTemplate.Enabled = false;
            this.TextBoxCmdInputDocument.ReadOnly = true;
            CmdOutputBookmark = (DataGridViewComboBoxColumn)this.dataGridViewCmdBookmarkMatch.Columns[2];


        }

        public void SetCommandsList(IEnumerable<CommandViewModel> commands)
        {
            // materialComboBoxCmdList.Items.Add(commands.First().Name);
        }

        /// <summary>
        /// ������ ������ ������
        /// </summary>
        /// <param name="templatesViewModel">������ �������</param>
        public void SetTemplateList(IEnumerable<TemplateViewModel> templatesViewModel)
        {
            if (this.dataGridViewTableTemplate.Rows.Count == 0) // ���� ������� �� ���������� �� �������
            {
                int counter = 0; // �������� ������� � ���'��

                while (templatesViewModel.Count() > counter)
                {
                    // �������� ����� � ����������� ��� ������
                    dataGridViewTableTemplate.Rows.Insert(IndexRowTemplateTable, 0, templatesViewModel.ElementAt(counter).FileName,
                        templatesViewModel.ElementAt(counter).DateModificationFile, templatesViewModel.ElementAt(counter).SizeFile);
                    // templatesViewModel.ElementAt(i).BookmarksFile
                    listTemplates.Add(templatesViewModel.ElementAt(counter)); // ������ �� ������ �������
                    // ������ ������ ���������� ������� � ����� "���������"
                    MaterialListBoxItem listBoxItem = new MaterialListBoxItem();
                    listBoxItem.Text = templatesViewModel.ElementAt(counter).FileName;
                    ListBoxGenSavedTemplates.Items.Add(listBoxItem);
                    ListBoxGenSavedTemplates.SelectedIndex = 0;
                    // �������� ������ �� ������ ������
                    this.ComboBoxCmdOutputTemplate.Items.Add(templatesViewModel.ElementAt(counter).FileName);
                    this.ComboBoxCmdOutputTemplate.SelectedIndex = 0;
                    IndexRowTemplateTable++; // ��������� ������� ����� ������� �������
                    counter++;
                }

            }
            else
            {   // ���� � ������� ��� ���������� �������

                // ������� ����� �� ������� � ����������� ��� ������
                dataGridViewTableTemplate.Rows.Insert(IndexRowTemplateTable, 0, templatesViewModel.Last().FileName,
                     templatesViewModel.Last().DateModificationFile, templatesViewModel.Last().SizeFile);
                IndexRowTemplateTable++;
                this.ComboBoxCmdOutputTemplate.Items.Add(templatesViewModel.Last().FileName);
                MaterialListBoxItem listBoxItem = new MaterialListBoxItem();
                listBoxItem.Text = templatesViewModel.Last().FileName;
                ListBoxGenSavedTemplates.Items.Add(listBoxItem);
                ListBoxGenSavedTemplates.SelectedIndex = 0;
            }

        }

        /// <summary>
        /// ������� �������� ��������
        /// (����: ��'� ��������, ��������: ��� ��������)
        /// </summary>
        /// <param name="dictionaryBookmarks">������� �������</param>
        public void SetBookmarksDictionary(IDictionary<string, string> dictionaryBookmarks)
        {   // �������� �� ��������� ������� ��������
            this.dataGridViewTableBookmarks.Rows.Clear();
            this.dataGridViewTableBookmarks.Refresh();
            foreach (var itemBookmarks in dictionaryBookmarks)
            {   // �������� ����� �� ������� ��������
                this.dataGridViewTableBookmarks.Rows.Add(0, itemBookmarks.Key, itemBookmarks.Value);
            }

        }
        /// <summary>
        /// �������� ����� ������� 
        /// �� ����������
        /// </summary>
        /// <param name="NameTemplate">����� �������</param>
        /// <returns>true - ���� ����� ��������, ��� false - ���� ����� ����������</returns>
        public bool checkNameTemplate(string NameTemplate)
        {
            if (string.IsNullOrEmpty(NameTemplate) || Path.GetExtension(NameTemplate) != ".docx")
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// �������� ������� �������� � ���������
        /// (���� - ����� ��������, �������� - ��� ����� (����� �� �������������))
        /// </summary>
        /// <param name="pathFile">���� �� �����</param>
        /// <returns></returns>
        public Dictionary<string, string> GetBookmarksFromDoc(string pathFile)
        {
            Document doc = new Document(pathFile);
            if (doc.Range.Bookmarks.Count == 0)
            {   // ���� � �������� ���� ��������
                CustomMessageBox.Show("������ �� ������ ��������! ������� �������� �� �������.", "�����������", MessageBoxButtons.OK);
                return null;
            }
            
            // ������� ��������
            Dictionary<string, string> dictionaryBookmarks = new Dictionary<string, string>();
            for (int i = 0; i < doc.Range.Bookmarks.Count; i++)
            {
                dictionaryBookmarks.Add(doc.Range.Bookmarks[i].Name, "�����");
            }
            return dictionaryBookmarks;
        }

        private void dataGridViewTableTemplate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {    // ����� ������� ������� �������
            string columnTableTemplate = dataGridViewTableTemplate.Columns[e.ColumnIndex].Name;

            if (columnTableTemplate == "DeleteTemplate")
            {
                if (this.dataGridViewTableTemplate.Rows[e.RowIndex].Cells[0].Value == null)
                {
                    CustomMessageBox.Show("�������� ������� ������ �� ��������� ����� ��� ������� ����� � ������.",
                        "��������� �������", MessageBoxButtons.OK);
                    return;
                }

                DialogResult dialogResult = CustomMessageBox.Show("�� �������, �� ������ �������� ������? ��������� ��������� ���������.",
               "��������� �������", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes) // ���� �������� ������
                {
                    if (dataGridViewTableTemplate.SelectedRows.Count == 0) // ���� ������ �� �������
                    {
                        CustomMessageBox.Show("��� ��������� ������� ������ � ������.", "��������� �������", MessageBoxButtons.OK);
                    }
                    else
                    {   // ���� ������ �������
                        int index = dataGridViewTableTemplate.CurrentCell.RowIndex;
                        listTemplates.RemoveAt(index);
                        this.dataGridViewTableTemplate.Rows.RemoveAt(index);
                        IndexRowTemplateTable--;
                        if (this.dataGridViewTableBookmarks.Rows.Count > 0)
                        {
                            this.dataGridViewTableBookmarks.Rows.Clear();
                            this.dataGridViewTableBookmarks.Refresh();
                        }

                        //// generator
                        // this.ComboBoxGenSavedTemplate.Items.RemoveAt(index);
                        this.ListBoxGenSavedTemplates.Items.RemoveAt(index);
                        this.dataGridViewGenSettingBookmarks.Rows.Clear();
                        this.dataGridViewTableBookmarks.Refresh();
                    }
                }
            }
        }

        /// <summary>
        /// ������ "������" (������)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void materialButtonAddTemplate_Click(object sender, EventArgs e)
        {
            // ������� �������� ���� � ������� ����� .docx
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Word|*.docx"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileInfo fileInfo = new FileInfo(ofd.FileName); // ����� �����
                DateTime modification = File.GetLastWriteTime(fileInfo.FullName); // ���� ����
                double sizeFileKb = fileInfo.Length / 1000; // ����� ����� � ��
                foreach (var item in listTemplates)
                {
                    if (fileInfo.Name == item.FileName) // ���� ���� ������ � ����� ������
                    {
                        CustomMessageBox.Show("������ �� ���� � ��������� ������.", "�����������", MessageBoxButtons.OK);
                        return;
                    }
                }
                Dictionary<string, string> dictionaryBookmarks = GetBookmarksFromDoc(fileInfo.FullName);
                // ������ ������ �� ������
                listTemplates.Add(new TemplateViewModel
                {
                    FileName = fileInfo.Name,
                    DateModificationFile = modification.ToString(),
                    SizeFile = sizeFileKb,
                    BookmarksFile = dictionaryBookmarks,
                    ContentFile = File.ReadAllBytes(fileInfo.FullName)
                });
                this.SetTemplateList(listTemplates);

            }
        }

        /// <summary>
        /// ������ "����������" (������)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void materialButtonEditTemplate_Click(object sender, EventArgs e)
        {
            if (dataGridViewTableTemplate.SelectedRows.Count == 0)
            {
                CustomMessageBox.Show("��� ����������� ������� ������ � ������.", "�����������", MessageBoxButtons.OK);
            }
            else
            {
                int indSelTemplate = dataGridViewTableTemplate.CurrentCell.RowIndex; // ������ ��������� �������
                var selectedTemplate = listTemplates[indSelTemplate]; // �������� ������
                // ����� ��� �����������
                FormEditTemplate formEditTemplate = new FormEditTemplate(selectedTemplate);
                formEditTemplate.ShowDialog();
                listTemplates[indSelTemplate] = formEditTemplate.Template; // ������� ��� ��� ������
                // ���������� ������� ��� �������
                this.dataGridViewTableTemplate.Rows[indSelTemplate].Cells[1].Value = listTemplates[indSelTemplate].FileName.ToString();
                this.dataGridViewTableTemplate.Rows[indSelTemplate].Cells[2].Value = listTemplates[indSelTemplate].DateModificationFile.ToString();
                this.SetBookmarksDictionary(listTemplates[indSelTemplate].BookmarksFile);

                this.ListBoxGenSavedTemplates.Items[indSelTemplate].Text = listTemplates[indSelTemplate].FileName.ToString();
            }

        }

        /// <summary>
        /// ������ "������" 
        /// (�������� �������� � �������)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void materialButtonReadTemplate_Click(object sender, EventArgs e)
        {
            if (dataGridViewTableTemplate.SelectedRows.Count == 0)
            {
                CustomMessageBox.Show("��� ����������� ������� ������ � ������.", "�����������", MessageBoxButtons.OK);
            }
            else
            {
                int index = dataGridViewTableTemplate.CurrentCell.RowIndex;
                if (listTemplates.Count() == 0)
                {
                    CustomMessageBox.Show("List template is empty.", "�����������", MessageBoxButtons.OK);

                }
                else
                    this.SetBookmarksDictionary(listTemplates[index].BookmarksFile);
            }
        }

        /// <summary>
        /// ���� "������ ������" (������� ��䳿)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void materialTextBoxSearchTemplate_TrailingIconClick(object sender, EventArgs e)
        {
            string nameTemplate = this.TextBoxSearchTemplate.Text;

            if (!checkNameTemplate(nameTemplate))
            {
                CustomMessageBox.Show("�������� ������� ����� �������! ����� ������� " + nameTemplate + " �� ������ .docx ���������.",
                    "����� �������", MessageBoxButtons.OK);
                return;
            }
            else
            {
                if (this.dataGridViewTableTemplate.Rows.Count == 0)
                {   // ���� ������� ������� ����
                    CustomMessageBox.Show("������� ��� ������ ������! ������� �������.", "����� �������", MessageBoxButtons.OK);
                    return;
                }

                int rowCount = dataGridViewTableTemplate.RowCount - 1;
                int i = 0; // �������� �����
                while (i <= rowCount)
                {
                    if (dataGridViewTableTemplate.Rows[i].Cells["NameFile"].Value.ToString() == nameTemplate)
                    {   // ������� ��������� ������
                        dataGridViewTableTemplate.CurrentCell = dataGridViewTableTemplate.Rows[i].Cells[0];
                        return;
                    }
                    i++;
                }
                CustomMessageBox.Show("������ � ������ " + nameTemplate + " �� ��������!", "����� �������", MessageBoxButtons.OK);

            }

        }

        private void dataGridViewTableTemplate_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {    // ��������� ����� ������� �������
            this.dataGridViewTableTemplate.Rows[e.RowIndex].Cells["NumberRows"].Value = (e.RowIndex + 1).ToString();
        }

        private void dataGridViewTableBookmarks_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {    // ��������� ����� ������� ��������
            this.dataGridViewTableBookmarks.Rows[e.RowIndex].Cells["ColumnNumber"].Value = (e.RowIndex + 1).ToString();
        }

        // Generator
        private void materialButtonSelectPathForSaved_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\Users";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                this.materialTextBoxPathForSaveDocument.Text = dialog.FileName;
            }
        }

        private void dataGridViewGenSettingBookmarks_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridViewGenSettingBookmarks.Rows[e.RowIndex].Cells["GenNumberRows"].Value = (e.RowIndex + 1).ToString();
        }

        private void dataGridViewGenSettingBookmarks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnTableBookmark = this.dataGridViewGenSettingBookmarks.Columns[e.ColumnIndex].Name;

            if (columnTableBookmark == "GenEnterData")
            {
                string typeData = Convert.ToString(dataGridViewGenSettingBookmarks.Rows[e.RowIndex].Cells[2].FormattedValue.ToString());
                // MessageBox.Show(materialComboBoxGenSavedTemplate.SelectedItem.ToString());

                if (typeData == "�����")
                {
                    string nameBookmark = dataGridViewGenSettingBookmarks.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    // MessageBox.Show("name bookmark: " + nameBoomark.ToString());
                    FormTextData formTextData = new FormTextData();
                    formTextData.ShowDialog();
                    // MessageBox.Show("text data: " + formTextData.TextData);
                    // fillTemplate.BookmarksFile[nameBookmark] = formTextData.TextData;

                }
                else if (typeData == "����������")
                {
                    FormImageData formImageData = new FormImageData();
                    formImageData.ShowDialog();
                }
                else if (typeData == "�������")
                {
                    FormTableData formTableData = new FormTableData();
                    formTableData.ShowDialog();
                    // string firstCell =  formTableData.tableData.arrayData[0, 0].ToString();
                    //MessageBox.Show("table data, [0,0]: " + firstCell);

                }
            }
        }

        private void materialButtonGenerateDocument_Click(object sender, EventArgs e)
        {
            string pathFile = this.materialButtonSelectPathForSaved.Text.ToString();
            string nameFile = this.materialTextBoxGenNameOutputDocument.Text.ToString();

        }


        private void materialTabControlGenSelectTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialTabControlGenSelectTemplate.SelectedTab == tabPageGenSaveTemplate)
            {
                this.dataGridViewGenSettingBookmarks.Refresh();
                // this.materialComboBoxGenSavedTemplate_SelectedValueChanged(sender, e);
                this.ListBoxGenSavedTemplates_SelectedValueChanged(sender, null);

            }
            else if (materialTabControlGenSelectTemplate.SelectedTab == tabPageGenLoadTemplate)
            {
                this.dataGridViewGenSettingBookmarks.Rows.Clear();
            }
        }

        private void ListBoxGenSavedTemplates_SelectedValueChanged(object sender, MaterialListBoxItem selectedItem)
        {
            int indexSelectedTemplate = ListBoxGenSavedTemplates.SelectedIndex;
            this.dataGridViewGenSettingBookmarks.Rows.Clear();
            this.dataGridViewGenSettingBookmarks.Refresh();

            int i = 0;
            foreach (var item in listTemplates.ElementAt(indexSelectedTemplate).BookmarksFile)
            {
                string val = item.Value.ToString();
                this.dataGridViewGenSettingBookmarks.Rows.Add(0, item.Key);
                this.dataGridViewGenSettingBookmarks.Rows[i].Cells[2].Value = val;
                cmbGenSetBookmark.DefaultCellStyle.NullValue = val;
                i++;
            }
        }


        // Command

        private void TextBoxCmdInputDocument_TrailingIconClick(object sender, EventArgs e)
        {
            //this.TextBoxCmdInputDocument.Text = "Input.docx";
            // ������� �������� ���� � ������� ����� .docx
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Word|*.docx"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileInfo fileInfo = new FileInfo(ofd.FileName);
                this.TextBoxCmdInputDocument.Text = fileInfo.Name;
                DateTime modification = File.GetLastWriteTime(fileInfo.FullName); // ���� ����
                double sizeFileKb = fileInfo.Length / 1000; // ����� ����� � ��
                Document doc = new Document(fileInfo.FullName);
                if (doc.Range.Bookmarks.Count == 0)
                {   // ���� � �������� ���� ��������
                    CustomMessageBox.Show("������ �� ������ ��������! ������� �������� �� �������.", "�����������", MessageBoxButtons.OK);
                    return;
                }
                // ������� ��������
                Dictionary<string, string> dictionaryBookmarks = new Dictionary<string, string>();
                for (int i = 0; i < doc.Range.Bookmarks.Count; i++)
                {
                    dictionaryBookmarks.Add(doc.Range.Bookmarks[i].Name, "�����");
                }
                cmdInputDoc.FileName = ofd.FileName;
                cmdInputDoc.BookmarksFile = dictionaryBookmarks;
                cmdInputDoc.SizeFile = sizeFileKb;
                cmdInputDoc.ContentFile = File.ReadAllBytes(fileInfo.FullName);
                

            }
        }


        private void ButtonCmdViewBookmark_Click(object sender, EventArgs e)
        {

            if (this.dataGridViewCmdBookmarkMatch.Rows.Count > 0)
            {
                DialogResult dialogResult = CustomMessageBox.Show("�������� ��� �������." +
                    " ���� �� �� �������� � �������� ����������� ������������� �������, �� ���� ������ �������. ����������?",
              "����� ��������", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.dataGridViewCmdBookmarkMatch.Rows.Clear();
                    this.dataGridViewCmdBookmarkMatch.Refresh();
                    // ����� ����� ��������
                }
                else
                {
                    return;
                }

            }
            else
            {
                int indexOutputTemplate = ComboBoxCmdOutputTemplate.SelectedIndex;

                foreach (var item in listTemplates.ElementAt(indexOutputTemplate).BookmarksFile)
                {
                    CmdInputBookmark.Items.Add(item.Key);
                    CmdOutputBookmark.Items.Add(item.Key);
                    // CmdOutputBookmark.DefaultCellStyle.NullValue = CmdOutputBookmark.Items[0].ToString();
                    this.dataGridViewCmdBookmarkMatch.Rows.Insert(0);
                    CmdOutputBookmark.DefaultCellStyle.NullValue = CmdOutputBookmark.Items[0].ToString();
                    CmdInputBookmark.DefaultCellStyle.NullValue = CmdOutputBookmark.Items[0].ToString();
                    // string val = item.Value.ToString();
                    // this.dataGridViewGenSettingBookmarks.Rows.Add(0, item.Key);
                    // this.dataGridViewGenSettingBookmarks.Rows[i].Cells[2].Value = val;
                    //// cmbGenSetBookmark.DefaultCellStyle.NullValue = val;

                }
            }
        }

        private void dataGridViewCmdBookmarkMatch_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridViewCmdBookmarkMatch.Rows[e.RowIndex].Cells["CmdNumberRow"].Value = (e.RowIndex + 1).ToString();
        }
    }
}

