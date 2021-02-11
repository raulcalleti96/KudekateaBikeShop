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
    public partial class Compras : Form
    {
        public Compras()
        {
            InitializeComponent();
        }

        private void comprasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.comprasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bBDDCiclismoDataSet);

        }

        private void comprasBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.comprasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bBDDCiclismoDataSet);

        }

        private void Compras_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bBDDCiclismoDataSet.DetalleCompras' Puede moverla o quitarla según sea necesario.
            this.detalleComprasTableAdapter.Fill(this.bBDDCiclismoDataSet.DetalleCompras);
            // TODO: esta línea de código carga datos en la tabla 'bBDDCiclismoDataSet.Proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.Fill(this.bBDDCiclismoDataSet.Proveedor);
            // TODO: esta línea de código carga datos en la tabla 'bBDDCiclismoDataSet.Compras' Puede moverla o quitarla según sea necesario.
            this.comprasTableAdapter.Fill(this.bBDDCiclismoDataSet.Compras);
            // TODO: esta línea de código carga datos en la tabla 'bBDDCiclismoDataSet.Bicicletas' Puede moverla o quitarla según sea necesario.
            this.bicicletasTableAdapter.Fill(this.bBDDCiclismoDataSet.Bicicletas);
            // TODO: esta línea de código carga datos en la tabla 'bBDDCiclismoDataSet.Proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.Fill(this.bBDDCiclismoDataSet.Proveedor);
            // TODO: esta línea de código carga datos en la tabla 'bBDDCiclismoDataSet.Empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this.bBDDCiclismoDataSet.Empleados);
            // TODO: esta línea de código carga datos en la tabla 'bBDDCiclismoDataSet.DetalleCompras' Puede moverla o quitarla según sea necesario.
            this.detalleComprasTableAdapter.Fill(this.bBDDCiclismoDataSet.DetalleCompras);
            // TODO: esta línea de código carga datos en la tabla 'bBDDCiclismoDataSet.Venta' Puede moverla o quitarla según sea necesario.
            this.ventaTableAdapter.Fill(this.bBDDCiclismoDataSet.Venta);
            // TODO: esta línea de código carga datos en la tabla 'bBDDCiclismoDataSet.Compras' Puede moverla o quitarla según sea necesario.
            this.comprasTableAdapter.Fill(this.bBDDCiclismoDataSet.Compras);

            Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            int w = Width >= screen.Width ? screen.Width : (screen.Width + Width) / 2;
            int h = Height >= screen.Height ? screen.Height : (screen.Height + Height) / 2;
            this.Location = new Point((screen.Width - w) / 2, (screen.Height - h) / 2);
            this.Size = new Size(w, h);

            consultaMaestro();
            consultaDetalle();

            totalLabel1.Visible = false;

            detalleComprasDataGridView.Enabled = false;

            nombre_proveedorLabel1.Visible = false;

            btnPrimeroLinea.Enabled = false;
            btnAnteriorLinea.Enabled = false;
            btnSiguienteLinea.Enabled = false;
            btnUltimoLinea.Enabled = false;
            btnAnadirLinea.Enabled = false;
            btnEditarLinea.Enabled = false;
            btnBorrarLinea.Enabled = false;

            btnTerminar.Enabled = false;

        }

        public void descuento()
        {
            int cantidad;
            float precio, total, descuento, totalDesc, totalDefinitivo;

            cantidad = int.Parse(cantidad_compradaTextBox.Text);
            precio = float.Parse(precio_compraTextBox.Text);
            descuento = float.Parse(descuentoTextBox.Text);

           
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

            id_proveedorComboBox.Enabled = false;
            id_empleadoComboBox.Enabled = false;
            nombre_proveedorLabel1.Enabled = false;
            telefono_proveedorTextBox.Enabled = false;
            email_proveedorTextBox.Enabled = false;


            btnInforme.Enabled = true;

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

            id_proveedorComboBox.Enabled = true;
            id_empleadoComboBox.Enabled = true;
            nombre_proveedorLabel1.Enabled = true;
            telefono_proveedorTextBox.Enabled = true;
            email_proveedorTextBox.Enabled = true;
           
            btnInforme.Enabled = false;

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
            nombre_bicicletaTextBox.Enabled = false;
            categoriaComboBox.Enabled = false;
            fabricanteTextBox.Enabled = false;
            cantidad_compradaTextBox.Enabled = false;
            precio_compraTextBox.Enabled = false;
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
            nombre_bicicletaTextBox.Enabled = true;
            categoriaComboBox.Enabled = true;
            fabricanteTextBox.Enabled = true;
            cantidad_compradaTextBox.Enabled = true;
            precio_compraTextBox.Enabled = true;
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

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            comprasBindingSource.MoveFirst();

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            comprasBindingSource.MovePrevious();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            comprasBindingSource.MoveNext();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            comprasBindingSource.MoveLast();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            edicionMaestro();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            comprasBindingSource.AddNew();
         
            edicionMaestro();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

            if ((MessageBox.Show("¿Desea borrar esta compra?", "Eliminar compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                try
                {
                  
                    while (detalleComprasBindingSource.Count > 0)
                    {
                        detalleComprasBindingSource.RemoveCurrent();
                    }

               
                    comprasBindingSource.RemoveCurrent();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al eliminar una compra. La compra no existe", "Compra inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.comprasBindingSource.EndEdit();
            this.detalleComprasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bBDDCiclismoDataSet);

            MessageBox.Show("Los cambios han sido guardados correctamente", "Guardado satisfactorio", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (id_proveedorComboBox.Text.Equals("") | id_empleadoComboBox.Text.Equals("") | telefono_proveedorTextBox.Text.Equals("") | email_proveedorTextBox.Text.Equals(""))
            {
                if (id_proveedorComboBox.Text == "")
                {
                    errorProvider1.SetError(id_proveedorComboBox, "Debe introducir el nombre del proveedor");
                }
                if (id_empleadoComboBox.Text == "")
                {
                    errorProvider1.SetError(id_empleadoComboBox, "Debe introducir el nombre del empleado que realiza la compra");
                }
                if (telefono_proveedorTextBox.Text == "")
                {
                    errorProvider1.SetError(telefono_proveedorTextBox, "Debe introducir el  teléfono del proveedor");
                }
                if (email_proveedorTextBox.Text == "")
                {
                    errorProvider1.SetError(email_proveedorTextBox, "Debe introducir el email del proveedor");
                }
            }
            else
            {

                try
                {
              
                    errorProvider1.Clear();

                    comprasBindingSource.EndEdit();
                    consultaMaestro();


                    btnPrimero.Enabled = false;
                    btnAnterior.Enabled = false;
                    btnSiguiente.Enabled = false;
                    btnUltimo.Enabled = false;

                    contextMenuStrip1.Enabled = false;
                    menuStrip1.Enabled = false;

                    btnInforme.Enabled = false;

                    btnEditar.Enabled = false;
                    btnAnadir.Enabled = false;
                    btnBorrar.Enabled = false;
                    btnGuardar.Enabled = false;


                    consultaDetalle();
                }
                catch (Exception)
                {
                    MessageBox.Show("Tiene que seleccionar un proveedor", "Error en el proveedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            comprasBindingSource.CancelEdit();

            errorProvider1.Clear();

            consultaMaestro();
        }

        private void btnPrimeroLinea_Click(object sender, EventArgs e)
        {
            detalleComprasBindingSource.MoveFirst();
        }

        private void btnAnteriorLinea_Click(object sender, EventArgs e)
        {
            detalleComprasBindingSource.MovePrevious();
        }

        private void btnSiguienteLinea_Click(object sender, EventArgs e)
        {
            detalleComprasBindingSource.MoveNext();
        }

        private void btnUltimoLinea_Click(object sender, EventArgs e)
        {
            detalleComprasBindingSource.MoveLast();
        }

        private void btnEditarLinea_Click(object sender, EventArgs e)
        {
            edicionDetalle();
        }

        private void btnBorrarLinea_Click(object sender, EventArgs e)
        {
            try
            {
                detalleComprasBindingSource.RemoveCurrent();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar una linea inexistente", "Linea inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptarLinea_Click(object sender, EventArgs e)
        {
            if (nombre_bicicletaTextBox.Text.Equals("") | categoriaComboBox.Text.Equals("") | fabricanteTextBox.Text.Equals("") | cantidad_compradaTextBox.Text.Equals("") |
               precio_compraTextBox.Text.Equals("") | descuentoTextBox.Text.Equals(""))
            {
                if (nombre_bicicletaTextBox.Text == "")
                {
                    errorProvider1.SetError(nombre_bicicletaTextBox, "Debe introducir el nombre de la bicicleta");
                }
                if (categoriaComboBox.Text == "")
                {
                    errorProvider1.SetError(categoriaComboBox, "Debe seleccionar la categoría del bicicleta");
                }
                if (fabricanteTextBox.Text == "")
                {
                    errorProvider1.SetError(fabricanteTextBox, "Debe introducir el nombre del creador del bicicleta");
                }
                if (cantidad_compradaTextBox.Text == "")
                {
                    errorProvider1.SetError(cantidad_compradaTextBox, "Debe introducir la cantidad comprada");
                }
                if (precio_compraTextBox.Text == "")
                {
                    errorProvider1.SetError(precio_compraTextBox, "Debe introducir el precio de compra");
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

                    detalleComprasBindingSource.EndEdit();

                  
                    descuento();

                    consultaDetalle();

                    btnTerminar.Enabled = true;

                 
                    detalleComprasDataGridView.Refresh();

                }
                catch (Exception)
                {
                    MessageBox.Show("Error. El producto ya existe", "Producto duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAnadirLinea_Click(object sender, EventArgs e)
        {
            detalleComprasBindingSource.AddNew();

            edicionDetalle();
        }

        private void btnCancelarLinea_Click(object sender, EventArgs e)
        {
            detalleComprasBindingSource.CancelEdit();

            errorProvider1.Clear();

            btnTerminar.Enabled = true;

            consultaDetalle();
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

        private void comprasBindingSource_PositionChanged(object sender, EventArgs e)
        {
            label1.Text = "Compra " + (comprasBindingSource.Position + 1) + " de " + comprasBindingSource.Count;

            if (comprasBindingSource.Position == 0)
            {
                btnPrimero.Enabled = false;
                btnAnterior.Enabled = false;
            }
            else
            {
                btnPrimero.Enabled = true;
                btnAnterior.Enabled = true;
            }

            if (comprasBindingSource.Position == comprasBindingSource.Count - 1)
            {
                btnSiguiente.Enabled = false;
                btnUltimo.Enabled = false;
            }
            else
            {
                btnSiguiente.Enabled = true;
                btnUltimo.Enabled = true;
            }

           
            btnBorrar.Enabled = comprasBindingSource.Count > 0;
        }

        private void id_proveedorComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (id_proveedorComboBox.Text != "")
            {
                errorProvider1.SetError(id_proveedorComboBox, "");
            }
        }

        private void id_empleadoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void id_empleadoComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (id_empleadoComboBox.Text != "")
            {
                errorProvider1.SetError(id_empleadoComboBox, "");
            }
        }

        private void telefono_proveedorTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (telefono_proveedorTextBox.Text != "")
            {
                errorProvider1.SetError(telefono_proveedorTextBox, "");
            }
        }

        private void email_proveedorTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (email_proveedorTextBox.Text != "")
            {
                errorProvider1.SetError(email_proveedorTextBox, "");
            }
        }

        private void detalleComprasBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            label2.Text = "Producto " + (detalleComprasBindingSource.Position + 1) + " de " + detalleComprasBindingSource.Count;

            if (detalleComprasBindingSource.Position == 0)
            {
                btnPrimeroLinea.Enabled = false;
                btnAnteriorLinea.Enabled = false;
            }
            else
            {
                btnPrimeroLinea.Enabled = true;
                btnAnteriorLinea.Enabled = true;
            }

            if (detalleComprasBindingSource.Position == detalleComprasBindingSource.Count - 1)
            {
                btnSiguienteLinea.Enabled = false;
                btnUltimoLinea.Enabled = false;
            }
            else
            {
                btnSiguienteLinea.Enabled = true;
                btnUltimoLinea.Enabled = true;
            }

           
            btnBorrarLinea.Enabled = detalleComprasBindingSource.Count > 0;
        }

        private void nombre_bicicletaTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (nombre_bicicletaTextBox.Text != "")
            {
                errorProvider1.SetError(nombre_bicicletaTextBox, "");
            }
        }

        private void fabricanteTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (fabricanteTextBox.Text != "")
            {
                errorProvider1.SetError(fabricanteTextBox, "");
            }
        }

        private void categoriaTextBox1_Validating(object sender, CancelEventArgs e)
        {
            if (categoriaComboBox.Text != "")
            {
                errorProvider1.SetError(categoriaComboBox, "");
            }
        }

        private void cantidad_compradaTextBox_Validating(object sender, CancelEventArgs e)
        {
           
            float i;
            if (!float.TryParse(cantidad_compradaTextBox.Text, out i) | (i <= 0))
            {
                errorProvider1.SetError(cantidad_compradaTextBox, "Error introduzca un número mayor a 0");
                cantidad_compradaTextBox.Text = String.Empty;
                e.Cancel = true;
            }

            if (cantidad_compradaTextBox.Text != "")
            {
                errorProvider1.SetError(cantidad_compradaTextBox, "");
            }
        }

        private void precio_compraTextBox_Validating(object sender, CancelEventArgs e)
        {
            
            float i;
            if (!float.TryParse(precio_compraTextBox.Text, out i) | (i <= 0))
            {
                errorProvider1.SetError(precio_compraTextBox, "Error introduzca un número mayor a 0");
                precio_compraTextBox.Text = String.Empty;
                e.Cancel = true;
            }

            if (precio_compraTextBox.Text != "")
            {
                errorProvider1.SetError(precio_compraTextBox, "");
            }
        }

        private void descuentoTextBox_Validating(object sender, CancelEventArgs e)
        {
           
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
            
            

         }

        private void Compras_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bBDDCiclismoDataSet.HasChanges())
            {
                if (MessageBox.Show("¿Guardar las modificaciones pendientes antes de salir?", "Guardar cambios", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    try
                    {
                        comprasBindingSource.EndEdit();
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

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void id_proveedorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BBDDCiclismoDataSet.ProveedorRow filaCliente;

            if (id_proveedorComboBox.SelectedIndex != -1)
            {
                filaCliente = bBDDCiclismoDataSet.Proveedor[id_proveedorComboBox.SelectedIndex];


                if (filaCliente.IsNombreNull())
                    nombre_proveedorLabel1.Text = "";
                else
                    nombre_proveedorLabel1.Text = filaCliente.Nombre;


                if (filaCliente.IsTelefonoNull())
                    telefono_proveedorTextBox.Text = "";
                else
                {
                    telefono_proveedorTextBox.Text = filaCliente.Telefono;
                }

                if (filaCliente.IsEmailNull())
                    email_proveedorTextBox.Text = "";
                else
                {
                    email_proveedorTextBox.Text = filaCliente.Email;
                }

            }
        }

        private void nombre_proveedorLabel1_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
