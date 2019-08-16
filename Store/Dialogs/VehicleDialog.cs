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
    public partial class VehicleDialog : BaseObjectDialog
    {
        public VehicleDialog()
        {
            InitializeComponent();
        }
        public VehicleDialog(BaseObject baseObject) : base(baseObject)
        {
            InitializeComponent();
            comboSource = new List<String> { "st_vehicle_status_list_combo" };
            comboValueMember = new List<String> { "id" };
            comboDisplayMember = new List<String> { "value" };
        }

        protected override void SetFields()
        {
            Vehicle vehicle = (Vehicle)baseObject;
            if (vehicle.Id == 0) Text = "Новый автомобиль";
            else Text = String.Format("Автомобиль: {0}, г/н: {1}", vehicle.Mark, vehicle.StateNum);

            txtMark.Text = vehicle.Mark;
            txtStateNum.Text = vehicle.StateNum;
            cbStatus.SelectedValue = (int)vehicle.IdStatus;
            txtCapacity.Text = vehicle.Capacity.ToString();
            txtLength.Text = vehicle.Length.ToString();
            txtWidth.Text = vehicle.Width.ToString();
            txtHeight.Text = vehicle.Height.ToString();
        }

        protected override bool GetFields(out string errMessage)
        {
            errMessage = "";
            Vehicle vehicle = (Vehicle)baseObject;

            vehicle.Mark = txtMark.Text;
            vehicle.StateNum = txtStateNum.Text;
            if (cbStatus.SelectedItem == null)
            {
                errMessage = "Не указан статус автомобиля";
                return false;
            }
            vehicle.IdStatus = (int)cbStatus.SelectedValue;
            vehicle.Capacity = int.Parse(txtCapacity.Text);
            vehicle.Length = int.Parse(txtLength.Text);
            vehicle.Width = int.Parse(txtWidth.Text);
            vehicle.Height = int.Parse(txtHeight.Text);

            return true;
        }

        private void OnOkClick(object sender, EventArgs e)
        {
            baseObject.SaveChildren = false;
            SaveObject();
        }

        private void OnValidating(object sender, CancelEventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            int tmp = 0;
            if (!int.TryParse(txtBox.Text, out tmp))
            {
                MessageBox.Show("Некорректное целое число", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBox.BackColor = Color.Red;
                e.Cancel = true;
            }
            else if (tmp <= 0)
            {
                MessageBox.Show("Значение должно быть больше нуля", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBox.BackColor = Color.Red;
                e.Cancel = true;
            }
            else txtBox.BackColor = SystemColors.Window;
        }

    }
}
