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
    public partial class RackForm : MDIChildBase
    {
        public RackForm() : base()
        {
            InitializeComponent();
            toolStrip = toolStripRack;
        }
        public RackForm(MDIForm mdiForm) : base(mdiForm)
        {
            InitializeComponent();
            toolStrip = toolStripRack;
            parentType = typeof(Rack);
            toolAddRack.Click += OnAddClick;
            toolEditRack.Click += OnEditClick;
            toolDeleteRack.Click += OnDeleteClick;
        }

        #region Настройка DataGridView
        protected override void SetGridParameters()
        {
            execute = new List<bool> { true, false };
            procedure = new List<String> { "st_rack_list", "st_rack_list" };
            tables = new List<String> { "st_rack_list", "st_rack_list1" };
            queries = new List<String> { "", "" };
            columns = new List<List<String>> { new List<String> { "id", "num", "note" },
                                               new List<String> { "id", "num", "max_weight", "note", "procent", "id_rack" } };
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

            if (sender == gridRack)
            {
                if (gridRack.DataSource == null) return;
                ((BindingSource)gridShelf.DataSource).Filter = String.Format("id_rack = {0}", grid.SelectedRows.Count == 0 ? 0 : (int)grid.SelectedRows[0].Cells["id_Rack"].Value);
                if (gridShelf.Rows.Count > 0) gridShelf.Rows[0].Selected = true;
            }
        }




    }
}
