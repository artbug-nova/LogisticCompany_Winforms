namespace Store
{
    partial class BoxDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoxDialog));
            this.grpOrder = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalWeight = new System.Windows.Forms.TextBox();
            this.txtBoxCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.dtDtBeg = new System.Windows.Forms.DateTimePicker();
            this.txtIdOrder = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbShelf = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbRack = new System.Windows.Forms.ComboBox();
            this.grpOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(301, 335);
            this.btnOk.TabIndex = 7;
            this.btnOk.Click += new System.EventHandler(this.OnOKClick);
            // 
            // btnCancel
            // 
            this.btnCancel.CausesValidation = false;
            this.btnCancel.Location = new System.Drawing.Point(407, 335);
            this.btnCancel.TabIndex = 8;
            // 
            // grpOrder
            // 
            this.grpOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOrder.Controls.Add(this.label4);
            this.grpOrder.Controls.Add(this.label5);
            this.grpOrder.Controls.Add(this.txtTotalWeight);
            this.grpOrder.Controls.Add(this.txtBoxCount);
            this.grpOrder.Controls.Add(this.label3);
            this.grpOrder.Controls.Add(this.label2);
            this.grpOrder.Controls.Add(this.label1);
            this.grpOrder.Controls.Add(this.txtNum);
            this.grpOrder.Controls.Add(this.dtDtBeg);
            this.grpOrder.Controls.Add(this.txtIdOrder);
            this.grpOrder.Enabled = false;
            this.grpOrder.Location = new System.Drawing.Point(12, 6);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Size = new System.Drawing.Size(425, 158);
            this.grpOrder.TabIndex = 0;
            this.grpOrder.TabStop = false;
            this.grpOrder.Text = "Информация о заказе:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Общий вес:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Количество мест:";
            // 
            // txtTotalWeight
            // 
            this.txtTotalWeight.Enabled = false;
            this.txtTotalWeight.Location = new System.Drawing.Point(117, 123);
            this.txtTotalWeight.Name = "txtTotalWeight";
            this.txtTotalWeight.Size = new System.Drawing.Size(100, 20);
            this.txtTotalWeight.TabIndex = 4;
            // 
            // txtBoxCount
            // 
            this.txtBoxCount.Enabled = false;
            this.txtBoxCount.Location = new System.Drawing.Point(117, 97);
            this.txtBoxCount.Name = "txtBoxCount";
            this.txtBoxCount.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCount.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Дата заказа:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Номер квитанции:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
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
            this.txtNum.TabIndex = 1;
            // 
            // dtDtBeg
            // 
            this.dtDtBeg.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDtBeg.Location = new System.Drawing.Point(117, 71);
            this.dtDtBeg.Name = "dtDtBeg";
            this.dtDtBeg.Size = new System.Drawing.Size(100, 20);
            this.dtDtBeg.TabIndex = 2;
            // 
            // txtIdOrder
            // 
            this.txtIdOrder.Enabled = false;
            this.txtIdOrder.Location = new System.Drawing.Point(117, 19);
            this.txtIdOrder.Name = "txtIdOrder";
            this.txtIdOrder.Size = new System.Drawing.Size(100, 20);
            this.txtIdOrder.TabIndex = 0;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(108, 170);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 1;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(108, 196);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 20);
            this.txtWeight.TabIndex = 2;
            this.txtWeight.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Идентификатор:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Вес:";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(66, 248);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 20);
            this.txtLength.TabIndex = 4;
            this.txtLength.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidating);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(234, 248);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWidth.TabIndex = 5;
            this.txtWidth.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidating);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(404, 248);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 6;
            this.txtHeight.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Длина:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(177, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Ширина";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(345, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Высота:";
            // 
            // txtNote
            // 
            this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNote.Location = new System.Drawing.Point(108, 222);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(396, 20);
            this.txtNote.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 225);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Примечание:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(443, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbShelf);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cbRack);
            this.groupBox1.Location = new System.Drawing.Point(12, 274);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 52);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Размещение:";
            // 
            // cbShelf
            // 
            this.cbShelf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbShelf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbShelf.FormattingEnabled = true;
            this.cbShelf.Location = new System.Drawing.Point(241, 19);
            this.cbShelf.Name = "cbShelf";
            this.cbShelf.Size = new System.Drawing.Size(248, 21);
            this.cbShelf.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(193, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Полка:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Стеллаж:";
            // 
            // cbRack
            // 
            this.cbRack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRack.FormattingEnabled = true;
            this.cbRack.Location = new System.Drawing.Point(66, 19);
            this.cbRack.Name = "cbRack";
            this.cbRack.Size = new System.Drawing.Size(121, 21);
            this.cbRack.TabIndex = 0;
            this.cbRack.Tag = 0;
            this.cbRack.SelectedValueChanged += new System.EventHandler(this.OnSelectRack);
            // 
            // BoxDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 385);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.grpOrder);
            this.Name = "BoxDialog";
            this.Text = "BoxDialog";
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.grpOrder, 0);
            this.Controls.SetChildIndex(this.txtId, 0);
            this.Controls.SetChildIndex(this.txtWeight, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtLength, 0);
            this.Controls.SetChildIndex(this.txtWidth, 0);
            this.Controls.SetChildIndex(this.txtHeight, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.txtNote, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.grpOrder.ResumeLayout(false);
            this.grpOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalWeight;
        private System.Windows.Forms.TextBox txtBoxCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.DateTimePicker dtDtBeg;
        private System.Windows.Forms.TextBox txtIdOrder;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbShelf;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbRack;
    }
}