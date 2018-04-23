Imports DevExpress.Spreadsheet
Imports System.Windows.Forms

Namespace MessageBoxServiceExample
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
			ribbonControl1.SelectedPage = ribbonControl1.Pages("Test")
'			#Region "#replaceservice"
			Dim svc As New MyMessageBoxService(spreadsheetControl1, spreadsheetControl1.LookAndFeel)
			spreadsheetControl1.ReplaceService(Of DevExpress.XtraSpreadsheet.Services.IMessageBoxService)(svc)
'			#End Region ' #replaceservice

			spreadsheetControl1.ActiveWorksheet.DataValidations.Add(spreadsheetControl1.ActiveWorksheet("A2:A10"), DataValidationType.Decimal, DataValidationOperator.Between, 10, 40)
		End Sub

		Private Sub barButtonItem1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem1.ItemClick
			SendKeys.Send("=asdfg;{ENTER}")
		End Sub
	End Class
End Namespace
