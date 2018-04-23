Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
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
		End Sub

		Private Sub barButtonItem1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem1.ItemClick
			SendKeys.Send("=foo;{ENTER}")
		End Sub
	End Class
End Namespace
