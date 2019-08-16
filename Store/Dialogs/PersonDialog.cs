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
    public partial class PersonDialog : BaseObjectDialog
    {
        public PersonDialog() : base()
        {
            InitializeComponent();
        }

        public PersonDialog(BaseObject baseObject) : base(baseObject)
        {
            InitializeComponent();
            comboSource = new List<String> { "st_person_position_list_combo", "st_person_status_list_combo", "st_person_role_list_combo" };
            comboValueMember = new List<String> { "id", "id", "id" };
            comboDisplayMember = new List<String> { "value", "value", "value" };
        }

        protected override void SetFields()
        {
            Person person = (Person)baseObject;
            if (person.Id == 0) Text = "Новый сотрудник";
            else Text = String.Format("Сотрудник: {0} {1}.{2}.", person.LastName, person.FirstName.Substring(0, 1), person.SecondName.Substring(0, 1));

            txtLastName.Text = person.LastName;
            txtFirstName.Text = person.FirstName;
            txtSecondName.Text = person.SecondName;
            txtAddress.Text = person.Address;
            dtDtBirth.Value = person.DtBirth;
            txtPhone.Text = person.Phone;
            cbPosition.SelectedValue = person.IdPosition;
            cbStatus.SelectedValue = person.IdStatus;
            chkAccess.Checked = txtLogin.Enabled = txtPassword.Enabled = cbRole.Enabled = person.Access != 0;
            txtLogin.Text = person.Login;
            cbRole.SelectedValue = person.IdRole;
        }

        protected override bool GetFields(out string errMessage)
        {
            errMessage = "";
            Person person = (Person)baseObject;
            person.LastName = txtLastName.Text;
            person.FirstName = txtFirstName.Text;
            person.SecondName = txtSecondName.Text;
            person.Address = txtAddress.Text;
            person.DtBirth = dtDtBirth.Value;
            person.Phone = txtPhone.Text;
            if (cbPosition.SelectedValue == null)
            {
                errMessage = "Не указана должность";
                return false;
            }
            person.IdPosition = (int)(cbPosition.SelectedValue);

            if (cbStatus.SelectedValue == null)
            {
                errMessage = "Не указан статус сотрудника";
                return false;
            }
            person.IdStatus = (int)(cbStatus.SelectedValue);

            person.Access = chkAccess.Checked ? 1 : 0;
            person.Login = chkAccess.Checked ? txtLogin.Text : null;
            person.NewPassword = chkAccess.Checked ? txtPassword.Text : null;

            if (chkAccess.Checked && cbRole.SelectedValue == null)
            {
                errMessage = "Не указана роль пользователя";
                return false;
            }
            person.IdRole = (int)cbRole.SelectedValue;

            return true;
        }

        private void OnOkClick(object sender, EventArgs e)
        {
            baseObject.SaveChildren = false;
            SaveObject();
        }

        private void OnAccessChkChanged(object sender, EventArgs e)
        {
            txtLogin.Enabled = txtPassword.Enabled = cbRole.Enabled = chkAccess.Checked;
            if (!chkAccess.Checked) txtLogin.Text = txtPassword.Text = "";
        }

        private void OnStatusChanged(object sender, EventArgs e)
        {
            if (cbStatus.SelectedValue == null) return;

        }
    }
}
