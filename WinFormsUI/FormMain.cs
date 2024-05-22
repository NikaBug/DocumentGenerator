using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.WindowsAPICodePack.Dialogs;
using Presentation.ViewModels;
using Presentation.Views;
using Spire.Doc;
using Spire.Doc.Documents;

namespace WinFormsUI
{
    public partial class FormMain : MaterialForm, IMainView
    {
        static public int IndexRowCommandTable = 0; // ������ ����� ������� �������
        static public int IndexRowTemplateTable = 0; // ������ ����� ������� ������
        private DataGridViewComboBoxColumn cmbGenTypeDataBookmarks; // ��� ����� �������� [������ ���������]
        private TemplateViewModel cmdInputDoc; // ������� �������� [������ ������]
        private TemplateViewModel genInputTemplate; // ������� ������ [������ ���������]
        private Dictionary<string, object> bookmarksData { get; set; } // ��� �������� [������ ���������]

        // ��䳿 ��� �������
        public event EventHandler? DeleteTemplate;
        public event EventHandler? SaveTemplate;
        public event EventHandler? UpdateTemplate;
        public event EventHandler<TemplateViewModel> GetTemplate;

        // ��䳿 ��� ������
        public event EventHandler? SaveCommand;
        public event EventHandler? DeleteCommand;
        public event EventHandler<CommandViewModel>? GetCommand;
        public event EventHandler? UpdateCommand;

        // ���� ��� �������������
        private string templateName;
        private string commandName;
        private TemplateViewModel templateViewModel;
        private CommandViewModel commandViewModel;

        public string viewNameTemplate { get => templateName; set => templateName = value; }
        public TemplateViewModel viewTemplate { get => templateViewModel; set => templateViewModel = value; }
        public CommandViewModel viewCommand { get => commandViewModel; set => commandViewModel = value; }
        public string viewNameCommand { get => commandName; set => commandName = value; }

        public FormMain()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            this.WindowState = FormWindowState.Maximized;

            // [������ ���������]
            // ������ � �������� ������� �������� ���� �����
            cmbGenTypeDataBookmarks = (DataGridViewComboBoxColumn)this.dataGridViewGenSettingBookmarks.Columns[2];
            cmbGenTypeDataBookmarks.Items.Add("�����");
            cmbGenTypeDataBookmarks.Items.Add("����������");
            cmbGenTypeDataBookmarks.Items.Add("�������");
            this.TextBoxCmdInputDocument.ReadOnly = true;

            this.bookmarksData = new Dictionary<string, object>();

            this.ComboBoxGenCommandList.Enabled = false;
            // [������ ������]
            CmdInputBookmark = (DataGridViewComboBoxColumn)this.dataGridViewCmdBookmarkMatch.Columns[2];
            // ������������� �������� ��������� ��� �������
            this.cmdInputDoc = new TemplateViewModel();
        }

        /// <summary>
        /// ������ ������ ������
        /// </summary>
        /// <param name="commands">������ ������</param>
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
                        templates.ElementAt(counter).FilePath);

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
            {
                // ������� ����� �� ������� � ����������� ��� ������
                dataGridViewTableTemplate.Rows.Insert(IndexRowTemplateTable, 0, templates.Last().FileName,
                     templates.Last().FilePath);
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
        /// [������ �������]
        /// �������� �������� �������
        /// </summary>
        /// <param name="dictionaryBookmarks">������� ��������
        /// (����: ��'� ��������, ��������: ��� ��������)</param>
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
        private bool checkNameTemplate(string NameTemplate)
        {
            if (string.IsNullOrEmpty(NameTemplate) || Path.GetExtension(NameTemplate) != ".docx")
            {
                return false;
            }
            return true;
        }

        // �������� �� ����������� ������� � ����� ��������
        // � ������ TextBody (��� �������)
        private bool checkIsSameTextBody(Document doc)
        {
            foreach (Bookmark bookmark in doc.Bookmarks)
            {
                var start = bookmark.BookmarkStart.OwnerParagraph.OwnerTextBody;
                var end = bookmark.BookmarkEnd.OwnerParagraph.OwnerTextBody;
                if (!object.Equals(start, end))
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
        private Dictionary<string, string> GetBookmarksFromDoc(string pathFile)
        {
            Document doc = new Document(pathFile);
            if (doc.Bookmarks.Count == 0)
            {
                CustomMessageBox.Show("������ �� ������ ��������! ������� �������� �� �������.", "�����������", MessageBoxButtons.OK);
                return null;
            }
            // ������� ��������
            Dictionary<string, string> dictionaryBookmarks = new Dictionary<string, string>();
            for (int i = 0; i < doc.Bookmarks.Count; i++)
            {
                dictionaryBookmarks.Add(doc.Bookmarks[i].Name, "�����");
            }
            return dictionaryBookmarks;
        }

        /// <summary>
        /// [������ �������]
        /// ��������� �������
        /// </summary>
        private void dataGridViewTableTemplate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {    // ����� ������� ������� �������
            string columnTableTemplate = dataGridViewTableTemplate.Columns[e.ColumnIndex].Name;

            if (columnTableTemplate == "RemoveTemplate")
            {
                //if (this.dataGridViewTableTemplate.Rows[e.RowIndex].Cells[0].Value == null)
                //{
                //    CustomMessageBox.Show("�������� ������� ������ �� ��������� ����� ��� ������� ����� � ������.",
                //        "��������� �������", MessageBoxButtons.OK);
                //    return;
                //}

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
                        templateName = dataGridViewTableTemplate.Rows[index].Cells[1].Value.ToString() ?? throw new ArgumentNullException();
                        DeleteTemplate?.Invoke(sender, e);

                        this.dataGridViewTableTemplate.Rows.RemoveAt(index);
                        IndexRowTemplateTable--;
                        if (this.dataGridViewTableBookmarks.Rows.Count > 0)
                        {
                            this.dataGridViewTableBookmarks.Rows.Clear();
                            this.dataGridViewTableBookmarks.Refresh();
                        }

                        this.ListBoxGenSavedTemplates.Items.RemoveAt(index);
                        // +
                        //this.ListBoxGenSavedTemplates.SelectedIndex = index > 0 ? index - 1 : 0;

                        this.dataGridViewGenSettingBookmarks.Rows.Clear();
                        this.dataGridViewGenSettingBookmarks.Refresh();

                        this.ComboBoxCmdOutputTemplate.Items.RemoveAt(index);
                    }
                }
            }
        }

        /// <summary>
        /// [������ �������]
        /// ��������� �������
        /// </summary>
        private void ButtonAddTemplate_Click(object sender, EventArgs e)
        {
            // ������� �������� ���� � ������� ����� .docx
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Word|*.docx"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileInfo fileInfo = new FileInfo(ofd.FileName); // ����� �����
                foreach (DataGridViewRow row in this.dataGridViewTableTemplate.Rows)
                {
                    string columnValue = row.Cells[1].Value.ToString() ?? throw new ArgumentNullException(); ;
                    if (columnValue == fileInfo.Name)
                    {
                        CustomMessageBox.Show("������ �� ���� � ��������� ������.", "�����������", MessageBoxButtons.OK);
                        return;
                    }
                }

                templateViewModel = new TemplateViewModel();
                templateViewModel.FileName = fileInfo.Name;
                templateViewModel.FilePath = fileInfo.FullName;
                templateViewModel.ContentFile = File.ReadAllBytes(fileInfo.FullName);
                templateViewModel.BookmarksFile = GetBookmarksFromDoc(fileInfo.FullName);

                // ���������� ������� � ���'��
                SaveTemplate?.Invoke(sender, e);

                // ������ ������ �� ������ ��� ������
                List<TemplateViewModel> templates = new List<TemplateViewModel>
                {
                    templateViewModel // Template
                };
                this.SetTemplateList(templates);
            }
        }

        /// <summary>
        /// [������ �������]
        /// ����������� �������
        /// </summary>
        private void ButtonEditTemplate_Click(object sender, EventArgs e)
        {
            if (dataGridViewTableTemplate.SelectedRows.Count == 0)
            {
                CustomMessageBox.Show("��� ����������� ������� ������ � ������.", "�����������", MessageBoxButtons.OK);
            }
            else
            {
                int indexTmp = dataGridViewTableTemplate.CurrentCell.RowIndex; // ������ ��������� �������
                // ����� ������� �� ���� �� �����
                string templateName = this.dataGridViewTableTemplate.Rows[indexTmp].Cells[1].Value.ToString() ?? throw new ArgumentNullException();
                string templatePath = this.dataGridViewTableTemplate.Rows[indexTmp].Cells[2].Value.ToString() ?? throw new ArgumentNullException();

                List<string> namesTemplates = new List<string>();
                foreach (DataGridViewRow row in this.dataGridViewTableTemplate.Rows)
                {
                    string name = row.Cells[1].Value.ToString() ?? throw new ArgumentNullException();
                    if (name != templateName)
                        namesTemplates.Add(name);
                }

                // ����� ��� �����������
                FormEditTemplate formEditTemplate = new FormEditTemplate(templateName,
                        this.GetBookmarksFromDoc(templatePath), namesTemplates);
                formEditTemplate.ShowDialog();
                if (!formEditTemplate.SavedChanges)
                    return;

                this.templateName = formEditTemplate.oldNameTemplate;
                templateViewModel = new TemplateViewModel();
                templateViewModel.FileName = formEditTemplate.newNameTemplate;
                templateViewModel.BookmarksFile = formEditTemplate.newBookmarksTemplate;

                // ��������� ������� � ���'��
                UpdateTemplate?.Invoke(sender, e);

                this.dataGridViewTableTemplate.Rows[indexTmp].Cells[1].Value = formEditTemplate.newNameTemplate;
                this.SetBookmarksDictionary(formEditTemplate.newBookmarksTemplate);

                this.ListBoxGenSavedTemplates.Items[indexTmp].Text = formEditTemplate.newNameTemplate;
                this.ComboBoxCmdOutputTemplate.Items[indexTmp] = formEditTemplate.newNameTemplate;
            }

        }

        /// <summary>
        /// [������ �������]
        /// ������� ������� (����������� ��������)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonReadTemplate_Click(object sender, EventArgs e)
        {
            if (dataGridViewTableTemplate.SelectedRows.Count == 0)
            {
                CustomMessageBox.Show("��� ����������� ������� ������ � ������.", "�����������", MessageBoxButtons.OK);
            }
            else
            {
                int index = dataGridViewTableTemplate.CurrentCell.RowIndex;
                string nameTemplate = this.dataGridViewTableTemplate.Rows[index].Cells[1].Value.ToString() ?? throw new ArgumentNullException();
                this.templateViewModel = new TemplateViewModel();
                templateViewModel.FileName = nameTemplate;
                GetTemplate?.Invoke(sender, viewTemplate);

                if (viewTemplate != null)
                    this.SetBookmarksDictionary(viewTemplate.BookmarksFile);
                else
                    CustomMessageBox.Show("������ �� ��������.", "�����������", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// [������ �������]
        /// ����� ������� �� ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxSearchTemplate_TrailingIconClick(object sender, EventArgs e)
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

        // =============== ������ ��������� ==================

        /// <summary>
        /// [������ ���������]
        /// ���� ����� ��� ���������� 
        /// ������������ ���������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSelectPathForSaved_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\Users";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                this.TextBoxGenPathSaveDocument.Text = dialog.FileName;
            }
        }

        private void dataGridViewGenSettingBookmarks_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridViewGenSettingBookmarks.Rows[e.RowIndex].Cells["GenNumberRows"].Value = (e.RowIndex + 1).ToString();
        }

        /// <summary>
        /// [������ ���������]
        /// ������������ �������
        /// </summary>
        private void TextBoxGenUploadTemplate_TrailingIconClick(object sender, EventArgs e)
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

                if (ListBoxGenSavedTemplates.Items.Count > 0)
                {
                    MaterialListBoxItem item = new MaterialListBoxItem();
                    item.Text = ofd.FileName;
                    var isContains = ListBoxGenSavedTemplates.Items.Contains(item);
                    if (isContains)
                    {
                        CustomMessageBox.Show("����� ������� �� �� ��������� � ��� ������������ ��������! ����� ����� ������ � �����.",
                                    "������������ �������", MessageBoxButtons.OK);
                        return;
                    }
                }

                this.TextBoxGenUploadTemplate.Text = fileInfo.Name;

                Document doc = new Document(fileInfo.FullName);
                if (doc.Bookmarks.Count == 0)
                {   // ���� � �������� ���� ��������
                    CustomMessageBox.Show("������ �� ������ ��������! ������� �������� �� �������.",
                        "������������ �������", MessageBoxButtons.OK);
                    return;
                }

                // ������� ��������
                Dictionary<string, string> dictionaryBookmarks = new Dictionary<string, string>();
                for (int i = 0; i < doc.Bookmarks.Count; i++)
                {
                    dictionaryBookmarks.Add(doc.Bookmarks[i].Name, "�����");
                }
                genInputTemplate = new TemplateViewModel();
                genInputTemplate.FileName = fileInfo.Name;
                genInputTemplate.BookmarksFile = dictionaryBookmarks;
                genInputTemplate.FilePath = fileInfo.FullName;
                genInputTemplate.ContentFile = File.ReadAllBytes(fileInfo.FullName);

                if (this.bookmarksData.Count > 0)
                    this.bookmarksData.Clear();
                this.dataGridViewGenSettingBookmarks.Rows.Clear();
                this.dataGridViewGenSettingBookmarks.Refresh();

                int indexRow = 0;
                foreach (var item in genInputTemplate.BookmarksFile)
                {
                    string val = item.Value;
                    this.dataGridViewGenSettingBookmarks.Rows.Add(0, item.Key);
                    this.dataGridViewGenSettingBookmarks.Rows[indexRow].Cells[2].Value = val;
                    cmbGenTypeDataBookmarks.DefaultCellStyle.NullValue = val;
                    indexRow++;
                }
            }
        }

        /// <summary>
        /// [������ ���������]
        /// ������� ����� ��� �������� �������
        /// ������� �� ���� (�����, ����������, �������)
        /// </summary>
        private void dataGridViewGenSettingBookmarks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnTableBookmark = this.dataGridViewGenSettingBookmarks.Columns[e.ColumnIndex].Name;
            if (columnTableBookmark == "GenEnterData")
            {
                string typeData = dataGridViewGenSettingBookmarks.Rows[e.RowIndex].Cells[2].FormattedValue.ToString() 
                    ?? throw new ArgumentNullException();
                if (typeData == "�����")
                {
                    string nameBookmark = dataGridViewGenSettingBookmarks.Rows[e.RowIndex].Cells[1].FormattedValue.ToString() 
                        ?? throw new ArgumentNullException();
                    FormTextData formTextData = new FormTextData();
                    formTextData.ShowDialog();
                    if (this.bookmarksData.ContainsKey(nameBookmark))
                    {
                        this.bookmarksData[nameBookmark] = formTextData.textData;
                    } else
                        this.bookmarksData.Add(nameBookmark, formTextData.textData);
                }
                else if (typeData == "����������")
                {
                    string nameBookmark = dataGridViewGenSettingBookmarks.Rows[e.RowIndex].Cells[1].FormattedValue.ToString() 
                        ?? throw new ArgumentNullException();
                    FormImageData formImageData = new FormImageData();
                    formImageData.ShowDialog();
                    if (this.bookmarksData.ContainsKey(nameBookmark))
                    {
                        this.bookmarksData[nameBookmark] = formImageData.imageData;
                    } else
                        this.bookmarksData.Add(nameBookmark, formImageData.imageData);
                }
                else if (typeData == "�������")
                {
                    string nameBookmark = dataGridViewGenSettingBookmarks.Rows[e.RowIndex].Cells[1].FormattedValue.ToString() 
                        ?? throw new ArgumentNullException(); ;
                    FormTableData formTableData = new FormTableData();
                    formTableData.ShowDialog();
                    if (this.bookmarksData.ContainsKey(nameBookmark))
                    {
                        this.bookmarksData[nameBookmark] = formTableData.tableData;
                    } else
                        this.bookmarksData.Add(nameBookmark, formTableData.tableData);
                }
            }
        }

        /// <summary>
        /// [������ ���������]
        /// ��������� ������� ���
        /// ������� � Word ��������
        /// </summary>
        /// <param name="document">��������</param>
        /// <param name="tableInsert">��� ������� ��� ����������</param>
        /// <returns>�������</returns>
        Table CreateTableForWord(Document document, TableData tableInsert)
        {
            Table table = new Table(document, true);
            table.ResetCells(tableInsert.numberRows, tableInsert.numberColumns);
            for (int i = 0; i < tableInsert.numberRows; i++)
            {
                TableRow row = table.Rows[i];
                for (int j = 0; j < tableInsert.numberColumns; j++)
                {
                    TableCell cell = row.Cells[j];
                    Paragraph para = cell.AddParagraph();
                    para.AppendText(tableInsert.arrayData[i, j]);
                }
            }
            return table;
        }

        /// <summary>
        /// [������ ���������]
        /// ��������� ��������� �� ����� �������
        /// </summary>
        private void ButtonGenerateDocument_Click(object sender, EventArgs e)
        {
            string pathFile = this.TextBoxGenPathSaveDocument.Text.ToString(); // ���� ��� �����������
            string nameFile = this.TextBoxGenNameOutputDocument.Text; // ����� ��������� �����

            if (string.IsNullOrEmpty(pathFile) || (checkNameTemplate(nameFile) == false)
                || (this.dataGridViewGenSettingBookmarks.Rows.Count == 0))
            {
                CustomMessageBox.Show("�������� �� ����������! �������, �� �������� ���� ��� ����������, " +
                    "��� ��������� ����� ��������� ��������� �� �� ������� �������� �������.", "���������� ���������", MessageBoxButtons.OK);
                return;
            }
            else
            {
                if (SwitchGenUseCommand.Checked)
                {   // ���������� ��������� � ������������� ����� �������
                    int indexSelectedCommand = ComboBoxGenCommandList.SelectedIndex;
                    string nameSelectedCommand = ComboBoxGenCommandList.Items[indexSelectedCommand].ToString() 
                        ?? throw new ArgumentNullException();

                    this.commandViewModel = new CommandViewModel();
                    commandViewModel.NameCommand = nameSelectedCommand;
                    this.GetCommand?.Invoke(sender, viewCommand);

                    CustomMessageBox.Show("�����: " + viewCommand.NameCommand + ", ������� ��������: " +
                        viewCommand.InputTemplate.FileName + ", �������� ������: " + viewCommand.OutputTemplate.FileName,
                        "������� �������", MessageBoxButtons.OK);

                    // ������� ��������
                    Document inputDocument = new Document();
                    MemoryStream streamInput = new MemoryStream(viewCommand.InputTemplate.ContentFile);
                    inputDocument.LoadFromStream(streamInput, FileFormat.Docx);

                    // �������� ������
                    Document outputTemplate = new Document();
                    MemoryStream streamOutput = new MemoryStream(viewCommand.OutputTemplate.ContentFile);
                    outputTemplate.LoadFromStream(streamOutput, FileFormat.Docx);

                    // ��������� �� ��������� �������� ��������� �� ��������� ������� ��������
                    BookmarksNavigator navigatorInput = new BookmarksNavigator(inputDocument);
                    BookmarksNavigator navigatorOutput = new BookmarksNavigator(outputTemplate);

                    foreach (var setting in viewCommand.CommandSetting)
                    {
                        navigatorInput.MoveToBookmark(setting.Value); // �� ������ ��������
                        TextBodyPart inTextBodyPart = navigatorInput.GetBookmarkContent();
                        navigatorOutput.MoveToBookmark(setting.Key); // �� ������� ��������
                        navigatorOutput.ReplaceBookmarkContent(inTextBodyPart); // �������
                    }

                    string fullpath = pathFile + @"\" + nameFile;
                    outputTemplate.SaveToFile(fullpath, FileFormat.Docx);
                    CustomMessageBox.Show("�������� ������ ��������! ����: " + fullpath,
                        "���������� ���������", MessageBoxButtons.OK);
                }
                else
                {
                    Document inputTemplate = new Document();
                    if (materialTabControlGenSelectTemplate.SelectedTab == tabPageGenSaveTemplate)
                    {
                        //CustomMessageBox.Show("�� ������� ������ � ������ ���������� �������", "���� �������", MessageBoxButtons.OK);
                        if (this.bookmarksData.Count != this.dataGridViewGenSettingBookmarks.Rows.Count)
                        {
                            CustomMessageBox.Show("������� ��� ��� ��� �������� �������!",
                                "���������� ���������", MessageBoxButtons.OK);
                            return;
                        }

                        int indexSelectedTemplate = ListBoxGenSavedTemplates.SelectedIndex;
                        this.templateViewModel = new TemplateViewModel();
                        templateViewModel.FileName = ListBoxGenSavedTemplates.Items[indexSelectedTemplate].Text;
                        this.GetTemplate.Invoke(sender, viewTemplate);

                        // bookmarksData: key - ��������, value - ���
                        MemoryStream streamInput = new MemoryStream(viewTemplate.ContentFile);
                        inputTemplate.LoadFromStream(streamInput, FileFormat.Docx);
                    }
                    else if (materialTabControlGenSelectTemplate.SelectedTab == tabPageGenLoadTemplate)
                    {
                        // CustomMessageBox.Show("�� ������� ������������ ������", "���� �������", MessageBoxButtons.OK);
                        if (string.IsNullOrEmpty(genInputTemplate.FileName))
                        {
                            CustomMessageBox.Show("���������� ������ ��� ������� � ������ ����������!",
                                "���� �������", MessageBoxButtons.OK);
                            return;
                        }
                        else if (this.bookmarksData.Count != this.dataGridViewGenSettingBookmarks.Rows.Count)
                        {
                            CustomMessageBox.Show("������� ��� ��� ��� �������� �������!",
                                    "���������� ���������", MessageBoxButtons.OK);
                            return;
                        }
                        MemoryStream streamInput = new MemoryStream(genInputTemplate.ContentFile);
                        inputTemplate.LoadFromStream(streamInput, FileFormat.Docx);
                    }

                    BookmarksNavigator navigatorInput = new BookmarksNavigator(inputTemplate);

                    foreach (var item in bookmarksData)
                    {
                        navigatorInput.MoveToBookmark(item.Key);
                        if (item.Value.GetType() == typeof(string)) // ���� ��� �����
                        {
                            if (navigatorInput.GetBookmarkContent() != null)
                            {
                                navigatorInput.ReplaceBookmarkContent(item.Value.ToString(), true);
                            }
                            else
                                navigatorInput.InsertText(item.Value.ToString());
                        }
                        else if (item.Value.GetType() == typeof(System.Drawing.Bitmap)) // ���� ��� ����������
                        {
                            Section section0 = inputTemplate.AddSection();
                            Paragraph paragraph = section0.AddParagraph();
                            paragraph.AppendPicture((System.Drawing.Image)item.Value);
                            // navigatorInput.InsertParagraph(paragraph);
                            TextBodyPart textBodyPart = new TextBodyPart(inputTemplate);
                            textBodyPart.BodyItems.Add(paragraph);
                            navigatorInput.ReplaceBookmarkContent(textBodyPart);
                        }
                        else if (item.Value.GetType() == typeof(TableData)) // ���� ��� �������
                        {
                            Table table = CreateTableForWord(inputTemplate, (TableData)item.Value);
                            TextBodyPart part = new TextBodyPart(inputTemplate);
                            part.BodyItems.Add(table);
                            // navigatorInput.InsertTextBodyPart(part);
                            navigatorInput.ReplaceBookmarkContent(part);
                        }
                    }

                    string fullpath = pathFile + @"\" + nameFile;
                    inputTemplate.SaveToFile(fullpath, FileFormat.Docx);
                    CustomMessageBox.Show("�������� ������ ��������! ����: " + fullpath,
                        "���������� ���������", MessageBoxButtons.OK);
                }
            }

        }
        
        /// <summary>
        /// [������ ���������]
        /// TabControl ������ �������
        /// ����� ���������� ��� �����������
        /// </summary>
        private void TabControlGenSelectTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialTabControlGenSelectTemplate.SelectedTab == tabPageGenSaveTemplate)
            {
                if (this.dataGridViewTableTemplate.Rows.Count > 0)
                {
                    this.dataGridViewGenSettingBookmarks.Refresh();
                    this.ListBoxGenSavedTemplates_SelectedValueChanged(sender, null);
                }
            }
            else if (materialTabControlGenSelectTemplate.SelectedTab == tabPageGenLoadTemplate)
            {
                if (bookmarksData.Count > 0)
                {
                    var result = CustomMessageBox.Show("�����! ���������� ����� ��� ��� �������� ��������� ������� ���� ��������!" +
                        "����������?", "������������", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                        this.bookmarksData.Clear();
                    else
                        return;
                }
                this.dataGridViewGenSettingBookmarks.Rows.Clear();
                this.TextBoxGenUploadTemplate.Text = string.Empty;
            }
        }

        /// <summary>
        /// [������ ���������]
        /// ������ ���������� �������
        /// </summary>
        private void ListBoxGenSavedTemplates_SelectedValueChanged(object sender, MaterialListBoxItem selectedItem)
        {
            int indexSelectedTemplate = ListBoxGenSavedTemplates.SelectedIndex;
            if (bookmarksData.Count > 0)
            {
                var result = CustomMessageBox.Show("�����! ���������� ����� ��� ��� �������� ��������� ������� ���� ��������!" +
                    " ����������?", "������������", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    this.bookmarksData.Clear();
                }
                else
                {
                    if (indexSelectedTemplate > 0)
                        ListBoxGenSavedTemplates.SelectedIndex = indexSelectedTemplate - 1;
                    return;
                }
            }

            this.dataGridViewGenSettingBookmarks.Rows.Clear();
            this.dataGridViewGenSettingBookmarks.Refresh();

            this.templateViewModel = new TemplateViewModel();
            templateViewModel.FileName = ListBoxGenSavedTemplates.Items[indexSelectedTemplate].Text;

            // �������� ������ � ���� �����
            this.GetTemplate.Invoke(sender, viewTemplate);

            int indexRow = 0;
            foreach (var item in viewTemplate.BookmarksFile)
            {
                string val = item.Value.ToString();
                this.dataGridViewGenSettingBookmarks.Rows.Add(0, item.Key);
                this.dataGridViewGenSettingBookmarks.Rows[indexRow].Cells[2].Value = val;
                cmbGenTypeDataBookmarks.DefaultCellStyle.NullValue = val;
                indexRow++;
            }
        }


        // ============= ������ ������ ===============

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

                if (ComboBoxCmdOutputTemplate.Items.Count > 0)
                {
                    var isContains = ComboBoxCmdOutputTemplate.Items.Contains(ofd.FileName);
                    if (isContains)
                    {
                        CustomMessageBox.Show("����� ��������� �� �� ��������� � ��� ������������ ��������! ����� ����� ������ � �����.",
                                    "������������ ���������", MessageBoxButtons.OK);
                        return;
                    }
                }

                this.TextBoxCmdInputDocument.Text = fileInfo.Name;

                Document doc = new Document(fileInfo.FullName);
                if (doc.Bookmarks.Count == 0)
                {   // ���� � �������� ���� ��������
                    CustomMessageBox.Show("������ �� ������ ��������! ������� �������� �� �������.", "������������ ���������", MessageBoxButtons.OK);
                    return;
                }

                if (!checkIsSameTextBody(doc))
                {
                    CustomMessageBox.Show("������� � ����� �������� �� ���� � ������ ���������� ��! " +
                        "�������� �������� �� �������: ������� �� ���� �� ���� ����� ���� �������, � ����� - �����.",
                        "������������ ���������",
                        MessageBoxButtons.OK);
                    this.TextBoxCmdInputDocument.Text = "";
                    return;
                }

                // ������� ��������
                Dictionary<string, string> dictionaryBookmarks = new Dictionary<string, string>();
                for (int i = 0; i < doc.Bookmarks.Count; i++)
                {
                    dictionaryBookmarks.Add(doc.Bookmarks[i].Name, "�����");
                }
                cmdInputDoc.FileName = fileInfo.Name;
                cmdInputDoc.BookmarksFile = dictionaryBookmarks;
                cmdInputDoc.FilePath = fileInfo.FullName;
                cmdInputDoc.ContentFile = File.ReadAllBytes(fileInfo.FullName);
            }
        }

        /// <summary>
        /// [������ ������]
        /// ����� �������� (����������� �������)
        /// </summary>
        private void ButtonCmdViewBookmark_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewCmdBookmarkMatch.Rows.Count > 0)
            {
                DialogResult dialogResult = CustomMessageBox.Show("�������� ��� �������." +
                    " ���� �� �� �������� � �������� ����������� ������������� �������, �� ���� ������ �������. ����������?",
              "����� ��������", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    CmdInputBookmark.Items.Clear();
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

                this.templateViewModel = new TemplateViewModel();
                string nameSelectedTemplate = ComboBoxCmdOutputTemplate.Items[indexOutputTemplate].ToString() 
                    ?? throw new ArgumentNullException();
                templateViewModel.FileName = nameSelectedTemplate;

                GetTemplate?.Invoke(sender, viewTemplate);

                int countOutput = viewTemplate.BookmarksFile.Count;
                int countInput = cmdInputDoc.BookmarksFile.Count();
                if (countOutput != countInput)
                {
                    CustomMessageBox.Show("ʳ������ �������� � �������� �������� �� ��������� ������ �� ���� ��������! " +
                        "������� �������� �� " + countInput.ToString() + " ��������(��), � �������� ������ " + countOutput.ToString(),
                        "����� ��������", MessageBoxButtons.OK);
                    return;
                }
                DataGridViewComboBoxColumn inputBookmarks = (DataGridViewComboBoxColumn)this.dataGridViewCmdBookmarkMatch.Columns[2];

                foreach (var input in cmdInputDoc.BookmarksFile.Keys)
                {
                    inputBookmarks.Items.Add(input);
                    inputBookmarks.DefaultCellStyle.NullValue = inputBookmarks.Items[0].ToString();
                }

                foreach (var output in viewTemplate.BookmarksFile.Keys)
                {
                    this.dataGridViewCmdBookmarkMatch.Rows.Add(0, output);
                }
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

        /// <summary>
        /// [������ ������]
        /// ��������� �������
        /// </summary>
        private void ButtonCreateCommand_Click(object sender, EventArgs e)
        {
            string commandName = this.TextBoxCmdCommandName.Text;
            int indexOutputTemplate = ComboBoxCmdOutputTemplate.SelectedIndex;
            if(this.dataGridViewCmdBookmarkMatch.Rows.Count == 0) {
                CustomMessageBox.Show("������� ������������ �������!", "��������� �������", MessageBoxButtons.OK);
                return; 
            }

            if(this.dataGridViewTableBookmarks.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in this.dataGridViewTableCommand.Rows)
                {
                    string name = row.Cells[1].Value.ToString() ?? throw new ArgumentNullException();
                    if (commandName == name)
                    {
                        CustomMessageBox.Show("������� � ����� ������ ��� ����!", "��������� �������", MessageBoxButtons.OK);
                        return;
                    }
                }
            }
           
            Dictionary<string, string> cmdSetting = new Dictionary<string, string>();
            for (int indexRow = 0; indexRow < this.dataGridViewCmdBookmarkMatch.Rows.Count; indexRow++)
            {
                string OutputBookmark = this.dataGridViewCmdBookmarkMatch.Rows[indexRow].Cells[1].Value.ToString() ?? throw new ArgumentNullException();
                string InputBookmark = this.dataGridViewCmdBookmarkMatch.Rows[indexRow].Cells[2].FormattedValue.ToString() ?? throw new ArgumentNullException();
                if (string.Equals(OutputBookmark, InputBookmark))
                {
                    CustomMessageBox.Show("����� ������ �� ������� �������� �� ����� ���������! ��� ������� �������� � ����� ������, " +
                        " ��� ����� ����� �������� � " + this.TextBoxCmdInputDocument.Text + " �� ���������� ���� �����.",
                        "��������� �������", MessageBoxButtons.OK);
                    return;
                }

                cmdSetting.Add(OutputBookmark, InputBookmark);
            }

            this.templateViewModel = new TemplateViewModel();
            string nameSelectedTemplate = ComboBoxCmdOutputTemplate.Items[indexOutputTemplate].ToString() ?? throw new ArgumentNullException();
            templateViewModel.FileName = nameSelectedTemplate;

            GetTemplate?.Invoke(sender, viewTemplate);

            this.commandViewModel = new CommandViewModel();
            commandViewModel.NameCommand = commandName;
            commandViewModel.InputTemplate = cmdInputDoc;
            commandViewModel.OutputTemplate = viewTemplate;
            commandViewModel.CommandSetting = cmdSetting;

            SaveCommand?.Invoke(sender, e);

            List<CommandViewModel> command = new List<CommandViewModel>()
            { viewCommand };

            this.SetCommandsList(command);
        }

        private void dataGridViewTableCommand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // ������ ������� ������� ������
            string columnTableCommand = this.dataGridViewTableCommand.Columns[e.ColumnIndex].Name;

            if (columnTableCommand == "CmdDeleteCommand")
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
                    {   // ���������
                        int index = this.dataGridViewTableCommand.CurrentCell.RowIndex;
                        viewNameCommand = this.dataGridViewTableCommand.Rows[index].Cells[1].Value.ToString() ?? throw new ArgumentNullException();
                        commandViewModel = new CommandViewModel();
                        commandViewModel.NameCommand = viewNameCommand;

                        GetCommand?.Invoke(sender, viewCommand);
                        DeleteCommand?.Invoke(sender, e);

                        // ��������� � �������
                        this.dataGridViewTableCommand.Rows.RemoveAt(index);
                        IndexRowCommandTable--;

                        // ��������� � ������ ������ � ����� ���������
                        this.ComboBoxGenCommandList.Items.RemoveAt(index);
                        this.ComboBoxGenCommandList.SelectedIndex = 0;
                    }

                }
            }

        }
        /// <summary>
        /// [������ ���������]
        /// ��������� ������������ ����� �������
        /// </summary>
        private void SwitchGenUseCommand_CheckedChanged(object sender, EventArgs e)
        {
            if (this.SwitchGenUseCommand.Checked)
                this.ComboBoxGenCommandList.Enabled = true;
            else
                this.ComboBoxGenCommandList.Enabled = false;
        }

        /// <summary>
        /// [������ ������]
        /// ����������� �������
        /// </summary>
        private void ButtonEditCommand_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewTableCommand.SelectedRows.Count == 0)
            {
                CustomMessageBox.Show("��� ����������� ������� ������� � �������.", "����������� �������", MessageBoxButtons.OK);
            }
            else
            {
                int indexCmd = this.dataGridViewTableCommand.CurrentCell.RowIndex; // ������ ������� �������
                this.commandName = this.dataGridViewTableCommand.Rows[indexCmd].Cells[1].Value.ToString() ?? throw new ArgumentNullException();

                commandViewModel = new CommandViewModel();
                commandViewModel.NameCommand = commandName;

                GetCommand?.Invoke(sender, viewCommand);

                List<string> namesCommand = new List<string>();
                foreach (DataGridViewRow row in this.dataGridViewTableCommand.Rows)
                {
                    string name = row.Cells[1].Value.ToString() ?? throw new ArgumentNullException();
                    if (viewCommand.NameCommand != name)
                    {
                        namesCommand.Add(name);
                    }
                }

                FormEditCommand formEditCommand = new FormEditCommand(viewCommand.NameCommand, viewCommand.InputTemplate.BookmarksFile,
                    viewCommand.CommandSetting, namesCommand);
                formEditCommand.ShowDialog();
                if (!formEditCommand.SavedChanges)
                    return;

                commandViewModel = new CommandViewModel();
                commandViewModel.NameCommand = formEditCommand.newNameCommand;
                commandViewModel.CommandSetting = formEditCommand.newCommandSetting;
                UpdateCommand?.Invoke(sender, e);

                this.dataGridViewTableCommand.Rows[indexCmd].Cells[1].Value = viewCommand.NameCommand;
                this.ComboBoxGenCommandList.Items[indexCmd] = viewCommand.NameCommand;
            }
        }
    }
}

