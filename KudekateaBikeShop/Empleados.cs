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
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bBDDCiclismoDataSet.Empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this.bBDDCiclismoDataSet.Empleados);

            Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            int w = Width >= screen.Width ? screen.Width : (screen.Width + Width) / 2;
            int h = Height >= screen.Height ? screen.Height : (screen.Height + Height) / 2;
            this.Location = new Point((screen.Width - w) / 2, (screen.Height - h) / 2);
            this.Size = new Size(w, h);

            btnAceptar.Enabled = false;
            btnCancelar.Enabled = false;

            modoConsulta();

        }

        private void empleadosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.empleadosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bBDDCiclismoDataSet);



        }

        public void modoConsulta()
        {
            contextMenuStrip1.Enabled = true;
            menuStrip1.Enabled = true;

            nombreTextBox.Enabled = false;
            dNITextBox.Enabled = false;
            direccionTextBox.Enabled = false;
            telefonoTextBox.Enabled = false;
            usuarioTextBox.Enabled = false;
            passwordTextBox.Enabled = false;
            rolComboBox.Enabled = false;
            fotoPictureBox.Enabled = false;

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
            direccionTextBox.Enabled = true;
            telefonoTextBox.Enabled = true;
            usuarioTextBox.Enabled = true;
            passwordTextBox.Enabled = true;
            rolComboBox.Enabled = true;
            fotoPictureBox.Enabled = true;

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
            empleadosBindingSource.MoveFirst();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            empleadosBindingSource.MovePrevious();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            empleadosBindingSource.MoveNext();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            empleadosBindingSource.MoveLast();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            modoEditar();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            empleadosBindingSource.AddNew();
            modoEditar();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("¿Desea borrar este empleado?", "Eliminar empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)) == DialogResult.Yes)
            {
                try
                {
                    empleadosBindingSource.RemoveCurrent();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al eliminar un empleado inexistente", "Empleado inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            empleadosTableAdapter.Update(bBDDCiclismoDataSet);
            MessageBox.Show("Datos guardados correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (nombreTextBox.Text.Equals("") | dNITextBox.Text.Equals("") | direccionTextBox.Text.Equals("")
          | telefonoTextBox.Text.Equals("") |  usuarioTextBox.Text.Equals("")
          | passwordTextBox.Text.Equals("") | rolComboBox.Text.Equals(""))
            {
                if (nombreTextBox.Text == "")
                {
                    errorProvider1.SetError(nombreTextBox, "Debe introducir el nombre del empleado");
                }
                if (dNITextBox.Text == "")
                {
                    errorProvider1.SetError(dNITextBox, "Debe introducir el DNI");
                }
                if (direccionTextBox.Text == "")
                {
                    errorProvider1.SetError(direccionTextBox, "Debe introducir la dirección del empleado");
                }
                if (telefonoTextBox.Text == "")
                {
                    errorProvider1.SetError(telefonoTextBox, "Debe introducir teléfono");
                }
                if (usuarioTextBox.Text == "")
                {
                    errorProvider1.SetError(usuarioTextBox, "Debe introducir el nombre de usuario");
                }
                if (passwordTextBox.Text == "")
                {
                    errorProvider1.SetError(passwordTextBox, "Debe introducir la contraseña del usuario");
                }
                if (rolComboBox.Text == "")
                {
                    errorProvider1.SetError(rolComboBox, "Debe introducir el rol de usuario");
                }
            }
            else
            {
      
                errorProvider1.Clear();

                empleadosBindingSource.EndEdit();

               
                modoConsulta();
            }
        }

        private void empleadosBindingSource_PositionChanged(object sender, EventArgs e)
        {
            label1.Text = "Empleado " + (empleadosBindingSource.Position + 1) + " de " + empleadosBindingSource.Count;

            if (empleadosBindingSource.Position == 0)
            {
                btnPrimero.Enabled = false;
                btnAnterior.Enabled = false;
            }
            else
            {
                btnPrimero.Enabled = true;
                btnAnterior.Enabled = true;
            }

            if (empleadosBindingSource.Position == empleadosBindingSource.Count - 1)
            {
                btnSiguiente.Enabled = false;
                btnUltimo.Enabled = false;
            }
            else
            {
                btnSiguiente.Enabled = true;
                btnUltimo.Enabled = true;
            }

           
            btnBorrar.Enabled = empleadosBindingSource.Count > 0;
        }

        private void dNITextBox_Validating(object sender, CancelEventArgs e)
        {
            if (dNITextBox.Text.Length > 9)
            {
                errorProvider1.SetError(dNITextBox, "Error en el número de caracteres del DNI (9)");
                dNITextBox.Text = "";
            }
            if (dNITextBox.Text != "")
            {
                errorProvider1.SetError(dNITextBox, "");
            }
        }

        private void direccionTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (direccionTextBox.Text != "")
            {
                errorProvider1.SetError(direccionTextBox, "");
            }
        }

        private void telefonoTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (telefonoTextBox.Text.Length > 9)
            {
                errorProvider1.SetError(telefonoTextBox, "Error en el número de caracteres del teléfono (9)");
                telefonoTextBox.Text = "";
            }
            if (telefonoTextBox.Text != "")
            {
                errorProvider1.SetError(telefonoTextBox, "");
            }
        }

        private void usuarioTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (usuarioTextBox.Text != "")
            {
                errorProvider1.SetError(usuarioTextBox, "");
            }
        }

        private void passwordTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (passwordTextBox.Text != "")
            {
                errorProvider1.SetError(passwordTextBox, "");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            empleadosBindingSource.CancelEdit();

            
            errorProvider1.Clear();

            modoConsulta();
        }

        private void Empleados_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bBDDCiclismoDataSet.HasChanges())
            {
                if (MessageBox.Show("¿Guardar las modificaciones pendientes antes de salir?", "Guardar cambios", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    try
                    {
                        empleadosBindingSource.EndEdit();
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

        private void fotoPictureBox_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivos gráficos|*.bmp;*.gif;*.jpg;*.png";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fotoPictureBox.Image = Image.FromFile((openFileDialog1.FileName));
            }
            else
            {
                fotoPictureBox.Image = null;
            }
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
             Boolean abierta = false;

            foreach (Form fm in Application.OpenForms)
            {
                if (fm.GetType() == typeof(InformeEmpleados))
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
                InformeEmpleados v2 = new InformeEmpleados();
                v2.Show();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text.Equals("Id"))
                {

                 
                    if (empleadosBindingSource.Find("Id", buscarTextBox.Text) == -1)
                    {
                        MessageBox.Show("Error al encontrar el Id", "Id inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        buscarTextBox.Text = "";
                    }
                    else
                    {
                        empleadosBindingSource.Position = empleadosBindingSource.Find("Id", buscarTextBox.Text);
                    }
                }

                if (comboBox1.Text.Equals("Nombre"))
                {

                  
                    if (empleadosBindingSource.Find("Nombre", buscarTextBox.Text) == -1)
                    {
                        MessageBox.Show("Error al encontrar el nombre", "Nombre inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        buscarTextBox.Text = "";
                    }
                    else
                    {
                        empleadosBindingSource.Position = empleadosBindingSource.Find("Nombre", buscarTextBox.Text);
                    }
                }

                if (comboBox1.Text.Equals("DNI"))
                {

                    if (empleadosBindingSource.Find("DNI", buscarTextBox.Text) == -1)
                    {
                        MessageBox.Show("Error al encontrar el DNI", "DNI inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        buscarTextBox.Text = "";
                    }
                    else
                    {
                        empleadosBindingSource.Position = empleadosBindingSource.Find("DNI", buscarTextBox.Text);
                    }
                }

                if (comboBox1.Text.Equals("Usuario"))
                {

                   
                    if (empleadosBindingSource.Find("Usuario", buscarTextBox.Text) == -1)
                    {
                        MessageBox.Show("Error al encontrar el telefono", "telefono inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        buscarTextBox.Text = "";
                    }
                    else
                    {
                        empleadosBindingSource.Position = empleadosBindingSource.Find("Usuario", buscarTextBox.Text);
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error al encontrar al empleado", "Empleado inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ayudatoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, helpProvider1.HelpNamespace);
        }
    }
}
