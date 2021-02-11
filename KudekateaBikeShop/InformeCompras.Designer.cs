
namespace KudekateaBikeShop
{
    partial class InformeCompras
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BBDDCiclismoDataSet = new KudekateaBikeShop.BBDDCiclismoDataSet();
            this.DetalleComprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DetalleComprasTableAdapter = new KudekateaBikeShop.BBDDCiclismoDataSetTableAdapters.DetalleComprasTableAdapter();
            this.ProveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProveedorTableAdapter = new KudekateaBikeShop.BBDDCiclismoDataSetTableAdapters.ProveedorTableAdapter();
            this.ComprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ComprasTableAdapter = new KudekateaBikeShop.BBDDCiclismoDataSetTableAdapters.ComprasTableAdapter();
            this.detalleComprasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.proveedorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.proveedorBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.comprasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.proveedorBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BBDDCiclismoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleComprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleComprasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DetalleComprasBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.ProveedorBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.ComprasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "KudekateaBikeShop.InformeCompras.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-3, -3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1377, 755);
            this.reportViewer1.TabIndex = 0;
            // 
            // BBDDCiclismoDataSet
            // 
            this.BBDDCiclismoDataSet.DataSetName = "BBDDCiclismoDataSet";
            this.BBDDCiclismoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DetalleComprasBindingSource
            // 
            this.DetalleComprasBindingSource.DataMember = "DetalleCompras";
            this.DetalleComprasBindingSource.DataSource = this.BBDDCiclismoDataSet;
            // 
            // DetalleComprasTableAdapter
            // 
            this.DetalleComprasTableAdapter.ClearBeforeFill = true;
            // 
            // ProveedorBindingSource
            // 
            this.ProveedorBindingSource.DataMember = "Proveedor";
            this.ProveedorBindingSource.DataSource = this.BBDDCiclismoDataSet;
            // 
            // ProveedorTableAdapter
            // 
            this.ProveedorTableAdapter.ClearBeforeFill = true;
            // 
            // ComprasBindingSource
            // 
            this.ComprasBindingSource.DataMember = "Compras";
            this.ComprasBindingSource.DataSource = this.BBDDCiclismoDataSet;
            // 
            // ComprasTableAdapter
            // 
            this.ComprasTableAdapter.ClearBeforeFill = true;
            // 
            // detalleComprasBindingSource1
            // 
            this.detalleComprasBindingSource1.DataMember = "DetalleCompras";
            this.detalleComprasBindingSource1.DataSource = this.BBDDCiclismoDataSet;
            // 
            // proveedorBindingSource1
            // 
            this.proveedorBindingSource1.DataMember = "Proveedor";
            this.proveedorBindingSource1.DataSource = this.BBDDCiclismoDataSet;
            // 
            // proveedorBindingSource2
            // 
            this.proveedorBindingSource2.DataMember = "Proveedor";
            this.proveedorBindingSource2.DataSource = this.BBDDCiclismoDataSet;
            // 
            // comprasBindingSource1
            // 
            this.comprasBindingSource1.DataMember = "Compras";
            this.comprasBindingSource1.DataSource = this.BBDDCiclismoDataSet;
            // 
            // proveedorBindingSource3
            // 
            this.proveedorBindingSource3.DataMember = "Proveedor";
            this.proveedorBindingSource3.DataSource = this.BBDDCiclismoDataSet;
            // 
            // InformeCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 743);
            this.Controls.Add(this.reportViewer1);
            this.Name = "InformeCompras";
            this.Text = "InformeCompras";
            this.Load += new System.EventHandler(this.InformeCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BBDDCiclismoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleComprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleComprasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DetalleComprasBindingSource;
        private BBDDCiclismoDataSet BBDDCiclismoDataSet;
        private System.Windows.Forms.BindingSource ProveedorBindingSource;
        private System.Windows.Forms.BindingSource ComprasBindingSource;
        private BBDDCiclismoDataSetTableAdapters.DetalleComprasTableAdapter DetalleComprasTableAdapter;
        private BBDDCiclismoDataSetTableAdapters.ProveedorTableAdapter ProveedorTableAdapter;
        private BBDDCiclismoDataSetTableAdapters.ComprasTableAdapter ComprasTableAdapter;
        private System.Windows.Forms.BindingSource detalleComprasBindingSource1;
        private System.Windows.Forms.BindingSource proveedorBindingSource1;
        private System.Windows.Forms.BindingSource comprasBindingSource1;
        private System.Windows.Forms.BindingSource proveedorBindingSource2;
        private System.Windows.Forms.BindingSource proveedorBindingSource3;
    }
}