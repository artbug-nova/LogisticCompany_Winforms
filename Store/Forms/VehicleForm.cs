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
    public partial class VehicleForm : MDIChildBase
    {
        public VehicleForm() : base()
        {
            InitializeComponent();
            toolStrip = toolStripVehicle;
        }

        public VehicleForm(MDIForm mdiForm) : base(mdiForm)
        {
            InitializeComponent();
            toolStrip = toolStripVehicle;
            parentType = typeof(Vehicle);
            toolAddVehicle.Click += OnAddClick;
            toolEditVehicle.Click += OnEditClick;
            toolDeleteVehicle.Click += OnDeleteClick;
        }

        #region Настройка DataGridView
        protected override void SetGridParameters()
        {
            execute = new List<bool> { true };
            procedure = new List<String> { "st_vehicle_list" };
            tables = new List<String> { "st_vehicle_list" };
            queries = new List<String> { "" };
            columns = new List<List<String>> { new List<String> { "id", "mark", "state_num", "capacity", "length", "width", "height", "st_value", "id_status" } };
            bindSources = new List<BindingSource> { new BindingSource() };
            adapters = new List<SqlDataAdapter> { new SqlDataAdapter() };
        }
        #endregion Настройка DataGridView

        protected override void SetControls(bool _on)
        {
            base.SetControls(_on);
        }
    }
}
