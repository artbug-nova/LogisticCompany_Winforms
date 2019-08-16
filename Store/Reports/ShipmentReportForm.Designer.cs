namespace Store
{
    partial class ShipmentReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShipmentReportForm));
            this.st_shipment_report_getBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeDataSet = new Store.storeDataSet();
            this.st_shipment_order_report_getBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.st_shipment_report_getTableAdapter = new Store.storeDataSetTableAdapters.st_shipment_report_getTableAdapter();
            this.st_shipment_order_report_getTableAdapter = new Store.storeDataSetTableAdapters.st_shipment_order_report_getTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.st_shipment_report_getBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.st_shipment_order_report_getBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // st_shipment_report_getBindingSource
            // 
            this.st_shipment_report_getBindingSource.DataMember = "st_shipment_report_get";
            this.st_shipment_report_getBindingSource.DataSource = this.storeDataSet;
            // 
            // storeDataSet
            // 
            this.storeDataSet.DataSetName = "storeDataSet";
            this.storeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // st_shipment_order_report_getBindingSource
            // 
            this.st_shipment_order_report_getBindingSource.DataMember = "st_shipment_order_report_get";
            this.st_shipment_order_report_getBindingSource.DataSource = this.storeDataSet;
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "shipmentDataSet";
            reportDataSource1.Value = this.st_shipment_report_getBindingSource;
            reportDataSource2.Name = "orderDataSet";
            reportDataSource2.Value = this.st_shipment_order_report_getBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "Store.Reports.ShipmentReport.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.Size = new System.Drawing.Size(909, 534);
            this.reportViewer.TabIndex = 0;
            // 
            // st_shipment_report_getTableAdapter
            // 
            this.st_shipment_report_getTableAdapter.ClearBeforeFill = true;
            // 
            // st_shipment_order_report_getTableAdapter
            // 
            this.st_shipment_order_report_getTableAdapter.ClearBeforeFill = true;
            // 
            // ShipmentReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 534);
            this.Controls.Add(this.reportViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShipmentReportForm";
            this.Text = "Накладная на отгрузку";
            this.Load += new System.EventHandler(this.ShipmentReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.st_shipment_report_getBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.st_shipment_order_report_getBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource st_shipment_report_getBindingSource;
        private storeDataSet storeDataSet;
        private System.Windows.Forms.BindingSource st_shipment_order_report_getBindingSource;
        private storeDataSetTableAdapters.st_shipment_report_getTableAdapter st_shipment_report_getTableAdapter;
        private storeDataSetTableAdapters.st_shipment_order_report_getTableAdapter st_shipment_order_report_getTableAdapter;
    }
}