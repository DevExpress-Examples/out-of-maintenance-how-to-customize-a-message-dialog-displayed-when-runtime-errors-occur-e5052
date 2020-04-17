#Region "#usings"
Imports System.Windows.Forms
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors
Imports DevExpress.Spreadsheet
Imports DevExpress.Portable
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

        ' To test: select a range of cells with and without data validation settings and click Data Validation command to invoke the Data Validation dialog.
        Public Function ShowYesNoCancelMessage(ByVal message As String) As PortableDialogResult Implements DevExpress.XtraSpreadsheet.Services.IMessageBoxService.ShowYesNoCancelMessage
            Dim myMessage As String = "Aktion auswählen" & ControlChars.Lf & ControlChars.Lf & message
            Return CType(XtraMessageBox.Show(lookAndFeel, control, myMessage, Application.ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information), PortableDialogResult)
        End Function

        ' To test: enter incorrect data into a cell with a data validation rule applied. 
        Public Function ShowDataValidationDialog(ByVal message As String, ByVal title As String, ByVal errorStyle As DataValidationErrorStyle) As PortableDialogResult Implements DevExpress.XtraSpreadsheet.Services.IMessageBoxService.ShowDataValidationDialog
            Dim myMessage As String = "Der eingegebene Wert ist ungültig." & ControlChars.Lf & ControlChars.Lf & message
            Dim buttons As MessageBoxButtons
            Dim icon As MessageBoxIcon
            If errorStyle = DataValidationErrorStyle.Stop Then
                buttons = MessageBoxButtons.RetryCancel
                icon = MessageBoxIcon.Error
            ElseIf errorStyle = DataValidationErrorStyle.Warning Then
                buttons = MessageBoxButtons.YesNoCancel
                icon = MessageBoxIcon.Warning
            Else
                buttons = MessageBoxButtons.OKCancel
                icon = MessageBoxIcon.Information
            End If
            Return CType(XtraMessageBox.Show(lookAndFeel, control, myMessage, title, buttons, icon), PortableDialogResult)
        End Function

        ' To test: click the Test button or try to set the row height to 1000.
        Public Function ShowMessage(ByVal message As String, ByVal title As String, ByVal icon As PortableMessageBoxIcon) As PortableDialogResult Implements DevExpress.XtraSpreadsheet.Services.IMessageBoxService.ShowMessage
            Dim myMessage As String = "Ein Fehler tritt auf." & ControlChars.Lf & ControlChars.Lf & message
            Dim myIcon = CType(icon, MessageBoxIcon)
            Return CType(XtraMessageBox.Show(lookAndFeel, control, myMessage, title, MessageBoxButtons.OK, myIcon), PortableDialogResult)
        End Function

        ' To test: drag and drop cells to another location trying to overwrite the content of the destination cells.
        Public Function ShowOkCancelMessage(ByVal message As String) As Boolean Implements DevExpress.XtraSpreadsheet.Services.IMessageBoxService.ShowOkCancelMessage
            Dim myMessage As String = "Möchten Sie diesen Vorgang wirklich ausführen?" & ControlChars.Lf & ControlChars.Lf & message
            Return PortableDialogResult.OK = CType(XtraMessageBox.Show(lookAndFeel, control, myMessage, Application.ProductName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information), PortableDialogResult)
        End Function

        ' To test: try to delete a defined name in the Name Manager dialog.
        Public Function ShowYesNoMessage(ByVal message As String) As Boolean Implements DevExpress.XtraSpreadsheet.Services.IMessageBoxService.ShowYesNoMessage
            Dim myMessage As String = "Entscheidung treffen. Ja oder Nein?" & ControlChars.Lf & ControlChars.Lf & message
            Return PortableDialogResult.Yes = CType(XtraMessageBox.Show(lookAndFeel, control, myMessage, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question), PortableDialogResult)
        End Function

    End Class
#End Region ' #service
End Namespace
