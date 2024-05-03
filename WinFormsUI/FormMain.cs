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
        private List<TemplateViewModel> listTemplates; // список шаблонів
        private List<CommandViewModel> listCommands; // список команд
        static public int IndexRowCommandTable = 0; // індекс рядка таблиці шаблонів
        static public int IndexRowTemplateTable = 0; // індекс рядка таблиці команд
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
            cmbGenSetBookmark.Items.Add("Текст");
            cmbGenSetBookmark.Items.Add("Зображення");
            cmbGenSetBookmark.Items.Add("Таблиця");
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
            // генератор
            this.ComboBoxGenCommandList.Items.Add(commands.Last().NameCommand);
            this.ComboBoxGenCommandList.SelectedIndex = 0;
        }

        /// <summary>
        /// Задати список шабонів
        /// </summary>
        /// <param name="templates">список шаблонів</param>
        public void SetTemplateList(IEnumerable<TemplateViewModel> templates)
        {
            if (this.dataGridViewTableTemplate.Rows.Count == 0) // якщо шаблони не завантажені до таблиці
            {
                int counter = 0; // лічильник шаблонів в пам'яті

                while (templates.Count() > counter)
                {
                    // вставити рядок з інформацією про шаблон
                    dataGridViewTableTemplate.Rows.Insert(IndexRowTemplateTable, 0, templates.ElementAt(counter).FileName,
                        templates.ElementAt(counter).DateModificationFile, templates.ElementAt(counter).SizeFile);
                    // templatesViewModel.ElementAt(i).BookmarksFile
                    listTemplates.Add(templates.ElementAt(counter)); // додати до списку шаблонів
                    // додати списку збережених шаблонів в модулі "Генератор"
                    MaterialListBoxItem listBoxItem = new MaterialListBoxItem();
                    listBoxItem.Text = templates.ElementAt(counter).FileName;
                    ListBoxGenSavedTemplates.Items.Add(listBoxItem);
                    ListBoxGenSavedTemplates.SelectedIndex = 0;
                    // вихідний шаблон до модуля команд
                    this.ComboBoxCmdOutputTemplate.Items.Add(templates.ElementAt(counter).FileName);
                    this.ComboBoxCmdOutputTemplate.SelectedIndex = 0;
                    IndexRowTemplateTable++; // збільшення індекса рядка таблиці шаблонів
                    counter++;
                }

            }
            else
            {   // якщо в таблиці вже завантажені шаблони

                // вставка рядка до таблиці з інформацією про шаблон
                dataGridViewTableTemplate.Rows.Insert(IndexRowTemplateTable, 0, templates.Last().FileName,
                     templates.Last().DateModificationFile, templates.Last().SizeFile);
                IndexRowTemplateTable++;
                this.ComboBoxCmdOutputTemplate.Items.Add(templates.Last().FileName);
                // генератор
                MaterialListBoxItem listBoxItem = new MaterialListBoxItem();
                listBoxItem.Text = templates.Last().FileName;
                ListBoxGenSavedTemplates.Items.Add(listBoxItem);
                ListBoxGenSavedTemplates.SelectedIndex = 0;
            }

        }

        /// <summary>
        /// Задання словника закладок
        /// (ключ: ім'я закладки, значення: тип закладки)
        /// </summary>
        /// <param name="dictionaryBookmarks">словник закладо</param>
        public void SetBookmarksDictionary(IDictionary<string, string> dictionaryBookmarks)
        {   // очишення та оновлення таблиці закладок
            this.dataGridViewTableBookmarks.Rows.Clear();
            this.dataGridViewTableBookmarks.Refresh();
            foreach (var itemBookmarks in dictionaryBookmarks)
            {   // додаваня рядків до таблиці закладок
                this.dataGridViewTableBookmarks.Rows.Add(0, itemBookmarks.Key, itemBookmarks.Value);
            }

        }
        /// <summary>
        /// Перевірка назви шаблону 
        /// на коректність
        /// </summary>
        /// <param name="NameTemplate">назва шаблону</param>
        /// <returns>true - якщо назва коректна, або false - якщо назва некоректна</returns>
        public bool checkNameTemplate(string NameTemplate)
        {
            if (string.IsNullOrEmpty(NameTemplate) || Path.GetExtension(NameTemplate) != ".docx")
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Отримати словник закладок з документу
        /// (ключ - назва закладки, значення - тип даних (текст за замовчуванням))
        /// </summary>
        /// <param name="pathFile">шлях до файлу</param>
        /// <returns></returns>
        public Dictionary<string, string> GetBookmarksFromDoc(string pathFile)
        {
            Document doc = new Document(pathFile);
            if (doc.Range.Bookmarks.Count == 0)
            {   // якщо в документі немає закладок
                CustomMessageBox.Show("Шаблон не містить закладок! Додайте закладки до шаблону.", "Повідомлення", MessageBoxButtons.OK);
                return null;
            }

            // словник закладок
            Dictionary<string, string> dictionaryBookmarks = new Dictionary<string, string>();
            for (int i = 0; i < doc.Range.Bookmarks.Count; i++)
            {
                dictionaryBookmarks.Add(doc.Range.Bookmarks[i].Name, "Текст");
            }
            return dictionaryBookmarks;
        }

        /// <summary>
        /// [Модуль шаблонів]
        /// Видалення шаблону
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewTableTemplate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {    // назва стовпця таблиці шаблонів
            string columnTableTemplate = dataGridViewTableTemplate.Columns[e.ColumnIndex].Name;

            if (columnTableTemplate == "DeleteTemplate")
            {
                if (this.dataGridViewTableTemplate.Rows[e.RowIndex].Cells[0].Value == null)
                {
                    CustomMessageBox.Show("Спочатку додайте шаблон до поточного рядка або виберіть інший зі списку.",
                        "Видалення шаблону", MessageBoxButtons.OK);
                    return;
                }

                DialogResult dialogResult = CustomMessageBox.Show("Ви впевнені, що хочете видалити шаблон? Видалення скасувати неможливо.",
               "Видалення шаблону", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes) // якщо видалити шаблон
                {
                    if (dataGridViewTableTemplate.SelectedRows.Count == 0) // якщо шаблон не вибрано
                    {
                        CustomMessageBox.Show("Для видалення виберіть шаблон зі списку.", "Видалення шаблону", MessageBoxButtons.OK);
                    }
                    else
                    {   // якщо шаблон вибрано
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
        /// Кнопка "Додати" (шаблон)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void materialButtonAddTemplate_Click(object sender, EventArgs e)
        {
            // відкрити діалогове вікно з вибором файлу .docx
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Word|*.docx"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileInfo fileInfo = new FileInfo(ofd.FileName); // назва файлу
                DateTime modification = File.GetLastWriteTime(fileInfo.FullName); // дата зміни
                double sizeFileKb = fileInfo.Length / 1000; // розмір файлу в КБ
                foreach (var item in listTemplates)
                {
                    if (fileInfo.Name == item.FileName) // якщо існує шаблон з такою назвою
                    {
                        CustomMessageBox.Show("Шаблон має бути з унікальним іменем.", "Повідомлення", MessageBoxButtons.OK);
                        return;
                    }
                }
                Dictionary<string, string> dictionaryBookmarks = GetBookmarksFromDoc(fileInfo.FullName);
                // додати шаблон до списку
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
        /// [Модуль шаблонів]
        /// Редагування шаблона
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void materialButtonEditTemplate_Click(object sender, EventArgs e)
        {
            if (dataGridViewTableTemplate.SelectedRows.Count == 0)
            {
                CustomMessageBox.Show("Для редагування виберіть шаблон зі списку.", "Повідомлення", MessageBoxButtons.OK);
            }
            else
            {
                int indSelTemplate = dataGridViewTableTemplate.CurrentCell.RowIndex; // індекс вибраного шаблону
                var selectedTemplate = listTemplates[indSelTemplate]; // вибраний шаблон
                // форма для редагування
                FormEditTemplate formEditTemplate = new FormEditTemplate(selectedTemplate);
                formEditTemplate.ShowDialog();
                listTemplates[indSelTemplate] = formEditTemplate.Template; // оновити дані про шаблон
                // відобразити оновлені дані шаблону
                this.dataGridViewTableTemplate.Rows[indSelTemplate].Cells[1].Value = listTemplates[indSelTemplate].FileName.ToString();
                this.dataGridViewTableTemplate.Rows[indSelTemplate].Cells[2].Value = listTemplates[indSelTemplate].DateModificationFile.ToString();
                this.SetBookmarksDictionary(listTemplates[indSelTemplate].BookmarksFile);

                this.ListBoxGenSavedTemplates.Items[indSelTemplate].Text = listTemplates[indSelTemplate].FileName.ToString();
                this.ComboBoxCmdOutputTemplate.Items[indSelTemplate] = listTemplates[indSelTemplate].FileName.ToString();
            }

        }

        /// <summary>
        /// [Модуль шаблонів]
        /// Читання шаблонів (відображення закладок)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void materialButtonReadTemplate_Click(object sender, EventArgs e)
        {
            if (dataGridViewTableTemplate.SelectedRows.Count == 0)
            {
                CustomMessageBox.Show("Для редагування виберіть шаблон зі списку.", "Повідомлення", MessageBoxButtons.OK);
            }
            else
            {
                int index = dataGridViewTableTemplate.CurrentCell.RowIndex;
                if (listTemplates.Count() == 0)
                {
                    CustomMessageBox.Show("List template is empty.", "Повідомлення", MessageBoxButtons.OK);

                }
                else
                    this.SetBookmarksDictionary(listTemplates[index].BookmarksFile);
            }
        }

        /// <summary>
        /// [Модуль шаблонів]
        /// Пошук шаблона за назвою
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void materialTextBoxSearchTemplate_TrailingIconClick(object sender, EventArgs e)
        {
            string nameTemplate = this.TextBoxSearchTemplate.Text;

            if (!checkNameTemplate(nameTemplate))
            {
                CustomMessageBox.Show("Перевірте ведення назви шаблону! Назва шаблону " + nameTemplate + " має містити .docx наприкінці.",
                    "Пошук шаблону", MessageBoxButtons.OK);
                return;
            }
            else
            {
                if (this.dataGridViewTableTemplate.Rows.Count == 0)
                {   // якщо доданих шаблонів немає
                    CustomMessageBox.Show("Шаблони для пошуку відсутні! Додайте шаблони.", "Пошук шаблону", MessageBoxButtons.OK);
                    return;
                }

                int rowCount = dataGridViewTableTemplate.RowCount - 1;
                int i = 0; // лічильник рядків
                while (i <= rowCount)
                {
                    if (dataGridViewTableTemplate.Rows[i].Cells["NameFile"].Value.ToString() == nameTemplate)
                    {   // виділити знайдений шаблон
                        dataGridViewTableTemplate.CurrentCell = dataGridViewTableTemplate.Rows[i].Cells[0];
                        return;
                    }
                    i++;
                }
                CustomMessageBox.Show("Шаблон з назвою " + nameTemplate + " НЕ знайдено!", "Пошук шаблону", MessageBoxButtons.OK);

            }

        }

        private void dataGridViewTableTemplate_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {    // нумерація рядків таблиці шаблонів
            this.dataGridViewTableTemplate.Rows[e.RowIndex].Cells["NumberRows"].Value = (e.RowIndex + 1).ToString();
        }

        private void dataGridViewTableBookmarks_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {    // нумерація рядків таблиці закладок
            this.dataGridViewTableBookmarks.Rows[e.RowIndex].Cells["ColumnNumber"].Value = (e.RowIndex + 1).ToString();
        }

        // ----------- Generator -------------

        /// <summary>
        /// [Модуль генерації]
        /// Вибір шляху для збереження 
        /// сформованого документа
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

                if (typeData == "Текст")
                {
                    string nameBookmark = dataGridViewGenSettingBookmarks.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    // MessageBox.Show("name bookmark: " + nameBoomark.ToString());
                    FormTextData formTextData = new FormTextData();
                    formTextData.ShowDialog();
                    // MessageBox.Show("text data: " + formTextData.TextData);
                    // fillTemplate.BookmarksFile[nameBookmark] = formTextData.TextData;

                }
                else if (typeData == "Зображення")
                {
                    FormImageData formImageData = new FormImageData();
                    formImageData.ShowDialog();
                }
                else if (typeData == "Таблиця")
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
        /// [Модуль команд]
        /// завантажити вхідний документ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxCmdInputDocument_TrailingIconClick(object sender, EventArgs e)
        {
            // відкрити діалогове вікно з вибором файлу .docx
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Word|*.docx"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // інформація про файл
                FileInfo fileInfo = new FileInfo(ofd.FileName);
                if(listTemplates.Count() > 0)
                {
                    foreach (var item in listTemplates)
                    {
                        if(item.FileName == fileInfo.Name)
                        {
                            CustomMessageBox.Show("Назва документа не має співпадати з вже завантаженим шаблоном! Змініть назву одного з файлів.", 
                                "Завантаження документа", MessageBoxButtons.OK);
                            return;
                        }
                    }
                }

                this.TextBoxCmdInputDocument.Text = fileInfo.Name;
                DateTime modification = File.GetLastWriteTime(fileInfo.FullName); // дата зміни
                double sizeFileKb = fileInfo.Length / 1000; // розмір файлу в КБ

                Document doc = new Document(fileInfo.FullName);
                if (doc.Range.Bookmarks.Count == 0)
                {   // якщо в документі немає закладок
                    CustomMessageBox.Show("Шаблон не містить закладок! Додайте закладки до шаблону.", "Завантаження документа", MessageBoxButtons.OK);
                    return;
                }
                // словник закладок
                Dictionary<string, string> dictionaryBookmarks = new Dictionary<string, string>();
                for (int i = 0; i < doc.Range.Bookmarks.Count; i++)
                {
                    dictionaryBookmarks.Add(doc.Range.Bookmarks[i].Name, "Текст");
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
                DialogResult dialogResult = CustomMessageBox.Show("Закладки вже показані." +
                    " Якщо ви не створили з наявними параметрами конвертування команду, то вони будуть видалені. Продовжити?",
              "Показ закладок", MessageBoxButtons.YesNo);
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
                    CustomMessageBox.Show("Спочатку завантажте заповнений шаблон!", "Показ закладок", MessageBoxButtons.OK);
                    return;
                }

                int countOutput = listTemplates.ElementAt(indexOutputTemplate).BookmarksFile.Count();
                int countInput = cmdInputDoc.BookmarksFile.Count();
                if (countOutput != countInput)
                {

                    CustomMessageBox.Show("Кількість закладок у вхідному документі та вихідному шаблоні має бути однакова! " +
                        "Вхідний документ має " + countInput.ToString() + " закладки(ок), а вихідний шаблон " + countOutput.ToString(),
                        "Показ закладок", MessageBoxButtons.OK);
                    return;
                }

                DataGridViewComboBoxColumn outDocBookmarks = (DataGridViewComboBoxColumn)this.dataGridViewCmdBookmarkMatch.Columns[2];
            
                for(int i = 0; i < countInput; i++) // цикл по закладкам
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
                    CustomMessageBox.Show("Команда з такою назвою вже існує!", "Створення команди", MessageBoxButtons.OK);
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
            // індекс стовпця таблиці команд
            string columnTableCommand = this.dataGridViewTableCommand.Columns[e.ColumnIndex].Name;

            if(columnTableCommand == "CmdDeleteCommand")
            {
                DialogResult dialogResult = CustomMessageBox.Show("Ви впевнені, що хочете видалити команду? Видалення скасувати неможливо.",
                "Видалення команди", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) // якщо видалити команду
                {
                    if (this.dataGridViewTableCommand.SelectedRows.Count == 0) //
                    {
                        CustomMessageBox.Show("Для видалення виберіть команду зі списку.", "Видалення команди", MessageBoxButtons.OK);
                    }
                    else
                    {   // видалення з пам'яті
                        int index = this.dataGridViewTableCommand.CurrentCell.RowIndex;
                        listCommands.RemoveAt(index);
                        // видалення з таблиці
                        this.dataGridViewTableCommand.Rows.RemoveAt(index);
                        IndexRowCommandTable--;

                        //if(this.dataGridViewCmdBookmarkMatch.Rows.Count > 0)
                        //{
                        //    this.dataGridViewCmdBookmarkMatch.Rows.Clear();
                        //    this.dataGridViewCmdBookmarkMatch.Refresh();
                        //}


                        // видалення зі списку команд у модулі генерації
                        this.ComboBoxGenCommandList.Items.RemoveAt(index);
                    }

                }
            }

        }
    }
}

