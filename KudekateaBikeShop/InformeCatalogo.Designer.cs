
namespace KudekateaBikeShop
{
    partial class InformeCatalogo
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
            this.BicicletasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BBDDCiclismoDataSet = new KudekateaBikeShop.BBDDCiclismoDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BicicletasTableAdapter = new KudekateaBikeShop.BBDDCiclismoDataSetTableAdapters.BicicletasTableAdapter();
            this.btnReinicio = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.BicicletasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BBDDCiclismoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // BicicletasBindingSource
            // 
            this.BicicletasBindingSource.DataMember = "Bicicletas";
            this.BicicletasBindingSource.DataSource = this.BBDDCiclismoDataSet;
            // 
            // BBDDCiclismoDataSet
            // 
            this.BBDDCiclismoDataSet.DataSetName = "BBDDCiclismoDataSet";
            this.BBDDCiclismoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.BicicletasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "KudekateaBikeShop.InformeCatalogo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-17, 159);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1234, 764);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // BicicletasTableAdapter
            // 
            this.BicicletasTableAdapter.ClearBeforeFill = true;
            // 
            // btnReinicio
            // 
            this.btnReinicio.Location = new System.Drawing.Point(878, 67);
            this.btnReinicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReinicio.Name = "btnReinicio";
            this.btnReinicio.Size = new System.Drawing.Size(134, 49);
            this.btnReinicio.TabIndex = 9;
            this.btnReinicio.Text = "Reiniciar";
            this.btnReinicio.UseVisualStyleBackColor = true;
            this.btnReinicio.Click += new System.EventHandler(this.btnReinicio_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(706, 65);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(143, 49);
            this.btnFiltrar.TabIndex = 8;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(447, 65);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 44);
            this.textBox1.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Id",
            "Nombre",
            "Categoria",
            "Fabricante"});
            this.comboBox1.Location = new System.Drawing.Point(168, 65);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(247, 45);
            this.comboBox1.TabIndex = 6;
            // 
            // InformeCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 923);
            this.Controls.Add(this.btnReinicio);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "InformeCatalogo";
            this.Text = "InformeCatalogo";
            this.Load += new System.EventHandler(this.InformeCatalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BicicletasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BBDDCiclismoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BicicletasBindingSource;
        private BBDDCiclismoDataSet BBDDCiclismoDataSet;
        private BBDDCiclismoDataSetTableAdapters.BicicletasTableAdapter BicicletasTableAdapter;
        private System.Windows.Forms.Button btnReinicio;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}