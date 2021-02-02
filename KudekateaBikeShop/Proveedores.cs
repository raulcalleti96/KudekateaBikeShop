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
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }

        private void proveedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.proveedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bBDDCiclismoDataSet);

        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bBDDCiclismoDataSet.Proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.Fill(this.bBDDCiclismoDataSet.Proveedor);


            btnAceptar.Enabled = false;
            btnCancelar.Enabled = false;

            modoConsulta();

        }


        public void modoConsulta()
        {
            contextMenuStrip1.Enabled = true;
            menuStrip1.Enabled = true;

            //cuadros de dialogo a desactivados
            nombreTextBox.Enabled = false;
            telefonoTextBox.Enabled = false;
            emailTextBox.Enabled = false;
            provinciaTextBox.Enabled = false;
            direccionTextBox.Enabled = false;
            cod_postalTextBox.Enabled = false;
            paisTextBox.Enabled = false;

            btnInforme.Enabled = true;

            //los botones de movimiento activados
            btnUltimo.Enabled = true;
            btnSiguiente.Enabled = true;
            btnAnterior.Enabled = true;
            btnPrimero.Enabled = true;

            //buscar
            comboBox1.Enabled = true;
            buscarTextBox.Enabled = true;
            btnBuscar.Enabled = true;

            //botones navegacion y acciones activos
            btnEditar.Enabled = true;
            btnAnadir.Enabled = true;
            btnBorrar.Enabled = true;
            btnGuardar.Enabled = true;

            //boton aceptar y cancelar desactivados
            btnAceptar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        public void modoEditar()
        {
            contextMenuStrip1.Enabled = false;
            menuStrip1.Enabled = false;

            //cuadros de dialogo a activados
            nombreTextBox.Enabled = true;
            telefonoTextBox.Enabled = true;
            emailTextBox.Enabled = true;
            provinciaTextBox.Enabled = true;
            direccionTextBox.Enabled = true;
            cod_postalTextBox.Enabled = true;
            paisTextBox.Enabled = true;

            btnInforme.Enabled = false;

            //los botones de movimiento activados
            btnUltimo.Enabled = false;
            btnSiguiente.Enabled = false;
            btnAnterior.Enabled = false;
            btnPrimero.Enabled = false;

            //buscar
            comboBox1.Enabled = false;
            buscarTextBox.Enabled = false;
            btnBuscar.Enabled = false;

            //botones navegacion y acciones activos
            btnEditar.Enabled = false;
            btnAnadir.Enabled = false;
            btnBorrar.Enabled = false;
            btnGuardar.Enabled = false;

            //boton aceptar y cancelar desactivados
            btnAceptar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
           /* Boolean abierta = false;

            foreach (Form fm in Application.OpenForms)
            {
                if (fm.GetType() == typeof(ProveedoresInf))
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
                ProveedoresInf v2 = new ProveedoresInf();
                v2.Show();
            }*/
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            proveedorBindingSource.MoveFirst();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            proveedorBindingSource.MovePrevious();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            proveedorBindingSource.MoveNext();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            proveedorBindingSource.MoveLast();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            proveedorBindingSource.AddNew();
            modoEditar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            modoEditar();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Desea borrar este proveedor?", "Eliminar proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)) == DialogResult.Yes)
            {
                try
                {
                    proveedorBindingSource.RemoveCurrent();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al eliminar un proveedor inexistente", "Proveedor inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            proveedorTableAdapter.Update(bBDDCiclismoDataSet);
            MessageBox.Show("Datos guardados correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text.Equals("Id"))
                {

                    //Buscar por id
                    if (proveedorBindingSource.Find("Id", buscarTextBox.Text) == -1)
                    {
                        MessageBox.Show("Error al encontrar el Id", "Id inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        buscarTextBox.Text = "";
                    }
                    else
                    {
                        proveedorBindingSource.Position = proveedorBindingSource.Find("Id", buscarTextBox.Text);
                    }
                }

                if (comboBox1.Text.Equals("Nombre"))
                {

                    //Buscar por nombre
                    if (proveedorBindingSource.Find("Nombre", buscarTextBox.Text) == -1)
                    {
                        MessageBox.Show("Error al encontrar el nombre", "Nombre inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        buscarTextBox.Text = "";
                    }
                    else
                    {
                        proveedorBindingSource.Position = proveedorBindingSource.Find("Nombre", buscarTextBox.Text);
                    }
                }

                if (comboBox1.Text.Equals("Telefono"))
                {

                    //Buscar por nombre
                    if (proveedorBindingSource.Find("Telefono", buscarTextBox.Text) == -1)
                    {
                        MessageBox.Show("Error al encontrar el teléfono", "Teléfono inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        buscarTextBox.Text = "";
                    }
                    else
                    {
                        proveedorBindingSource.Position = proveedorBindingSource.Find("Telefono", buscarTextBox.Text);
                    }
                }

                if (comboBox1.Text.Equals("Provincia"))
                {

                    //Buscar por nombre
                    if (proveedorBindingSource.Find("Provincia", buscarTextBox.Text) == -1)
                    {
                        MessageBox.Show("Error al encontrar la provincia", "Provincia inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        buscarTextBox.Text = "";
                    }
                    else
                    {
                        proveedorBindingSource.Position = proveedorBindingSource.Find("Provincia", buscarTextBox.Text);
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error al encontrar al proveedor", "Proveedor inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (nombreTextBox.Text.Equals("") | telefonoTextBox.Text.Equals("") | emailTextBox.Text.Equals("")
          | provinciaTextBox.Text.Equals("") | direccionTextBox.Text.Equals("") | cod_postalTextBox.Text.Equals("")
          | paisTextBox.Text.Equals(""))
            {
                if (nombreTextBox.Text == "")
                {
                    errorProvider1.SetError(nombreTextBox, "Debe introducir el nombre del proveedor");
                }
                if (telefonoTextBox.Text == "")
                {
                    errorProvider1.SetError(telefonoTextBox, "Debe introducir el teléfono");
                }
                if (emailTextBox.Text == "")
                {
                    errorProvider1.SetError(emailTextBox, "Debe introducir el email");
                }
                if (provinciaTextBox.Text == "")
                {
                    errorProvider1.SetError(provinciaTextBox, "Debe introducir la provincia del proveedor");
                }
                if (direccionTextBox.Text == "")
                {
                    errorProvider1.SetError(direccionTextBox, "Debe introducir la dirección");
                }
                if (cod_postalTextBox.Text == "")
                {
                    errorProvider1.SetError(cod_postalTextBox, "Debe introducir la provincia");
                }
                if (paisTextBox.Text == "")
                {
                    errorProvider1.SetError(paisTextBox, "Debe introducir el código postal");
                }
            }
            else
            {
                //Limpiar el errorprovider
                errorProvider1.Clear();

                proveedorBindingSource.EndEdit();

                //ponemos el modo consulta
                modoConsulta();
            }
        }
    

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            proveedorBindingSource.CancelEdit();

            //Limpiar el errorprovider
            errorProvider1.Clear();

            modoConsulta();
        }

        private void nombreTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (nombreTextBox.Text != "")
            {
                errorProvider1.SetError(nombreTextBox, "");
            }
        }

        private void telefonoTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (telefonoTextBox.Text.Length > 9)
            {
                errorProvider1.SetError(telefonoTextBox, "Teléfono demasiado largo (9 números)");
                telefonoTextBox.Text = "";
            }
            if (telefonoTextBox.Text != "")
            {
                errorProvider1.SetError(telefonoTextBox, "");
            }

        }

        private void emailTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (telefonoTextBox.Text.Length > 9)
            {
                errorProvider1.SetError(telefonoTextBox, "Teléfono demasiado largo (9 números)");
                telefonoTextBox.Text = "";
            }
            if (telefonoTextBox.Text != "")
            {
                errorProvider1.SetError(telefonoTextBox, "");
            }
        }

        private void provinciaTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (provinciaTextBox.Text != "")
            {
                errorProvider1.SetError(provinciaTextBox, "");
            }
        }

        private void direccionTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (direccionTextBox.Text != "")
            {
                errorProvider1.SetError(direccionTextBox, "");
            }
        }

        private void cod_postalTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (cod_postalTextBox.Text.Length > 4)
            {
                errorProvider1.SetError(cod_postalTextBox, "Código postal demasiado largo (4 números)");
                cod_postalTextBox.Text = "";
            }
            if (cod_postalTextBox.Text != "")
            {
                errorProvider1.SetError(cod_postalTextBox, "");
            }
        }

        private void paisTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (paisTextBox.Text != "")
            {
                errorProvider1.SetError(paisTextBox, "");
            }
        }

        private void Proveedores_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bBDDCiclismoDataSet.HasChanges())
            {
                if (MessageBox.Show("¿Guardar las modificaciones pendientes antes de salir?", "Guardar cambios", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    try
                    {
                        proveedorBindingSource.EndEdit();
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

        private void proveedorBindingSource_PositionChanged(object sender, EventArgs e)
        {
            label2.Text = "Proveedor " + (proveedorBindingSource.Position + 1) + " de " + proveedorBindingSource.Count;

            if (proveedorBindingSource.Position == 0)
            {
                btnPrimero.Enabled = false;
                btnAnterior.Enabled = false;
            }
            else
            {
                btnPrimero.Enabled = true;
                btnAnterior.Enabled = true;
            }

            if (proveedorBindingSource.Position == proveedorBindingSource.Count - 1)
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
            btnBorrar.Enabled = proveedorBindingSource.Count > 0;
        }
    }
}
