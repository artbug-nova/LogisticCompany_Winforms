namespace Store
{
    partial class ProductDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductDialog));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpOrder = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.dtDtBeg = new System.Windows.Forms.DateTimePicker();
            this.txtId = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.btnDelBox = new System.Windows.Forms.Button();
            this.btnEditBox = new System.Windows.Forms.Button();
            this.btnAddBox = new System.Windows.Forms.Button();
            this.gridBox = new System.Windows.Forms.DataGridView();
            this.id_Box = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight_Box = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.length_Box = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.width_Box = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.height_Box = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_Box = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note_Box = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_status_Box = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(403, 418);
            this.btnOk.Click += new System.EventHandler(this.OnOKClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(509, 418);
            // 
            // grpOrder
            // 
            this.grpOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOrder.Controls.Add(this.label3);
            this.grpOrder.Controls.Add(this.label2);
            this.grpOrder.Controls.Add(this.label1);
            this.grpOrder.Controls.Add(this.txtNum);
            this.grpOrder.Controls.Add(this.dtDtBeg);
            this.grpOrder.Controls.Add(this.txtId);
            this.grpOrder.Enabled = false;
            this.grpOrder.Location = new System.Drawing.Point(12, 7);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Size = new System.Drawing.Size(527, 101);
            this.grpOrder.TabIndex = 2;
            this.grpOrder.TabStop = false;
            this.grpOrder.Text = "Информация о заказе:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Дата заказа:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Номер квитанции:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Идентификатор:";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(117, 45);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 20);
            this.txtNum.TabIndex = 30;
            // 
            // dtDtBeg
            // 
            this.dtDtBeg.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDtBeg.Location = new System.Drawing.Point(117, 71);
            this.dtDtBeg.Name = "dtDtBeg";
            this.dtDtBeg.Size = new System.Drawing.Size(100, 20);
            this.dtDtBeg.TabIndex = 31;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(117, 19);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(545, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(129, 114);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(410, 20);
            this.txtName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Название товара:";
            // 
            // grpBox
            // 
            this.grpBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBox.Controls.Add(this.btnDelBox);
            this.grpBox.Controls.Add(this.btnEditBox);
            this.grpBox.Controls.Add(this.btnAddBox);
            this.grpBox.Controls.Add(this.gridBox);
            this.grpBox.Location = new System.Drawing.Point(12, 140);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(597, 272);
            this.grpBox.TabIndex = 6;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "Ящики:";
            // 
            // btnDelBox
            // 
            this.btnDelBox.AutoSize = true;
            this.btnDelBox.Image = ((System.Drawing.Image)(resources.GetObject("btnDelBox.Image")));
            this.btnDelBox.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDelBox.Location = new System.Drawing.Point(218, 19);
            this.btnDelBox.Name = "btnDelBox";
            this.btnDelBox.Size = new System.Drawing.Size(100, 38);
            this.btnDelBox.TabIndex = 5;
            this.btnDelBox.Tag = 0;
            this.btnDelBox.Text = "Удалить";
            this.btnDelBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelBox.UseVisualStyleBackColor = true;
            // 
            // btnEditBox
            // 
            this.btnEditBox.AutoSize = true;
            this.btnEditBox.Image = ((System.Drawing.Image)(resources.GetObject("btnEditBox.Image")));
            this.btnEditBox.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEditBox.Location = new System.Drawing.Point(112, 19);
            this.btnEditBox.Name = "btnEditBox";
            this.btnEditBox.Size = new System.Drawing.Size(100, 38);
            this.btnEditBox.TabIndex = 4;
            this.btnEditBox.Tag = 0;
            this.btnEditBox.Text = "Изменить";
            this.btnEditBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditBox.UseVisualStyleBackColor = true;
            // 
            // btnAddBox
            // 
            this.btnAddBox.AutoSize = true;
            this.btnAddBox.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBox.Image")));
            this.btnAddBox.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAddBox.Location = new System.Drawing.Point(6, 19);
            this.btnAddBox.Name = "btnAddBox";
            this.btnAddBox.Size = new System.Drawing.Size(100, 38);
            this.btnAddBox.TabIndex = 3;
            this.btnAddBox.Tag = 0;
            this.btnAddBox.Text = "Добавить";
            this.btnAddBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddBox.UseVisualStyleBackColor = true;
            // 
            // gridBox
            // 
            this.gridBox.AllowUserToAddRows = false;
            this.gridBox.AllowUserToDeleteRows = false;
            this.gridBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridBox.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Box,
            this.weight_Box,
            this.length_Box,
            this.width_Box,
            this.height_Box,
            this.status_Box,
            this.note_Box,
            this.id_status_Box});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridBox.DefaultCellStyle = dataGridViewCellStyle9;
            this.gridBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridBox.Location = new System.Drawing.Point(3, 63);
            this.gridBox.MultiSelect = false;
            this.gridBox.Name = "gridBox";
            this.gridBox.ReadOnly = true;
            this.gridBox.RowHeadersWidth = 15;
            this.gridBox.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBox.Size = new System.Drawing.Size(591, 206);
            this.gridBox.TabIndex = 1;
            this.gridBox.Tag = 0;
            // 
            // id_Box
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.id_Box.DefaultCellStyle = dataGridViewCellStyle2;
            this.id_Box.HeaderText = "ID";
            this.id_Box.Name = "id_Box";
            this.id_Box.ReadOnly = true;
            this.id_Box.Width = 60;
            // 
            // weight_Box
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.weight_Box.DefaultCellStyle = dataGridViewCellStyle3;
            this.weight_Box.HeaderText = "Вес";
            this.weight_Box.Name = "weight_Box";
            this.weight_Box.ReadOnly = true;
            this.weight_Box.Width = 60;
            // 
            // length_Box
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.length_Box.DefaultCellStyle = dataGridViewCellStyle4;
            this.length_Box.HeaderText = "Длина";
            this.length_Box.Name = "length_Box";
            this.length_Box.ReadOnly = true;
            this.length_Box.Width = 60;
            // 
            // width_Box
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.width_Box.DefaultCellStyle = dataGridViewCellStyle5;
            this.width_Box.HeaderText = "Ширина";
            this.width_Box.Name = "width_Box";
            this.width_Box.ReadOnly = true;
            this.width_Box.Width = 60;
            // 
            // height_Box
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.height_Box.DefaultCellStyle = dataGridViewCellStyle6;
            this.height_Box.HeaderText = "Высота";
            this.height_Box.Name = "height_Box";
            this.height_Box.ReadOnly = true;
            this.height_Box.Width = 60;
            // 
            // status_Box
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.status_Box.DefaultCellStyle = dataGridViewCellStyle7;
            this.status_Box.HeaderText = "Статус";
            this.status_Box.Name = "status_Box";
            this.status_Box.ReadOnly = true;
            this.status_Box.Width = 70;
            // 
            // note_Box
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.note_Box.DefaultCellStyle = dataGridViewCellStyle8;
            this.note_Box.HeaderText = "Примечание";
            this.note_Box.Name = "note_Box";
            this.note_Box.ReadOnly = true;
            this.note_Box.Width = 200;
            // 
            // id_status_Box
            // 
            this.id_status_Box.HeaderText = "id_status";
            this.id_status_Box.Name = "id_status_Box";
            this.id_status_Box.ReadOnly = true;
            this.id_status_Box.Visible = false;
            // 
            // ProductDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 468);
            this.Controls.Add(this.grpBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpOrder);
            this.Name = "ProductDialog";
            this.Text = "ProductDialog";
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.grpOrder, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.grpBox, 0);
            this.grpOrder.ResumeLayout(false);
            this.grpOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOrder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.DateTimePicker dtDtBeg;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpBox;
        protected System.Windows.Forms.DataGridView gridBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Box;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight_Box;
        private System.Windows.Forms.DataGridViewTextBoxColumn length_Box;
        private System.Windows.Forms.DataGridViewTextBoxColumn width_Box;
        private System.Windows.Forms.DataGridViewTextBoxColumn height_Box;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_Box;
        private System.Windows.Forms.DataGridViewTextBoxColumn note_Box;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_status_Box;
        private System.Windows.Forms.Button btnDelBox;
        private System.Windows.Forms.Button btnEditBox;
        private System.Windows.Forms.Button btnAddBox;
    }
}