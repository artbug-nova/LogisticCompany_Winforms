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
    public partial class CustomerForm : MDIChildBase
    {
        public CustomerForm() : base()
        {
            InitializeComponent();
            toolStrip = toolStripCustomer;
        }

        public CustomerForm(MDIForm mdiForm) : base(mdiForm)
        {
            InitializeComponent();
            toolStrip = toolStripCustomer;
            parentType = typeof(Customer);
            toolAddCustomer.Click += OnAddClick;
            toolEditCustomer.Click += OnEditClick;
            toolDeleteCustomer.Click += OnDeleteClick;
        }

        #region Настройка DataGridView
        protected override void SetGridParameters()
        {
            execute = new List<bool> { true, false };
            procedure = new List<String> { "st_customer_list", "st_customer_list" };
            tables = new List<String> { "st_customer_list", "st_customer_list1" };
            queries = new List<String> { "", "", "" };
            columns = new List<List<String>> { new List<String> { "id", "full_name", "phone", "address", "district", "id_district" },
                                               new List<String> { "id", "num", "dt_beg", "dt_end", "dt_ship", "status", "note", "id_customer", "id_status" } };
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

            if (sender == gridCustomer)
            {
                if (gridCustomer.DataSource == null) return;
                ((BindingSource)gridOrder.DataSource).Filter = String.Format("id_customer = {0}", grid.SelectedRows.Count == 0 ? 0 : (int)grid.SelectedRows[0].Cells["id_Customer"].Value);
                if (gridOrder.Rows.Count > 0) gridOrder.Rows[0].Selected = true;
            }
        }
    }
}
