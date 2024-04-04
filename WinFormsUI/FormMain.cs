using Aspose.Words;
using MaterialSkin;
using MaterialSkin.Controls;
using Presentation.ViewModels;
using Presentation.Views;
//using Syncfusion.DocIO;
//using Syncfusion.DocIO.DLS;

namespace WinFormsUI
{
    public partial class FormMain : MaterialForm, ICommandView, ITemplateView
    {
        private List<TemplateViewModel> listTemplates; // ������ �������
        static public int IndexRowTemplateTable = 0; // ������ ����� ������� �������

        public FormMain()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            this.WindowState = FormWindowState.Maximized;
            this.listTemplates = new List<TemplateViewModel>();
        }

        public void SetCommandsList(IEnumerable<CommandViewModel> commands)
        {
            materialComboBoxCmdList.Items.Add(commands.First().Name);
        }

        /// <summary>
        /// ������ ������ ������
        /// </summary>
        /// <param name="templatesViewModel">������ �������</param>
        public void SetTemplateList(IEnumerable<TemplateViewModel> templatesViewModel)
        {
            if (templatesViewModel.Count() == 0)
            {
                return;
            }
            else
            {   // ������� ����� �� ������� � ����������� ��� ������
                dataGridViewTableTemplate.Rows.Insert(IndexRowTemplateTable, 0, templatesViewModel.Last().FileName,
                templatesViewModel.Last().DateModificationFile, templatesViewModel.Last().SizeFile);
                IndexRowTemplateTable++;
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
                // ������ ������ �� ������
                listTemplates.Add(new TemplateViewModel
                {
                    FileName = fileInfo.Name,
                    DateModificationFile = modification.ToString(),
                    SizeFile = sizeFileKb,
                    BookmarksFile = dictionaryBookmarks
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
            string nameTemplate = this.materialTextBoxSearchTemplate.Text;

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


    }
}

