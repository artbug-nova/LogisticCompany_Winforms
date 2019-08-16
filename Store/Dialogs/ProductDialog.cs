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
    public partial class ProductDialog : BaseObjectDialog
    {
        public ProductDialog() : base()
        {
            InitializeComponent();
        }
        public ProductDialog(BaseObject baseObject) : base(baseObject)
        {
            InitializeComponent();
            columns = new List<List<String>> { new List<String> { "Id", "Weight", "Length", "Width", "Height", "Status", "Note", "IdStatus"} };
            btnAddBox.Click += OnAddClick;
            btnEditBox.Click += OnEditClick;
            btnDelBox.Click += OnDeleteClick;
        }

        protected override void SetGrids()
        {
            base.SetGrids();
            RetrieveGrid();
        }

        protected override void RetrieveGrid()
        {
            gridBox.DataSource = null;
            if (((Product)baseObject).ChildList.Count > 0 && ((Product)baseObject).ChildList[0].Count > 0) gridBox.DataSource = ((Product)baseObject).ChildList[0].ConvertAll<Box>(delegate (BaseObject baseObject) { return (Box)baseObject; });
        }

        protected override void SetFields()
        {
            Product product = (Product)baseObject;
            if (product.Id == 0) Text = "Новый товар";
            else Text = "Товар: " + product.Name;

            txtId.Text = product.Order.Id.ToString();
            txtNum.Text = product.Order.Num;
            dtDtBeg.Value = product.Order.DtBeg;
            txtName.Text = product.Name;
        }

        protected override bool GetFields(out string errMessage)
        {
            bool result = true;
            errMessage = "";
            Product product = (Product)baseObject;

            product.Name = txtName.Text;

            return result;
        }

        private void OnOKClick(object sender, EventArgs e)
        {
            baseObject.SaveChildren = true;
            SaveObject();
        }
    }
}
