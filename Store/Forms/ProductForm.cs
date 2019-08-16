using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Store
{
    public partial class ProductForm : MDIChildBase
    {
        public ProductForm() : base()
        {
            InitializeComponent();
            toolStrip = null;
        }

        public ProductForm(MDIForm mdiForm) : base(mdiForm)
        {
            InitializeComponent();
            toolStrip = null;
            parentType = typeof(Product);
        }

        #region Настройка DataGridView

        protected override void SetGridParameters()
        {
            execute = new List<bool> { true, false };
            procedure = new List<String> { "st_product_list", "st_product_list" };
            tables = new List<String> { "st_product_list", "st_product_list1" };
            queries = new List<String> { "", "" };
            columns = new List<List<String>> { new List<String> { "id", "name", "num", "dt_beg", "value", "customer", "id_status" },
                                               new List<String> { "id", "weight", "length", "width", "height", "status", "note", "id_product", "id_status"} };
            bindSources = new List<BindingSource> { new BindingSource(), new BindingSource() };
            adapters = new List<SqlDataAdapter> { new SqlDataAdapter(), null };
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
                ((BindingSource)gridProduct.DataSource).Filter = "id_status > 3";
            }
            else
            {
                ((BindingSource)gridProduct.DataSource).Filter = "";
            }
        }

        private void OnSelectionChanged(object sender, EventArgs e)
        {
            DataGridView grid = (DataGridView)sender;

            if (sender == gridProduct)
            {
                if (gridProduct.DataSource == null) return;
                ((BindingSource)gridBox.DataSource).Filter = String.Format("id_product = {0}", grid.SelectedRows.Count == 0 ? 0 : (int)grid.SelectedRows[0].Cells["id_Product"].Value);
                if (gridBox.Rows.Count > 0) gridBox.Rows[0].Selected = true;
            }
        }

    }
}
