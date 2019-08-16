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
    public partial class BoxForm : MDIChildBase
    {
        public BoxForm() : base()
        {
            InitializeComponent();
            toolStrip = toolStripBox;
        }

        public BoxForm(MDIForm mdiForm) : base(mdiForm)
        {
            InitializeComponent();
            toolStrip = toolStripBox;
            parentType = typeof(Box);
        }

        #region Настройка DataGridView

        protected override void SetGridParameters()
        {
            execute = new List<bool> { true };
            procedure = new List<String> { "st_box_list" };
            tables = new List<String> { "st_box_list" };
            queries = new List<String> { "" };
            columns = new List<List<String>> { new List<String> { "id", "weight", "length", "width", "height", "status", "note", "id_status"} };
            bindSources = new List<BindingSource> { new BindingSource() };
            adapters = new List<SqlDataAdapter> { new SqlDataAdapter() };
        }
        #endregion Настройка DataGridView

        protected override void SetControls(bool _on)
        {
            base.SetControls(_on);
        }

        protected override void SetFilters()
        {
            if (Person.CurrUser.IdRole == 2)
            {
                ((BindingSource)gridBox.DataSource).Filter = "id_status > 3";
            }
            else
            {
                ((BindingSource)gridBox.DataSource).Filter = "";
            }
        }

        private void OnFindBoxClick(object sender, EventArgs e)
        {
            int id = 0;
            if (!int.TryParse(toolFindText.Text, out id) || id == 0)
            {
                MessageBox.Show("Введен некорректный ID ящика. Поиск невозможен.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Box box = new Box(id, null, null, false);
            if (box.ErrCode != ErrCode.ErrOK)
            {
                MessageBox.Show("Ошибка загрузки объекта: " + box.ErrMessage, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (box.IdStatus != (int)OrderStatus.ToStore)
            {
                MessageBox.Show("Данный ящик находится в статусе \"" + box.Status + "\" и не может быть принят на склад", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            box.IdStatus = (int)OrderStatus.Stored;
            box.SetStatusToOrder();
            BoxDialog dialog = new BoxDialog(box);
            dialog.ShowDialog(this);
            if (dialog.DialogResult == DialogResult.OK)
            {
                if (execute != null)
                {
                    RetrieveForm(id);
                }
            }
        }

        private void OnBackBoxClick(object sender, EventArgs e)
        {
            int id = 0;
            if (!int.TryParse(toolFindText.Text, out id) || id == 0)
            {
                MessageBox.Show("Введен некорректный ID ящика. Поиск невозможен.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Box box = new Box(id, null, null, false);
            if (box.ErrCode != ErrCode.ErrOK)
            {
                MessageBox.Show("Ошибка загрузки объекта: " + box.ErrMessage, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (box.IdStatus != (int)OrderStatus.ToStore)
            {
                MessageBox.Show("Данный ящик находится в статусе \"" + box.Status + "\" и не может быть возвращен в работу", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Order order = null;
            if (box.Product != null && box.Product.Order != null) order = box.Product.Order;
            else
            {
                MessageBox.Show("Нарушение целостности данных, завершение операции невозможно", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            box.IdStatus = (int)OrderStatus.OnWork;
            box.SetStatusToOrder();
            order.SaveChildren = true;
            box.Product.SaveChildren = true;
            order.SaveToDB();
            if (order.ErrCode != ErrCode.ErrOK)
            {
                MessageBox.Show("Ошибка записи объекта: " + order.ErrMessage, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            RetrieveForm(id);
        }
    }
}
