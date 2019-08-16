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
    public partial class OrderDialog : BaseObjectDialog
    {

        public OrderDialog() : base()
        {
            InitializeComponent();
        }

        public OrderDialog(BaseObject baseObject) : base(baseObject)
        {
            InitializeComponent();
            columns = new List<List<String>> { new List<String> { "Id", "Name"},
                                               new List<String> { "Id", "Weight", "Length", "Width", "Height", "Status", "Note", "IdStatus"} };
            comboSource = new List<String> { "st_customer_list", "st_district_list" };
            comboValueMember = new List<String> { "id", "id" };
            comboDisplayMember = new List<String> { "full_name", "value" };
            btnAddProduct.Click += OnAddClick;
            btnEditProduct.Click += OnEditClick;
            btnDelProduct.Click += OnDeleteClick;
        }
        protected override void SetGrids()
        {
            base.SetGrids();
            RetrieveGrid();
        }

        protected override void RetrieveGrid()
        {
            gridProduct.DataSource = null;
            if (((Order)baseObject).ChildList.Count > 0 && ((Order)baseObject).ChildList[0].Count > 0) gridProduct.DataSource = ((Order)baseObject).ChildList[0].ConvertAll<Product>(delegate (BaseObject baseObject) { return (Product)baseObject; });
        }
        protected override void SetFields()
        {
            Order order = (Order)baseObject;
            if (order.Id == 0) Text = "Новый заказ";
            else Text = "Заказ ID: " + order.Id.ToString() + " (Статус: " + order.Status + ")";

            txtId.Text = order.Id.ToString();
            txtNum.Text = order.Num;
            dtDtBeg.Value = order.DtBeg;
            dtDtEnd.Value = order.DtEnd;
            if (order.DtShip.HasValue)
            {
                dtDtShip.Format = DateTimePickerFormat.Short;
                dtDtShipTime.Format = DateTimePickerFormat.Time;
                dtDtShip.Value = dtDtShipTime.Value = order.DtShip.Value;
            }
            else
            {
                dtDtShip.Format = dtDtShipTime.Format = DateTimePickerFormat.Custom;
                dtDtShip.CustomFormat = " ";
                dtDtShipTime.CustomFormat = " ";
            }
            cbCustomer.SelectedValueChanged += OnSelectedChanged;
            cbCustomer.SelectedValue = order.IdCustomer;
            if (order.Customer != null)
            {
                txtAddress.Text = order.Customer.Address;
                cbDistrict.SelectedValue = order.Customer.IdDistrict;
                txtPhone.Text = order.Customer.Phone;
            }
            else cbDistrict.SelectedValue = 0;
            txtNote.Text = order.Note;
        }

        protected override bool GetFields(out string errMessage)
        {
            bool result = true;
            errMessage = "";
            Order order = (Order)baseObject;

            order.Num = txtNum.Text;
            order.Note = txtNote.Text;
            order.DtBeg = dtDtBeg.Value;
            order.DtEnd = dtDtEnd.Value;
            if (dtDtShip.Format == DateTimePickerFormat.Custom)
            {
                order.DtShip = null;
            }
            else
            {
                order.DtShip = new DateTime(dtDtShip.Value.Year, dtDtShip.Value.Month, dtDtShip.Value.Day, dtDtShipTime.Value.Hour, dtDtShipTime.Value.Minute, dtDtShipTime.Value.Second);
            }
            
            return result;
        }

        private void OnSelectProductChanged(object sender, EventArgs e)
        {
            DataGridView grid = (DataGridView)sender;
            gridBox.DataSource = null;
            if (grid.SelectedRows.Count == 1)
            {
                if (((Product)(((Order)baseObject).ChildList[0][grid.SelectedRows[0].Index])).ChildList.Count > 0 && ((Product)(((Order)baseObject).ChildList[0][grid.SelectedRows[0].Index])).ChildList[0].Count > 0) gridBox.DataSource = ((Product)(((Order)baseObject).ChildList[0][grid.SelectedRows[0].Index])).ChildList[0].ConvertAll<Box>(delegate (BaseObject baseObject) { return (Box)baseObject; });
            }
        }

        private void OnSelectedChanged(object sender, EventArgs e)
        {
            Order order = (Order)baseObject;
            if (cbCustomer.SelectedValue != null)
            {
                order.IdCustomer = (int)cbCustomer.SelectedValue;
                if (order.Customer != null)
                {
                    txtAddress.Text = order.Customer.Address;
                    cbDistrict.SelectedValue = order.Customer.IdDistrict;
                    txtPhone.Text = order.Customer.Phone;
                }
                else cbDistrict.SelectedValue = 0;
            }
        }

        private void OnDtValueChanged(object sender, EventArgs e)
        {
            dtDtShip.Format = DateTimePickerFormat.Short;
            dtDtShipTime.Format = DateTimePickerFormat.Time;
            dtDtShip.CustomFormat = "dd.MM.yyyy";
        }

        private void OnKeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                dtDtShip.Format = dtDtShipTime.Format = DateTimePickerFormat.Custom;
                dtDtShip.CustomFormat = dtDtShipTime.CustomFormat = " ";
            }
        }

        private void OnOkClick(object sender, EventArgs e)
        {
            baseObject.SaveChildren = true;
            SaveObject();
        }
    }
}
