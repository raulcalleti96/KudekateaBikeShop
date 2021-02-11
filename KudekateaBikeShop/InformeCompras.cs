using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KudekateaBikeShop
{
    public partial class InformeCompras : Form
    {
        public InformeCompras()
        {
            InitializeComponent();
        }

        private void InformeCompras_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'BBDDCiclismoDataSet.Proveedor' Puede moverla o quitarla según sea necesario.
            this.ProveedorTableAdapter.Fill(this.BBDDCiclismoDataSet.Proveedor);
            // TODO: esta línea de código carga datos en la tabla 'BBDDCiclismoDataSet.Compras' Puede moverla o quitarla según sea necesario.
            this.ComprasTableAdapter.Fill(this.BBDDCiclismoDataSet.Compras);
            // TODO: esta línea de código carga datos en la tabla 'BBDDCiclismoDataSet.DetalleCompras' Puede moverla o quitarla según sea necesario.
            this.DetalleComprasTableAdapter.Fill(this.BBDDCiclismoDataSet.DetalleCompras);

            this.ComprasBindingSource.Filter = "Id_compra=" + Properties.Settings.Default.numCompra;
            this.DetalleComprasBindingSource.Filter = "Id_compra=" + Properties.Settings.Default.numCompra;


            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
