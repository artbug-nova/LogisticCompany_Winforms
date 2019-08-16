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
    public partial class OrderForm : MDIChildBase
    {
        public OrderForm() : base()
        {
            InitializeComponent();
            toolStrip = toolStripStore;
        }

        public OrderForm(MDIForm mdiForm) : base(mdiForm)
        {
            InitializeComponent();
            toolStrip = toolStripStore;
            parentType = typeof(Order);
            toolAddOrder.Click += OnAddClick;
            toolEditOrder.Click += OnEditClick;
            toolDeleteOrder.Click += OnDeleteClick;
        }



        #region Настройка DataGridView
        protected override void SetGridParameters()
        {
            execute = new List<bool> { true, false, false };
            procedure = new List<String> { "st_order_list", "st_order_list", "st_order_list" };
            tables = new List<String> { "st_order_list", "st_order_list1", "st_order_list2" };
            queries = new List<String> { "", "", "" };
            columns = new List<List<String>> { new List<String> { "id", "num", "dt_beg", "dt_end", "dt_ship",
                                                                  "cust_name", "status", "note", "id_customer",
                                                                  "id_status" },
                                               new List<String> { "id", "name", "id_order"},
                                               new List<String> { "id", "weight", "length", "width", "height",
                                                                  "status", "note", "id_product", "id_status"} };
            bindSources = new List<BindingSource> { new BindingSource(), new BindingSource(), new BindingSource() };
            adapters = new List<SqlDataAdapter> { new SqlDataAdapter(), null, null };
        }
        #endregion Настройка DataGridView



        protected override void SetControls(bool _on)
        {
            base.SetControls(_on);
        }

        protected override void SetFilters()
        {
            if (Person.CurrUser.IdRole == 2)
            {
                ((BindingSource)gridOrder.DataSource).Filter = "id_status > 3";
            }
            else
            {
                ((BindingSource)gridOrder.DataSource).Filter = "";
            }
        }



        private void OnSelectionChanged(object sender, EventArgs e)
        {
            DataGridView grid = (DataGridView)sender;

            if (sender == gridOrder)
            {
                ((BindingSource)gridProduct.DataSource).Filter = String.Format("id_order = {0}",
                    grid.SelectedRows.Count == 0 ? 0 : (grid.SelectedRows[0].Cells["id_Order"].Value == null
                    ? 0 :(int)grid.SelectedRows[0].Cells["id_Order"].Value));
                if (gridProduct.Rows.Count > 0) gridProduct.Rows[0].Selected = true;
            }
            else if (sender == gridProduct)
            {
                ((BindingSource)gridBox.DataSource).Filter = String.Format("id_product = {0}",
                    grid.SelectedRows.Count == 0 ? 0 : (grid.SelectedRows[0].Cells["id_Product"].Value == null
                    ? 0 : (int)grid.SelectedRows[0].Cells["id_Product"].Value));
                if (gridBox.Rows.Count > 0) gridBox.Rows[0].Selected = true;
            }
        }



    }
}
