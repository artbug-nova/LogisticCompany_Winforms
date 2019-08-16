namespace Store
{
    partial class ShelfDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShelfDialog));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtMaxWeight = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtProcent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.gridBox = new System.Windows.Forms.DataGridView();
            this.id_status_Box = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note_Box = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_Box = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight_Box = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_Box = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(297, 334);
            this.btnOk.Click += new System.EventHandler(this.OnOkClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(403, 334);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(147, 12);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(66, 20);
            this.txtNum.TabIndex = 2;
            // 
            // txtMaxWeight
            // 
            this.txtMaxWeight.Location = new System.Drawing.Point(147, 38);
            this.txtMaxWeight.Name = "txtMaxWeight";
            this.txtMaxWeight.Size = new System.Drawing.Size(66, 20);
            this.txtMaxWeight.TabIndex = 3;
            this.txtMaxWeight.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidating);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(439, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // txtNote
            // 
            this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNote.Location = new System.Drawing.Point(147, 64);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(286, 20);
            this.txtNote.TabIndex = 5;
            // 
            // txtProcent
            // 
            this.txtProcent.Enabled = false;
            this.txtProcent.Location = new System.Drawing.Point(237, 38);
            this.txtProcent.Name = "txtProcent";
            this.txtProcent.Size = new System.Drawing.Size(66, 20);
            this.txtProcent.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Номер:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Макс. вес / % загрузки:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Примечание:";
            // 
            // grpBox
            // 
            this.grpBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBox.Controls.Add(this.gridBox);
            this.grpBox.Location = new System.Drawing.Point(12, 90);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(491, 238);
            this.grpBox.TabIndex = 11;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "Ящики:";
            // 
            // gridBox
            // 
            this.gridBox.AllowUserToAddRows = false;
            this.gridBox.AllowUserToDeleteRows = false;
            this.gridBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridBox.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.gridBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Box,
            this.weight_Box,
            this.status_Box,
            this.note_Box,
            this.id_status_Box});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridBox.DefaultCellStyle = dataGridViewCellStyle18;
            this.gridBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBox.Location = new System.Drawing.Point(3, 16);
            this.gridBox.MultiSelect = false;
            this.gridBox.Name = "gridBox";
            this.gridBox.ReadOnly = true;
            this.gridBox.RowHeadersWidth = 15;
            this.gridBox.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBox.Size = new System.Drawing.Size(485, 219);
            this.gridBox.TabIndex = 2;
            this.gridBox.Tag = 0;
            // 
            // id_status_Box
            // 
            this.id_status_Box.HeaderText = "id_status";
            this.id_status_Box.Name = "id_status_Box";
            this.id_status_Box.ReadOnly = true;
            this.id_status_Box.Visible = false;
            // 
            // note_Box
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.note_Box.DefaultCellStyle = dataGridViewCellStyle17;
            this.note_Box.HeaderText = "Примечание";
            this.note_Box.Name = "note_Box";
            this.note_Box.ReadOnly = true;
            this.note_Box.Width = 250;
            // 
            // status_Box
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.status_Box.DefaultCellStyle = dataGridViewCellStyle16;
            this.status_Box.HeaderText = "Статус";
            this.status_Box.Name = "status_Box";
            this.status_Box.ReadOnly = true;
            this.status_Box.Width = 70;
            // 
            // weight_Box
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.weight_Box.DefaultCellStyle = dataGridViewCellStyle15;
            this.weight_Box.HeaderText = "Вес";
            this.weight_Box.Name = "weight_Box";
            this.weight_Box.ReadOnly = true;
            this.weight_Box.Width = 60;
            // 
            // id_Box
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.id_Box.DefaultCellStyle = dataGridViewCellStyle14;
            this.id_Box.HeaderText = "ID";
            this.id_Box.Name = "id_Box";
            this.id_Box.ReadOnly = true;
            this.id_Box.Width = 60;
            // 
            // ShelfDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 384);
            this.Controls.Add(this.grpBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProcent);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtMaxWeight);
            this.Controls.Add(this.txtNum);
            this.Name = "ShelfDialog";
            this.Text = "ShelfDialog";
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.txtNum, 0);
            this.Controls.SetChildIndex(this.txtMaxWeight, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.txtNote, 0);
            this.Controls.SetChildIndex(this.txtProcent, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.grpBox, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtMaxWeight;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtProcent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpBox;
        protected System.Windows.Forms.DataGridView gridBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Box;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight_Box;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_Box;
        private System.Windows.Forms.DataGridViewTextBoxColumn note_Box;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_status_Box;
    }
}