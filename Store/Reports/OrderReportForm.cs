using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Store
{
    public partial class OrderReportForm : Form
    {
        protected int typeReport;
        protected int id;
        public OrderReportForm()
        {
            InitializeComponent();
        }

        public OrderReportForm(MDIForm mdiForm, int typeReport, int id)
        {
            InitializeComponent();
            this.MdiParent = mdiForm;
            this.typeReport = typeReport;
            this.id = id;
        }

        private void OrderReportForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            try
            {
                ((MDIForm)MdiParent).ChangeWindowList();
            }
            catch { }

            this.st_order_report_getTableAdapter.Connection = SQLConnection.GetConnection();
            this.st_order_report_getTableAdapter.Fill(this.storeDataSet.st_order_report_get, id);
            this.st_order_product_report_getTableAdapter.Connection = SQLConnection.GetConnection();
            this.st_order_product_report_getTableAdapter.Fill(this.storeDataSet.st_order_product_report_get, id);

            this.reportViewer1.RefreshReport();
        }
    }
}
