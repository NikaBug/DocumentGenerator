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
        static public int IndexRowCommandTable = 0; // індекс рядка таблиці шаблонів
        static public int IndexRowTemplateTable = 0; // індекс рядка таблиці команд
        private DataGridViewComboBoxColumn cmbGenTypeDataBookmarks; // тип даних закладки [модуль генерації]
        private TemplateViewModel cmdInputDoc; // вхідний документ [модуль команд]
        private TemplateViewModel genInputTemplate; // вхідний шаблон [модуль генерації]
        private Dictionary<string, object> bookmarksData { get; set; } // дані закладок [модуль генерації]

        // події для шаблонів
        public event EventHandler? DeleteTemplate;
        public event EventHandler? SaveTemplate;
        public event EventHandler? UpdateTemplate;
        public event EventHandler<TemplateViewModel> GetTemplate;

        // події для команд
        public event EventHandler? SaveCommand;
        public event EventHandler? DeleteCommand;
        public event EventHandler<CommandViewModel>? GetCommand;
        public event EventHandler? UpdateCommand;

        // поля для представлення
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

            // [Модуль Генерації]
            // додати у стовпець таблиці закладок типи даних
            cmbGenTypeDataBookmarks = (DataGridViewComboBoxColumn)this.dataGridViewGenSettingBookmarks.Columns[2];
            cmbGenTypeDataBookmarks.Items.Add("Текст");
            cmbGenTypeDataBookmarks.Items.Add("Зображення");
            cmbGenTypeDataBookmarks.Items.Add("Таблиця");
            this.TextBoxCmdInputDocument.ReadOnly = true;

            this.bookmarksData = new Dictionary<string, object>();

            this.ComboBoxGenCommandList.Enabled = false;
            // [Модуль Команд]
            CmdInputBookmark = (DataGridViewComboBoxColumn)this.dataGridViewCmdBookmarkMatch.Columns[2];
            // представлення вхідного документа для команди
            this.cmdInputDoc = new TemplateViewModel();
        }

        /// <summary>
        /// Задати список команд
        /// </summary>
        /// <param name="commands">список команд</param>
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
                        templates.ElementAt(counter).FilePath);

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
            {
                // вставка рядка до таблиці з інформацією про шаблон
                dataGridViewTableTemplate.Rows.Insert(IndexRowTemplateTable, 0, templates.Last().FileName,
                     templates.Last().FilePath);
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
        /// [Модуль шаблонів]
        /// Показати закладки шаблону
        /// </summary>
        /// <param name="dictionaryBookmarks">словник закладок
        /// (ключ: ім'я закладки, значення: тип закладки)</param>
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
        private bool checkNameTemplate(string NameTemplate)
        {
            if (string.IsNullOrEmpty(NameTemplate) || Path.GetExtension(NameTemplate) != ".docx")
            {
                return false;
            }
            return true;
        }

        // перевірка чи знаходиться початок і кінець закладки
        // в одному TextBody (для таблиць)
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
        /// Отримати словник закладок з документу
        /// (ключ - назва закладки, значення - тип даних (текст за замовчуванням))
        /// </summary>
        /// <param name="pathFile">шлях до файлу</param>
        /// <returns></returns>
        private Dictionary<string, string> GetBookmarksFromDoc(string pathFile)
        {
            Document doc = new Document(pathFile);
            if (doc.Bookmarks.Count == 0)
            {
                CustomMessageBox.Show("Шаблон не містить закладок! Додайте закладки до шаблону.", "Повідомлення", MessageBoxButtons.OK);
                return null;
            }
            // словник закладок
            Dictionary<string, string> dictionaryBookmarks = new Dictionary<string, string>();
            for (int i = 0; i < doc.Bookmarks.Count; i++)
            {
                dictionaryBookmarks.Add(doc.Bookmarks[i].Name, "Текст");
            }
            return dictionaryBookmarks;
        }

        /// <summary>
        /// [Модуль шаблонів]
        /// Видалення шаблону
        /// </summary>
        private void dataGridViewTableTemplate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {    // назва стовпця таблиці шаблонів
            string columnTableTemplate = dataGridViewTableTemplate.Columns[e.ColumnIndex].Name;

            if (columnTableTemplate == "RemoveTemplate")
            {
                //if (this.dataGridViewTableTemplate.Rows[e.RowIndex].Cells[0].Value == null)
                //{
                //    CustomMessageBox.Show("Спочатку додайте шаблон до поточного рядка або виберіть інший зі списку.",
                //        "Видалення шаблону", MessageBoxButtons.OK);
                //    return;
                //}

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
        /// [Модуль шаблонів]
        /// Додавання шаблонів
        /// </summary>
        private void ButtonAddTemplate_Click(object sender, EventArgs e)
        {
            // відкрити діалогове вікно з вибором файлу .docx
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Word|*.docx"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileInfo fileInfo = new FileInfo(ofd.FileName); // назва файлу
                foreach (DataGridViewRow row in this.dataGridViewTableTemplate.Rows)
                {
                    string columnValue = row.Cells[1].Value.ToString() ?? throw new ArgumentNullException(); ;
                    if (columnValue == fileInfo.Name)
                    {
                        CustomMessageBox.Show("Шаблон має бути з унікальним іменем.", "Повідомлення", MessageBoxButtons.OK);
                        return;
                    }
                }

                templateViewModel = new TemplateViewModel();
                templateViewModel.FileName = fileInfo.Name;
                templateViewModel.FilePath = fileInfo.FullName;
                templateViewModel.ContentFile = File.ReadAllBytes(fileInfo.FullName);
                templateViewModel.BookmarksFile = GetBookmarksFromDoc(fileInfo.FullName);

                // збереження шаблона в пам'яті
                SaveTemplate?.Invoke(sender, e);

                // додати шаблон до списку для показу
                List<TemplateViewModel> templates = new List<TemplateViewModel>
                {
                    templateViewModel // Template
                };
                this.SetTemplateList(templates);
            }
        }

        /// <summary>
        /// [Модуль шаблонів]
        /// Редагування шаблона
        /// </summary>
        private void ButtonEditTemplate_Click(object sender, EventArgs e)
        {
            if (dataGridViewTableTemplate.SelectedRows.Count == 0)
            {
                CustomMessageBox.Show("Для редагування виберіть шаблон зі списку.", "Повідомлення", MessageBoxButtons.OK);
            }
            else
            {
                int indexTmp = dataGridViewTableTemplate.CurrentCell.RowIndex; // індекс вибраного шаблону
                // назва шаблона та шлях до файлу
                string templateName = this.dataGridViewTableTemplate.Rows[indexTmp].Cells[1].Value.ToString() ?? throw new ArgumentNullException();
                string templatePath = this.dataGridViewTableTemplate.Rows[indexTmp].Cells[2].Value.ToString() ?? throw new ArgumentNullException();

                List<string> namesTemplates = new List<string>();
                foreach (DataGridViewRow row in this.dataGridViewTableTemplate.Rows)
                {
                    string name = row.Cells[1].Value.ToString() ?? throw new ArgumentNullException();
                    if (name != templateName)
                        namesTemplates.Add(name);
                }

                // форма для редагування
                FormEditTemplate formEditTemplate = new FormEditTemplate(templateName,
                        this.GetBookmarksFromDoc(templatePath), namesTemplates);
                formEditTemplate.ShowDialog();
                if (!formEditTemplate.SavedChanges)
                    return;

                this.templateName = formEditTemplate.oldNameTemplate;
                templateViewModel = new TemplateViewModel();
                templateViewModel.FileName = formEditTemplate.newNameTemplate;
                templateViewModel.BookmarksFile = formEditTemplate.newBookmarksTemplate;

                // оновлення шаблону в пам'яті
                UpdateTemplate?.Invoke(sender, e);

                this.dataGridViewTableTemplate.Rows[indexTmp].Cells[1].Value = formEditTemplate.newNameTemplate;
                this.SetBookmarksDictionary(formEditTemplate.newBookmarksTemplate);

                this.ListBoxGenSavedTemplates.Items[indexTmp].Text = formEditTemplate.newNameTemplate;
                this.ComboBoxCmdOutputTemplate.Items[indexTmp] = formEditTemplate.newNameTemplate;
            }

        }

        /// <summary>
        /// [Модуль шаблонів]
        /// Читання шаблонів (відображення закладок)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonReadTemplate_Click(object sender, EventArgs e)
        {
            if (dataGridViewTableTemplate.SelectedRows.Count == 0)
            {
                CustomMessageBox.Show("Для редагування виберіть шаблон зі списку.", "Повідомлення", MessageBoxButtons.OK);
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
                    CustomMessageBox.Show("Шаблон не знайдено.", "Повідомлення", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// [Модуль шаблонів]
        /// Пошук шаблона за назвою
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxSearchTemplate_TrailingIconClick(object sender, EventArgs e)
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

        // =============== Модуль генерації ==================

        /// <summary>
        /// [Модуль генерації]
        /// Вибір шляху для збереження 
        /// сформованого документа
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
        /// [Модуль генерації]
        /// Завантаження шаблона
        /// </summary>
        private void TextBoxGenUploadTemplate_TrailingIconClick(object sender, EventArgs e)
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

                if (ListBoxGenSavedTemplates.Items.Count > 0)
                {
                    MaterialListBoxItem item = new MaterialListBoxItem();
                    item.Text = ofd.FileName;
                    var isContains = ListBoxGenSavedTemplates.Items.Contains(item);
                    if (isContains)
                    {
                        CustomMessageBox.Show("Назва шаблона не має співпадати з вже завантаженим шаблоном! Змініть назву одного з файлів.",
                                    "Завантаження шаблона", MessageBoxButtons.OK);
                        return;
                    }
                }

                this.TextBoxGenUploadTemplate.Text = fileInfo.Name;

                Document doc = new Document(fileInfo.FullName);
                if (doc.Bookmarks.Count == 0)
                {   // якщо в документі немає закладок
                    CustomMessageBox.Show("Шаблон не містить закладок! Додайте закладки до шаблону.",
                        "Завантаження шаблона", MessageBoxButtons.OK);
                    return;
                }

                // словник закладок
                Dictionary<string, string> dictionaryBookmarks = new Dictionary<string, string>();
                for (int i = 0; i < doc.Bookmarks.Count; i++)
                {
                    dictionaryBookmarks.Add(doc.Bookmarks[i].Name, "Текст");
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
        /// [Модуль генерації]
        /// Задання даних для закладок шаблона
        /// залежно від типу (текст, зображення, таблиця)
        /// </summary>
        private void dataGridViewGenSettingBookmarks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnTableBookmark = this.dataGridViewGenSettingBookmarks.Columns[e.ColumnIndex].Name;
            if (columnTableBookmark == "GenEnterData")
            {
                string typeData = dataGridViewGenSettingBookmarks.Rows[e.RowIndex].Cells[2].FormattedValue.ToString() 
                    ?? throw new ArgumentNullException();
                if (typeData == "Текст")
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
                else if (typeData == "Зображення")
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
                else if (typeData == "Таблиця")
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
        /// [Модуль генерації]
        /// Створення таблиці для
        /// вставки у Word документ
        /// </summary>
        /// <param name="document">документ</param>
        /// <param name="tableInsert">дані таблиці для заповнення</param>
        /// <returns>таблиця</returns>
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
        /// [Модуль генерації]
        /// Створення документа на основі шаблона
        /// </summary>
        private void ButtonGenerateDocument_Click(object sender, EventArgs e)
        {
            string pathFile = this.TextBoxGenPathSaveDocument.Text.ToString(); // шлях для збрежеження
            string nameFile = this.TextBoxGenNameOutputDocument.Text; // назва вихідного файлу

            if (string.IsNullOrEmpty(pathFile) || (checkNameTemplate(nameFile) == false)
                || (this.dataGridViewGenSettingBookmarks.Rows.Count == 0))
            {
                CustomMessageBox.Show("Документ не сформовано! Можливо, не вказаний шлях для збереження, " +
                    "або некорекна назва вихідного документа чи не показані закладки шаблона.", "Формування документа", MessageBoxButtons.OK);
                return;
            }
            else
            {
                if (SwitchGenUseCommand.Checked)
                {   // формування документа з використанням даних команди
                    int indexSelectedCommand = ComboBoxGenCommandList.SelectedIndex;
                    string nameSelectedCommand = ComboBoxGenCommandList.Items[indexSelectedCommand].ToString() 
                        ?? throw new ArgumentNullException();

                    this.commandViewModel = new CommandViewModel();
                    commandViewModel.NameCommand = nameSelectedCommand;
                    this.GetCommand?.Invoke(sender, viewCommand);

                    CustomMessageBox.Show("Назва: " + viewCommand.NameCommand + ", Вхідний документ: " +
                        viewCommand.InputTemplate.FileName + ", Вихідний шаблон: " + viewCommand.OutputTemplate.FileName,
                        "Вибрана команда", MessageBoxButtons.OK);

                    // вхідний документ
                    Document inputDocument = new Document();
                    MemoryStream streamInput = new MemoryStream(viewCommand.InputTemplate.ContentFile);
                    inputDocument.LoadFromStream(streamInput, FileFormat.Docx);

                    // вихідний шаблон
                    Document outputTemplate = new Document();
                    MemoryStream streamOutput = new MemoryStream(viewCommand.OutputTemplate.ContentFile);
                    outputTemplate.LoadFromStream(streamOutput, FileFormat.Docx);

                    // навігатори по закладкам вхідного документа та вихідного шаблона відповідно
                    BookmarksNavigator navigatorInput = new BookmarksNavigator(inputDocument);
                    BookmarksNavigator navigatorOutput = new BookmarksNavigator(outputTemplate);

                    foreach (var setting in viewCommand.CommandSetting)
                    {
                        navigatorInput.MoveToBookmark(setting.Value); // до вхідної закладки
                        TextBodyPart inTextBodyPart = navigatorInput.GetBookmarkContent();
                        navigatorOutput.MoveToBookmark(setting.Key); // до вихідної закладки
                        navigatorOutput.ReplaceBookmarkContent(inTextBodyPart); // замінити
                    }

                    string fullpath = pathFile + @"\" + nameFile;
                    outputTemplate.SaveToFile(fullpath, FileFormat.Docx);
                    CustomMessageBox.Show("Документ успішно створено! Шлях: " + fullpath,
                        "Формування документа", MessageBoxButtons.OK);
                }
                else
                {
                    Document inputTemplate = new Document();
                    if (materialTabControlGenSelectTemplate.SelectedTab == tabPageGenSaveTemplate)
                    {
                        //CustomMessageBox.Show("Ви вибрали шаблон зі списку збережених шаблонів", "Вибір шаблона", MessageBoxButtons.OK);
                        if (this.bookmarksData.Count != this.dataGridViewGenSettingBookmarks.Rows.Count)
                        {
                            CustomMessageBox.Show("Задайте дані для всіх закладок шаблона!",
                                "Формування документа", MessageBoxButtons.OK);
                            return;
                        }

                        int indexSelectedTemplate = ListBoxGenSavedTemplates.SelectedIndex;
                        this.templateViewModel = new TemplateViewModel();
                        templateViewModel.FileName = ListBoxGenSavedTemplates.Items[indexSelectedTemplate].Text;
                        this.GetTemplate.Invoke(sender, viewTemplate);

                        // bookmarksData: key - закладка, value - дані
                        MemoryStream streamInput = new MemoryStream(viewTemplate.ContentFile);
                        inputTemplate.LoadFromStream(streamInput, FileFormat.Docx);
                    }
                    else if (materialTabControlGenSelectTemplate.SelectedTab == tabPageGenLoadTemplate)
                    {
                        // CustomMessageBox.Show("Ви вибрали завантажений шаблон", "Вибір шаблона", MessageBoxButtons.OK);
                        if (string.IsNullOrEmpty(genInputTemplate.FileName))
                        {
                            CustomMessageBox.Show("Завантажте шаблон або виберіть зі списку збережених!",
                                "Вибір шаблона", MessageBoxButtons.OK);
                            return;
                        }
                        else if (this.bookmarksData.Count != this.dataGridViewGenSettingBookmarks.Rows.Count)
                        {
                            CustomMessageBox.Show("Задайте дані для всіх закладок шаблона!",
                                    "Формування документа", MessageBoxButtons.OK);
                            return;
                        }
                        MemoryStream streamInput = new MemoryStream(genInputTemplate.ContentFile);
                        inputTemplate.LoadFromStream(streamInput, FileFormat.Docx);
                    }

                    BookmarksNavigator navigatorInput = new BookmarksNavigator(inputTemplate);

                    foreach (var item in bookmarksData)
                    {
                        navigatorInput.MoveToBookmark(item.Key);
                        if (item.Value.GetType() == typeof(string)) // якщо дані текст
                        {
                            if (navigatorInput.GetBookmarkContent() != null)
                            {
                                navigatorInput.ReplaceBookmarkContent(item.Value.ToString(), true);
                            }
                            else
                                navigatorInput.InsertText(item.Value.ToString());
                        }
                        else if (item.Value.GetType() == typeof(System.Drawing.Bitmap)) // якщо дані зображення
                        {
                            Section section0 = inputTemplate.AddSection();
                            Paragraph paragraph = section0.AddParagraph();
                            paragraph.AppendPicture((System.Drawing.Image)item.Value);
                            // navigatorInput.InsertParagraph(paragraph);
                            TextBodyPart textBodyPart = new TextBodyPart(inputTemplate);
                            textBodyPart.BodyItems.Add(paragraph);
                            navigatorInput.ReplaceBookmarkContent(textBodyPart);
                        }
                        else if (item.Value.GetType() == typeof(TableData)) // якщо дані таблиця
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
                    CustomMessageBox.Show("Документ успішно створено! Шлях: " + fullpath,
                        "Формування документа", MessageBoxButtons.OK);
                }
            }

        }
        
        /// <summary>
        /// [Модуль генерації]
        /// TabControl вибору шаблона
        /// серед збережених або завантажити
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
                    var result = CustomMessageBox.Show("Увага! Попередньо задані дані для закладок поточного шаблону буде видалено!" +
                        "Продовжити?", "Попередження", MessageBoxButtons.YesNo);
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
        /// [Модуль генерації]
        /// Список збережених шаблонів
        /// </summary>
        private void ListBoxGenSavedTemplates_SelectedValueChanged(object sender, MaterialListBoxItem selectedItem)
        {
            int indexSelectedTemplate = ListBoxGenSavedTemplates.SelectedIndex;
            if (bookmarksData.Count > 0)
            {
                var result = CustomMessageBox.Show("Увага! Попередньо задані дані для закладок поточного шаблону буде видалено!" +
                    " Продовжити?", "Попередження", MessageBoxButtons.YesNo);
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

            // отримати шаблон з бази даних
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


        // ============= Модуль команд ===============

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

                if (ComboBoxCmdOutputTemplate.Items.Count > 0)
                {
                    var isContains = ComboBoxCmdOutputTemplate.Items.Contains(ofd.FileName);
                    if (isContains)
                    {
                        CustomMessageBox.Show("Назва документа не має співпадати з вже завантаженим шаблоном! Змініть назву одного з файлів.",
                                    "Завантаження документа", MessageBoxButtons.OK);
                        return;
                    }
                }

                this.TextBoxCmdInputDocument.Text = fileInfo.Name;

                Document doc = new Document(fileInfo.FullName);
                if (doc.Bookmarks.Count == 0)
                {   // якщо в документі немає закладок
                    CustomMessageBox.Show("Шаблон не містить закладок! Додайте закладки до шаблону.", "Завантаження документа", MessageBoxButtons.OK);
                    return;
                }

                if (!checkIsSameTextBody(doc))
                {
                    CustomMessageBox.Show("Початок і кінець закладки має бути в одному текстовому тілі! " +
                        "Перевірте закладку до таблиці: початок має бути на один рядок вище таблиці, а кінець - нижче.",
                        "Завантаження документа",
                        MessageBoxButtons.OK);
                    this.TextBoxCmdInputDocument.Text = "";
                    return;
                }

                // словник закладок
                Dictionary<string, string> dictionaryBookmarks = new Dictionary<string, string>();
                for (int i = 0; i < doc.Bookmarks.Count; i++)
                {
                    dictionaryBookmarks.Add(doc.Bookmarks[i].Name, "Текст");
                }
                cmdInputDoc.FileName = fileInfo.Name;
                cmdInputDoc.BookmarksFile = dictionaryBookmarks;
                cmdInputDoc.FilePath = fileInfo.FullName;
                cmdInputDoc.ContentFile = File.ReadAllBytes(fileInfo.FullName);
            }
        }

        /// <summary>
        /// [Модуль команд]
        /// Показ закладок (налаштувань команди)
        /// </summary>
        private void ButtonCmdViewBookmark_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewCmdBookmarkMatch.Rows.Count > 0)
            {
                DialogResult dialogResult = CustomMessageBox.Show("Закладки вже показані." +
                    " Якщо ви не створили з наявними параметрами конвертування команду, то вони будуть видалені. Продовжити?",
              "Показ закладок", MessageBoxButtons.YesNo);
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
                    CustomMessageBox.Show("Спочатку завантажте заповнений шаблон!", "Показ закладок", MessageBoxButtons.OK);
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
                    CustomMessageBox.Show("Кількість закладок у вхідному документі та вихідному шаблоні має бути однакова! " +
                        "Вхідний документ має " + countInput.ToString() + " закладки(ок), а вихідний шаблон " + countOutput.ToString(),
                        "Показ закладок", MessageBoxButtons.OK);
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
        /// [Модуль команд]
        /// Створення команди
        /// </summary>
        private void ButtonCreateCommand_Click(object sender, EventArgs e)
        {
            string commandName = this.TextBoxCmdCommandName.Text;
            int indexOutputTemplate = ComboBoxCmdOutputTemplate.SelectedIndex;
            if(this.dataGridViewCmdBookmarkMatch.Rows.Count == 0) {
                CustomMessageBox.Show("Задайте налаштування команди!", "Створення команди", MessageBoxButtons.OK);
                return; 
            }

            if(this.dataGridViewTableBookmarks.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in this.dataGridViewTableCommand.Rows)
                {
                    string name = row.Cells[1].Value.ToString() ?? throw new ArgumentNullException();
                    if (commandName == name)
                    {
                        CustomMessageBox.Show("Команда з такою назвою вже існує!", "Створення команди", MessageBoxButtons.OK);
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
                    CustomMessageBox.Show("Назви вхідної та вихідної закладки не мають співпадати! Або виберіть закладку з іншою назвою, " +
                        " або змініть назву закладки в " + this.TextBoxCmdInputDocument.Text + " та завантажте його знову.",
                        "Створення команди", MessageBoxButtons.OK);
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
            // індекс стовпця таблиці команд
            string columnTableCommand = this.dataGridViewTableCommand.Columns[e.ColumnIndex].Name;

            if (columnTableCommand == "CmdDeleteCommand")
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
                    {   // видалення
                        int index = this.dataGridViewTableCommand.CurrentCell.RowIndex;
                        viewNameCommand = this.dataGridViewTableCommand.Rows[index].Cells[1].Value.ToString() ?? throw new ArgumentNullException();
                        commandViewModel = new CommandViewModel();
                        commandViewModel.NameCommand = viewNameCommand;

                        GetCommand?.Invoke(sender, viewCommand);
                        DeleteCommand?.Invoke(sender, e);

                        // видалення з таблиці
                        this.dataGridViewTableCommand.Rows.RemoveAt(index);
                        IndexRowCommandTable--;

                        // видалення зі списку команд у модулі генерації
                        this.ComboBoxGenCommandList.Items.RemoveAt(index);
                        this.ComboBoxGenCommandList.SelectedIndex = 0;
                    }

                }
            }

        }
        /// <summary>
        /// [Модуль генерації]
        /// Перемикач використання даних команди
        /// </summary>
        private void SwitchGenUseCommand_CheckedChanged(object sender, EventArgs e)
        {
            if (this.SwitchGenUseCommand.Checked)
                this.ComboBoxGenCommandList.Enabled = true;
            else
                this.ComboBoxGenCommandList.Enabled = false;
        }

        /// <summary>
        /// [Модуль команд]
        /// Редагування команди
        /// </summary>
        private void ButtonEditCommand_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewTableCommand.SelectedRows.Count == 0)
            {
                CustomMessageBox.Show("Для редагування виберіть команду з таблиці.", "Редагування команди", MessageBoxButtons.OK);
            }
            else
            {
                int indexCmd = this.dataGridViewTableCommand.CurrentCell.RowIndex; // індекс вибраної команди
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

