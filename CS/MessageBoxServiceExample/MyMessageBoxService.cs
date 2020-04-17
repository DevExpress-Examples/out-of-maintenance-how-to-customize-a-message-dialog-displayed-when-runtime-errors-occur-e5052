#region #usings;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using DevExpress.Spreadsheet;
using DevExpress.Portable;
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

        // To test: select a range of cells with and without data validation settings and click Data Validation command to invoke the Data Validation dialog.
        public PortableDialogResult ShowYesNoCancelMessage(string message) {
            string mymessage = "Aktion auswählen\n\n" + message;
            return (PortableDialogResult)XtraMessageBox.Show(lookAndFeel, control, mymessage, Application.ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }

        // To test: enter incorrect data into a cell with a data validation rule applied. 
        public PortableDialogResult ShowDataValidationDialog(string message, string title, DataValidationErrorStyle errorStyle) {
            string mymessage = "Der eingegebene Wert ist ungültig.\n\n" + message;
            MessageBoxButtons buttons;
            MessageBoxIcon icon;
            if(errorStyle == DataValidationErrorStyle.Stop) {
                buttons = MessageBoxButtons.RetryCancel;
                icon = MessageBoxIcon.Error;
            } else if(errorStyle == DataValidationErrorStyle.Warning) {
                buttons = MessageBoxButtons.YesNoCancel;
                icon = MessageBoxIcon.Warning;
            } else {
                buttons = MessageBoxButtons.OKCancel;
                icon = MessageBoxIcon.Information;
            }
            return (PortableDialogResult)XtraMessageBox.Show(lookAndFeel, control, mymessage, title, buttons, icon);
        }

        // To test: click the Test button or try to set the row height to 1000.
        public PortableDialogResult ShowMessage(string message, string title, PortableMessageBoxIcon icon)
        {
            string myMessage = "Ein Fehler tritt auf.\n\n" + message;
            var myIcon = (MessageBoxIcon)icon;
            return (PortableDialogResult)XtraMessageBox.Show(lookAndFeel, control, myMessage, title, MessageBoxButtons.OK, myIcon);
        }

        // Not in use; use ShowMessage instead.
        public DialogResult ShowWarningMessage(string message)
        {
            string mymessage = "Es ist ein Fehler aufgetreten. Bitte überprüfen Sie die Eingabe.\n\n" + message;
            return XtraMessageBox.Show(lookAndFeel, control, mymessage, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        
        // To test: drag and drop cells to another location trying to overwrite the content of the destination cells.
        public bool ShowOkCancelMessage(string message)
        {
            string mymessage = "Möchten Sie diesen Vorgang wirklich ausführen?\n\n" + message;
            return DialogResult.OK == XtraMessageBox.Show(lookAndFeel, control, mymessage, Application.ProductName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        // To test: try to delete a defined name in the Name Manager dialog.
        public bool ShowYesNoMessage(string message)
        {
            string mymessage = "Entscheidung treffen. Ja oder Nein?\n\n" + message;
            return DialogResult.Yes == XtraMessageBox.Show(lookAndFeel, control, mymessage, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

    }
    #endregion #service
}
