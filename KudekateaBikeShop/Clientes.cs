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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bBDDCiclismoDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.bBDDCiclismoDataSet.Clientes);


            btnAceptar.Enabled = false;
            btnCancelar.Enabled = false;

            modoConsulta();
        }

        public void modoConsulta()
        {
            contextMenuStrip1.Enabled = true;
            menuStrip1.Enabled = true;

            nombreTextBox.Enabled = false;
            dNITextBox.Enabled = false;
            emailTextBox.Enabled = false;
            telefonoTextBox.Enabled = false;
            direccionTextBox.Enabled = false;
            provinciaTextBox.Enabled = false;
            codigo_postalTextBox.Enabled = false;
          

            btnInforme.Enabled = true;

   
            btnUltimo.Enabled = true;
            btnSiguiente.Enabled = true;
            btnAnterior.Enabled = true;
            btnPrimero.Enabled = true;

            
            comboBox1.Enabled = true;
            buscarTextBox.Enabled = true;
            btnBuscar.Enabled = true;

            btnEditar.Enabled = true;
            btnAnadir.Enabled = true;
            btnBorrar.Enabled = true;
            btnGuardar.Enabled = true;

            btnAceptar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        public void modoEditar()
        {
            contextMenuStrip1.Enabled = false;
            menuStrip1.Enabled = false;

            nombreTextBox.Enabled = true;
            dNITextBox.Enabled = true;
            emailTextBox.Enabled = true;
            telefonoTextBox.Enabled = true;
            direccionTextBox.Enabled = true;
            provinciaTextBox.Enabled = true;
            codigo_postalTextBox.Enabled = true;
            

            btnInforme.Enabled = false;

            btnUltimo.Enabled = false;
            btnSiguiente.Enabled = false;
            btnAnterior.Enabled = false;
            btnPrimero.Enabled = false;

            comboBox1.Enabled = false;
            buscarTextBox.Enabled = false;
            btnBuscar.Enabled = false;

            btnEditar.Enabled = false;
            btnAnadir.Enabled = false;
            btnBorrar.Enabled = false;
            btnGuardar.Enabled = false;

            btnAceptar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            clientesBindingSource.MoveFirst();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            clientesBindingSource.MovePrevious();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            clientesBindingSource.MoveNext();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            clientesBindingSource.MoveLast();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            clientesBindingSource.AddNew();
            modoEditar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            modoEditar();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("¿Desea borrar este cliente?", "Eliminar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)) == DialogResult.Yes)
            {
                try
                {
                    clientesBindingSource.RemoveCurrent();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al eliminar un cliente inexistente", "Cliente inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
            clientesTableAdapter.Update(bBDDCiclismoDataSet);
            MessageBox.Show("Datos guardados correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text.Equals("Id"))
                {

                    if (clientesBindingSource.Find("Id", buscarTextBox.Text) == -1)
                    {
                        MessageBox.Show("Error al encontrar el Id", "Id inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        buscarTextBox.Text = "";
                    }
                    else
                    {
                        clientesBindingSource.Position = clientesBindingSource.Find("Id", buscarTextBox.Text);
                    }
                }

                if (comboBox1.Text.Equals("Nombre"))
                {

                    if (clientesBindingSource.Find("Nombre", buscarTextBox.Text) == -1)
                    {
                        MessageBox.Show("Error al encontrar el nombre", "Nombre inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        buscarTextBox.Text = "";
                    }
                    else
                    {
                        clientesBindingSource.Position = clientesBindingSource.Find("Nombre", buscarTextBox.Text);
                    }
                }

                if (comboBox1.Text.Equals("DNI"))
                {

                    if (clientesBindingSource.Find("DNI", buscarTextBox.Text) == -1)
                    {
                        MessageBox.Show("Error al encontrar el DNI", "DNI inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        buscarTextBox.Text = "";
                    }
                    else
                    {
                        clientesBindingSource.Position = clientesBindingSource.Find("DNI", buscarTextBox.Text);
                    }
                }

                if (comboBox1.Text.Equals("Telefono"))
                {

                    if (clientesBindingSource.Find("Telefono", buscarTextBox.Text) == -1)
                    {
                        MessageBox.Show("Error al encontrar el telefono", "telefono inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        buscarTextBox.Text = "";
                    }
                    else
                    {
                        clientesBindingSource.Position = clientesBindingSource.Find("Telefono", buscarTextBox.Text);
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error al encontrar el cliente", "Cliente inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (nombreTextBox.Text.Equals("") | dNITextBox.Text.Equals("") | emailTextBox.Text.Equals("")
          | telefonoTextBox.Text.Equals("") | direccionTextBox.Text.Equals("") | provinciaTextBox.Text.Equals("")
          | codigo_postalTextBox.Text.Equals("") )
            {
                if (nombreTextBox.Text == "")
                {
                    errorProvider1.SetError(nombreTextBox, "Debe introducir el nombre del videojuego");
                }
                if (dNITextBox.Text == "")
                {
                    errorProvider1.SetError(dNITextBox, "Debe introducir el DNI");
                }
                if (emailTextBox.Text == "")
                {
                    errorProvider1.SetError(emailTextBox, "Debe introducir el email");
                }
                if (telefonoTextBox.Text == "")
                {
                    errorProvider1.SetError(telefonoTextBox, "Debe introducir el teléfono");
                }
                if (direccionTextBox.Text == "")
                {
                    errorProvider1.SetError(direccionTextBox, "Debe introducir la dirección");
                }
                if (provinciaTextBox.Text == "")
                {
                    errorProvider1.SetError(provinciaTextBox, "Debe introducir la provincia");
                }
                if (codigo_postalTextBox.Text == "")
                {
                    errorProvider1.SetError(codigo_postalTextBox, "Debe introducir el código postal");
                }
            }
            else
            {
                errorProvider1.Clear();

                clientesBindingSource.EndEdit();

                modoConsulta();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clientesBindingSource.CancelEdit();

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

        private void dNITextBox_Validating(object sender, CancelEventArgs e)
        {
            if (dNITextBox.Text.Length > 9)
            {
                errorProvider1.SetError(dNITextBox, "DNI demasiado largo (9 incluyendo letra)");
                dNITextBox.Text = "";
            }

            if (dNITextBox.Text != "")
            {
                errorProvider1.SetError(dNITextBox, "");
            }
        }

        private void emailTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (emailTextBox.Text != "")
            {
                errorProvider1.SetError(emailTextBox, "");
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

        private void direccionTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (direccionTextBox.Text != "")
            {
                errorProvider1.SetError(direccionTextBox, "");
            }
        }

        private void provinciaTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (provinciaTextBox.Text != "")
            {
                errorProvider1.SetError(provinciaTextBox, "");
            }
        }

        private void codigo_postalTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (codigo_postalTextBox.Text.Length > 5)
            {
                errorProvider1.SetError(codigo_postalTextBox, "Cod. postal muy largo (5 números)");
                codigo_postalTextBox.Text = "";
            }
            if (codigo_postalTextBox.Text != "")
            {
                errorProvider1.SetError(codigo_postalTextBox, "");
            }
        }

        private void Clientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bBDDCiclismoDataSet.HasChanges())
            {
                if (MessageBox.Show("¿Guardar las modificaciones pendientes antes de salir?", "Guardar cambios", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    try
                    {
                        clientesBindingSource.EndEdit();
                        clientesTableAdapter.Update(bBDDCiclismoDataSet);
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

        private void clientesBindingSource_PositionChanged(object sender, EventArgs e)
        {
            label1.Text = "Cliente " + (clientesBindingSource.Position + 1) + " de " + clientesBindingSource.Count;

            if (clientesBindingSource.Position == 0)
            {
                btnPrimero.Enabled = false;
                btnAnterior.Enabled = false;
            }
            else
            {
                btnPrimero.Enabled = true;
                btnAnterior.Enabled = true;
            }

            if (clientesBindingSource.Position == clientesBindingSource.Count - 1)
            {
                btnSiguiente.Enabled = false;
                btnUltimo.Enabled = false;
            }
            else
            {
                btnSiguiente.Enabled = true;
                btnUltimo.Enabled = true;
            }

            btnBorrar.Enabled = clientesBindingSource.Count > 0;
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {

            Boolean abierta = false;

            foreach (Form fm in Application.OpenForms)
            {
                if (fm.GetType() == typeof(InformeClientes))
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
                InformeClientes v2 = new InformeClientes();
                v2.Show();
            }
        }

        private void ayudatoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, helpProvider1.HelpNamespace);
        }
    }
}
