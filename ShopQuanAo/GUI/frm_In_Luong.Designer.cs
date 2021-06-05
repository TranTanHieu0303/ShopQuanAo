
namespace ShopQuanAo.GUI
{
    partial class frm_In_Luong
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.fKCTNGAYLAMBANGCHAMCONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ShopQuanAo.DAL.DataSet1();
            this.fKBANGCHAMCONGNHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cT_NGAYLAMTableAdapter = new ShopQuanAo.DAL.DataSet1TableAdapters.CT_NGAYLAMTableAdapter();
            this.bANGCHAMCONGTableAdapter = new ShopQuanAo.DAL.DataSet1TableAdapters.BANGCHAMCONGTableAdapter();
            this.nHANVIENTableAdapter = new ShopQuanAo.DAL.DataSet1TableAdapters.NHANVIENTableAdapter();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bANGCHAMCONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTNGAYLAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fKCTNGAYLAMBANGCHAMCONGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKBANGCHAMCONGNHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANGCHAMCONGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTNGAYLAMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fKCTNGAYLAMBANGCHAMCONGBindingSource
            // 
            this.fKCTNGAYLAMBANGCHAMCONGBindingSource.DataMember = "FK_CT_NGAYLAM_BANGCHAMCONG";
            this.fKCTNGAYLAMBANGCHAMCONGBindingSource.DataSource = this.bANGCHAMCONGBindingSource;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fKBANGCHAMCONGNHANVIENBindingSource
            // 
            this.fKBANGCHAMCONGNHANVIENBindingSource.DataMember = "FK_BANGCHAMCONG_NHANVIEN";
            this.fKBANGCHAMCONGNHANVIENBindingSource.DataSource = this.nHANVIENBindingSource;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.cTNGAYLAMBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.fKBANGCHAMCONGNHANVIENBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.nHANVIENBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ShopQuanAo.GUI.TrangIn_Luong.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // cT_NGAYLAMTableAdapter
            // 
            this.cT_NGAYLAMTableAdapter.ClearBeforeFill = true;
            // 
            // bANGCHAMCONGTableAdapter
            // 
            this.bANGCHAMCONGTableAdapter.ClearBeforeFill = true;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.dataSet1;
            // 
            // bANGCHAMCONGBindingSource
            // 
            this.bANGCHAMCONGBindingSource.DataMember = "BANGCHAMCONG";
            this.bANGCHAMCONGBindingSource.DataSource = this.dataSet1;
            // 
            // cTNGAYLAMBindingSource
            // 
            this.cTNGAYLAMBindingSource.DataMember = "CT_NGAYLAM";
            this.cTNGAYLAMBindingSource.DataSource = this.dataSet1;
            // 
            // frm_In_Luong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_In_Luong";
            this.Text = "frm_In_Luong";
            this.Load += new System.EventHandler(this.frm_In_Luong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fKCTNGAYLAMBANGCHAMCONGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKBANGCHAMCONGNHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANGCHAMCONGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTNGAYLAMBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DAL.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource cTNGAYLAMBindingSource;
        private DAL.DataSet1TableAdapters.CT_NGAYLAMTableAdapter cT_NGAYLAMTableAdapter;
        private System.Windows.Forms.BindingSource bANGCHAMCONGBindingSource;
        private DAL.DataSet1TableAdapters.BANGCHAMCONGTableAdapter bANGCHAMCONGTableAdapter;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private DAL.DataSet1TableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private System.Windows.Forms.BindingSource fKCTNGAYLAMBANGCHAMCONGBindingSource;
        private System.Windows.Forms.BindingSource fKBANGCHAMCONGNHANVIENBindingSource;
    }
}