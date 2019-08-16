namespace Store
{
    partial class RackForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RackForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripRack = new System.Windows.Forms.ToolStrip();
            this.toolAddRack = new System.Windows.Forms.ToolStripButton();
            this.toolEditRack = new System.Windows.Forms.ToolStripButton();
            this.toolDeleteRack = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpRack = new System.Windows.Forms.GroupBox();
            this.gridRack = new System.Windows.Forms.DataGridView();
            this.id_Rack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_Rack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note_Rack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpShelf = new System.Windows.Forms.GroupBox();
            this.gridShelf = new System.Windows.Forms.DataGridView();
            this.id_Shelf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_Shelf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.max_weight_Shelf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note_Shelf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procent_Shelf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_rack_Shelf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.toolStripRack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpRack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRack)).BeginInit();
            this.grpShelf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridShelf)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripRack
            // 
            this.toolStripRack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.toolStripRack.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripRack.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripRack.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripRack.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAddRack,
            this.toolEditRack,
            this.toolDeleteRack});
            this.toolStripRack.Location = new System.Drawing.Point(9, 9);
            this.toolStripRack.Name = "toolStripRack";
            this.toolStripRack.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripRack.Size = new System.Drawing.Size(122, 39);
            this.toolStripRack.TabIndex = 3;
            // 
            // toolAddRack
            // 
            this.toolAddRack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAddRack.Image = ((System.Drawing.Image)(resources.GetObject("toolAddRack.Image")));
            this.toolAddRack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAddRack.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.toolAddRack.Name = "toolAddRack";
            this.toolAddRack.Size = new System.Drawing.Size(36, 36);
            this.toolAddRack.Text = "Добавить стеллаж";
            // 
            // toolEditRack
            // 
            this.toolEditRack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolEditRack.Image = ((System.Drawing.Image)(resources.GetObject("toolEditRack.Image")));
            this.toolEditRack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolEditRack.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.toolEditRack.Name = "toolEditRack";
            this.toolEditRack.Size = new System.Drawing.Size(36, 36);
            this.toolEditRack.Text = "Редактировать стеллаж";
            // 
            // toolDeleteRack
            // 
            this.toolDeleteRack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolDeleteRack.Image = ((System.Drawing.Image)(resources.GetObject("toolDeleteRack.Image")));
            this.toolDeleteRack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDeleteRack.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.toolDeleteRack.Name = "toolDeleteRack";
            this.toolDeleteRack.Size = new System.Drawing.Size(36, 36);
            this.toolDeleteRack.Text = "Удалить стеллаж";
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
            this.splitContainer1.Panel1.Controls.Add(this.grpRack);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grpShelf);
            this.splitContainer1.Size = new System.Drawing.Size(851, 560);
            this.splitContainer1.SplitterDistance = 280;
            this.splitContainer1.TabIndex = 4;
            // 
            // grpRack
            // 
            this.grpRack.Controls.Add(this.gridRack);
            this.grpRack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpRack.Location = new System.Drawing.Point(0, 0);
            this.grpRack.Name = "grpRack";
            this.grpRack.Size = new System.Drawing.Size(851, 280);
            this.grpRack.TabIndex = 0;
            this.grpRack.TabStop = false;
            this.grpRack.Text = "Стеллажи:";
            // 
            // gridRack
            // 
            this.gridRack.AllowUserToAddRows = false;
            this.gridRack.AllowUserToDeleteRows = false;
            this.gridRack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridRack.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridRack.ColumnHeadersHeight = 41;
            this.gridRack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridRack.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Rack,
            this.num_Rack,
            this.note_Rack});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridRack.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridRack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridRack.Location = new System.Drawing.Point(3, 16);
            this.gridRack.MultiSelect = false;
            this.gridRack.Name = "gridRack";
            this.gridRack.ReadOnly = true;
            this.gridRack.RowHeadersWidth = 15;
            this.gridRack.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridRack.ShowCellErrors = false;
            this.gridRack.ShowRowErrors = false;
            this.gridRack.Size = new System.Drawing.Size(845, 261);
            this.gridRack.TabIndex = 1;
            this.gridRack.Tag = 0;
            this.gridRack.SelectionChanged += new System.EventHandler(this.OnSelectionChanged);
            // 
            // id_Rack
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.id_Rack.DefaultCellStyle = dataGridViewCellStyle2;
            this.id_Rack.HeaderText = "ID";
            this.id_Rack.Name = "id_Rack";
            this.id_Rack.ReadOnly = true;
            this.id_Rack.Width = 80;
            // 
            // num_Rack
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.num_Rack.DefaultCellStyle = dataGridViewCellStyle3;
            this.num_Rack.HeaderText = "Номер";
            this.num_Rack.Name = "num_Rack";
            this.num_Rack.ReadOnly = true;
            this.num_Rack.Width = 80;
            // 
            // note_Rack
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.note_Rack.DefaultCellStyle = dataGridViewCellStyle4;
            this.note_Rack.HeaderText = "Примечание";
            this.note_Rack.Name = "note_Rack";
            this.note_Rack.ReadOnly = true;
            this.note_Rack.Width = 250;
            // 
            // grpShelf
            // 
            this.grpShelf.Controls.Add(this.gridShelf);
            this.grpShelf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpShelf.Location = new System.Drawing.Point(0, 0);
            this.grpShelf.Name = "grpShelf";
            this.grpShelf.Size = new System.Drawing.Size(851, 276);
            this.grpShelf.TabIndex = 0;
            this.grpShelf.TabStop = false;
            this.grpShelf.Text = "Полки:";
            // 
            // gridShelf
            // 
            this.gridShelf.AllowUserToAddRows = false;
            this.gridShelf.AllowUserToDeleteRows = false;
            this.gridShelf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridShelf.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridShelf.ColumnHeadersHeight = 41;
            this.gridShelf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridShelf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Shelf,
            this.num_Shelf,
            this.max_weight_Shelf,
            this.note_Shelf,
            this.procent_Shelf,
            this.id_rack_Shelf});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridShelf.DefaultCellStyle = dataGridViewCellStyle12;
            this.gridShelf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridShelf.Location = new System.Drawing.Point(3, 16);
            this.gridShelf.MultiSelect = false;
            this.gridShelf.Name = "gridShelf";
            this.gridShelf.ReadOnly = true;
            this.gridShelf.RowHeadersWidth = 15;
            this.gridShelf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridShelf.ShowCellErrors = false;
            this.gridShelf.ShowRowErrors = false;
            this.gridShelf.Size = new System.Drawing.Size(845, 257);
            this.gridShelf.TabIndex = 2;
            this.gridShelf.Tag = 1;
            // 
            // id_Shelf
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.id_Shelf.DefaultCellStyle = dataGridViewCellStyle7;
            this.id_Shelf.HeaderText = "ID";
            this.id_Shelf.Name = "id_Shelf";
            this.id_Shelf.ReadOnly = true;
            this.id_Shelf.Width = 80;
            // 
            // num_Shelf
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.num_Shelf.DefaultCellStyle = dataGridViewCellStyle8;
            this.num_Shelf.HeaderText = "Номер";
            this.num_Shelf.Name = "num_Shelf";
            this.num_Shelf.ReadOnly = true;
            this.num_Shelf.Width = 80;
            // 
            // max_weight_Shelf
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.max_weight_Shelf.DefaultCellStyle = dataGridViewCellStyle9;
            this.max_weight_Shelf.HeaderText = "Максимальный вес";
            this.max_weight_Shelf.Name = "max_weight_Shelf";
            this.max_weight_Shelf.ReadOnly = true;
            // 
            // note_Shelf
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.note_Shelf.DefaultCellStyle = dataGridViewCellStyle10;
            this.note_Shelf.HeaderText = "Примечание";
            this.note_Shelf.Name = "note_Shelf";
            this.note_Shelf.ReadOnly = true;
            this.note_Shelf.Width = 250;
            // 
            // procent_Shelf
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.procent_Shelf.DefaultCellStyle = dataGridViewCellStyle11;
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
            // RackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 560);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStripRack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RackForm";
            this.Text = "Стеллажи";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.toolStripRack.ResumeLayout(false);
            this.toolStripRack.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpRack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridRack)).EndInit();
            this.grpShelf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridShelf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripRack;
        private System.Windows.Forms.ToolStripButton toolAddRack;
        private System.Windows.Forms.ToolStripButton toolEditRack;
        private System.Windows.Forms.ToolStripButton toolDeleteRack;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grpRack;
        private System.Windows.Forms.GroupBox grpShelf;
        private System.Windows.Forms.DataGridView gridRack;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Rack;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_Rack;
        private System.Windows.Forms.DataGridViewTextBoxColumn note_Rack;
        protected System.Windows.Forms.DataGridView gridShelf;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Shelf;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_Shelf;
        private System.Windows.Forms.DataGridViewTextBoxColumn max_weight_Shelf;
        private System.Windows.Forms.DataGridViewTextBoxColumn note_Shelf;
        private System.Windows.Forms.DataGridViewTextBoxColumn procent_Shelf;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_rack_Shelf;
    }
}