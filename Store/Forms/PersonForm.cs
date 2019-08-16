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
    public partial class PersonForm : MDIChildBase
    {
        public PersonForm() : base()
        {
            InitializeComponent();
            toolStrip = toolStripPerson;
        }

        public PersonForm(MDIForm mdiForm) : base(mdiForm)
        {
            InitializeComponent();
            toolStrip = toolStripPerson;
            parentType = typeof(Person);
            toolAddPerson.Click += OnAddClick;
            toolEditPerson.Click += OnEditClick;
            toolDeletePerson.Click += OnDeleteClick;
        }

        #region Настройка DataGridView
        protected override void SetGridParameters()
        {
            execute = new List<bool> { true };
            procedure = new List<String> { "st_person_list" };
            tables = new List<String> { "st_person_list" };
            queries = new List<String> { ""};
            columns = new List<List<String>> { new List<String> { "id", "full_name", "dt_birth", "phone", "pos_value", "st_value", "id_position", "id_status" } };
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
