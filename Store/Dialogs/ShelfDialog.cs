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
    public partial class ShelfDialog : BaseObjectDialog
    {
        public ShelfDialog() : base()
        {
            InitializeComponent();
        }

        public ShelfDialog(BaseObject baseObject) : base(baseObject)
        {
            InitializeComponent();
            columns = new List<List<String>> { new List<String> { "Id", "Weight", "Status", "Note", "IdStatus" } };
        }

        protected override void SetGrids()
        {
            base.SetGrids();
            gridBox.DataSource = null;
            if (((Shelf)baseObject).ChildList.Count > 0 && ((Shelf)baseObject).ChildList[0].Count > 0) gridBox.DataSource = ((Shelf)baseObject).ChildList[0].ConvertAll<Box>(delegate (BaseObject baseObject) { return (Box)baseObject; });
        }

        protected override void SetFields()
        {
            Shelf shelf = (Shelf)baseObject;
            if (shelf.Id == 0) Text = "Новая полка";
            else Text = String.Format("Полка: {0}", shelf.Num);

            txtNum.Text = shelf.Num;
            txtMaxWeight.Text = shelf.MaxWeight.ToString();
            txtProcent.Text = shelf.Procent.ToString("0.00");
            txtNote.Text = shelf.Note;
        }

        protected override bool GetFields(out string errMessage)
        {
            errMessage = "";
            Shelf shelf = (Shelf)baseObject;
            shelf.Num = txtNum.Text;
            shelf.MaxWeight = int.Parse(txtMaxWeight.Text);
            shelf.Note = txtNote.Text;
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
