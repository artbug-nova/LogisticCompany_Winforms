namespace Store
{
    partial class ProductForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpProduct = new System.Windows.Forms.GroupBox();
            this.gridProduct = new System.Windows.Forms.DataGridView();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.gridBox = new System.Windows.Forms.DataGridView();
            this.id_Box = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight_Box = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.length_Box = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.width_Box = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.height_Box = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_Box = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note_Box = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_product_Box = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_status_Box = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_beg_Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_order_Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_status_Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).BeginInit();
            this.grpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBox)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grpProduct);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grpBox);
            this.splitContainer1.Size = new System.Drawing.Size(874, 547);
            this.splitContainer1.SplitterDistance = 291;
            this.splitContainer1.TabIndex = 0;
            // 
            // grpProduct
            // 
            this.grpProduct.Controls.Add(this.gridProduct);
            this.grpProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpProduct.Location = new System.Drawing.Point(0, 0);
            this.grpProduct.Name = "grpProduct";
            this.grpProduct.Size = new System.Drawing.Size(874, 291);
            this.grpProduct.TabIndex = 2;
            this.grpProduct.TabStop = false;
            this.grpProduct.Text = "Товары:";
            // 
            // gridProduct
            // 
            this.gridProduct.AllowUserToAddRows = false;
            this.gridProduct.AllowUserToDeleteRows = false;
            this.gridProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridProduct.ColumnHeadersHeight = 41;
            this.gridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Product,
            this.name_Product,
            this.num_Product,
            this.dt_beg_Product,
            this.status_Product,
            this.customer_Product,
            this.id_order_Product,
            this.id_status_Product});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridProduct.DefaultCellStyle = dataGridViewCellStyle8;
            this.gridProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProduct.Location = new System.Drawing.Point(3, 16);
            this.gridProduct.MultiSelect = false;
            this.gridProduct.Name = "gridProduct";
            this.gridProduct.ReadOnly = true;
            this.gridProduct.RowHeadersWidth = 15;
            this.gridProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProduct.Size = new System.Drawing.Size(868, 272);
            this.gridProduct.TabIndex = 0;
            this.gridProduct.Tag = 0;
            this.gridProduct.SelectionChanged += new System.EventHandler(this.OnSelectionChanged);
            // 
            // grpBox
            // 
            this.grpBox.Controls.Add(this.gridBox);
            this.grpBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBox.Location = new System.Drawing.Point(0, 0);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(874, 252);
            this.grpBox.TabIndex = 2;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "Ящики:";
            // 
            // gridBox
            // 
            this.gridBox.AllowUserToAddRows = false;
            this.gridBox.AllowUserToDeleteRows = false;
            this.gridBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridBox.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gridBox.ColumnHeadersHeight = 41;
            this.gridBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridBox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Box,
            this.weight_Box,
            this.length_Box,
            this.width_Box,
            this.height_Box,
            this.status_Box,
            this.note_Box,
            this.id_product_Box,
            this.id_status_Box});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridBox.DefaultCellStyle = dataGridViewCellStyle17;
            this.gridBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBox.Location = new System.Drawing.Point(3, 16);
            this.gridBox.MultiSelect = false;
            this.gridBox.Name = "gridBox";
            this.gridBox.ReadOnly = true;
            this.gridBox.RowHeadersWidth = 15;
            this.gridBox.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBox.Size = new System.Drawing.Size(868, 233);
            this.gridBox.TabIndex = 0;
            this.gridBox.Tag = 1;
            // 
            // id_Box
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.id_Box.DefaultCellStyle = dataGridViewCellStyle10;
            this.id_Box.HeaderText = "ID";
            this.id_Box.Name = "id_Box";
            this.id_Box.ReadOnly = true;
            this.id_Box.Width = 80;
            // 
            // weight_Box
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.weight_Box.DefaultCellStyle = dataGridViewCellStyle11;
            this.weight_Box.HeaderText = "Вес";
            this.weight_Box.Name = "weight_Box";
            this.weight_Box.ReadOnly = true;
            // 
            // length_Box
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.length_Box.DefaultCellStyle = dataGridViewCellStyle12;
            this.length_Box.HeaderText = "Длина";
            this.length_Box.Name = "length_Box";
            this.length_Box.ReadOnly = true;
            // 
            // width_Box
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.width_Box.DefaultCellStyle = dataGridViewCellStyle13;
            this.width_Box.HeaderText = "Ширина";
            this.width_Box.Name = "width_Box";
            this.width_Box.ReadOnly = true;
            // 
            // height_Box
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.height_Box.DefaultCellStyle = dataGridViewCellStyle14;
            this.height_Box.HeaderText = "Высота";
            this.height_Box.Name = "height_Box";
            this.height_Box.ReadOnly = true;
            // 
            // status_Box
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.status_Box.DefaultCellStyle = dataGridViewCellStyle15;
            this.status_Box.HeaderText = "Статус";
            this.status_Box.Name = "status_Box";
            this.status_Box.ReadOnly = true;
            // 
            // note_Box
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.note_Box.DefaultCellStyle = dataGridViewCellStyle16;
            this.note_Box.HeaderText = "Примечание";
            this.note_Box.Name = "note_Box";
            this.note_Box.ReadOnly = true;
            this.note_Box.Width = 250;
            // 
            // id_product_Box
            // 
            this.id_product_Box.HeaderText = "id_product";
            this.id_product_Box.Name = "id_product_Box";
            this.id_product_Box.ReadOnly = true;
            this.id_product_Box.Visible = false;
            // 
            // id_status_Box
            // 
            this.id_status_Box.HeaderText = "id_status";
            this.id_status_Box.Name = "id_status_Box";
            this.id_status_Box.ReadOnly = true;
            this.id_status_Box.Visible = false;
            // 
            // id_Product
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.id_Product.DefaultCellStyle = dataGridViewCellStyle2;
            this.id_Product.HeaderText = "ID";
            this.id_Product.Name = "id_Product";
            this.id_Product.ReadOnly = true;
            this.id_Product.Width = 80;
            // 
            // name_Product
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.name_Product.DefaultCellStyle = dataGridViewCellStyle3;
            this.name_Product.HeaderText = "Название";
            this.name_Product.Name = "name_Product";
            this.name_Product.ReadOnly = true;
            this.name_Product.Width = 250;
            // 
            // num_Product
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.num_Product.DefaultCellStyle = dataGridViewCellStyle4;
            this.num_Product.HeaderText = "№ заказа / квитанции";
            this.num_Product.Name = "num_Product";
            this.num_Product.ReadOnly = true;
            this.num_Product.Width = 80;
            // 
            // dt_beg_Product
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle5.Format = "dd.MM.yyyy";
            this.dt_beg_Product.DefaultCellStyle = dataGridViewCellStyle5;
            this.dt_beg_Product.HeaderText = "Дата заказа";
            this.dt_beg_Product.Name = "dt_beg_Product";
            this.dt_beg_Product.ReadOnly = true;
            // 
            // status_Product
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.status_Product.DefaultCellStyle = dataGridViewCellStyle6;
            this.status_Product.HeaderText = "Статус";
            this.status_Product.Name = "status_Product";
            this.status_Product.ReadOnly = true;
            // 
            // customer_Product
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.customer_Product.DefaultCellStyle = dataGridViewCellStyle7;
            this.customer_Product.HeaderText = "Заказчик";
            this.customer_Product.Name = "customer_Product";
            this.customer_Product.ReadOnly = true;
            this.customer_Product.Width = 250;
            // 
            // id_order_Product
            // 
            this.id_order_Product.HeaderText = "id_order";
            this.id_order_Product.Name = "id_order_Product";
            this.id_order_Product.ReadOnly = true;
            this.id_order_Product.Visible = false;
            // 
            // id_status_Product
            // 
            this.id_status_Product.HeaderText = "id_status";
            this.id_status_Product.Name = "id_status_Product";
            this.id_status_Product.ReadOnly = true;
            this.id_status_Product.Visible = false;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 547);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductForm";
            this.Text = "Товары";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).EndInit();
            this.grpBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grpProduct;
        protected System.Windows.Forms.DataGridView gridProduct;
        private System.Windows.Forms.GroupBox grpBox;
        protected System.Windows.Forms.DataGridView gridBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Box;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight_Box;
        private System.Windows.Forms.DataGridViewTextBoxColumn length_Box;
        private System.Windows.Forms.DataGridViewTextBoxColumn width_Box;
        private System.Windows.Forms.DataGridViewTextBoxColumn height_Box;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_Box;
        private System.Windows.Forms.DataGridViewTextBoxColumn note_Box;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_product_Box;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_status_Box;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_beg_Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_order_Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_status_Product;
    }
}