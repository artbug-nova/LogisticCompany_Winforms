namespace Store
{
    partial class MDIForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIForm));
            this.toolStripStore = new System.Windows.Forms.ToolStrip();
            this.toolOrder = new System.Windows.Forms.ToolStripButton();
            this.toolProduct = new System.Windows.Forms.ToolStripButton();
            this.toolBox = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolRack = new System.Windows.Forms.ToolStripButton();
            this.toolStripHelp = new System.Windows.Forms.ToolStrip();
            this.toolHelp = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolAbout = new System.Windows.Forms.ToolStripButton();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.itemStore = new System.Windows.Forms.ToolStripMenuItem();
            this.itemShipping = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSprav = new System.Windows.Forms.ToolStripMenuItem();
            this.itemAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.itemWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.itemInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.toolStripShipment = new System.Windows.Forms.ToolStrip();
            this.toolShipment = new System.Windows.Forms.ToolStripButton();
            this.toolStripSprav = new System.Windows.Forms.ToolStrip();
            this.toolCustomers = new System.Windows.Forms.ToolStripButton();
            this.toolVehicle = new System.Windows.Forms.ToolStripButton();
            this.toolDistricts = new System.Windows.Forms.ToolStripButton();
            this.toolPerson = new System.Windows.Forms.ToolStripButton();
            this.toolStripWindow = new System.Windows.Forms.ToolStrip();
            this.toolWindows = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLoading = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStore.SuspendLayout();
            this.toolStripHelp.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.toolStripShipment.SuspendLayout();
            this.toolStripSprav.SuspendLayout();
            this.toolStripWindow.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripStore
            // 
            this.toolStripStore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.toolStripStore.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripStore.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripStore.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripStore.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolOrder,
            this.toolProduct,
            this.toolBox,
            this.toolStripSeparator1,
            this.toolRack});
            this.toolStripStore.Location = new System.Drawing.Point(4, 4);
            this.toolStripStore.Name = "toolStripStore";
            this.toolStripStore.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.toolStripStore.Size = new System.Drawing.Size(173, 39);
            this.toolStripStore.TabIndex = 0;
            this.toolStripStore.Tag = 0;
            // 
            // toolOrder
            // 
            this.toolOrder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolOrder.Image = ((System.Drawing.Image)(resources.GetObject("toolOrder.Image")));
            this.toolOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolOrder.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.toolOrder.Name = "toolOrder";
            this.toolOrder.Size = new System.Drawing.Size(36, 36);
            this.toolOrder.Tag = 0;
            this.toolOrder.Text = "Заказы";
            this.toolOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolOrder.Click += new System.EventHandler(this.OnOpenFormClick);
            // 
            // toolProduct
            // 
            this.toolProduct.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolProduct.Image = ((System.Drawing.Image)(resources.GetObject("toolProduct.Image")));
            this.toolProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolProduct.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.toolProduct.Name = "toolProduct";
            this.toolProduct.Size = new System.Drawing.Size(36, 36);
            this.toolProduct.Tag = 1;
            this.toolProduct.Text = "Товары";
            this.toolProduct.Click += new System.EventHandler(this.OnOpenFormClick);
            // 
            // toolBox
            // 
            this.toolBox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBox.Image = ((System.Drawing.Image)(resources.GetObject("toolBox.Image")));
            this.toolBox.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.toolBox.Name = "toolBox";
            this.toolBox.Size = new System.Drawing.Size(36, 36);
            this.toolBox.Tag = 2;
            this.toolBox.Text = "Ящики";
            this.toolBox.Click += new System.EventHandler(this.OnOpenFormClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolRack
            // 
            this.toolRack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolRack.Image = ((System.Drawing.Image)(resources.GetObject("toolRack.Image")));
            this.toolRack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolRack.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.toolRack.Name = "toolRack";
            this.toolRack.Size = new System.Drawing.Size(36, 36);
            this.toolRack.Tag = 3;
            this.toolRack.Text = "Стеллажи";
            this.toolRack.Click += new System.EventHandler(this.OnOpenFormClick);
            // 
            // toolStripHelp
            // 
            this.toolStripHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.toolStripHelp.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripHelp.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripHelp.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripHelp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolHelp,
            this.toolStripSeparator2,
            this.toolAbout});
            this.toolStripHelp.Location = new System.Drawing.Point(4, 4);
            this.toolStripHelp.Name = "toolStripHelp";
            this.toolStripHelp.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.toolStripHelp.Size = new System.Drawing.Size(93, 39);
            this.toolStripHelp.TabIndex = 1;
            this.toolStripHelp.Tag = 5;
            // 
            // toolHelp
            // 
            this.toolHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolHelp.Image = ((System.Drawing.Image)(resources.GetObject("toolHelp.Image")));
            this.toolHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolHelp.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.toolHelp.Name = "toolHelp";
            this.toolHelp.Size = new System.Drawing.Size(36, 36);
            this.toolHelp.Text = "Помощь";
            this.toolHelp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // toolAbout
            // 
            this.toolAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAbout.Image = ((System.Drawing.Image)(resources.GetObject("toolAbout.Image")));
            this.toolAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAbout.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.toolAbout.Name = "toolAbout";
            this.toolAbout.Size = new System.Drawing.Size(36, 36);
            this.toolAbout.Text = "О программе";
            this.toolAbout.Click += new System.EventHandler(this.OnAboutClick);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemStore,
            this.itemShipping,
            this.itemSprav,
            this.itemAdmin,
            this.itemWindow,
            this.itemInfo});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(6, 2, 0, 0);
            this.menuStrip.Size = new System.Drawing.Size(1197, 30);
            this.menuStrip.TabIndex = 3;
            // 
            // itemStore
            // 
            this.itemStore.Image = ((System.Drawing.Image)(resources.GetObject("itemStore.Image")));
            this.itemStore.Name = "itemStore";
            this.itemStore.Size = new System.Drawing.Size(75, 28);
            this.itemStore.Tag = 0;
            this.itemStore.Text = "Склад";
            this.itemStore.Click += new System.EventHandler(this.OnClickItemMenu);
            // 
            // itemShipping
            // 
            this.itemShipping.Image = ((System.Drawing.Image)(resources.GetObject("itemShipping.Image")));
            this.itemShipping.Name = "itemShipping";
            this.itemShipping.Size = new System.Drawing.Size(91, 28);
            this.itemShipping.Tag = 1;
            this.itemShipping.Text = "Отгрузка";
            this.itemShipping.Click += new System.EventHandler(this.OnClickItemMenu);
            // 
            // itemSprav
            // 
            this.itemSprav.Image = ((System.Drawing.Image)(resources.GetObject("itemSprav.Image")));
            this.itemSprav.Name = "itemSprav";
            this.itemSprav.Size = new System.Drawing.Size(110, 28);
            this.itemSprav.Tag = 2;
            this.itemSprav.Text = "Справочники";
            this.itemSprav.Click += new System.EventHandler(this.OnClickItemMenu);
            // 
            // itemAdmin
            // 
            this.itemAdmin.Image = ((System.Drawing.Image)(resources.GetObject("itemAdmin.Image")));
            this.itemAdmin.Name = "itemAdmin";
            this.itemAdmin.Size = new System.Drawing.Size(146, 28);
            this.itemAdmin.Tag = 3;
            this.itemAdmin.Text = "Администрирование";
            this.itemAdmin.Click += new System.EventHandler(this.OnClickItemMenu);
            // 
            // itemWindow
            // 
            this.itemWindow.Image = ((System.Drawing.Image)(resources.GetObject("itemWindow.Image")));
            this.itemWindow.Name = "itemWindow";
            this.itemWindow.Size = new System.Drawing.Size(69, 28);
            this.itemWindow.Tag = 4;
            this.itemWindow.Text = "Окно";
            this.itemWindow.Click += new System.EventHandler(this.OnClickItemMenu);
            // 
            // itemInfo
            // 
            this.itemInfo.Image = ((System.Drawing.Image)(resources.GetObject("itemInfo.Image")));
            this.itemInfo.Name = "itemInfo";
            this.itemInfo.Size = new System.Drawing.Size(86, 28);
            this.itemInfo.Tag = 5;
            this.itemInfo.Text = "Справка";
            this.itemInfo.Click += new System.EventHandler(this.OnClickItemMenu);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelMenu.Controls.Add(this.toolStripShipment);
            this.panelMenu.Controls.Add(this.toolStripSprav);
            this.panelMenu.Controls.Add(this.toolStripWindow);
            this.panelMenu.Controls.Add(this.toolStripHelp);
            this.panelMenu.Controls.Add(this.toolStripStore);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 30);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1197, 47);
            this.panelMenu.TabIndex = 4;
            // 
            // toolStripShipment
            // 
            this.toolStripShipment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.toolStripShipment.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripShipment.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripShipment.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripShipment.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolShipment});
            this.toolStripShipment.Location = new System.Drawing.Point(4, 4);
            this.toolStripShipment.Name = "toolStripShipment";
            this.toolStripShipment.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.toolStripShipment.Size = new System.Drawing.Size(47, 39);
            this.toolStripShipment.TabIndex = 4;
            this.toolStripShipment.Tag = 1;
            // 
            // toolShipment
            // 
            this.toolShipment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolShipment.Image = ((System.Drawing.Image)(resources.GetObject("toolShipment.Image")));
            this.toolShipment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolShipment.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.toolShipment.Name = "toolShipment";
            this.toolShipment.Size = new System.Drawing.Size(36, 36);
            this.toolShipment.Tag = 8;
            this.toolShipment.Text = "Отгрузки";
            this.toolShipment.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolShipment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolShipment.Click += new System.EventHandler(this.OnOpenFormClick);
            // 
            // toolStripSprav
            // 
            this.toolStripSprav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.toolStripSprav.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripSprav.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripSprav.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripSprav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolCustomers,
            this.toolVehicle,
            this.toolDistricts,
            this.toolPerson});
            this.toolStripSprav.Location = new System.Drawing.Point(4, 4);
            this.toolStripSprav.Name = "toolStripSprav";
            this.toolStripSprav.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.toolStripSprav.Size = new System.Drawing.Size(198, 39);
            this.toolStripSprav.TabIndex = 3;
            this.toolStripSprav.Tag = 2;
            // 
            // toolCustomers
            // 
            this.toolCustomers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolCustomers.Image = ((System.Drawing.Image)(resources.GetObject("toolCustomers.Image")));
            this.toolCustomers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCustomers.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.toolCustomers.Name = "toolCustomers";
            this.toolCustomers.Size = new System.Drawing.Size(36, 36);
            this.toolCustomers.Tag = 4;
            this.toolCustomers.Text = "Заказчики";
            this.toolCustomers.Click += new System.EventHandler(this.OnOpenFormClick);
            // 
            // toolVehicle
            // 
            this.toolVehicle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolVehicle.Image = ((System.Drawing.Image)(resources.GetObject("toolVehicle.Image")));
            this.toolVehicle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolVehicle.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.toolVehicle.Name = "toolVehicle";
            this.toolVehicle.Size = new System.Drawing.Size(36, 36);
            this.toolVehicle.Tag = 5;
            this.toolVehicle.Text = "Автотранспорт";
            this.toolVehicle.Click += new System.EventHandler(this.OnOpenFormClick);
            // 
            // toolDistricts
            // 
            this.toolDistricts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolDistricts.Image = ((System.Drawing.Image)(resources.GetObject("toolDistricts.Image")));
            this.toolDistricts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDistricts.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.toolDistricts.Name = "toolDistricts";
            this.toolDistricts.Size = new System.Drawing.Size(36, 36);
            this.toolDistricts.Tag = 6;
            this.toolDistricts.Text = "Районы";
            this.toolDistricts.Click += new System.EventHandler(this.OnOpenFormClick);
            // 
            // toolPerson
            // 
            this.toolPerson.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolPerson.Image = ((System.Drawing.Image)(resources.GetObject("toolPerson.Image")));
            this.toolPerson.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPerson.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.toolPerson.Name = "toolPerson";
            this.toolPerson.Size = new System.Drawing.Size(36, 36);
            this.toolPerson.Tag = 7;
            this.toolPerson.Text = "Сотрудники";
            this.toolPerson.Click += new System.EventHandler(this.OnOpenFormClick);
            // 
            // toolStripWindow
            // 
            this.toolStripWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.toolStripWindow.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripWindow.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripWindow.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripWindow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolWindows,
            this.toolStripSeparator4});
            this.toolStripWindow.Location = new System.Drawing.Point(4, 4);
            this.toolStripWindow.Name = "toolStripWindow";
            this.toolStripWindow.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.toolStripWindow.Size = new System.Drawing.Size(62, 39);
            this.toolStripWindow.TabIndex = 2;
            this.toolStripWindow.Tag = 4;
            // 
            // toolWindows
            // 
            this.toolWindows.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolWindows.Image = ((System.Drawing.Image)(resources.GetObject("toolWindows.Image")));
            this.toolWindows.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolWindows.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.toolWindows.Name = "toolWindows";
            this.toolWindows.Size = new System.Drawing.Size(45, 36);
            this.toolWindows.Text = "Окна";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusUser,
            this.statusLoading,
            this.statusProgressBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 556);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1197, 22);
            this.statusStrip.TabIndex = 6;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusUser
            // 
            this.statusUser.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.statusUser.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.statusUser.Margin = new System.Windows.Forms.Padding(0);
            this.statusUser.Name = "statusUser";
            this.statusUser.Size = new System.Drawing.Size(63, 22);
            this.statusUser.Text = "Работает:";
            // 
            // statusLoading
            // 
            this.statusLoading.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.statusLoading.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.statusLoading.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.statusLoading.Name = "statusLoading";
            this.statusLoading.Size = new System.Drawing.Size(61, 22);
            this.statusLoading.Text = "Загрузка:";
            this.statusLoading.Visible = false;
            // 
            // statusProgressBar
            // 
            this.statusProgressBar.Margin = new System.Windows.Forms.Padding(1);
            this.statusProgressBar.MarqueeAnimationSpeed = 50;
            this.statusProgressBar.Name = "statusProgressBar";
            this.statusProgressBar.Size = new System.Drawing.Size(150, 20);
            this.statusProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.statusProgressBar.Visible = false;
            // 
            // MDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 578);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АРМ \"Отгрузка\"";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OnLoad);
            this.toolStripStore.ResumeLayout(false);
            this.toolStripStore.PerformLayout();
            this.toolStripHelp.ResumeLayout(false);
            this.toolStripHelp.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.toolStripShipment.ResumeLayout(false);
            this.toolStripShipment.PerformLayout();
            this.toolStripSprav.ResumeLayout(false);
            this.toolStripSprav.PerformLayout();
            this.toolStripWindow.ResumeLayout(false);
            this.toolStripWindow.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripStore;
        private System.Windows.Forms.ToolStripButton toolOrder;
        private System.Windows.Forms.ToolStripButton toolProduct;
        private System.Windows.Forms.ToolStripButton toolBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolRack;
        private System.Windows.Forms.ToolStrip toolStripHelp;
        private System.Windows.Forms.ToolStripButton toolHelp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolAbout;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem itemStore;
        private System.Windows.Forms.ToolStripMenuItem itemShipping;
        private System.Windows.Forms.ToolStripMenuItem itemSprav;
        private System.Windows.Forms.ToolStripMenuItem itemAdmin;
        private System.Windows.Forms.ToolStripMenuItem itemWindow;
        private System.Windows.Forms.ToolStripMenuItem itemInfo;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.ToolStrip toolStripWindow;
        private System.Windows.Forms.ToolStripDropDownButton toolWindows;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusUser;
        private System.Windows.Forms.ToolStripStatusLabel statusLoading;
        private System.Windows.Forms.ToolStripProgressBar statusProgressBar;
        private System.Windows.Forms.ToolStrip toolStripSprav;
        private System.Windows.Forms.ToolStripButton toolCustomers;
        private System.Windows.Forms.ToolStripButton toolVehicle;
        private System.Windows.Forms.ToolStripButton toolDistricts;
        private System.Windows.Forms.ToolStripButton toolPerson;
        private System.Windows.Forms.ToolStrip toolStripShipment;
        private System.Windows.Forms.ToolStripButton toolShipment;
    }
}

