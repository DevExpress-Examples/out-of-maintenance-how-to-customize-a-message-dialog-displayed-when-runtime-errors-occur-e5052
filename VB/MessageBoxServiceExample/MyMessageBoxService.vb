Imports Microsoft.VisualBasic
#Region "#usings"
Imports System.Windows.Forms
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors
Imports DevExpress.XtraSpreadsheet.Services
#End Region ' #usings


Namespace MessageBoxServiceExample
	#Region "#service"
	Friend Class MyMessageBoxService
		Implements DevExpress.XtraSpreadsheet.Services.IMessageBoxService
		Private ReadOnly control As Control
		Private ReadOnly lookAndFeel As UserLookAndFeel

		Public Sub New(ByVal control As Control, ByVal lookAndFeel As UserLookAndFeel)
			Me.control = control
			Me.lookAndFeel = lookAndFeel
		End Sub

		Public Function ShowWarningMessage(ByVal message As String) As DialogResult Implements IMessageBoxService.ShowWarningMessage
			Dim mymessage As String = "Es ist ein Fehler aufgetreten. Bitte überprüfen Sie die Eingabe." & Constants.vbLf + Constants.vbLf & message
			Return XtraMessageBox.Show(lookAndFeel, control, mymessage, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
		End Function
		Public Function ShowOkCancelMessage(ByVal message As String) As Boolean Implements IMessageBoxService.ShowOkCancelMessage
			Dim mymessage As String = "Möchten Sie diesen Vorgang wirklich ausführen?" & Constants.vbLf + Constants.vbLf & message
            Return DialogResult.OK = XtraMessageBox.Show(lookAndFeel, control, mymessage, Application.ProductName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        End Function
        Public Function ShowYesNoMessage(ByVal message As String) As Boolean Implements IMessageBoxService.ShowYesNoMessage
            Dim mymessage As String = "Entscheidung treffen. Ja oder Nein?" & Constants.vbLf + Constants.vbLf & message
            Return DialogResult.Yes = XtraMessageBox.Show(lookAndFeel, control, mymessage, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        End Function
	End Class
	#End Region ' #service
End Namespace
