namespace Store
{
    partial class ShipmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShipmentForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripShipment = new System.Windows.Forms.ToolStrip();
            this.toolAddShipment = new System.Windows.Forms.ToolStripButton();
            this.toolEditShipment = new System.Windows.Forms.ToolStripButton();
            this.toolDeleteShipment = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolPrint = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolShipmentRep = new System.Windows.Forms.ToolStripMenuItem();
            this.toolRouteRep = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolCustomerRep = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.grpShipment = new System.Windows.Forms.GroupBox();
            this.gridShipment = new System.Windows.Forms.DataGridView();
            this.id_Shipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_Shipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_beg_Shipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_end_Shipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicle_Shipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driver_Shipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agent_Shipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keeper_Shipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_Shipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_status_Shipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpOrder = new System.Windows.Forms.GroupBox();
            this.gridDetail = new System.Windows.Forms.DataGridView();
            this.id_Detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_Detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_beg_Detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_Detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address_Detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_shipment_Detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_order_Detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.toolStripShipment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.grpShipment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridShipment)).BeginInit();
            this.grpOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripShipment
            // 
            this.toolStripShipment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.toolStripShipment.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripShipment.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripShipment.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripShipment.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAddShipment,
            this.toolEditShipment,
            this.toolDeleteShipment,
            this.toolStripSeparator1,
            this.toolPrint});
            this.toolStripShipment.Location = new System.Drawing.Point(0, 0);
            this.toolStripShipment.Name = "toolStripShipment";
            this.toolStripShipment.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripShipment.Size = new System.Drawing.Size(173, 39);
            this.toolStripShipment.TabIndex = 5;
            // 
            // toolAddShipment
            // 
            this.toolAddShipment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAddShipment.Image = ((System.Drawing.Image)(resources.GetObject("toolAddShipment.Image")));
            this.toolAddShipment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAddShipment.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.toolAddShipment.Name = "toolAddShipment";
            this.toolAddShipment.Size = new System.Drawing.Size(36, 36);
            this.toolAddShipment.Text = "Добавить отгрузку";
            // 
            // toolEditShipment
            // 
            this.toolEditShipment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolEditShipment.Image = ((System.Drawing.Image)(resources.GetObject("toolEditShipment.Image")));
            this.toolEditShipment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolEditShipment.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.toolEditShipment.Name = "toolEditShipment";
            this.toolEditShipment.Size = new System.Drawing.Size(36, 36);
            this.toolEditShipment.Text = "Редактировать отгрузку";
            // 
            // toolDeleteShipment
            // 
            this.toolDeleteShipment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolDeleteShipment.Image = ((System.Drawing.Image)(resources.GetObject("toolDeleteShipment.Image")));
            this.toolDeleteShipment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDeleteShipment.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.toolDeleteShipment.Name = "toolDeleteShipment";
            this.toolDeleteShipment.Size = new System.Drawing.Size(36, 36);
            this.toolDeleteShipment.Text = "Удалить отгрузку";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolPrint
            // 
            this.toolPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolPrint.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolShipmentRep,
            this.toolRouteRep,
            this.toolStripMenuItem1,
            this.toolCustomerRep});
            this.toolPrint.Image = ((System.Drawing.Image)(resources.GetObject("toolPrint.Image")));
            this.toolPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPrint.Name = "toolPrint";
            this.toolPrint.Size = new System.Drawing.Size(45, 36);
            this.toolPrint.Text = "Печать";
            // 
            // toolShipmentRep
            // 
            this.toolShipmentRep.Image = ((System.Drawing.Image)(resources.GetObject("toolShipmentRep.Image")));
            this.toolShipmentRep.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolShipmentRep.Name = "toolShipmentRep";
            this.toolShipmentRep.Size = new System.Drawing.Size(250, 30);
            this.toolShipmentRep.Text = "Накладная на отгрузку";
            this.toolShipmentRep.Click += new System.EventHandler(this.OnShipRepClick);
            // 
            // toolRouteRep
            // 
            this.toolRouteRep.Image = ((System.Drawing.Image)(resources.GetObject("toolRouteRep.Image")));
            this.toolRouteRep.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolRouteRep.Name = "toolRouteRep";
            this.toolRouteRep.Size = new System.Drawing.Size(250, 30);
            this.toolRouteRep.Text = "Путевой лист";
            this.toolRouteRep.Click += new System.EventHandler(this.OnRouteRepClick);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(247, 6);
            // 
            // toolCustomerRep
            // 
            this.toolCustomerRep.Image = ((System.Drawing.Image)(resources.GetObject("toolCustomerRep.Image")));
            this.toolCustomerRep.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolCustomerRep.Name = "toolCustomerRep";
            this.toolCustomerRep.Size = new System.Drawing.Size(250, 30);
            this.toolCustomerRep.Text = "Накладная на выдачу заказчику";
            this.toolCustomerRep.Click += new System.EventHandler(this.OnCustomerRepForm);
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
            this.splitContainer.Panel1.Controls.Add(this.grpShipment);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.grpOrder);
            this.splitContainer.Size = new System.Drawing.Size(1088, 570);
            this.splitContainer.SplitterDistance = 412;
            this.splitContainer.TabIndex = 6;
            // 
            // grpShipment
            // 
            this.grpShipment.Controls.Add(this.gridShipment);
            this.grpShipment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpShipment.Location = new System.Drawing.Point(0, 0);
            this.grpShipment.Name = "grpShipment";
            this.grpShipment.Size = new System.Drawing.Size(1088, 412);
            this.grpShipment.TabIndex = 0;
            this.grpShipment.TabStop = false;
            this.grpShipment.Text = "Отгрузки:";
            // 
            // gridShipment
            // 
            this.gridShipment.AllowUserToAddRows = false;
            this.gridShipment.AllowUserToDeleteRows = false;
            this.gridShipment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridShipment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridShipment.ColumnHeadersHeight = 41;
            this.gridShipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridShipment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Shipment,
            this.num_Shipment,
            this.dt_beg_Shipment,
            this.dt_end_Shipment,
            this.vehicle_Shipment,
            this.driver_Shipment,
            this.agent_Shipment,
            this.keeper_Shipment,
            this.status_Shipment,
            this.id_status_Shipment});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridShipment.DefaultCellStyle = dataGridViewCellStyle11;
            this.gridShipment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridShipment.Location = new System.Drawing.Point(3, 16);
            this.gridShipment.MultiSelect = false;
            this.gridShipment.Name = "gridShipment";
            this.gridShipment.ReadOnly = true;
            this.gridShipment.RowHeadersWidth = 15;
            this.gridShipment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridShipment.Size = new System.Drawing.Size(1082, 393);
            this.gridShipment.TabIndex = 1;
            this.gridShipment.Tag = 0;
            // 
            // id_Shipment
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.id_Shipment.DefaultCellStyle = dataGridViewCellStyle2;
            this.id_Shipment.HeaderText = "ID";
            this.id_Shipment.Name = "id_Shipment";
            this.id_Shipment.ReadOnly = true;
            this.id_Shipment.Width = 80;
            // 
            // num_Shipment
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.num_Shipment.DefaultCellStyle = dataGridViewCellStyle3;
            this.num_Shipment.HeaderText = "№ отгрузки";
            this.num_Shipment.Name = "num_Shipment";
            this.num_Shipment.ReadOnly = true;
            this.num_Shipment.Width = 80;
            // 
            // dt_beg_Shipment
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle4.Format = "dd.MM.yyyy HH:mm";
            this.dt_beg_Shipment.DefaultCellStyle = dataGridViewCellStyle4;
            this.dt_beg_Shipment.HeaderText = "Дата/время отгрузки";
            this.dt_beg_Shipment.Name = "dt_beg_Shipment";
            this.dt_beg_Shipment.ReadOnly = true;
            // 
            // dt_end_Shipment
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle5.Format = "dd.MM.yyyy HH:mm";
            this.dt_end_Shipment.DefaultCellStyle = dataGridViewCellStyle5;
            this.dt_end_Shipment.HeaderText = "Дата/время исполнения";
            this.dt_end_Shipment.Name = "dt_end_Shipment";
            this.dt_end_Shipment.ReadOnly = true;
            // 
            // vehicle_Shipment
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.vehicle_Shipment.DefaultCellStyle = dataGridViewCellStyle6;
            this.vehicle_Shipment.HeaderText = "Марка/гос.номер автомобиля";
            this.vehicle_Shipment.Name = "vehicle_Shipment";
            this.vehicle_Shipment.ReadOnly = true;
            this.vehicle_Shipment.Width = 150;
            // 
            // driver_Shipment
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.driver_Shipment.DefaultCellStyle = dataGridViewCellStyle7;
            this.driver_Shipment.HeaderText = "Водитель";
            this.driver_Shipment.Name = "driver_Shipment";
            this.driver_Shipment.ReadOnly = true;
            this.driver_Shipment.Width = 200;
            // 
            // agent_Shipment
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.agent_Shipment.DefaultCellStyle = dataGridViewCellStyle8;
            this.agent_Shipment.HeaderText = "Экспедитор";
            this.agent_Shipment.Name = "agent_Shipment";
            this.agent_Shipment.ReadOnly = true;
            this.agent_Shipment.Width = 200;
            // 
            // keeper_Shipment
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.keeper_Shipment.DefaultCellStyle = dataGridViewCellStyle9;
            this.keeper_Shipment.HeaderText = "Кладовщик";
            this.keeper_Shipment.Name = "keeper_Shipment";
            this.keeper_Shipment.ReadOnly = true;
            this.keeper_Shipment.Width = 200;
            // 
            // status_Shipment
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.status_Shipment.DefaultCellStyle = dataGridViewCellStyle10;
            this.status_Shipment.HeaderText = "Статус";
            this.status_Shipment.Name = "status_Shipment";
            this.status_Shipment.ReadOnly = true;
            // 
            // id_status_Shipment
            // 
            this.id_status_Shipment.HeaderText = "id_status";
            this.id_status_Shipment.Name = "id_status_Shipment";
            this.id_status_Shipment.ReadOnly = true;
            this.id_status_Shipment.Visible = false;
            // 
            // grpOrder
            // 
            this.grpOrder.Controls.Add(this.gridDetail);
            this.grpOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpOrder.Location = new System.Drawing.Point(0, 0);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Size = new System.Drawing.Size(1088, 154);
            this.grpOrder.TabIndex = 0;
            this.grpOrder.TabStop = false;
            this.grpOrder.Text = "Заказы:";
            // 
            // gridDetail
            // 
            this.gridDetail.AllowUserToAddRows = false;
            this.gridDetail.AllowUserToDeleteRows = false;
            this.gridDetail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.gridDetail.ColumnHeadersHeight = 41;
            this.gridDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Detail,
            this.num_Detail,
            this.dt_beg_Detail,
            this.customer_Detail,
            this.address_Detail,
            this.id_shipment_Detail,
            this.id_order_Detail});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDetail.DefaultCellStyle = dataGridViewCellStyle18;
            this.gridDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDetail.Location = new System.Drawing.Point(3, 16);
            this.gridDetail.MultiSelect = false;
            this.gridDetail.Name = "gridDetail";
            this.gridDetail.ReadOnly = true;
            this.gridDetail.RowHeadersWidth = 15;
            this.gridDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDetail.ShowCellErrors = false;
            this.gridDetail.ShowRowErrors = false;
            this.gridDetail.Size = new System.Drawing.Size(1082, 135);
            this.gridDetail.TabIndex = 1;
            this.gridDetail.Tag = 1;
            // 
            // id_Detail
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.id_Detail.DefaultCellStyle = dataGridViewCellStyle13;
            this.id_Detail.HeaderText = "ID";
            this.id_Detail.Name = "id_Detail";
            this.id_Detail.ReadOnly = true;
            this.id_Detail.Width = 80;
            // 
            // num_Detail
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.num_Detail.DefaultCellStyle = dataGridViewCellStyle14;
            this.num_Detail.HeaderText = "№ заказа / квитанции";
            this.num_Detail.Name = "num_Detail";
            this.num_Detail.ReadOnly = true;
            this.num_Detail.Width = 80;
            // 
            // dt_beg_Detail
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle15.Format = "dd.MM.yyyy";
            this.dt_beg_Detail.DefaultCellStyle = dataGridViewCellStyle15;
            this.dt_beg_Detail.HeaderText = "Дата заказа";
            this.dt_beg_Detail.Name = "dt_beg_Detail";
            this.dt_beg_Detail.ReadOnly = true;
            // 
            // customer_Detail
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.customer_Detail.DefaultCellStyle = dataGridViewCellStyle16;
            this.customer_Detail.HeaderText = "Заказчик";
            this.customer_Detail.Name = "customer_Detail";
            this.customer_Detail.ReadOnly = true;
            this.customer_Detail.Width = 250;
            // 
            // address_Detail
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.address_Detail.DefaultCellStyle = dataGridViewCellStyle17;
            this.address_Detail.HeaderText = "Адрес";
            this.address_Detail.Name = "address_Detail";
            this.address_Detail.ReadOnly = true;
            this.address_Detail.Width = 250;
            // 
            // id_shipment_Detail
            // 
            this.id_shipment_Detail.HeaderText = "id_shipment";
            this.id_shipment_Detail.Name = "id_shipment_Detail";
            this.id_shipment_Detail.ReadOnly = true;
            this.id_shipment_Detail.Visible = false;
            // 
            // id_order_Detail
            // 
            this.id_order_Detail.HeaderText = "id_order";
            this.id_order_Detail.Name = "id_order_Detail";
            this.id_order_Detail.ReadOnly = true;
            this.id_order_Detail.Visible = false;
            // 
            // ShipmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 570);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.toolStripShipment);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShipmentForm";
            this.Text = "Отгрузки";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.toolStripShipment.ResumeLayout(false);
            this.toolStripShipment.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.grpShipment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridShipment)).EndInit();
            this.grpOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripShipment;
        private System.Windows.Forms.ToolStripButton toolAddShipment;
        private System.Windows.Forms.ToolStripButton toolEditShipment;
        private System.Windows.Forms.ToolStripButton toolDeleteShipment;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.GroupBox grpShipment;
        private System.Windows.Forms.GroupBox grpOrder;
        protected System.Windows.Forms.DataGridView gridDetail;
        protected System.Windows.Forms.DataGridView gridShipment;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Shipment;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_Shipment;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_beg_Shipment;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_end_Shipment;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicle_Shipment;
        private System.Windows.Forms.DataGridViewTextBoxColumn driver_Shipment;
        private System.Windows.Forms.DataGridViewTextBoxColumn agent_Shipment;
        private System.Windows.Forms.DataGridViewTextBoxColumn keeper_Shipment;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_Shipment;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_status_Shipment;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton toolPrint;
        private System.Windows.Forms.ToolStripMenuItem toolShipmentRep;
        private System.Windows.Forms.ToolStripMenuItem toolRouteRep;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolCustomerRep;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_Detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_beg_Detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_Detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn address_Detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_shipment_Detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_order_Detail;
    }
}