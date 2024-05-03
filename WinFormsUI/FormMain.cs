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
        private List<CommandViewModel> listCommands; // ������ ������
        static public int IndexRowCommandTable = 0; // ������ ����� ������� �������
        static public int IndexRowTemplateTable = 0; // ������ ����� ������� ������
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
            this.listCommands = new List<CommandViewModel>();

            //
            cmbGenSetBookmark = (DataGridViewComboBoxColumn)this.dataGridViewGenSettingBookmarks.Columns[2];
            cmbGenSetBookmark.Items.Add("�����");
            cmbGenSetBookmark.Items.Add("����������");
            cmbGenSetBookmark.Items.Add("�������");
            //this.materialButtonGenLoadTemplate.Enabled = false;
            //this.materialButtonGenRemoveLoadTemplate.Enabled = false;
            this.TextBoxCmdInputDocument.ReadOnly = true;
            //CmdInputBookmark = (DataGridViewComboBoxColumn)this.dataGridViewCmdBookmarkMatch.Columns[1];
            CmdOutputBookmark = (DataGridViewComboBoxColumn)this.dataGridViewCmdBookmarkMatch.Columns[2];
            this.cmdInputDoc = new TemplateViewModel();


        }

        public void SetCommandsList(IEnumerable<CommandViewModel> commands)
        {
            // materialComboBoxCmdList.Items.Add(commands.First().Name);
            this.dataGridViewTableCommand.Rows.Insert(IndexRowCommandTable, 0, commands.Last().NameCommand,
                commands.Last().InputTemplate.FileName, commands.Last().OutputTemplate.FileName);
            IndexRowCommandTable++;
            // ���������
            this.ComboBoxGenCommandList.Items.Add(commands.Last().NameCommand);
            this.ComboBoxGenCommandList.SelectedIndex = 0;
        }

        /// <summary>
        /// ������ ������ ������
        /// </summary>
        /// <param name="templates">������ �������</param>
        public void SetTemplateList(IEnumerable<TemplateViewModel> templates)
        {
            if (this.dataGridViewTableTemplate.Rows.Count == 0) // ���� ������� �� ���������� �� �������
            {
                int counter = 0; // �������� ������� � ���'��

                while (templates.Count() > counter)
                {
                    // �������� ����� � ����������� ��� ������
                    dataGridViewTableTemplate.Rows.Insert(IndexRowTemplateTable, 0, templates.ElementAt(counter).FileName,
                        templates.ElementAt(counter).DateModificationFile, templates.ElementAt(counter).SizeFile);
                    // templatesViewModel.ElementAt(i).BookmarksFile
                    listTemplates.Add(templates.ElementAt(counter)); // ������ �� ������ �������
                    // ������ ������ ���������� ������� � ����� "���������"
                    MaterialListBoxItem listBoxItem = new MaterialListBoxItem();
                    listBoxItem.Text = templates.ElementAt(counter).FileName;
                    ListBoxGenSavedTemplates.Items.Add(listBoxItem);
                    ListBoxGenSavedTemplates.SelectedIndex = 0;
                    // �������� ������ �� ������ ������
                    this.ComboBoxCmdOutputTemplate.Items.Add(templates.ElementAt(counter).FileName);
                    this.ComboBoxCmdOutputTemplate.SelectedIndex = 0;
                    IndexRowTemplateTable++; // ��������� ������� ����� ������� �������
                    counter++;
                }

            }
            else
            {   // ���� � ������� ��� ���������� �������

                // ������� ����� �� ������� � ����������� ��� ������
                dataGridViewTableTemplate.Rows.Insert(IndexRowTemplateTable, 0, templates.Last().FileName,
                     templates.Last().DateModificationFile, templates.Last().SizeFile);
                IndexRowTemplateTable++;
                this.ComboBoxCmdOutputTemplate.Items.Add(templates.Last().FileName);
                // ���������
                MaterialListBoxItem listBoxItem = new MaterialListBoxItem();
                listBoxItem.Text = templates.Last().FileName;
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

        /// <summary>
        /// [������ �������]
        /// ��������� �������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

                        this.ListBoxGenSavedTemplates.Items.RemoveAt(index);
                        this.dataGridViewGenSettingBookmarks.Rows.Clear();
                        this.dataGridViewGenSettingBookmarks.Refresh();

                        this.ComboBoxCmdOutputTemplate.Items.RemoveAt(index);
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
        /// [������ �������]
        /// ����������� �������
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
                this.ComboBoxCmdOutputTemplate.Items[indSelTemplate] = listTemplates[indSelTemplate].FileName.ToString();
            }

        }

        /// <summary>
        /// [������ �������]
        /// ������� ������� (����������� ��������)
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
        /// [������ �������]
        /// ����� ������� �� ������
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

        // ----------- Generator -------------

        /// <summary>
        /// [������ ���������]
        /// ���� ����� ��� ���������� 
        /// ������������ ���������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        // ----------- Command -------------

        /// <summary>
        /// [������ ������]
        /// ����������� ������� ��������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxCmdInputDocument_TrailingIconClick(object sender, EventArgs e)
        {
            // ������� �������� ���� � ������� ����� .docx
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Word|*.docx"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // ���������� ��� ����
                FileInfo fileInfo = new FileInfo(ofd.FileName);
                if(listTemplates.Count() > 0)
                {
                    foreach (var item in listTemplates)
                    {
                        if(item.FileName == fileInfo.Name)
                        {
                            CustomMessageBox.Show("����� ��������� �� �� ��������� � ��� ������������ ��������! ����� ����� ������ � �����.", 
                                "������������ ���������", MessageBoxButtons.OK);
                            return;
                        }
                    }
                }

                this.TextBoxCmdInputDocument.Text = fileInfo.Name;
                DateTime modification = File.GetLastWriteTime(fileInfo.FullName); // ���� ����
                double sizeFileKb = fileInfo.Length / 1000; // ����� ����� � ��

                Document doc = new Document(fileInfo.FullName);
                if (doc.Range.Bookmarks.Count == 0)
                {   // ���� � �������� ���� ��������
                    CustomMessageBox.Show("������ �� ������ ��������! ������� �������� �� �������.", "������������ ���������", MessageBoxButtons.OK);
                    return;
                }
                // ������� ��������
                Dictionary<string, string> dictionaryBookmarks = new Dictionary<string, string>();
                for (int i = 0; i < doc.Range.Bookmarks.Count; i++)
                {
                    dictionaryBookmarks.Add(doc.Range.Bookmarks[i].Name, "�����");
                }
                cmdInputDoc.FileName = fileInfo.Name;
                cmdInputDoc.BookmarksFile = dictionaryBookmarks;
                cmdInputDoc.SizeFile = sizeFileKb;
                cmdInputDoc.DateModificationFile = modification.ToString();
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
                    CmdOutputBookmark.Items.Clear();
                    this.dataGridViewCmdBookmarkMatch.Rows.Clear();
                    this.dataGridViewCmdBookmarkMatch.Refresh();
                }
                else
                    return;
            }
            else
            {
                int indexOutputTemplate = ComboBoxCmdOutputTemplate.SelectedIndex;
                if (TextBoxCmdInputDocument.Text.Length == 0)
                {
                    CustomMessageBox.Show("�������� ���������� ���������� ������!", "����� ��������", MessageBoxButtons.OK);
                    return;
                }

                int countOutput = listTemplates.ElementAt(indexOutputTemplate).BookmarksFile.Count();
                int countInput = cmdInputDoc.BookmarksFile.Count();
                if (countOutput != countInput)
                {

                    CustomMessageBox.Show("ʳ������ �������� � �������� �������� �� ��������� ������ �� ���� ��������! " +
                        "������� �������� �� " + countInput.ToString() + " ��������(��), � �������� ������ " + countOutput.ToString(),
                        "����� ��������", MessageBoxButtons.OK);
                    return;
                }

                DataGridViewComboBoxColumn outDocBookmarks = (DataGridViewComboBoxColumn)this.dataGridViewCmdBookmarkMatch.Columns[2];
            
                for(int i = 0; i < countInput; i++) // ���� �� ���������
                {
                    outDocBookmarks.Items.Add(listTemplates.ElementAt(indexOutputTemplate).BookmarksFile.ElementAt(i).Key);
                    outDocBookmarks.DefaultCellStyle.NullValue = outDocBookmarks.Items[0].ToString();
                    this.dataGridViewCmdBookmarkMatch.Rows.Add(0, cmdInputDoc.BookmarksFile.ElementAt(i).Key);
                }

                this.ButtonCreateCommand.Enabled = true;
            }
        }

        private void dataGridViewCmdBookmarkMatch_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridViewCmdBookmarkMatch.Rows[e.RowIndex].Cells["CmdNumberRow"].Value = (e.RowIndex + 1).ToString();
        }

        private void dataGridViewTableCommand_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridViewTableCommand.Rows[e.RowIndex].Cells["CmdNumberRowCommand"].Value = (e.RowIndex + 1).ToString();
        }

        private void ButtonCreateCommand_Click(object sender, EventArgs e)
        {
            string commandName = this.TextBoxCmdCommandName.Text;
            int indexOutputTemplate = ComboBoxCmdOutputTemplate.SelectedIndex;

            foreach(var cmd in this.listCommands)
            {
                if(cmd.NameCommand == commandName)
                {
                    CustomMessageBox.Show("������� � ����� ������ ��� ����!", "��������� �������", MessageBoxButtons.OK);
                    return;
                }
            }

            Dictionary<string, string> cmdSetting = new Dictionary<string, string>();
            for (int indexRow = 0; indexRow < this.dataGridViewCmdBookmarkMatch.Rows.Count; indexRow++)
            {
                string InputBookmark = this.dataGridViewCmdBookmarkMatch.Rows[indexRow].Cells[1].Value.ToString();//this.dataGridViewCmdBookmarkMatch.Rows[indexRow].Cells[1].FormattedValue.ToString());
                string OutputBookmark = this.dataGridViewCmdBookmarkMatch.Rows[indexRow].Cells[2].FormattedValue.ToString();
                cmdSetting.Add(InputBookmark, OutputBookmark);
            }
            //  this.dataGridViewCmdBookmarkMatch.Columns[1].cel
            listCommands.Add(new CommandViewModel
            {
                NameCommand = commandName,
                InputTemplate = cmdInputDoc,
                OutputTemplate = listTemplates[indexOutputTemplate],
                CommandSetting = cmdSetting
            });

            this.SetCommandsList(listCommands);

        }

        private void dataGridViewTableCommand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // ������ ������� ������� ������
            string columnTableCommand = this.dataGridViewTableCommand.Columns[e.ColumnIndex].Name;

            if(columnTableCommand == "CmdDeleteCommand")
            {
                DialogResult dialogResult = CustomMessageBox.Show("�� �������, �� ������ �������� �������? ��������� ��������� ���������.",
                "��������� �������", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) // ���� �������� �������
                {
                    if (this.dataGridViewTableCommand.SelectedRows.Count == 0) //
                    {
                        CustomMessageBox.Show("��� ��������� ������� ������� � ������.", "��������� �������", MessageBoxButtons.OK);
                    }
                    else
                    {   // ��������� � ���'��
                        int index = this.dataGridViewTableCommand.CurrentCell.RowIndex;
                        listCommands.RemoveAt(index);
                        // ��������� � �������
                        this.dataGridViewTableCommand.Rows.RemoveAt(index);
                        IndexRowCommandTable--;

                        //if(this.dataGridViewCmdBookmarkMatch.Rows.Count > 0)
                        //{
                        //    this.dataGridViewCmdBookmarkMatch.Rows.Clear();
                        //    this.dataGridViewCmdBookmarkMatch.Refresh();
                        //}


                        // ��������� � ������ ������ � ����� ���������
                        this.ComboBoxGenCommandList.Items.RemoveAt(index);
                    }

                }
            }

        }
    }
}

