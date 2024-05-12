using MaterialSkin;
using MaterialSkin.Controls;

namespace WinFormsUI
{
    public partial class FormEditCommand : MaterialForm
    {

       // private string oldNameCommand;
        private Dictionary<string, string> newCmdSetting;
        private Dictionary<string, string> inputBookmarks;
        private List<string> NamesSavedCommands;

        public string newNameCommand { get => this.TextBoxNewNameCommand.Text; set => this.TextBoxNewNameCommand.Text = value; }
        public Dictionary<string, string> newCommandSetting { get => newCmdSetting; set => this.newCmdSetting = value; }

        private bool flagSave;
        public bool SavedChanges { get => flagSave; }

        public FormEditCommand(string oldCmdName, Dictionary<string, string> inputDocBookmarks, Dictionary<string, string> oldCmdSetting,
            List<string> namesSavedCommands)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            this.TextBoxNewNameCommand.Text = oldCmdName;
            this.inputBookmarks = inputDocBookmarks;
            this.flagSave = false;
            this.NamesSavedCommands = namesSavedCommands;



            // стовпець - вхідні закладки (документ)
            DataGridViewComboBoxColumn cmbColBookmarks = (DataGridViewComboBoxColumn)this.dataGridViewEditBookmarkMatch.Columns[2];

            for (int i = 0; i < inputDocBookmarks.Count; i++) // цикл по закладкам
            {
                string def = oldCmdSetting.ElementAt(i).Value; // назва вибраної раніше вхідної закладки (документ)
                // inputBookmarks: ключ - назва, value - тип
                cmbColBookmarks.Items.Add(inputBookmarks.ElementAt(i).Key); // назви вхідних закладок (документ)
                this.dataGridViewEditBookmarkMatch.Rows.Add(0, oldCmdSetting.ElementAt(i).Key);
                this.dataGridViewEditBookmarkMatch.Rows[i].Cells[2].Value = def;
                CmdEditInputBookmark.DefaultCellStyle.NullValue = def;
            }
        }

        private void dataGridViewEditBookmarkMatch_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridViewEditBookmarkMatch.Rows[e.RowIndex].Cells["CmdEditNumberRow"].Value = (e.RowIndex + 1).ToString();
        }

        private void ButtonSaveChangeCommand_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.TextBoxNewNameCommand.Text))
            {
                CustomMessageBox.Show("Перевірте ведену назву команди! Поле назви команди не має бути порожнім.",
                    "Редагування команди", MessageBoxButtons.OK);
                return;
            }
            else
            {
                foreach (var name in NamesSavedCommands)
                {
                    if (name == this.TextBoxNewNameCommand.Text)
                    {
                        CustomMessageBox.Show("Назва команди "
                         + this.TextBoxNewNameCommand.Text + " немає співпадати зі вже збереженими командами!",
                         "Редагування команди", MessageBoxButtons.OK);
                        return;
                    }
                }

                this.newCmdSetting = new Dictionary<string, string>();
                for (int indexRow = 0; indexRow < this.dataGridViewEditBookmarkMatch.Rows.Count; indexRow++)
                {
                    string outputBoookmark = this.dataGridViewEditBookmarkMatch.Rows[indexRow].Cells[1].Value.ToString();
                    string SelectedInputBookmark = this.dataGridViewEditBookmarkMatch.Rows[indexRow].Cells[2].FormattedValue.ToString();
                    newCmdSetting.Add(outputBoookmark, SelectedInputBookmark);
                }

                flagSave = true;

                this.Close();
            }
        }
    }
}
