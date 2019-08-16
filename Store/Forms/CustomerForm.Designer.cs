namespace Store
{
    partial class CustomerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripCustomer = new System.Windows.Forms.ToolStrip();
            this.toolAddCustomer = new System.Windows.Forms.ToolStripButton();
            this.toolEditCustomer = new System.Windows.Forms.ToolStripButton();
            this.toolDeleteCustomer = new System.Windows.Forms.ToolStripButton();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.gridCustomer = new System.Windows.Forms.DataGridView();
            this.id_Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.full_name_Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address_Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.district_Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_district_Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpOrder = new System.Windows.Forms.GroupBox();
            this.gridOrder = new System.Windows.Forms.DataGridView();
            this.id_Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_beg_Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_end_Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_ship_Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note_Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_status_Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.toolStripCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.grpCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomer)).BeginInit();
            this.grpOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripCustomer
            // 
            this.toolStripCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.toolStripCustomer.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripCustomer.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripCustomer.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripCustomer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAddCustomer,
            this.toolEditCustomer,
            this.toolDeleteCustomer});
            this.toolStripCustomer.Location = new System.Drawing.Point(9, 9);
            this.toolStripCustomer.Name = "toolStripCustomer";
            this.toolStripCustomer.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripCustomer.Size = new System.Drawing.Size(122, 39);
            this.toolStripCustomer.TabIndex = 2;
            // 
            // toolAddCustomer
            // 
            this.toolAddCustomer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAddCustomer.Image = ((System.Drawing.Image)(resources.GetObject("toolAddCustomer.Image")));
            this.toolAddCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAddCustomer.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.toolAddCustomer.Name = "toolAddCustomer";
            this.toolAddCustomer.Size = new System.Drawing.Size(36, 36);
            this.toolAddCustomer.Text = "Добавить клиента";
            // 
            // toolEditCustomer
            // 
            this.toolEditCustomer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolEditCustomer.Image = ((System.Drawing.Image)(resources.GetObject("toolEditCustomer.Image")));
            this.toolEditCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolEditCustomer.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.toolEditCustomer.Name = "toolEditCustomer";
            this.toolEditCustomer.Size = new System.Drawing.Size(36, 36);
            this.toolEditCustomer.Text = "Редактировать клиента";
            // 
            // toolDeleteCustomer
            // 
            this.toolDeleteCustomer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolDeleteCustomer.Image = ((System.Drawing.Image)(resources.GetObject("toolDeleteCustomer.Image")));
            this.toolDeleteCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDeleteCustomer.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.toolDeleteCustomer.Name = "toolDeleteCustomer";
            this.toolDeleteCustomer.Size = new System.Drawing.Size(36, 36);
            this.toolDeleteCustomer.Text = "Удалить клиента";
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.grpCustomer);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.grpOrder);
            this.splitContainer.Size = new System.Drawing.Size(1117, 565);
            this.splitContainer.SplitterDistance = 413;
            this.splitContainer.TabIndex = 3;
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.gridCustomer);
            this.grpCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCustomer.Location = new System.Drawing.Point(0, 0);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(1117, 413);
            this.grpCustomer.TabIndex = 0;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Заказчики:";
            // 
            // gridCustomer
            // 
            this.gridCustomer.AllowUserToAddRows = false;
            this.gridCustomer.AllowUserToDeleteRows = false;
            this.gridCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridCustomer.ColumnHeadersHeight = 41;
            this.gridCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Customer,
            this.full_name_Customer,
            this.phone_Customer,
            this.address_Customer,
            this.district_Customer,
            this.id_district_Customer});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCustomer.DefaultCellStyle = dataGridViewCellStyle7;
            this.gridCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCustomer.Location = new System.Drawing.Point(3, 16);
            this.gridCustomer.MultiSelect = false;
            this.gridCustomer.Name = "gridCustomer";
            this.gridCustomer.ReadOnly = true;
            this.gridCustomer.RowHeadersWidth = 15;
            this.gridCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCustomer.ShowCellErrors = false;
            this.gridCustomer.ShowRowErrors = false;
            this.gridCustomer.Size = new System.Drawing.Size(1111, 394);
            this.gridCustomer.TabIndex = 0;
            this.gridCustomer.Tag = 0;
            this.gridCustomer.SelectionChanged += new System.EventHandler(this.OnSelectionChanged);
            // 
            // id_Customer
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.id_Customer.DefaultCellStyle = dataGridViewCellStyle2;
            this.id_Customer.HeaderText = "ID";
            this.id_Customer.Name = "id_Customer";
            this.id_Customer.ReadOnly = true;
            this.id_Customer.Width = 80;
            // 
            // full_name_Customer
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.full_name_Customer.DefaultCellStyle = dataGridViewCellStyle3;
            this.full_name_Customer.HeaderText = "Заказчик";
            this.full_name_Customer.Name = "full_name_Customer";
            this.full_name_Customer.ReadOnly = true;
            this.full_name_Customer.Width = 250;
            // 
            // phone_Customer
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.phone_Customer.DefaultCellStyle = dataGridViewCellStyle4;
            this.phone_Customer.HeaderText = "Телефон";
            this.phone_Customer.Name = "phone_Customer";
            this.phone_Customer.ReadOnly = true;
            this.phone_Customer.Width = 150;
            // 
            // address_Customer
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.address_Customer.DefaultCellStyle = dataGridViewCellStyle5;
            this.address_Customer.HeaderText = "Адрес";
            this.address_Customer.Name = "address_Customer";
            this.address_Customer.ReadOnly = true;
            this.address_Customer.Width = 250;
            // 
            // district_Customer
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.district_Customer.DefaultCellStyle = dataGridViewCellStyle6;
            this.district_Customer.HeaderText = "Район";
            this.district_Customer.Name = "district_Customer";
            this.district_Customer.ReadOnly = true;
            this.district_Customer.Width = 150;
            // 
            // id_district_Customer
            // 
            this.id_district_Customer.HeaderText = "id_district";
            this.id_district_Customer.Name = "id_district_Customer";
            this.id_district_Customer.ReadOnly = true;
            this.id_district_Customer.Visible = false;
            // 
            // grpOrder
            // 
            this.grpOrder.Controls.Add(this.gridOrder);
            this.grpOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpOrder.Location = new System.Drawing.Point(0, 0);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Size = new System.Drawing.Size(1117, 148);
            this.grpOrder.TabIndex = 0;
            this.grpOrder.TabStop = false;
            this.grpOrder.Text = "Заказы:";
            // 
            // gridOrder
            // 
            this.gridOrder.AllowUserToAddRows = false;
            this.gridOrder.AllowUserToDeleteRows = false;
            this.gridOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gridOrder.ColumnHeadersHeight = 41;
            this.gridOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Order,
            this.num_Order,
            this.dt_beg_Order,
            this.dt_end_Order,
            this.dt_ship_Order,
            this.status_Order,
            this.note_Order,
            this.dataGridViewTextBoxColumn1,
            this.id_status_Order});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridOrder.DefaultCellStyle = dataGridViewCellStyle16;
            this.gridOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridOrder.Location = new System.Drawing.Point(3, 16);
            this.gridOrder.MultiSelect = false;
            this.gridOrder.Name = "gridOrder";
            this.gridOrder.ReadOnly = true;
            this.gridOrder.RowHeadersWidth = 15;
            this.gridOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridOrder.ShowCellErrors = false;
            this.gridOrder.ShowRowErrors = false;
            this.gridOrder.Size = new System.Drawing.Size(1111, 129);
            this.gridOrder.TabIndex = 1;
            this.gridOrder.Tag = 1;
            // 
            // id_Order
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.id_Order.DefaultCellStyle = dataGridViewCellStyle9;
            this.id_Order.HeaderText = "ID";
            this.id_Order.Name = "id_Order";
            this.id_Order.ReadOnly = true;
            this.id_Order.Width = 80;
            // 
            // num_Order
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.num_Order.DefaultCellStyle = dataGridViewCellStyle10;
            this.num_Order.HeaderText = "№ заказа / квитанции";
            this.num_Order.Name = "num_Order";
            this.num_Order.ReadOnly = true;
            this.num_Order.Width = 80;
            // 
            // dt_beg_Order
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle11.Format = "dd.MM.yyyy";
            this.dt_beg_Order.DefaultCellStyle = dataGridViewCellStyle11;
            this.dt_beg_Order.HeaderText = "Дата заказа";
            this.dt_beg_Order.Name = "dt_beg_Order";
            this.dt_beg_Order.ReadOnly = true;
            // 
            // dt_end_Order
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle12.Format = "dd.MM.yyyy";
            this.dt_end_Order.DefaultCellStyle = dataGridViewCellStyle12;
            this.dt_end_Order.HeaderText = "Дата исполнения";
            this.dt_end_Order.Name = "dt_end_Order";
            this.dt_end_Order.ReadOnly = true;
            // 
            // dt_ship_Order
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle13.Format = "dd.MM.yyyy HH:mm";
            this.dt_ship_Order.DefaultCellStyle = dataGridViewCellStyle13;
            this.dt_ship_Order.HeaderText = "Дата отгрузки";
            this.dt_ship_Order.Name = "dt_ship_Order";
            this.dt_ship_Order.ReadOnly = true;
            // 
            // status_Order
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.status_Order.DefaultCellStyle = dataGridViewCellStyle14;
            this.status_Order.HeaderText = "Статус";
            this.status_Order.Name = "status_Order";
            this.status_Order.ReadOnly = true;
            // 
            // note_Order
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.note_Order.DefaultCellStyle = dataGridViewCellStyle15;
            this.note_Order.HeaderText = "Примечание";
            this.note_Order.Name = "note_Order";
            this.note_Order.ReadOnly = true;
            this.note_Order.Width = 250;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "id_customer";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // id_status_Order
            // 
            this.id_status_Order.HeaderText = "id_status";
            this.id_status_Order.Name = "id_status_Order";
            this.id_status_Order.ReadOnly = true;
            this.id_status_Order.Visible = false;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 565);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.toolStripCustomer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerForm";
            this.Text = "Заказчики";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.toolStripCustomer.ResumeLayout(false);
            this.toolStripCustomer.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.grpCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomer)).EndInit();
            this.grpOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripCustomer;
        private System.Windows.Forms.ToolStripButton toolAddCustomer;
        private System.Windows.Forms.ToolStripButton toolEditCustomer;
        private System.Windows.Forms.ToolStripButton toolDeleteCustomer;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.DataGridView gridCustomer;
        private System.Windows.Forms.GroupBox grpOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn full_name_Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn address_Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn district_Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_district_Customer;
        protected System.Windows.Forms.DataGridView gridOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_beg_Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_end_Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_ship_Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn note_Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_status_Order;
    }
}