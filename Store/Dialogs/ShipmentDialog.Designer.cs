namespace Store
{
    partial class ShipmentDialog
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShipmentDialog));
            this.txtID = new System.Windows.Forms.TextBox();
            this.dtDtBeginTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtDtBegin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtDtEndTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtDtEnd = new System.Windows.Forms.DateTimePicker();
            this.grpVehicle = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDriver = new System.Windows.Forms.ComboBox();
            this.cbVehicle = new System.Windows.Forms.ComboBox();
            this.grpPerson = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbAgent = new System.Windows.Forms.ComboBox();
            this.cbKeeper = new System.Windows.Forms.ComboBox();
            this.grpOrders = new System.Windows.Forms.GroupBox();
            this.gridDetail = new System.Windows.Forms.DataGridView();
            this.checked_Detail = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id_Detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_Detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_beg_Detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight_Detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_Detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address_Detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_shipment_Detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnForward = new System.Windows.Forms.Button();
            this.grpVehicle.SuspendLayout();
            this.grpPerson.SuspendLayout();
            this.grpOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(498, 543);
            this.btnOk.TabIndex = 9;
            this.btnOk.Click += new System.EventHandler(this.OnOkClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(604, 543);
            this.btnCancel.TabIndex = 10;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(154, 12);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 0;
            // 
            // dtDtBeginTime
            // 
            this.dtDtBeginTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtDtBeginTime.Location = new System.Drawing.Point(260, 64);
            this.dtDtBeginTime.Name = "dtDtBeginTime";
            this.dtDtBeginTime.ShowUpDown = true;
            this.dtDtBeginTime.Size = new System.Drawing.Size(79, 20);
            this.dtDtBeginTime.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Дата/время отгрузки:";
            // 
            // dtDtBegin
            // 
            this.dtDtBegin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDtBegin.Location = new System.Drawing.Point(154, 64);
            this.dtDtBegin.Name = "dtDtBegin";
            this.dtDtBegin.Size = new System.Drawing.Size(100, 20);
            this.dtDtBegin.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "ИД:";
            // 
            // dtDtEndTime
            // 
            this.dtDtEndTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDtEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtDtEndTime.Location = new System.Drawing.Point(260, 90);
            this.dtDtEndTime.Name = "dtDtEndTime";
            this.dtDtEndTime.ShowUpDown = true;
            this.dtDtEndTime.Size = new System.Drawing.Size(79, 20);
            this.dtDtEndTime.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Дата/время исполнения:";
            // 
            // dtDtEnd
            // 
            this.dtDtEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDtEnd.Location = new System.Drawing.Point(154, 90);
            this.dtDtEnd.Name = "dtDtEnd";
            this.dtDtEnd.Size = new System.Drawing.Size(100, 20);
            this.dtDtEnd.TabIndex = 4;
            // 
            // grpVehicle
            // 
            this.grpVehicle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpVehicle.Controls.Add(this.label8);
            this.grpVehicle.Controls.Add(this.txtCapacity);
            this.grpVehicle.Controls.Add(this.label4);
            this.grpVehicle.Controls.Add(this.label3);
            this.grpVehicle.Controls.Add(this.cbDriver);
            this.grpVehicle.Controls.Add(this.cbVehicle);
            this.grpVehicle.Location = new System.Drawing.Point(12, 116);
            this.grpVehicle.Name = "grpVehicle";
            this.grpVehicle.Size = new System.Drawing.Size(692, 74);
            this.grpVehicle.TabIndex = 6;
            this.grpVehicle.TabStop = false;
            this.grpVehicle.Text = "Автомобиль:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(515, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Грузоподъёмность:";
            // 
            // txtCapacity
            // 
            this.txtCapacity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCapacity.Location = new System.Drawing.Point(628, 20);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.ReadOnly = true;
            this.txtCapacity.Size = new System.Drawing.Size(58, 20);
            this.txtCapacity.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Водитель:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Автомобиль:";
            // 
            // cbDriver
            // 
            this.cbDriver.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDriver.FormattingEnabled = true;
            this.cbDriver.Location = new System.Drawing.Point(142, 46);
            this.cbDriver.Name = "cbDriver";
            this.cbDriver.Size = new System.Drawing.Size(544, 21);
            this.cbDriver.TabIndex = 2;
            this.cbDriver.Tag = 1;
            // 
            // cbVehicle
            // 
            this.cbVehicle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbVehicle.FormattingEnabled = true;
            this.cbVehicle.Location = new System.Drawing.Point(142, 19);
            this.cbVehicle.Name = "cbVehicle";
            this.cbVehicle.Size = new System.Drawing.Size(367, 21);
            this.cbVehicle.TabIndex = 0;
            this.cbVehicle.Tag = 0;
            this.cbVehicle.SelectedValueChanged += new System.EventHandler(this.OnVehicleSelectionChanged);
            // 
            // grpPerson
            // 
            this.grpPerson.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPerson.Controls.Add(this.label7);
            this.grpPerson.Controls.Add(this.label6);
            this.grpPerson.Controls.Add(this.cbAgent);
            this.grpPerson.Controls.Add(this.cbKeeper);
            this.grpPerson.Location = new System.Drawing.Point(12, 196);
            this.grpPerson.Name = "grpPerson";
            this.grpPerson.Size = new System.Drawing.Size(692, 75);
            this.grpPerson.TabIndex = 7;
            this.grpPerson.TabStop = false;
            this.grpPerson.Text = "Подписи:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Экспедитор:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Кладовщик:";
            // 
            // cbAgent
            // 
            this.cbAgent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAgent.FormattingEnabled = true;
            this.cbAgent.Location = new System.Drawing.Point(142, 46);
            this.cbAgent.Name = "cbAgent";
            this.cbAgent.Size = new System.Drawing.Size(544, 21);
            this.cbAgent.TabIndex = 1;
            this.cbAgent.Tag = 3;
            // 
            // cbKeeper
            // 
            this.cbKeeper.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbKeeper.FormattingEnabled = true;
            this.cbKeeper.Location = new System.Drawing.Point(142, 19);
            this.cbKeeper.Name = "cbKeeper";
            this.cbKeeper.Size = new System.Drawing.Size(544, 21);
            this.cbKeeper.TabIndex = 0;
            this.cbKeeper.Tag = 2;
            // 
            // grpOrders
            // 
            this.grpOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOrders.Controls.Add(this.gridDetail);
            this.grpOrders.Location = new System.Drawing.Point(12, 277);
            this.grpOrders.Name = "grpOrders";
            this.grpOrders.Size = new System.Drawing.Size(692, 260);
            this.grpOrders.TabIndex = 8;
            this.grpOrders.TabStop = false;
            this.grpOrders.Text = "Заказы";
            // 
            // gridDetail
            // 
            this.gridDetail.AllowUserToAddRows = false;
            this.gridDetail.AllowUserToDeleteRows = false;
            this.gridDetail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDetail.ColumnHeadersHeight = 41;
            this.gridDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checked_Detail,
            this.id_Detail,
            this.num_Detail,
            this.dt_beg_Detail,
            this.weight_Detail,
            this.customer_Detail,
            this.address_Detail,
            this.id_shipment_Detail});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDetail.DefaultCellStyle = dataGridViewCellStyle8;
            this.gridDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDetail.Location = new System.Drawing.Point(3, 16);
            this.gridDetail.MultiSelect = false;
            this.gridDetail.Name = "gridDetail";
            this.gridDetail.RowHeadersWidth = 15;
            this.gridDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDetail.ShowCellErrors = false;
            this.gridDetail.ShowRowErrors = false;
            this.gridDetail.Size = new System.Drawing.Size(686, 241);
            this.gridDetail.TabIndex = 0;
            this.gridDetail.Tag = 0;
            this.gridDetail.CurrentCellDirtyStateChanged += new System.EventHandler(this.OnDirtyStateChanged);
            // 
            // checked_Detail
            // 
            this.checked_Detail.FalseValue = "false";
            this.checked_Detail.Frozen = true;
            this.checked_Detail.HeaderText = "";
            this.checked_Detail.Name = "checked_Detail";
            this.checked_Detail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.checked_Detail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.checked_Detail.TrueValue = "true";
            this.checked_Detail.Width = 20;
            // 
            // id_Detail
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.id_Detail.DefaultCellStyle = dataGridViewCellStyle2;
            this.id_Detail.Frozen = true;
            this.id_Detail.HeaderText = "ID";
            this.id_Detail.Name = "id_Detail";
            this.id_Detail.ReadOnly = true;
            this.id_Detail.Width = 60;
            // 
            // num_Detail
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.num_Detail.DefaultCellStyle = dataGridViewCellStyle3;
            this.num_Detail.Frozen = true;
            this.num_Detail.HeaderText = "№ заказа / квитанции";
            this.num_Detail.Name = "num_Detail";
            this.num_Detail.ReadOnly = true;
            this.num_Detail.Width = 80;
            // 
            // dt_beg_Detail
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle4.Format = "dd.MM.yyyy";
            this.dt_beg_Detail.DefaultCellStyle = dataGridViewCellStyle4;
            this.dt_beg_Detail.HeaderText = "Дата заказа";
            this.dt_beg_Detail.Name = "dt_beg_Detail";
            this.dt_beg_Detail.ReadOnly = true;
            this.dt_beg_Detail.Width = 80;
            // 
            // weight_Detail
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.weight_Detail.DefaultCellStyle = dataGridViewCellStyle5;
            this.weight_Detail.HeaderText = "Вес";
            this.weight_Detail.Name = "weight_Detail";
            this.weight_Detail.ReadOnly = true;
            // 
            // customer_Detail
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.customer_Detail.DefaultCellStyle = dataGridViewCellStyle6;
            this.customer_Detail.HeaderText = "Заказчик";
            this.customer_Detail.Name = "customer_Detail";
            this.customer_Detail.ReadOnly = true;
            this.customer_Detail.Width = 150;
            // 
            // address_Detail
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.address_Detail.DefaultCellStyle = dataGridViewCellStyle7;
            this.address_Detail.HeaderText = "Адрес";
            this.address_Detail.Name = "address_Detail";
            this.address_Detail.ReadOnly = true;
            this.address_Detail.Width = 200;
            // 
            // id_shipment_Detail
            // 
            this.id_shipment_Detail.HeaderText = "id_shipment";
            this.id_shipment_Detail.Name = "id_shipment_Detail";
            this.id_shipment_Detail.ReadOnly = true;
            this.id_shipment_Detail.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(640, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(154, 38);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 20);
            this.txtNum.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Номер:";
            // 
            // btnForward
            // 
            this.btnForward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnForward.Image = ((System.Drawing.Image)(resources.GetObject("btnForward.Image")));
            this.btnForward.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnForward.Location = new System.Drawing.Point(12, 543);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(100, 38);
            this.btnForward.TabIndex = 49;
            this.btnForward.Text = "Вперед";
            this.btnForward.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.OnForwardClick);
            // 
            // ShipmentDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 593);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpOrders);
            this.Controls.Add(this.grpPerson);
            this.Controls.Add(this.grpVehicle);
            this.Controls.Add(this.dtDtEndTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtDtEnd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtDtBeginTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtDtBegin);
            this.Controls.Add(this.txtID);
            this.Name = "ShipmentDialog";
            this.Text = "ShipmentDialog";
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.dtDtBegin, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.dtDtBeginTime, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.dtDtEnd, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.dtDtEndTime, 0);
            this.Controls.SetChildIndex(this.grpVehicle, 0);
            this.Controls.SetChildIndex(this.grpPerson, 0);
            this.Controls.SetChildIndex(this.grpOrders, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.txtNum, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.btnForward, 0);
            this.grpVehicle.ResumeLayout(false);
            this.grpVehicle.PerformLayout();
            this.grpPerson.ResumeLayout(false);
            this.grpPerson.PerformLayout();
            this.grpOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DateTimePicker dtDtBeginTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtDtBegin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtDtEndTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtDtEnd;
        private System.Windows.Forms.GroupBox grpVehicle;
        private System.Windows.Forms.ComboBox cbDriver;
        private System.Windows.Forms.ComboBox cbVehicle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpPerson;
        private System.Windows.Forms.ComboBox cbAgent;
        private System.Windows.Forms.ComboBox cbKeeper;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpOrders;
        private System.Windows.Forms.PictureBox pictureBox1;
        protected System.Windows.Forms.DataGridView gridDetail;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checked_Detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_Detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_beg_Detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight_Detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_Detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn address_Detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_shipment_Detail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnForward;
    }
}