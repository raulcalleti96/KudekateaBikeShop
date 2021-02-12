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
    public partial class InformeVentas : Form
    {
        public InformeVentas()
        {
            InitializeComponent();
        }

        private void InformeVentas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'BBDDVideojuegosDataSet.Venta' Puede moverla o quitarla según sea necesario.
            this.VentaTableAdapter.Fill(this.BBDDCiclismoDataSet.Venta);
            // TODO: esta línea de código carga datos en la tabla 'BBDDVideojuegosDataSet.DetalleVenta' Puede moverla o quitarla según sea necesario.
            this.DetalleVentaTableAdapter.Fill(this.BBDDCiclismoDataSet.DetalleVenta);

            //creamos el filtro
            this.VentaBindingSource.Filter = "Id_venta=" + Properties.Settings.Default.numVenta;//asi accedemos a la variable global creda
            this.DetalleVentaBindingSource.Filter = "Id_venta=" + Properties.Settings.Default.numVenta;

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
