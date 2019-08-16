namespace Store
{
    partial class RackDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RackDialog));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpShelf = new System.Windows.Forms.GroupBox();
            this.gridShelf = new System.Windows.Forms.DataGridView();
            this.num_Shelf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.max_weight_Shelf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note_Shelf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procent_Shelf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_rack_Shelf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelShelf = new System.Windows.Forms.Button();
            this.btnEditShelf = new System.Windows.Forms.Button();
            this.btnAddShelf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpShelf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridShelf)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(380, 334);
            this.btnOk.Click += new System.EventHandler(this.OnOKClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(486, 334);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(91, 12);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 20);
            this.txtNum.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(522, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtNote
            // 
            this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNote.Location = new System.Drawing.Point(91, 38);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(425, 20);
            this.txtNote.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Номер:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Примечание:";
            // 
            // grpShelf
            // 
            this.grpShelf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpShelf.Controls.Add(this.gridShelf);
            this.grpShelf.Controls.Add(this.btnDelShelf);
            this.grpShelf.Controls.Add(this.btnEditShelf);
            this.grpShelf.Controls.Add(this.btnAddShelf);
            this.grpShelf.Location = new System.Drawing.Point(12, 82);
            this.grpShelf.Name = "grpShelf";
            this.grpShelf.Size = new System.Drawing.Size(574, 246);
            this.grpShelf.TabIndex = 7;
            this.grpShelf.TabStop = false;
            this.grpShelf.Text = "Полки:";
            // 
            // gridShelf
            // 
            this.gridShelf.AllowUserToAddRows = false;
            this.gridShelf.AllowUserToDeleteRows = false;
            this.gridShelf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridShelf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridShelf.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridShelf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridShelf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num_Shelf,
            this.max_weight_Shelf,
            this.note_Shelf,
            this.procent_Shelf,
            this.id_rack_Shelf});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridShelf.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridShelf.Location = new System.Drawing.Point(3, 63);
            this.gridShelf.MultiSelect = false;
            this.gridShelf.Name = "gridShelf";
            this.gridShelf.ReadOnly = true;
            this.gridShelf.RowHeadersWidth = 15;
            this.gridShelf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridShelf.ShowCellErrors = false;
            this.gridShelf.ShowRowErrors = false;
            this.gridShelf.Size = new System.Drawing.Size(568, 180);
            this.gridShelf.TabIndex = 6;
            this.gridShelf.Tag = 0;
            // 
            // num_Shelf
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.num_Shelf.DefaultCellStyle = dataGridViewCellStyle2;
            this.num_Shelf.HeaderText = "Номер";
            this.num_Shelf.Name = "num_Shelf";
            this.num_Shelf.ReadOnly = true;
            this.num_Shelf.Width = 80;
            // 
            // max_weight_Shelf
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.max_weight_Shelf.DefaultCellStyle = dataGridViewCellStyle3;
            this.max_weight_Shelf.HeaderText = "Максимальный вес";
            this.max_weight_Shelf.Name = "max_weight_Shelf";
            this.max_weight_Shelf.ReadOnly = true;
            // 
            // note_Shelf
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.note_Shelf.DefaultCellStyle = dataGridViewCellStyle4;
            this.note_Shelf.HeaderText = "Примечание";
            this.note_Shelf.Name = "note_Shelf";
            this.note_Shelf.ReadOnly = true;
            this.note_Shelf.Width = 250;
            // 
            // procent_Shelf
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle5.Format = "0.00";
            this.procent_Shelf.DefaultCellStyle = dataGridViewCellStyle5;
            this.procent_Shelf.HeaderText = "% загрузки";
            this.procent_Shelf.Name = "procent_Shelf";
            this.procent_Shelf.ReadOnly = true;
            // 
            // id_rack_Shelf
            // 
            this.id_rack_Shelf.HeaderText = "id_rack";
            this.id_rack_Shelf.Name = "id_rack_Shelf";
            this.id_rack_Shelf.ReadOnly = true;
            this.id_rack_Shelf.Visible = false;
            // 
            // btnDelShelf
            // 
            this.btnDelShelf.AutoSize = true;
            this.btnDelShelf.Image = ((System.Drawing.Image)(resources.GetObject("btnDelShelf.Image")));
            this.btnDelShelf.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDelShelf.Location = new System.Drawing.Point(218, 19);
            this.btnDelShelf.Name = "btnDelShelf";
            this.btnDelShelf.Size = new System.Drawing.Size(100, 38);
            this.btnDelShelf.TabIndex = 5;
            this.btnDelShelf.Tag = 0;
            this.btnDelShelf.Text = "Удалить";
            this.btnDelShelf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelShelf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelShelf.UseVisualStyleBackColor = true;
            // 
            // btnEditShelf
            // 
            this.btnEditShelf.AutoSize = true;
            this.btnEditShelf.Image = ((System.Drawing.Image)(resources.GetObject("btnEditShelf.Image")));
            this.btnEditShelf.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEditShelf.Location = new System.Drawing.Point(112, 19);
            this.btnEditShelf.Name = "btnEditShelf";
            this.btnEditShelf.Size = new System.Drawing.Size(100, 38);
            this.btnEditShelf.TabIndex = 4;
            this.btnEditShelf.Tag = 0;
            this.btnEditShelf.Text = "Изменить";
            this.btnEditShelf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditShelf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditShelf.UseVisualStyleBackColor = true;
            // 
            // btnAddShelf
            // 
            this.btnAddShelf.AutoSize = true;
            this.btnAddShelf.Image = ((System.Drawing.Image)(resources.GetObject("btnAddShelf.Image")));
            this.btnAddShelf.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAddShelf.Location = new System.Drawing.Point(6, 19);
            this.btnAddShelf.Name = "btnAddShelf";
            this.btnAddShelf.Size = new System.Drawing.Size(100, 38);
            this.btnAddShelf.TabIndex = 3;
            this.btnAddShelf.Tag = 0;
            this.btnAddShelf.Text = "Добавить";
            this.btnAddShelf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddShelf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddShelf.UseVisualStyleBackColor = true;
            // 
            // RackDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 384);
            this.Controls.Add(this.grpShelf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtNum);
            this.Name = "RackDialog";
            this.Text = "RackDialog";
            this.Controls.SetChildIndex(this.txtNum, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.txtNote, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.grpShelf, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpShelf.ResumeLayout(false);
            this.grpShelf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridShelf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpShelf;
        private System.Windows.Forms.Button btnDelShelf;
        private System.Windows.Forms.Button btnEditShelf;
        private System.Windows.Forms.Button btnAddShelf;
        protected System.Windows.Forms.DataGridView gridShelf;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_Shelf;
        private System.Windows.Forms.DataGridViewTextBoxColumn max_weight_Shelf;
        private System.Windows.Forms.DataGridViewTextBoxColumn note_Shelf;
        private System.Windows.Forms.DataGridViewTextBoxColumn procent_Shelf;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_rack_Shelf;
    }
}