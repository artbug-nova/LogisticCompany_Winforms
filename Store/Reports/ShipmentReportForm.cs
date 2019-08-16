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
    public partial class ShipmentReportForm : Form
    {
        protected int typeReport;
        protected int id;
        public ShipmentReportForm()
        {
            InitializeComponent();
        }

        public ShipmentReportForm(MDIForm mdiForm, int typeReport, int id)
        {
            InitializeComponent();
            this.MdiParent = mdiForm;
            this.typeReport = typeReport;
            this.id = id;
        }

        private void ShipmentReportForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            try
            {
                ((MDIForm)MdiParent).ChangeWindowList();
            }
            catch { }

            st_shipment_report_getTableAdapter.Connection = SQLConnection.GetConnection();
            this.st_shipment_report_getTableAdapter.Fill(this.storeDataSet.st_shipment_report_get, id);
            st_shipment_order_report_getTableAdapter.Connection = SQLConnection.GetConnection();
            this.st_shipment_order_report_getTableAdapter.Fill(this.storeDataSet.st_shipment_order_report_get, id);

            this.reportViewer.RefreshReport();
        }

        private void OnClosed(object sender, FormClosedEventArgs e)
        {
            ((MDIForm)MdiParent).ChangeWindowList(this);
        }
    }
}
