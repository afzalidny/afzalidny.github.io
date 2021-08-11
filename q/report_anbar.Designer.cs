namespace q
{
    partial class report_anbar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FooroushgahDataSet = new q.FooroushgahDataSet();
            this.anbar1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.anbar1TableAdapter = new q.FooroushgahDataSetTableAdapters.anbar1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.FooroushgahDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anbar1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.anbar1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "q.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(815, 616);
            this.reportViewer1.TabIndex = 0;
            // 
            // FooroushgahDataSet
            // 
            this.FooroushgahDataSet.DataSetName = "FooroushgahDataSet";
            this.FooroushgahDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // anbar1BindingSource
            // 
            this.anbar1BindingSource.DataMember = "anbar1";
            this.anbar1BindingSource.DataSource = this.FooroushgahDataSet;
            // 
            // anbar1TableAdapter
            // 
            this.anbar1TableAdapter.ClearBeforeFill = true;
            // 
            // report_anbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportViewer1);
            this.Name = "report_anbar";
            this.Size = new System.Drawing.Size(815, 616);
            ((System.ComponentModel.ISupportInitialize)(this.FooroushgahDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anbar1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource anbar1BindingSource;
        private FooroushgahDataSet FooroushgahDataSet;
        private FooroushgahDataSetTableAdapters.anbar1TableAdapter anbar1TableAdapter;
    }
}
