namespace Store
{
    partial class CustomerDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDialog));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.cbDistrict = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grpOrders = new System.Windows.Forms.GroupBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(481, 363);
            this.btnOk.Click += new System.EventHandler(this.OnOkClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(587, 363);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(77, 12);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(137, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(77, 38);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(137, 20);
            this.txtFirstName.TabIndex = 3;
            // 
            // txtSecondName
            // 
            this.txtSecondName.Location = new System.Drawing.Point(77, 64);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(137, 20);
            this.txtSecondName.TabIndex = 4;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Location = new System.Drawing.Point(77, 90);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(610, 20);
            this.txtAddress.TabIndex = 5;
            // 
            // cbDistrict
            // 
            this.cbDistrict.FormattingEnabled = true;
            this.cbDistrict.Location = new System.Drawing.Point(77, 116);
            this.cbDistrict.Name = "cbDistrict";
            this.cbDistrict.Size = new System.Drawing.Size(137, 21);
            this.cbDistrict.TabIndex = 6;
            this.cbDistrict.Tag = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(623, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Фамилия:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Имя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Отчество:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Адрес:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Район:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(77, 143);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(137, 20);
            this.txtPhone.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Телефон:";
            // 
            // grpOrders
            // 
            this.grpOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOrders.Controls.Add(this.gridOrder);
            this.grpOrders.Location = new System.Drawing.Point(12, 169);
            this.grpOrders.Name = "grpOrders";
            this.grpOrders.Size = new System.Drawing.Size(675, 188);
            this.grpOrders.TabIndex = 15;
            this.grpOrders.TabStop = false;
            this.grpOrders.Text = "Заказы:";
            // 
            // gridOrder
            // 
            this.gridOrder.AllowUserToAddRows = false;
            this.gridOrder.AllowUserToDeleteRows = false;
            this.gridOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridOrder.DefaultCellStyle = dataGridViewCellStyle9;
            this.gridOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridOrder.Location = new System.Drawing.Point(3, 16);
            this.gridOrder.MultiSelect = false;
            this.gridOrder.Name = "gridOrder";
            this.gridOrder.ReadOnly = true;
            this.gridOrder.RowHeadersWidth = 15;
            this.gridOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridOrder.Size = new System.Drawing.Size(669, 169);
            this.gridOrder.TabIndex = 2;
            this.gridOrder.Tag = 0;
            // 
            // id_Order
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.id_Order.DefaultCellStyle = dataGridViewCellStyle2;
            this.id_Order.HeaderText = "ID";
            this.id_Order.Name = "id_Order";
            this.id_Order.ReadOnly = true;
            this.id_Order.Width = 80;
            // 
            // num_Order
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.num_Order.DefaultCellStyle = dataGridViewCellStyle3;
            this.num_Order.HeaderText = "№ заказа / квитанции";
            this.num_Order.Name = "num_Order";
            this.num_Order.ReadOnly = true;
            this.num_Order.Width = 80;
            // 
            // dt_beg_Order
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle4.Format = "dd.MM.yyyy";
            this.dt_beg_Order.DefaultCellStyle = dataGridViewCellStyle4;
            this.dt_beg_Order.HeaderText = "Дата заказа";
            this.dt_beg_Order.Name = "dt_beg_Order";
            this.dt_beg_Order.ReadOnly = true;
            // 
            // dt_end_Order
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle5.Format = "dd.MM.yyyy";
            this.dt_end_Order.DefaultCellStyle = dataGridViewCellStyle5;
            this.dt_end_Order.HeaderText = "Дата исполнения";
            this.dt_end_Order.Name = "dt_end_Order";
            this.dt_end_Order.ReadOnly = true;
            // 
            // dt_ship_Order
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle6.Format = "dd.MM.yyyy HH:mm";
            this.dt_ship_Order.DefaultCellStyle = dataGridViewCellStyle6;
            this.dt_ship_Order.HeaderText = "Дата отгрузки";
            this.dt_ship_Order.Name = "dt_ship_Order";
            this.dt_ship_Order.ReadOnly = true;
            // 
            // status_Order
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.status_Order.DefaultCellStyle = dataGridViewCellStyle7;
            this.status_Order.HeaderText = "Статус";
            this.status_Order.Name = "status_Order";
            this.status_Order.ReadOnly = true;
            // 
            // note_Order
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.note_Order.DefaultCellStyle = dataGridViewCellStyle8;
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
            // CustomerDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 413);
            this.Controls.Add(this.grpOrders);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbDistrict);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtSecondName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Name = "CustomerDialog";
            this.Text = "CustomerDialog";
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.txtLastName, 0);
            this.Controls.SetChildIndex(this.txtFirstName, 0);
            this.Controls.SetChildIndex(this.txtSecondName, 0);
            this.Controls.SetChildIndex(this.txtAddress, 0);
            this.Controls.SetChildIndex(this.cbDistrict, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtPhone, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.grpOrders, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ComboBox cbDistrict;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpOrders;
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