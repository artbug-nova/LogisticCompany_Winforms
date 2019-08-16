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
    public partial class RouteReportForm : Form
    {
        protected int typeReport;
        protected int id;
        public RouteReportForm()
        {
            InitializeComponent();
        }

        public RouteReportForm(MDIForm mdiForm, int typeReport, int id)
        {
            InitializeComponent();
            this.MdiParent = mdiForm;
            this.typeReport = typeReport;
            this.id = id;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            try
            {
                ((MDIForm)MdiParent).ChangeWindowList();
            }
            catch { }

            st_shipment_report_getTableAdapter.Connection = SQLConnection.GetConnection();
            this.st_shipment_report_getTableAdapter.Fill(this.storeDataSet.st_shipment_report_get, id);
            st_shipment_detail_report_getTableAdapter.Connection = SQLConnection.GetConnection();
            this.st_shipment_detail_report_getTableAdapter.Fill(this.storeDataSet.st_shipment_detail_report_get, id);


            this.reportViewer.RefreshReport();
        }

        private void OnClosed(object sender, FormClosedEventArgs e)
        {
            ((MDIForm)MdiParent).ChangeWindowList(this);
        }
    }
}
