namespace Store
{
    partial class PersonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripPerson = new System.Windows.Forms.ToolStrip();
            this.toolAddPerson = new System.Windows.Forms.ToolStripButton();
            this.toolEditPerson = new System.Windows.Forms.ToolStripButton();
            this.toolDeletePerson = new System.Windows.Forms.ToolStripButton();
            this.grpPerson = new System.Windows.Forms.GroupBox();
            this.gridPerson = new System.Windows.Forms.DataGridView();
            this.id_Person = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.full_name_Person = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_birth_Person = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_Person = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pos_value_Person = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.st_value_Person = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_position_Person = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_status_Person = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.toolStripPerson.SuspendLayout();
            this.grpPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripPerson
            // 
            this.toolStripPerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.toolStripPerson.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripPerson.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripPerson.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripPerson.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAddPerson,
            this.toolEditPerson,
            this.toolDeletePerson});
            this.toolStripPerson.Location = new System.Drawing.Point(9, 9);
            this.toolStripPerson.Name = "toolStripPerson";
            this.toolStripPerson.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripPerson.Size = new System.Drawing.Size(122, 39);
            this.toolStripPerson.TabIndex = 3;
            // 
            // toolAddPerson
            // 
            this.toolAddPerson.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAddPerson.Image = ((System.Drawing.Image)(resources.GetObject("toolAddPerson.Image")));
            this.toolAddPerson.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAddPerson.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.toolAddPerson.Name = "toolAddPerson";
            this.toolAddPerson.Size = new System.Drawing.Size(36, 36);
            this.toolAddPerson.Text = "Добавить клиента";
            // 
            // toolEditPerson
            // 
            this.toolEditPerson.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolEditPerson.Image = ((System.Drawing.Image)(resources.GetObject("toolEditPerson.Image")));
            this.toolEditPerson.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolEditPerson.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.toolEditPerson.Name = "toolEditPerson";
            this.toolEditPerson.Size = new System.Drawing.Size(36, 36);
            this.toolEditPerson.Text = "Редактировать клиента";
            // 
            // toolDeletePerson
            // 
            this.toolDeletePerson.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolDeletePerson.Image = ((System.Drawing.Image)(resources.GetObject("toolDeletePerson.Image")));
            this.toolDeletePerson.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDeletePerson.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.toolDeletePerson.Name = "toolDeletePerson";
            this.toolDeletePerson.Size = new System.Drawing.Size(36, 36);
            this.toolDeletePerson.Text = "Удалить клиента";
            // 
            // grpPerson
            // 
            this.grpPerson.Controls.Add(this.gridPerson);
            this.grpPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPerson.Location = new System.Drawing.Point(0, 0);
            this.grpPerson.Name = "grpPerson";
            this.grpPerson.Size = new System.Drawing.Size(989, 543);
            this.grpPerson.TabIndex = 4;
            this.grpPerson.TabStop = false;
            this.grpPerson.Text = "Сотрудники:";
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
            this.id_Person,
            this.full_name_Person,
            this.dt_birth_Person,
            this.phone_Person,
            this.pos_value_Person,
            this.st_value_Person,
            this.id_position_Person,
            this.id_status_Person});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridPerson.DefaultCellStyle = dataGridViewCellStyle8;
            this.gridPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPerson.Location = new System.Drawing.Point(3, 16);
            this.gridPerson.MultiSelect = false;
            this.gridPerson.Name = "gridPerson";
            this.gridPerson.ReadOnly = true;
            this.gridPerson.RowHeadersWidth = 15;
            this.gridPerson.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPerson.ShowCellErrors = false;
            this.gridPerson.ShowRowErrors = false;
            this.gridPerson.Size = new System.Drawing.Size(983, 524);
            this.gridPerson.TabIndex = 0;
            this.gridPerson.Tag = 0;
            // 
            // id_Person
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.id_Person.DefaultCellStyle = dataGridViewCellStyle2;
            this.id_Person.HeaderText = "ID";
            this.id_Person.Name = "id_Person";
            this.id_Person.ReadOnly = true;
            this.id_Person.Width = 80;
            // 
            // full_name_Person
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.full_name_Person.DefaultCellStyle = dataGridViewCellStyle3;
            this.full_name_Person.HeaderText = "Ф.И.О. сотрудника";
            this.full_name_Person.Name = "full_name_Person";
            this.full_name_Person.ReadOnly = true;
            this.full_name_Person.Width = 250;
            // 
            // dt_birth_Person
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle4.Format = "dd.MM.yyyy";
            this.dt_birth_Person.DefaultCellStyle = dataGridViewCellStyle4;
            this.dt_birth_Person.HeaderText = "Дата рождения";
            this.dt_birth_Person.Name = "dt_birth_Person";
            this.dt_birth_Person.ReadOnly = true;
            this.dt_birth_Person.Width = 80;
            // 
            // phone_Person
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.phone_Person.DefaultCellStyle = dataGridViewCellStyle5;
            this.phone_Person.HeaderText = "Телефон";
            this.phone_Person.Name = "phone_Person";
            this.phone_Person.ReadOnly = true;
            this.phone_Person.Width = 150;
            // 
            // pos_value_Person
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.pos_value_Person.DefaultCellStyle = dataGridViewCellStyle6;
            this.pos_value_Person.HeaderText = "Должность";
            this.pos_value_Person.Name = "pos_value_Person";
            this.pos_value_Person.ReadOnly = true;
            this.pos_value_Person.Width = 150;
            // 
            // st_value_Person
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.st_value_Person.DefaultCellStyle = dataGridViewCellStyle7;
            this.st_value_Person.HeaderText = "Статус";
            this.st_value_Person.Name = "st_value_Person";
            this.st_value_Person.ReadOnly = true;
            this.st_value_Person.Width = 150;
            // 
            // id_position_Person
            // 
            this.id_position_Person.HeaderText = "id_position";
            this.id_position_Person.Name = "id_position_Person";
            this.id_position_Person.ReadOnly = true;
            this.id_position_Person.Visible = false;
            // 
            // id_status_Person
            // 
            this.id_status_Person.HeaderText = "id_status";
            this.id_status_Person.Name = "id_status_Person";
            this.id_status_Person.ReadOnly = true;
            this.id_status_Person.Visible = false;
            // 
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 543);
            this.Controls.Add(this.grpPerson);
            this.Controls.Add(this.toolStripPerson);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PersonForm";
            this.Text = "Сотрудники";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.toolStripPerson.ResumeLayout(false);
            this.toolStripPerson.PerformLayout();
            this.grpPerson.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripPerson;
        private System.Windows.Forms.ToolStripButton toolAddPerson;
        private System.Windows.Forms.ToolStripButton toolEditPerson;
        private System.Windows.Forms.ToolStripButton toolDeletePerson;
        private System.Windows.Forms.GroupBox grpPerson;
        private System.Windows.Forms.DataGridView gridPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Person;
        private System.Windows.Forms.DataGridViewTextBoxColumn full_name_Person;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_birth_Person;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_Person;
        private System.Windows.Forms.DataGridViewTextBoxColumn pos_value_Person;
        private System.Windows.Forms.DataGridViewTextBoxColumn st_value_Person;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_position_Person;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_status_Person;
    }
}