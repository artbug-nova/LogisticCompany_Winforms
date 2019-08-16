using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Store
{
    public partial class ShipmentForm : MDIChildBase
    {
        public ShipmentForm() : base()
        {
            InitializeComponent();
            toolStrip = toolStripShipment;
        }

        public ShipmentForm(MDIForm mdiForm) : base(mdiForm)
        {
            InitializeComponent();
            toolStrip = toolStripShipment;
            parentType = typeof(Shipment);
            toolAddShipment.Click += OnAddClick;
            toolEditShipment.Click += OnEditClick;
            toolDeleteShipment.Click += OnDeleteClick;
        }

        #region Настройка DataGridView
        protected override void SetGridParameters()
        {
            execute = new List<bool> { true, false };
            procedure = new List<String> { "st_shipment_list", "st_shipment_list" };
            tables = new List<String> { "st_shipment_list", "st_shipment_list1" };
            queries = new List<String> { "", "" };
            columns = new List<List<String>> { new List<String> { "id", "num", "dt_begin", "dt_end", "vehicle", "driver", "agent", "keeper", "status", "id_status" },
                                               new List<String> { "id", "num", "dt_beg", "customer", "address", "id_shipment", "id_order" } };
            bindSources = new List<BindingSource> { new BindingSource(), new BindingSource() };
            adapters = new List<SqlDataAdapter> { new SqlDataAdapter(), null };
        }
        #endregion Настройка DataGridView

        protected override void SetControls(bool _on)
        {
            base.SetControls(_on);
        }

        private void OnSelectionChanged(object sender, EventArgs e)
        {
            DataGridView grid = (DataGridView)sender;

            if (sender == gridShipment)
            {
                if (gridShipment.DataSource == null) return;
                ((BindingSource)gridDetail.DataSource).Filter = String.Format("id_shipment = {0}", grid.SelectedRows.Count == 0 ? 0 : (int)grid.SelectedRows[0].Cells["id_Shipment"].Value);
                if (gridDetail.Rows.Count > 0) gridDetail.Rows[0].Selected = true;
            }
        }

        private void OnShipRepClick(object sender, EventArgs e)
        {
            if (gridShipment.SelectedRows.Count == 0)
            {
                MessageBox.Show("Объект не выбран, печать отчета невозможна", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int id = (int)gridShipment.SelectedRows[0].Cells[0].Value;
            ShipmentReportForm report = new ShipmentReportForm((MDIForm)this.MdiParent, 0, id);
            report.Show();
        }

        private void OnRouteRepClick(object sender, EventArgs e)
        {
            if (gridShipment.SelectedRows.Count == 0)
            {
                MessageBox.Show("Объект не выбран, печать отчета невозможна", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int id = (int)gridShipment.SelectedRows[0].Cells[0].Value;
            RouteReportForm report = new RouteReportForm((MDIForm)this.MdiParent, 0, id);
            report.Show();
        }

        private void OnCustomerRepForm(object sender, EventArgs e)
        {
            if (gridDetail.SelectedRows.Count == 0)
            {
                MessageBox.Show("Объект не выбран, печать отчета невозможна", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int id = (int)gridDetail.SelectedRows[0].Cells["id_order_Detail"].Value;
            OrderReportForm report = new OrderReportForm((MDIForm)this.MdiParent, 0, id);
            report.Show();
        }
    }
}
