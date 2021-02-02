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

            detalleVentaDataGridView.Enabled = false;

            consultaMaestro();
            consultaDetalle();

            totalLabel1.Visible = false;

            btnPrimeroLinea.Enabled = false;
            btnAnteriorLinea.Enabled = false;
            btnSiguienteLinea.Enabled = false;
            btnUltimoLinea.Enabled = false;
            btnAnadirLinea.Enabled = false;
            btnEditarLinea.Enabled = false;
            btnBorrarLinea.Enabled = false;

            btnCancelarLinea.Enabled = false;


        }
        public void descuento()
        {
            int cantidad;
            float precio, total, descuento, totalDesc, totalDefinitivo;

            cantidad = int.Parse(cantidad_vendidaTextBox.Text);
            precio = float.Parse(precio_ventaTextBox.Text);
            descuento = float.Parse(descuentoTextBox.Text);

            //calculamos el total del precio * cantidad
            total = cantidad * precio;

            if (descuento == 0)
            {

                total_lineaLabel1.Text = "" + total;
            }
            else
            {
                totalDesc = total * descuento / 100;
                totalDefinitivo = total - totalDesc;

                total_lineaLabel1.Text = "" + totalDefinitivo;
            }

        }

        public void consultaMaestro()
        {
            contextMenuStrip1.Enabled = true;
            menuStrip1.Enabled = true;

            btnInforme.Enabled = true;

            id_clienteComboBox.Enabled = false;
            id_empleadoComboBox.Enabled = false;
            dNI_clienteTextBox.Enabled = false;
            email_clienteTextBox.Enabled = false;
            fecha_ventaDateTimePicker.Enabled = false;

            btnPrimero.Enabled = true;
            btnAnterior.Enabled = true;
            btnSiguiente.Enabled = true;
            btnUltimo.Enabled = true;

            btnEditar.Enabled = true;
            btnAnadir.Enabled = true;
            btnBorrar.Enabled = true;
            btnGuardar.Enabled = true;

            btnAceptar.Visible = false;
            btnCancelar.Visible = false;
        }
        public void edicionMaestro()
        {
            contextMenuStrip1.Enabled = false;
            menuStrip1.Enabled = false;

            btnInforme.Enabled = false;

            id_clienteComboBox.Enabled = true;
            id_empleadoComboBox.Enabled = true;
            dNI_clienteTextBox.Enabled = true;
            email_clienteTextBox.Enabled = true;
            fecha_ventaDateTimePicker.Enabled = true;

            btnPrimero.Enabled = false;
            btnAnterior.Enabled = false;
            btnSiguiente.Enabled = false;
            btnUltimo.Enabled = false;

            btnEditar.Enabled = false;
            btnAnadir.Enabled = false;
            btnBorrar.Enabled = false;
            btnGuardar.Enabled = false;

            btnAceptar.Visible = true;
            btnCancelar.Visible = true;
        }

        public void consultaDetalle()
        {
            id_bicicletaComboBox.Enabled = false;
            categoriaTextBox.Enabled = false;
            fabricanteTextBox.Enabled = false;
            cantidad_vendidaTextBox.Enabled = false;
            precio_ventaTextBox.Enabled = false;
            descuentoTextBox.Enabled = false;


            btnPrimeroLinea.Enabled = true;
            btnAnteriorLinea.Enabled = true;
            btnSiguienteLinea.Enabled = true;
            btnUltimoLinea.Enabled = true;

            btnEditarLinea.Enabled = true;
            btnAnadirLinea.Enabled = true;
            btnBorrarLinea.Enabled = true;

            btnAceptarLinea.Visible = false;
            btnCancelarLinea.Visible = false;
        }
        public void edicionDetalle()
        {
            id_bicicletaComboBox.Enabled = true;
            categoriaTextBox.Enabled = true;
            fabricanteTextBox.Enabled = true;
            cantidad_vendidaTextBox.Enabled = true;
            precio_ventaTextBox.Enabled = true;
            descuentoTextBox.Enabled = true;


            btnPrimeroLinea.Enabled = false;
            btnAnteriorLinea.Enabled = false;
            btnSiguienteLinea.Enabled = false;
            btnUltimoLinea.Enabled = false;

            btnEditarLinea.Enabled = false;
            btnAnadirLinea.Enabled = false;
            btnBorrarLinea.Enabled = false;

            btnAceptarLinea.Visible = true;
            btnCancelarLinea.Visible = true;

            /////////////////

            contextMenuStrip1.Enabled = false;
            menuStrip1.Enabled = false;

            btnInforme.Enabled = false;

            btnPrimero.Enabled = false;
            btnAnterior.Enabled = false;
            btnSiguiente.Enabled = false;
            btnUltimo.Enabled = false;

            btnEditar.Enabled = false;
            btnAnadir.Enabled = false;
            btnBorrar.Enabled = false;
            btnGuardar.Enabled = false;

            btnTerminar.Enabled = false;
        }


        private void id_bicicletaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        { 
            BBDDCiclismoDataSet.BicicletasRow filaProducto;

            if (id_bicicletaComboBox.SelectedIndex != -1)
            {
                filaProducto = bBDDCiclismoDataSet.Bicicletas[id_bicicletaComboBox.SelectedIndex];

                //si algun campo esta vacio
                if (filaProducto.IsCategoriaNull())
                    categoriaTextBox.Text = "";
                else
                    categoriaTextBox.Text = filaProducto.Categoria;

                if (filaProducto.IsNombreNull())
                {
                    nombre_bicicletaTextBox.Text = "";
                }
                else
                {
                    nombre_bicicletaTextBox.Text = filaProducto.Nombre;
                }

                if (filaProducto.IsFabricanteNull())
                    fabricanteTextBox.Text = "";
                else
                {
                    fabricanteTextBox.Text = filaProducto.Fabricante;
                }

                if (filaProducto.IsPrecioNull())
                    precio_ventaTextBox.Text = "";
                else
                {
                    precio_ventaTextBox.Text = filaProducto.Precio.ToString();
                }

            }
        }

        private void id_clienteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BBDDCiclismoDataSet.ClientesRow filaCliente;

            if (id_clienteComboBox.SelectedIndex != -1)
            {
                filaCliente = bBDDCiclismoDataSet.Clientes[id_clienteComboBox.SelectedIndex];

                //si algun campo esta vacio
                if (filaCliente.IsDNINull())
                    dNI_clienteTextBox.Text = "";
                else
                    dNI_clienteTextBox.Text = filaCliente.DNI;


                if (filaCliente.IsEmailNull())
                    email_clienteTextBox.Text = "";
                else
                {
                    email_clienteTextBox.Text = filaCliente.Email;
                }

            }
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            ventaBindingSource.MoveFirst();

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            ventaBindingSource.MovePrevious();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            ventaBindingSource.MoveNext();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            ventaBindingSource.MoveLast();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ventaBindingSource.EndEdit();
            this.detalleVentaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bBDDCiclismoDataSet);

            MessageBox.Show("Se han guardado los cambios correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("¿Desea eliminar esta venta?", "Eliminar venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                try
                {
                    //borramos las lineas del detalle
                    while (detalleVentaBindingSource.Count > 0)
                    {
                        detalleVentaBindingSource.RemoveCurrent();
                    }

                    //borramos el maestro
                    ventaBindingSource.RemoveCurrent();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al intentar eliminar esta venta", "Venta inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAceptarLinea_Click(object sender, EventArgs e)
        {
            if (id_bicicletaComboBox.Text.Equals("") | categoriaTextBox.Text.Equals("") | fabricanteTextBox.Text.Equals("") | cantidad_vendidaTextBox.Text.Equals("") |
              precio_ventaTextBox.Text.Equals("") | descuentoTextBox.Text.Equals(""))
            {
                if (id_bicicletaComboBox.Text == "")
                {
                    errorProvider1.SetError(id_bicicletaComboBox, "Debe introducir el nombre del videojuego");
                }
                if (categoriaTextBox.Text == "")
                {
                    errorProvider1.SetError(categoriaTextBox, "Debe introducir la categoría del videojuego");
                }
                if (fabricanteTextBox.Text == "")
                {
                    errorProvider1.SetError(fabricanteTextBox, "Debe introducir el nombre del creador del videojuego");
                }
                if (cantidad_vendidaTextBox.Text == "")
                {
                    errorProvider1.SetError(cantidad_vendidaTextBox, "Debe introducir la cantidad vendida");
                }
                if (precio_ventaTextBox.Text == "")
                {
                    errorProvider1.SetError(precio_ventaTextBox, "Debe introducir el precio de venta");
                }
                if (descuentoTextBox.Text == "")
                {
                    errorProvider1.SetError(descuentoTextBox, "Debe introducir un descuento");
                }
            }
            else
            {
                try
                {
                    errorProvider1.Clear();

                    detalleVentaBindingSource.EndEdit();

                    descuento();
                    consultaDetalle();

                    btnTerminar.Enabled = true;

                    //refrescamos el grid para mostrar los datos
                    detalleVentaDataGridView.Refresh();
                }
                catch (Exception)
                {
                    MessageBox.Show("Este producto ya existe", "Producto duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelarLinea_Click(object sender, EventArgs e)
        {
            detalleVentaBindingSource.CancelEdit();

            errorProvider1.Clear();

            btnTerminar.Enabled = true;

            consultaDetalle();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (id_clienteComboBox.Text.Equals("") | id_empleadoComboBox.Text.Equals("") | dNI_clienteTextBox.Text.Equals("") | email_clienteTextBox.Text.Equals(""))
            {
                if (id_clienteComboBox.Text == "")
                {
                    errorProvider1.SetError(id_clienteComboBox, "Debe introducir el nombre del cliente");
                }

                if (id_empleadoComboBox.Text == "")
                {
                    errorProvider1.SetError(id_empleadoComboBox, "Debe introducir el nombre del empleado que realiza la venta");
                }

                if (dNI_clienteTextBox.Text == "")
                {
                    errorProvider1.SetError(dNI_clienteTextBox, "Debe introducir el DNI del cliente");
                }

                if (email_clienteTextBox.Text == "")
                {
                    errorProvider1.SetError(email_clienteTextBox, "Debe introducir el email del cliente");
                }

            }
            else
            {
                try
                {
                    //hacer las validaciones
                    errorProvider1.Clear();

                    ventaBindingSource.EndEdit();

                    consultaMaestro();

                    nombre_clienteTextBox.Text = id_clienteComboBox.Text;//guardamos lo que haya en el combo en el label

                    contextMenuStrip1.Enabled = false;
                    menuStrip1.Enabled = false;

                    btnPrimero.Enabled = false;
                    btnAnterior.Enabled = false;
                    btnSiguiente.Enabled = false;
                    btnUltimo.Enabled = false;

                    btnInforme.Enabled = false;

                    btnEditar.Enabled = false;
                    btnAnadir.Enabled = false;
                    btnBorrar.Enabled = false;
                    btnGuardar.Enabled = false;


                    consultaDetalle();
                }
                catch (Exception)
                {
                    MessageBox.Show("Tiene que haber un cliente", "Error en el cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ventaBindingSource.CancelEdit();

            //limpiamos el error
            errorProvider1.Clear();

            consultaMaestro();
        }

        private void btnAnadirLinea_Click(object sender, EventArgs e)
        {
            detalleVentaBindingSource.AddNew();

            edicionDetalle();
        }

        private void btnBorrarLinea_Click(object sender, EventArgs e)
        {
            try
            {
                detalleVentaBindingSource.RemoveCurrent();
            }
            catch (Exception)
            {
                MessageBox.Show("Línea inexistente. Error", "Linea inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrimeroLinea_Click(object sender, EventArgs e)
        {

            detalleVentaBindingSource.MoveFirst();
        }

        private void btnAnteriorLinea_Click(object sender, EventArgs e)
        {
            detalleVentaBindingSource.MovePrevious();
        }

        private void btnSiguienteLinea_Click(object sender, EventArgs e)
        {
            detalleVentaBindingSource.MoveNext();
        }

        private void btnUltimoLinea_Click(object sender, EventArgs e)
        {
            detalleVentaBindingSource.MoveLast();
        }

        private void btnEditarLinea_Click(object sender, EventArgs e)
        {
            edicionDetalle();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            edicionMaestro();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            ventaBindingSource.AddNew();
            edicionMaestro();
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            consultaMaestro();

            btnPrimeroLinea.Enabled = false;
            btnAnteriorLinea.Enabled = false;
            btnSiguienteLinea.Enabled = false;
            btnUltimoLinea.Enabled = false;

            btnEditarLinea.Enabled = false;
            btnAnadirLinea.Enabled = false;
            btnBorrarLinea.Enabled = false;

            btnTerminar.Enabled = false;
        }

        private void ventaBindingSource_PositionChanged(object sender, EventArgs e)
        {
            label1.Text = "Venta " + (ventaBindingSource.Position + 1) + " de " + ventaBindingSource.Count;

            if (ventaBindingSource.Position == 0)
            {
                btnPrimero.Enabled = false;
                btnAnterior.Enabled = false;
            }
            else
            {
                btnPrimero.Enabled = true;
                btnAnterior.Enabled = true;
            }

            if (ventaBindingSource.Position == ventaBindingSource.Count - 1)
            {
                btnSiguiente.Enabled = false;
                btnUltimo.Enabled = false;
            }
            else
            {
                btnSiguiente.Enabled = true;
                btnUltimo.Enabled = true;
            }

            //cuando este a 0 desbilite el boton y no cierra el programa
            btnBorrar.Enabled = ventaBindingSource.Count > 0;
        }

        private void id_clienteComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (id_clienteComboBox.Text != "")
            {
                errorProvider1.SetError(id_clienteComboBox, "");
            }
        }

        private void dNI_clienteTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (dNI_clienteTextBox.Text.Length > 9)
            {
                MessageBox.Show("Error en el DNI. Debe contener 9 dígitos", "DNI erróneo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //le vacimaos el dni
                dNI_clienteTextBox.Text = "";
            }
            else
            {
                if (dNI_clienteTextBox.Text != "")
                {
                    errorProvider1.SetError(dNI_clienteTextBox, "");
                }
            }
        }

        private void email_clienteTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (email_clienteTextBox.Text != "")
            {
                errorProvider1.SetError(email_clienteTextBox, "");
            }
        }

        private void detalleVentaBindingSource_PositionChanged(object sender, EventArgs e)
        {
            label2.Text = "Producto " + (detalleVentaBindingSource.Position + 1) + " de " + detalleVentaBindingSource.Count;

            if (detalleVentaBindingSource.Position == 0)
            {
                btnPrimeroLinea.Enabled = false;
                btnAnteriorLinea.Enabled = false;
            }
            else
            {
                btnPrimeroLinea.Enabled = true;
                btnAnteriorLinea.Enabled = true;
            }

            if (detalleVentaBindingSource.Position == detalleVentaBindingSource.Count - 1)
            {
                btnSiguienteLinea.Enabled = false;
                btnUltimoLinea.Enabled = false;
            }
            else
            {
                btnSiguienteLinea.Enabled = true;
                btnUltimoLinea.Enabled = true;
            }

            //cuando este a 0 desbilite el boton y no cierra el programa
            btnBorrarLinea.Enabled = detalleVentaBindingSource.Count > 0;
        }

        private void id_bicicletaComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (id_bicicletaComboBox.Text != "")
            {
                errorProvider1.SetError(id_bicicletaComboBox, "");
            }
        }

        private void categoriaTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (categoriaTextBox.Text != "")
            {
                errorProvider1.SetError(categoriaTextBox, "");
            }
        }

        private void fabricanteTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (fabricanteTextBox.Text != "")
            {
                errorProvider1.SetError(fabricanteTextBox, "");
            }
        }

        private void cantidad_vendidaTextBox_Validating(object sender, CancelEventArgs e)
        {
            //comprobamos que sea mayor a 0
            float i;
            if (!float.TryParse(cantidad_vendidaTextBox.Text, out i) | (i <= 0))
            {
                errorProvider1.SetError(cantidad_vendidaTextBox, "Error introduzca un número mayor a 0");
                cantidad_vendidaTextBox.Text = String.Empty;
                e.Cancel = true;
            }

            if (cantidad_vendidaTextBox.Text != "")
            {
                errorProvider1.SetError(cantidad_vendidaTextBox, "");
            }
        }

        private void precio_ventaTextBox_Validating(object sender, CancelEventArgs e)
        {
            //comprobamos que sea mayor a 0
            float i;
            if (!float.TryParse(precio_ventaTextBox.Text, out i) | (i <= 0))
            {
                errorProvider1.SetError(precio_ventaTextBox, "Error introduzca un número mayor a 0");
                precio_ventaTextBox.Text = String.Empty;
                e.Cancel = true;
            }

            if (precio_ventaTextBox.Text != "")
            {
                errorProvider1.SetError(precio_ventaTextBox, "");
            }
        }

        private void descuentoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void descuentoTextBox_Validating(object sender, CancelEventArgs e)
        {
            //comprobamos que sea mayor a 0
            int i;
            if (!int.TryParse(descuentoTextBox.Text, out i) | (i < 0))
            {
                errorProvider1.SetError(descuentoTextBox, "Error introduzca un número superior o igual a 0");
                descuentoTextBox.Text = String.Empty;
                e.Cancel = true;
            }

            if (descuentoTextBox.Text != "")
            {
                errorProvider1.SetError(descuentoTextBox, "");
            }
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            //guardamos el id en la variable global (creada en Proyecto > Propiedades > Configuracion)
          /*  Properties.Settings.Default.numVenta = id_ventaLabel1.Text;

            Boolean abierta = false;

            foreach (Form fm in Application.OpenForms)
            {
                if (fm.GetType() == typeof(VentasInf))
                {
                    if (fm.WindowState == FormWindowState.Minimized)
                    {
                        fm.WindowState = FormWindowState.Normal;
                    }
                    fm.BringToFront();
                    abierta = true;
                    break;
                }
            }

            if (!abierta)
            {
                VentasInf v2 = new VentasInf();
                v2.Show();
            }*/

        }

        private void Ventas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bBDDCiclismoDataSet.HasChanges())
            {
                if (MessageBox.Show("¿Guardar las modificaciones pendientes antes de salir?", "Guardar cambios", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    try
                    {
                        ventaBindingSource.EndEdit();
                        tableAdapterManager.UpdateAll(bBDDCiclismoDataSet);
                        bBDDCiclismoDataSet.AcceptChanges();
                        MessageBox.Show("Los cambios han sido guardados", "Guardar cambios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Guardar cambios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
