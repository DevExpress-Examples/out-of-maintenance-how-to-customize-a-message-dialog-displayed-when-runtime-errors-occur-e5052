using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SendKeys.Send("=foo;{ENTER}");
        }
    }
}
