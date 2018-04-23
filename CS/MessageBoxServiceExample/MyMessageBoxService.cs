#region #usings;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
#endregion #usings


namespace MessageBoxServiceExample
{
    #region #service
    class MyMessageBoxService : DevExpress.XtraSpreadsheet.Services.IMessageBoxService
    {
        readonly Control control;
        readonly UserLookAndFeel lookAndFeel;

        public MyMessageBoxService(Control control, UserLookAndFeel lookAndFeel)
        {
            this.control = control;
            this.lookAndFeel = lookAndFeel;
        }

        public DialogResult ShowWarningMessage(string message)
        {
            string mymessage = "Es ist ein Fehler aufgetreten. Bitte überprüfen Sie die Eingabe.\n\n" + message;
            return XtraMessageBox.Show(lookAndFeel, control, mymessage, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public bool ShowOkCancelMessage(string message)
        {
            string mymessage = "Möchten Sie diesen Vorgang wirklich ausführen?\n\n" + message;
            return DialogResult.OK == XtraMessageBox.Show(lookAndFeel, control, mymessage, Application.ProductName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        public bool ShowYesNoMessage(string message)
        {
            string mymessage = "Entscheidung treffen. Ja oder Nein?\n\n" + message;
            return DialogResult.Yes == XtraMessageBox.Show(lookAndFeel, control, mymessage, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

    }
    #endregion #service
}
