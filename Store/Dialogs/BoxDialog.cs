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
    public partial class BoxDialog : BaseObjectDialog
    {
        public BoxDialog() : base()
        {
            InitializeComponent();
        }

        public BoxDialog(BaseObject baseObject) : base(baseObject)
        {
            InitializeComponent();
            comboSource = new List<String> { "st_rack_list" };
            comboValueMember = new List<String> { "id" };
            comboDisplayMember = new List<String> { "num" };
        }
        protected override void SetFields()
        {
            Box box = (Box)baseObject;
            if (box.Id == 0) Text = "Новый ящик";
            else Text = "Ящик ID: " + box.Id.ToString() + "; статус: " + box.Status;

            txtIdOrder.Text = box.Product.Order.Id.ToString();
            txtNum.Text = box.Product.Order.Num;
            dtDtBeg.Value = box.Product.Order.DtBeg;
            txtBoxCount.Text = box.Product.Order.BoxCount.ToString();
            txtTotalWeight.Text = box.Product.Order.TotalWeight.ToString();
            txtId.Text = box.Id.ToString();
            txtWeight.Text = box.Weight.ToString();
            txtNote.Text = box.Note;
            txtLength.Text = box.Length.ToString();
            txtWidth.Text = box.Width.ToString();
            txtHeight.Text = box.Height.ToString();
            cbRack.SelectedValue = box.IdRack;
            cbShelf.SelectedValueChanged -= OnSelectShelf;
            cbShelf.SelectedValue = box.IdShelf;
            cbShelf.SelectedValueChanged += OnSelectShelf;
        }

        protected override bool GetFields(out string errMessage)
        {
            bool result = true;
            errMessage = "";
            Box box = (Box)baseObject;

            box.Weight = int.Parse(txtWeight.Text);
            box.Length = int.Parse(txtLength.Text);
            box.Width = int.Parse(txtWidth.Text);
            box.Height = int.Parse(txtHeight.Text);
            box.Note = txtNote.Text;
            if (box.IdStatus == (int)OrderStatus.Stored && cbShelf.SelectedValue == null)
            {
                errMessage = "В статусе \"" + box.Status + "\" необходимо назначить место хранения";
                return false;
            }
            if (box.IdStatus != (int)OrderStatus.Stored && cbShelf.SelectedValue != null)
            {
                errMessage = "В статусе \"" + box.Status + "\" место хранения назначать нельзя";
                return false;
            }
            box.IdShelf = cbShelf.SelectedValue == null ? 0 : (int)cbShelf.SelectedValue;
            return result;
        }

        private void OnOKClick(object sender, EventArgs e)
        {
            Box box = (Box)baseObject;
            baseObject.SaveChildren = true;
            SaveObject();
            if (box.Parent == null)
            {
                ((Product)box.Product).SaveChildren = true;
                ((Order)((Product)box.Product).Order).SaveChildren = true;
                ((Order)((Product)box.Product).Order).SaveToDB();
            }
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

        private void OnSelectRack(object sender, EventArgs e)
        {
            int idRack = cbRack.SelectedValue == null ? 0 : (int)cbRack.SelectedValue;
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand();
            command.Connection = SQLConnection.GetConnection();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "st_shelf_list_combo";
            command.Parameters.AddWithValue("@id_rack", idRack);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            cbShelf.DataSource = null;
            cbShelf.DataSource = table;
            cbShelf.ValueMember = "id";
            cbShelf.DisplayMember = "disp_value";
        }

        private void OnSelectShelf(object sender, EventArgs e)
        {
            Box box = (Box)baseObject;
            if (cbShelf.SelectedValue == null) return;
            DataRowView row = (DataRowView)cbShelf.SelectedItem;
            if ((int)row["free_place"] < box.Weight)
            {
                MessageBox.Show("Полка перегружена, возможно нарушение правил хранения", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
    }
}
