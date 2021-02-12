
namespace KudekateaBikeShop
{
    partial class InformeVentas
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
            this.BBDDCiclismoDataSet = new KudekateaBikeShop.BBDDCiclismoDataSet();
            this.DetalleVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DetalleVentaTableAdapter = new KudekateaBikeShop.BBDDCiclismoDataSetTableAdapters.DetalleVentaTableAdapter();
            this.VentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VentaTableAdapter = new KudekateaBikeShop.BBDDCiclismoDataSetTableAdapters.VentaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BBDDCiclismoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.DocumentMapWidth = 74;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DetalleVentaBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.VentaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "KudekateaBikeShop.InformeVentas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-3, -2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1419, 683);
            this.reportViewer1.TabIndex = 0;
            // 
            // BBDDCiclismoDataSet
            // 
            this.BBDDCiclismoDataSet.DataSetName = "BBDDCiclismoDataSet";
            this.BBDDCiclismoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DetalleVentaBindingSource
            // 
            this.DetalleVentaBindingSource.DataMember = "DetalleVenta";
            this.DetalleVentaBindingSource.DataSource = this.BBDDCiclismoDataSet;
            // 
            // DetalleVentaTableAdapter
            // 
            this.DetalleVentaTableAdapter.ClearBeforeFill = true;
            // 
            // VentaBindingSource
            // 
            this.VentaBindingSource.DataMember = "Venta";
            this.VentaBindingSource.DataSource = this.BBDDCiclismoDataSet;
            // 
            // VentaTableAdapter
            // 
            this.VentaTableAdapter.ClearBeforeFill = true;
            // 
            // InformeVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 679);
            this.Controls.Add(this.reportViewer1);
            this.Name = "InformeVentas";
            this.Text = "InformeVentas";
            this.Load += new System.EventHandler(this.InformeVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BBDDCiclismoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DetalleVentaBindingSource;
        private BBDDCiclismoDataSet BBDDCiclismoDataSet;
        private System.Windows.Forms.BindingSource VentaBindingSource;
        private BBDDCiclismoDataSetTableAdapters.DetalleVentaTableAdapter DetalleVentaTableAdapter;
        private BBDDCiclismoDataSetTableAdapters.VentaTableAdapter VentaTableAdapter;
    }
}