namespace Store
{
    partial class VehicleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripVehicle = new System.Windows.Forms.ToolStrip();
            this.toolAddVehicle = new System.Windows.Forms.ToolStripButton();
            this.toolEditVehicle = new System.Windows.Forms.ToolStripButton();
            this.toolDeleteVehicle = new System.Windows.Forms.ToolStripButton();
            this.grpVehicle = new System.Windows.Forms.GroupBox();
            this.gridPerson = new System.Windows.Forms.DataGridView();
            this.id_Vehicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mark_Vehicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state_num_Vehicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacity_Vehicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.length_Vehicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.width_Vehicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.height_Vehicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_Vehicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_status_Vehicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.toolStripVehicle.SuspendLayout();
            this.grpVehicle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripVehicle
            // 
            this.toolStripVehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.toolStripVehicle.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripVehicle.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripVehicle.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripVehicle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAddVehicle,
            this.toolEditVehicle,
            this.toolDeleteVehicle});
            this.toolStripVehicle.Location = new System.Drawing.Point(9, 9);
            this.toolStripVehicle.Name = "toolStripVehicle";
            this.toolStripVehicle.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripVehicle.Size = new System.Drawing.Size(122, 39);
            this.toolStripVehicle.TabIndex = 4;
            // 
            // toolAddVehicle
            // 
            this.toolAddVehicle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAddVehicle.Image = ((System.Drawing.Image)(resources.GetObject("toolAddVehicle.Image")));
            this.toolAddVehicle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAddVehicle.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.toolAddVehicle.Name = "toolAddVehicle";
            this.toolAddVehicle.Size = new System.Drawing.Size(36, 36);
            this.toolAddVehicle.Text = "Добавить клиента";
            // 
            // toolEditVehicle
            // 
            this.toolEditVehicle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolEditVehicle.Image = ((System.Drawing.Image)(resources.GetObject("toolEditVehicle.Image")));
            this.toolEditVehicle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolEditVehicle.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.toolEditVehicle.Name = "toolEditVehicle";
            this.toolEditVehicle.Size = new System.Drawing.Size(36, 36);
            this.toolEditVehicle.Text = "Редактировать клиента";
            // 
            // toolDeleteVehicle
            // 
            this.toolDeleteVehicle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolDeleteVehicle.Image = ((System.Drawing.Image)(resources.GetObject("toolDeleteVehicle.Image")));
            this.toolDeleteVehicle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDeleteVehicle.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.toolDeleteVehicle.Name = "toolDeleteVehicle";
            this.toolDeleteVehicle.Size = new System.Drawing.Size(36, 36);
            this.toolDeleteVehicle.Text = "Удалить клиента";
            // 
            // grpVehicle
            // 
            this.grpVehicle.Controls.Add(this.gridPerson);
            this.grpVehicle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpVehicle.Location = new System.Drawing.Point(0, 0);
            this.grpVehicle.Name = "grpVehicle";
            this.grpVehicle.Size = new System.Drawing.Size(1083, 575);
            this.grpVehicle.TabIndex = 5;
            this.grpVehicle.TabStop = false;
            this.grpVehicle.Text = "Автомобили:";
            // 
            // gridPerson
            // 
            this.gridPerson.AllowUserToAddRows = false;
            this.gridPerson.AllowUserToDeleteRows = false;
            this.gridPerson.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPerson.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridPerson.ColumnHeadersHeight = 41;
            this.gridPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridPerson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Vehicle,
            this.mark_Vehicle,
            this.state_num_Vehicle,
            this.capacity_Vehicle,
            this.length_Vehicle,
            this.width_Vehicle,
            this.height_Vehicle,
            this.status_Vehicle,
            this.id_status_Vehicle});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridPerson.DefaultCellStyle = dataGridViewCellStyle10;
            this.gridPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPerson.Location = new System.Drawing.Point(3, 16);
            this.gridPerson.MultiSelect = false;
            this.gridPerson.Name = "gridPerson";
            this.gridPerson.ReadOnly = true;
            this.gridPerson.RowHeadersWidth = 15;
            this.gridPerson.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPerson.ShowCellErrors = false;
            this.gridPerson.ShowRowErrors = false;
            this.gridPerson.Size = new System.Drawing.Size(1077, 556);
            this.gridPerson.TabIndex = 0;
            this.gridPerson.Tag = 0;
            // 
            // id_Vehicle
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.id_Vehicle.DefaultCellStyle = dataGridViewCellStyle2;
            this.id_Vehicle.HeaderText = "ID";
            this.id_Vehicle.Name = "id_Vehicle";
            this.id_Vehicle.ReadOnly = true;
            this.id_Vehicle.Width = 80;
            // 
            // mark_Vehicle
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.mark_Vehicle.DefaultCellStyle = dataGridViewCellStyle3;
            this.mark_Vehicle.HeaderText = "Марка";
            this.mark_Vehicle.Name = "mark_Vehicle";
            this.mark_Vehicle.ReadOnly = true;
            this.mark_Vehicle.Width = 150;
            // 
            // state_num_Vehicle
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.state_num_Vehicle.DefaultCellStyle = dataGridViewCellStyle4;
            this.state_num_Vehicle.HeaderText = "Гос. номер";
            this.state_num_Vehicle.Name = "state_num_Vehicle";
            this.state_num_Vehicle.ReadOnly = true;
            this.state_num_Vehicle.Width = 80;
            // 
            // capacity_Vehicle
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.capacity_Vehicle.DefaultCellStyle = dataGridViewCellStyle5;
            this.capacity_Vehicle.HeaderText = "Грузоподъемность";
            this.capacity_Vehicle.Name = "capacity_Vehicle";
            this.capacity_Vehicle.ReadOnly = true;
            this.capacity_Vehicle.Width = 150;
            // 
            // length_Vehicle
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.length_Vehicle.DefaultCellStyle = dataGridViewCellStyle6;
            this.length_Vehicle.HeaderText = "Длина кузова";
            this.length_Vehicle.Name = "length_Vehicle";
            this.length_Vehicle.ReadOnly = true;
            this.length_Vehicle.Width = 150;
            // 
            // width_Vehicle
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.width_Vehicle.DefaultCellStyle = dataGridViewCellStyle7;
            this.width_Vehicle.HeaderText = "Ширина кузова";
            this.width_Vehicle.Name = "width_Vehicle";
            this.width_Vehicle.ReadOnly = true;
            this.width_Vehicle.Width = 150;
            // 
            // height_Vehicle
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.height_Vehicle.DefaultCellStyle = dataGridViewCellStyle8;
            this.height_Vehicle.HeaderText = "Высота кузова";
            this.height_Vehicle.Name = "height_Vehicle";
            this.height_Vehicle.ReadOnly = true;
            this.height_Vehicle.Width = 150;
            // 
            // status_Vehicle
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.status_Vehicle.DefaultCellStyle = dataGridViewCellStyle9;
            this.status_Vehicle.HeaderText = "Статус";
            this.status_Vehicle.Name = "status_Vehicle";
            this.status_Vehicle.ReadOnly = true;
            this.status_Vehicle.Width = 150;
            // 
            // id_status_Vehicle
            // 
            this.id_status_Vehicle.HeaderText = "id_status";
            this.id_status_Vehicle.Name = "id_status_Vehicle";
            this.id_status_Vehicle.ReadOnly = true;
            this.id_status_Vehicle.Visible = false;
            // 
            // VehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 575);
            this.Controls.Add(this.grpVehicle);
            this.Controls.Add(this.toolStripVehicle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VehicleForm";
            this.Text = "Автомобили";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.toolStripVehicle.ResumeLayout(false);
            this.toolStripVehicle.PerformLayout();
            this.grpVehicle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripVehicle;
        private System.Windows.Forms.ToolStripButton toolAddVehicle;
        private System.Windows.Forms.ToolStripButton toolEditVehicle;
        private System.Windows.Forms.ToolStripButton toolDeleteVehicle;
        private System.Windows.Forms.GroupBox grpVehicle;
        private System.Windows.Forms.DataGridView gridPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Vehicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn mark_Vehicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn state_num_Vehicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacity_Vehicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn length_Vehicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn width_Vehicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn height_Vehicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_Vehicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_status_Vehicle;
    }
}