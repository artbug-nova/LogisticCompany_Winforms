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
    public partial class CustomerDialog : BaseObjectDialog
    {
        public CustomerDialog() : base()
        {
            InitializeComponent();
        }

        public CustomerDialog(BaseObject baseObject) : base(baseObject)
        {
            InitializeComponent();
            columns = new List<List<String>> { new List<String> { "Id", "Num", "DtBeg", "DtEnd", "DtShip", "Status", "Note", "IdCustomer", "IdStatus"} };
            comboSource = new List<String> { "st_district_list" };
            comboValueMember = new List<String> { "id" };
            comboDisplayMember = new List<String> { "value" };
        }

        protected override void SetGrids()
        {
            base.SetGrids();
            gridOrder.DataSource = null;
            if (((Customer)baseObject).ChildList.Count > 0 && ((Customer)baseObject).ChildList[0].Count > 0) gridOrder.DataSource = ((Customer)baseObject).ChildList[0].ConvertAll<Order>(delegate (BaseObject baseObject) { return (Order)baseObject; });
        }

        protected override void SetFields()
        {
            Customer customer = (Customer)baseObject;
            if (customer.Id == 0) Text = "Новый заказчик";
            else Text = String.Format("Заказчик: {0} {1}.{2}.", customer.LastName, customer.FirstName.Substring(0, 1), customer.SecondName.Substring(0, 1));

            txtLastName.Text = customer.LastName;
            txtFirstName.Text = customer.FirstName;
            txtSecondName.Text = customer.SecondName;
            txtAddress.Text = customer.Address;
            txtPhone.Text = customer.Phone;
            cbDistrict.SelectedValue = customer.IdDistrict;
        }

        protected override bool GetFields(out string errMessage)
        {
            errMessage = "";
            Customer customer = (Customer)baseObject;
            customer.LastName = txtLastName.Text;
            customer.FirstName = txtFirstName.Text;
            customer.SecondName = txtSecondName.Text;
            customer.Address = txtAddress.Text;
            customer.Phone = txtPhone.Text;
            if (cbDistrict.SelectedValue == null)
            {
                errMessage = "Не указан район";
                return false;
            }
            customer.IdDistrict = (int)(cbDistrict.SelectedValue);
            return true;
        }

        private void OnOkClick(object sender, EventArgs e)
        {
            baseObject.SaveChildren = false;
            SaveObject();
        }
    }
}
