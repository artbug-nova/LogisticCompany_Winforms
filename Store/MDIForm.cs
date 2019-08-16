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
    public partial class MDIForm : Form
    {
        private List<Type> childForms = new List<Type> { typeof(OrderForm), typeof(ProductForm), typeof(BoxForm), typeof(RackForm), typeof(CustomerForm), typeof(VehicleForm), /*typeof(DistrictForm)*/null, typeof(PersonForm), typeof(ShipmentForm) };
        public MDIForm()
        {
            InitializeComponent();
        }

        private void OnClickItemMenu(object sender, EventArgs e)
        {
            int itemIndex = (int)((ToolStripMenuItem)sender).Tag;
            ((ToolStripMenuItem)sender).BackColor = Color.FromArgb(224, 224, 224);
            foreach (ToolStripMenuItem _item in menuStrip.Items)
            {
                if (_item != sender) _item.BackColor = SystemColors.Control;
            }
            foreach (Control toolMenu in panelMenu.Controls)
            {
                if (toolMenu.Tag != null && (int)toolMenu.Tag == itemIndex) toolMenu.Visible = true;
                else if (toolMenu.Tag != null && (int)toolMenu.Tag != itemIndex) toolMenu.Visible = false;
            }
            MoveToolStrip();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            OnClickItemMenu(itemStore, new EventArgs());
            statusUser.Text = String.Format("Работает: {0} {1} {2}; должность: {3}; права: {4}", Person.CurrUser.LastName, Person.CurrUser.FirstName, Person.CurrUser.SecondName, Person.CurrUser.Position, Person.CurrUser.Role);
        }

        public void ChangeWindowList(Form closedForm = null)
        {
            toolWindows.DropDownItems.Clear();
            ToolStripItem item;
            foreach (Form form in this.MdiChildren)
            {
                if (form != closedForm)
                {
                    item = toolWindows.DropDownItems.Add(form.Text, form.Icon.ToBitmap());
                    item.Tag = form;
                    item.ImageScaling = ToolStripItemImageScaling.None;
                    item.Click += OnClickChildWindow;
                }
            }
        }

        private void OnClickChildWindow(object sender, EventArgs e)
        {
            if (((ToolStripItem)sender).Tag != null && ((ToolStripItem)sender).Tag is Form) ((Form)((ToolStripItem)sender).Tag).Activate();
        }


        public void SetToolStrip(ToolStrip toolStrip)
        {
            panelMenu.Controls.Add(toolStrip);
            toolStrip.Visible = true;
            MoveToolStrip();
        }

        public void RemoveToolStrip(ToolStrip toolStrip)
        {
            panelMenu.Controls.Remove(toolStrip);
        }

        private void MoveToolStrip()
        {
            ToolStrip activeStrip = null;
            ToolStrip addedStrip = null;
            foreach (Control control in panelMenu.Controls)
            {
                if (control.Tag != null && control.Visible) activeStrip = (ToolStrip)control;
                if (control.Tag == null) addedStrip = (ToolStrip)control;
            }
            if (addedStrip != null)
            {
                addedStrip.Left = activeStrip != null ? activeStrip.Left + activeStrip.Width + 16 : 4;
                addedStrip.Top = 4;
            }
        }

        public void SetControls(bool _on)
        {
            statusLoading.Visible = statusProgressBar.Visible = !_on;
            panelMenu.Enabled = _on;
        }

        private void OnOpenFormClick(object sender, EventArgs e)
        {
            if (!(((ToolStripButton)sender).Tag != null && ((ToolStripButton)sender).Tag is int)) return;
            Type childType = childForms[(int)(((ToolStripButton)sender).Tag)];
            if (childType == null)
            {
                MessageBox.Show("Выбранная форма не настроена", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            Form childObject = MdiChildren.ToList<Form>().Find(f => f.GetType() == childType);
            MDIChildBase childForm = childObject == null ? null : (MDIChildBase)childObject;
            if (childForm == null)
            {
                childForm = (MDIChildBase)childType.GetConstructor(new Type[] { typeof(MDIForm) }).Invoke(new object[] { this });
                childForm.Show();
            }
            else
            {
                childForm.Activate();
                childForm.WindowState = FormWindowState.Maximized;
            }
        }

        private void OnAboutClick(object sender, EventArgs e)
        {
            AboutDialog dialog = new AboutDialog();
            dialog.ShowDialog(this);
        }
    }
}
