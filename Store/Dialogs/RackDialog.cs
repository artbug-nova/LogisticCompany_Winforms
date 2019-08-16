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
    public partial class RackDialog : BaseObjectDialog
    {
        public RackDialog() : base()
        {
            InitializeComponent();
        }
        public RackDialog(BaseObject baseObject) : base(baseObject)
        {
            InitializeComponent();
            columns = new List<List<String>> { new List<String> { "Num", "MaxWeight", "Note", "Procent", "IdRack" } };
            btnAddShelf.Click += OnAddClick;
            btnEditShelf.Click += OnEditClick;
            btnDelShelf.Click += OnDeleteClick;
        }

        protected override void SetGrids()
        {
            base.SetGrids();
            RetrieveGrid();
        }

        protected override void RetrieveGrid()
        {
            gridShelf.DataSource = null;
            if (((Rack)baseObject).ChildList.Count > 0 && ((Rack)baseObject).ChildList[0].Count > 0) gridShelf.DataSource = ((Rack)baseObject).ChildList[0].ConvertAll<Shelf>(delegate (BaseObject baseObject) { return (Shelf)baseObject; });
        }

        protected override void SetFields()
        {
            Rack rack = (Rack)baseObject;
            if (rack.Id == 0) Text = "Новый стеллаж";
            else Text = "Стеллаж №: " + rack.Num;

            txtNum.Text = rack.Num;
            txtNote.Text = rack.Note;
        }

        protected override bool GetFields(out string errMessage)
        {
            bool result = true;
            errMessage = "";
            Rack rack = (Rack)baseObject;

            rack.Num = txtNum.Text;
            rack.Note = txtNote.Text;
            return result;
        }

        private void OnOKClick(object sender, EventArgs e)
        {
            baseObject.SaveChildren = true;
            SaveObject();
        }
    }
}
