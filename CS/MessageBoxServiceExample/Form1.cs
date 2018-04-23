using DevExpress.Spreadsheet;
using System.Windows.Forms;

namespace MessageBoxServiceExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ribbonControl1.SelectedPage = ribbonControl1.Pages["Test"];
            #region #replaceservice
            MyMessageBoxService svc = new MyMessageBoxService(spreadsheetControl1, spreadsheetControl1.LookAndFeel);
            spreadsheetControl1.ReplaceService<DevExpress.XtraSpreadsheet.Services.IMessageBoxService>(svc);
            #endregion #replaceservice

            spreadsheetControl1.ActiveWorksheet.DataValidations.Add(spreadsheetControl1.ActiveWorksheet["A2:A10"], DataValidationType.Decimal, DataValidationOperator.Between, 10, 40);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SendKeys.Send("=asdfg;{ENTER}");
        }
    }
}
