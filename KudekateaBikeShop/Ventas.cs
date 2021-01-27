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
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void ventaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ventaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bBDDCiclismoDataSet);

        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bBDDCiclismoDataSet.DetalleCompras' Puede moverla o quitarla según sea necesario.
            this.detalleComprasTableAdapter.Fill(this.bBDDCiclismoDataSet.DetalleCompras);
            // TODO: esta línea de código carga datos en la tabla 'bBDDCiclismoDataSet.Bicicletas' Puede moverla o quitarla según sea necesario.
            this.bicicletasTableAdapter.Fill(this.bBDDCiclismoDataSet.Bicicletas);
            // TODO: esta línea de código carga datos en la tabla 'bBDDCiclismoDataSet.Empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this.bBDDCiclismoDataSet.Empleados);
            // TODO: esta línea de código carga datos en la tabla 'bBDDCiclismoDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.bBDDCiclismoDataSet.Clientes);
            // TODO: esta línea de código carga datos en la tabla 'bBDDCiclismoDataSet.DetalleVenta' Puede moverla o quitarla según sea necesario.
            this.detalleVentaTableAdapter.Fill(this.bBDDCiclismoDataSet.DetalleVenta);
            // TODO: esta línea de código carga datos en la tabla 'bBDDCiclismoDataSet.DetalleVenta' Puede moverla o quitarla según sea necesario.
            this.detalleVentaTableAdapter.Fill(this.bBDDCiclismoDataSet.DetalleVenta);
            // TODO: esta línea de código carga datos en la tabla 'bBDDCiclismoDataSet.DetalleVenta' Puede moverla o quitarla según sea necesario.
            this.detalleVentaTableAdapter.Fill(this.bBDDCiclismoDataSet.DetalleVenta);
            // TODO: esta línea de código carga datos en la tabla 'bBDDCiclismoDataSet.DetalleCompras' Puede moverla o quitarla según sea necesario.
            this.detalleComprasTableAdapter.Fill(this.bBDDCiclismoDataSet.DetalleCompras);
            // TODO: esta línea de código carga datos en la tabla 'bBDDCiclismoDataSet.DetalleCompras' Puede moverla o quitarla según sea necesario.
            this.detalleComprasTableAdapter.Fill(this.bBDDCiclismoDataSet.DetalleCompras);
            // TODO: esta línea de código carga datos en la tabla 'bBDDCiclismoDataSet.Venta' Puede moverla o quitarla según sea necesario.
            this.ventaTableAdapter.Fill(this.bBDDCiclismoDataSet.Venta);

        }
    }
}
