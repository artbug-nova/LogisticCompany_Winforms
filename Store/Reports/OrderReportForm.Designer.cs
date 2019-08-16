namespace Store
{
    partial class OrderReportForm
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.storeDataSet = new Store.storeDataSet();
            this.st_order_report_getBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.st_order_report_getTableAdapter = new Store.storeDataSetTableAdapters.st_order_report_getTableAdapter();
            this.st_order_product_report_getBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.st_order_product_report_getTableAdapter = new Store.storeDataSetTableAdapters.st_order_product_report_getTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.st_order_report_getBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.st_order_product_report_getBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "orderDataSet";
            reportDataSource1.Value = this.st_order_report_getBindingSource;
            reportDataSource2.Name = "productDataSet";
            reportDataSource2.Value = this.st_order_product_report_getBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Store.Reports.OrderReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(757, 440);
            this.reportViewer1.TabIndex = 0;
            // 
            // storeDataSet
            // 
            this.storeDataSet.DataSetName = "storeDataSet";
            this.storeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // st_order_report_getBindingSource
            // 
            this.st_order_report_getBindingSource.DataMember = "st_order_report_get";
            this.st_order_report_getBindingSource.DataSource = this.storeDataSet;
            // 
            // st_order_report_getTableAdapter
            // 
            this.st_order_report_getTableAdapter.ClearBeforeFill = true;
            // 
            // st_order_product_report_getBindingSource
            // 
            this.st_order_product_report_getBindingSource.DataMember = "st_order_product_report_get";
            this.st_order_product_report_getBindingSource.DataSource = this.storeDataSet;
            // 
            // st_order_product_report_getTableAdapter
            // 
            this.st_order_product_report_getTableAdapter.ClearBeforeFill = true;
            // 
            // OrderReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 440);
            this.Controls.Add(this.reportViewer1);
            this.Name = "OrderReportForm";
            this.Text = "OrderReportForm";
            this.Load += new System.EventHandler(this.OrderReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.st_order_report_getBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.st_order_product_report_getBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource st_order_report_getBindingSource;
        private storeDataSet storeDataSet;
        private System.Windows.Forms.BindingSource st_order_product_report_getBindingSource;
        private storeDataSetTableAdapters.st_order_report_getTableAdapter st_order_report_getTableAdapter;
        private storeDataSetTableAdapters.st_order_product_report_getTableAdapter st_order_product_report_getTableAdapter;
    }
}