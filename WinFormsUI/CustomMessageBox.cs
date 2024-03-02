using System.Windows.Forms;

namespace WinFormsUI
{
    public static class CustomMessageBox
    {
        public static DialogResult Show(string message, string caption, MessageBoxButtons buttons)
        {
            DialogResult dialogResult = DialogResult.None;
            switch (buttons)
            {
                case MessageBoxButtons.YesNo:
                    using (FormYesNo formYesNo = new FormYesNo())
                    {
                        formYesNo.Text = caption;
                        formYesNo.Message = message;
                        dialogResult = formYesNo.ShowDialog();
                    }
                    break;
                case MessageBoxButtons.OK:
                    using (FormOK formOK = new FormOK())
                    {
                        formOK.Text = caption;
                        formOK.Message = message;
                        dialogResult = formOK.ShowDialog();
                    }
                    break;
            }
            return dialogResult;
        }
    }
}
