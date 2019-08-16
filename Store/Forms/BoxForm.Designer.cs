namespace Store
{
    partial class BoxForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoxForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripBox = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolFindText = new System.Windows.Forms.ToolStripTextBox();
            this.toolFindBox = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBackBox = new System.Windows.Forms.ToolStripButton();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.gridBox = new System.Windows.Forms.DataGridView();
            this.id_Box = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight_Box = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.length_Box = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.width_Box = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.height_Box = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_Box = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note_Box = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_status_Box = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.toolStripBox.SuspendLayout();
            this.grpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBox)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripBox
            // 
            this.toolStripBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.toolStripBox.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripBox.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripBox.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolFindText,
            this.toolFindBox,
            this.toolStripSeparator1,
            this.toolBackBox});
            this.toolStripBox.Location = new System.Drawing.Point(0, 0);
            this.toolStripBox.Name = "toolStripBox";
            this.toolStripBox.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripBox.Size = new System.Drawing.Size(281, 39);
            this.toolStripBox.TabIndex = 3;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(58, 36);
            this.toolStripLabel1.Text = "ID ящика:";
            // 
            // toolFindText
            // 
            this.toolFindText.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.toolFindText.Name = "toolFindText";
            this.toolFindText.Size = new System.Drawing.Size(100, 36);
            // 
            // toolFindBox
            // 
            this.toolFindBox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolFindBox.Image = ((System.Drawing.Image)(resources.GetObject("toolFindBox.Image")));
            this.toolFindBox.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolFindBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.toolFindBox.Name = "toolFindBox";
            this.toolFindBox.Size = new System.Drawing.Size(36, 36);
            this.toolFindBox.Text = "Принять ящик";
            this.toolFindBox.Click += new System.EventHandler(this.OnFindBoxClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolBackBox
            // 
            this.toolBackBox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBackBox.Image = ((System.Drawing.Image)(resources.GetObject("toolBackBox.Image")));
            this.toolBackBox.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBackBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.toolBackBox.Name = "toolBackBox";
            this.toolBackBox.Size = new System.Drawing.Size(36, 36);
            this.toolBackBox.Text = "Вернуть ящик";
            this.toolBackBox.Click += new System.EventHandler(this.OnBackBoxClick);
            // 
            // grpBox
            // 
            this.grpBox.Controls.Add(this.gridBox);
            this.grpBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBox.Location = new System.Drawing.Point(0, 0);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(1002, 585);
            this.grpBox.TabIndex = 4;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "Ящики:";
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
            this.id_status_Box});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridBox.DefaultCellStyle = dataGridViewCellStyle9;
            this.gridBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBox.Location = new System.Drawing.Point(3, 16);
            this.gridBox.MultiSelect = false;
            this.gridBox.Name = "gridBox";
            this.gridBox.ReadOnly = true;
            this.gridBox.RowHeadersWidth = 15;
            this.gridBox.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBox.Size = new System.Drawing.Size(996, 566);
            this.gridBox.TabIndex = 0;
            this.gridBox.Tag = 0;
            // 
            // id_Box
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.id_Box.DefaultCellStyle = dataGridViewCellStyle2;
            this.id_Box.HeaderText = "ID";
            this.id_Box.Name = "id_Box";
            this.id_Box.ReadOnly = true;
            this.id_Box.Width = 80;
            // 
            // weight_Box
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.weight_Box.DefaultCellStyle = dataGridViewCellStyle3;
            this.weight_Box.HeaderText = "Вес";
            this.weight_Box.Name = "weight_Box";
            this.weight_Box.ReadOnly = true;
            // 
            // length_Box
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.length_Box.DefaultCellStyle = dataGridViewCellStyle4;
            this.length_Box.HeaderText = "Длина";
            this.length_Box.Name = "length_Box";
            this.length_Box.ReadOnly = true;
            // 
            // width_Box
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.width_Box.DefaultCellStyle = dataGridViewCellStyle5;
            this.width_Box.HeaderText = "Ширина";
            this.width_Box.Name = "width_Box";
            this.width_Box.ReadOnly = true;
            // 
            // height_Box
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.height_Box.DefaultCellStyle = dataGridViewCellStyle6;
            this.height_Box.HeaderText = "Высота";
            this.height_Box.Name = "height_Box";
            this.height_Box.ReadOnly = true;
            // 
            // status_Box
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.status_Box.DefaultCellStyle = dataGridViewCellStyle7;
            this.status_Box.HeaderText = "Статус";
            this.status_Box.Name = "status_Box";
            this.status_Box.ReadOnly = true;
            // 
            // note_Box
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.note_Box.DefaultCellStyle = dataGridViewCellStyle8;
            this.note_Box.HeaderText = "Примечание";
            this.note_Box.Name = "note_Box";
            this.note_Box.ReadOnly = true;
            this.note_Box.Width = 250;
            // 
            // id_status_Box
            // 
            this.id_status_Box.HeaderText = "id_status";
            this.id_status_Box.Name = "id_status_Box";
            this.id_status_Box.ReadOnly = true;
            this.id_status_Box.Visible = false;
            // 
            // BoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 585);
            this.Controls.Add(this.grpBox);
            this.Controls.Add(this.toolStripBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BoxForm";
            this.Text = "Ящики";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.toolStripBox.ResumeLayout(false);
            this.toolStripBox.PerformLayout();
            this.grpBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripBox;
        private System.Windows.Forms.ToolStripButton toolFindBox;
        private System.Windows.Forms.ToolStripButton toolBackBox;
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
        private System.Windows.Forms.ToolStripTextBox toolFindText;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}