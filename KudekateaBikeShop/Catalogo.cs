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
    public partial class Catalogo : Form
    {
        public Catalogo()
        {
            InitializeComponent();
        }

        private void bicicletasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bicicletasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bBDDCiclismoDataSet);

        }

        private void bicicletasBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bicicletasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bBDDCiclismoDataSet);

        }

        private void Catalogo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bBDDCiclismoDataSet.Bicicletas' Puede moverla o quitarla según sea necesario.
            this.bicicletasTableAdapter.Fill(this.bBDDCiclismoDataSet.Bicicletas);
            btnAceptar.Enabled = false;
            btnCancelar.Enabled = false;

            modoConsulta();

        }
        public void modoConsulta()
        {
            contextMenuStrip1.Enabled = true;
            menuStrip1.Enabled = true;

            nombreTextBox.Enabled = false;
            categoriaComboBox.Enabled = false;
            fabricanteTextBox.Enabled = false;
            stockTextBox.Enabled = false;
            precioTextBox.Enabled = false;
            fotoPictureBox.Enabled = false;
            descripcionTextBox.Enabled = false;

            btnUltimo.Enabled = true;
            btnSiguiente.Enabled = true;
            btnAnterior.Enabled = true;
            btnPrimero.Enabled = true;

            btnInforme.Enabled = true;

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
            categoriaComboBox.Enabled = true;
            fabricanteTextBox.Enabled = true;
            stockTextBox.Enabled = true;
            precioTextBox.Enabled = true;
            fotoPictureBox.Enabled = true;
            descripcionTextBox.Enabled = true;

            btnUltimo.Enabled = false;
            btnSiguiente.Enabled = false;
            btnAnterior.Enabled = false;
            btnPrimero.Enabled = false;

 
            comboBox1.Enabled = false;
            buscarTextBox.Enabled = false;
            btnBuscar.Enabled = false;

            btnInforme.Enabled = false;

            btnEditar.Enabled = false;
            btnAnadir.Enabled = false;
            btnBorrar.Enabled = false;
            btnGuardar.Enabled = false;


            btnAceptar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            bicicletasBindingSource.MoveFirst();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            bicicletasBindingSource.MovePrevious();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            bicicletasBindingSource.MoveNext();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            bicicletasBindingSource.MoveLast();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            modoEditar();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            bicicletasBindingSource.AddNew();
            modoEditar();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("¿Desea borrar esta bicicleta?", "Eliminar bicicleta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)) == DialogResult.Yes)
            {
                try
                {
                    bicicletasBindingSource.RemoveCurrent();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al eliminar una bicicleta inexistente", "bicicleta inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bicicletasTableAdapter.Update(bBDDCiclismoDataSet);
            MessageBox.Show("Datos guardados correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bicicletasBindingSource.CancelEdit();

            //Limpiar el errorprovider
            errorProvider1.Clear();

            modoConsulta();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (nombreTextBox.Text.Equals("") | categoriaComboBox.Text.Equals("") | fabricanteTextBox.Text.Equals("")
           | precioTextBox.Text.Equals("") | descripcionTextBox.Text.Equals("") | stockTextBox.Text.Equals(""))
            {
                if (nombreTextBox.Text == "")
                {
                    errorProvider1.SetError(nombreTextBox, "Debe introducir el nombre de la bicicleta");
                }
                if (categoriaComboBox.Text == "")
                {
                    errorProvider1.SetError(categoriaComboBox, "Debe introducir la categoria");
                }
                if (fabricanteTextBox.Text == "")
                {
                    errorProvider1.SetError(fabricanteTextBox, "Debe introducir el fabricante");
                }
                if (precioTextBox.Text == "")
                {
                    errorProvider1.SetError(precioTextBox, "Debe introducir el precio");
                }
                if (descripcionTextBox.Text == "")
                {
                    errorProvider1.SetError(descripcionTextBox, "Debe introducir la descripción");
                }
                if (stockTextBox.Text == "")
                {
                    errorProvider1.SetError(stockTextBox, "Debe introducir el stock disponible");
                }
            }
            else
            {
                //Limpiar el errorprovider
                errorProvider1.Clear();

                bicicletasBindingSource.EndEdit();

                //ponemos el modo consulta
                modoConsulta();
            }
        }

        private void bicicletasBindingSource_PositionChanged(object sender, EventArgs e)
        {
            label2.Text = "bicicleta " + (bicicletasBindingSource.Position + 1) + " de " + bicicletasBindingSource.Count;

            if (bicicletasBindingSource.Position == 0)
            {
                btnPrimero.Enabled = false;
                btnAnterior.Enabled = false;
            }
            else
            {
                btnPrimero.Enabled = true;
                btnAnterior.Enabled = true;
            }

            if (bicicletasBindingSource.Position == bicicletasBindingSource.Count - 1)
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
            btnBorrar.Enabled = bicicletasBindingSource.Count > 0;
        }

        private void nombreTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (nombreTextBox.Text != "")
            {
                errorProvider1.SetError(nombreTextBox, "");
            }
        }

        private void categoriaComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (categoriaComboBox.Text != "")
            {
                errorProvider1.SetError(categoriaComboBox, "");
            }
        }

        private void fabricanteTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (fabricanteTextBox.Text != "")
            {
                errorProvider1.SetError(fabricanteTextBox, "");
            }
        }

        private void stockTextBox_Validating(object sender, CancelEventArgs e)
        {
            //comprobamos que sea mayor a 0
            float i;
            if (!float.TryParse(stockTextBox.Text, out i) | (i <= 0))
            {
                errorProvider1.SetError(stockTextBox, "Error introduzca un número mayor a 0");
                stockTextBox.Text = String.Empty;
                e.Cancel = true;
            }

            if (stockTextBox.Text != "")
            {
                errorProvider1.SetError(stockTextBox, "");
            }
        }

        private void precioTextBox_Validating(object sender, CancelEventArgs e)
        {
            //comprobamos que sea mayor a 0
            float i;
            if (!float.TryParse(precioTextBox.Text, out i) | (i <= 0))
            {
                errorProvider1.SetError(precioTextBox, "Error introduzca un número mayor a 0");
                precioTextBox.Text = String.Empty;
                e.Cancel = true;
            }

            if (precioTextBox.Text != "")
            {
                errorProvider1.SetError(precioTextBox, "");
            }
        }

        private void descripcionTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (descripcionTextBox.Text.Length > 200)
            {
                MessageBox.Show("Error en la descripción de la bicicleta", "Descripcion demasiado larga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                descripcionTextBox.Text = "";
            }

            if (descripcionTextBox.Text != "")
            {
                errorProvider1.SetError(descripcionTextBox, "");
            }
        }

        private void Catalogo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bBDDCiclismoDataSet.HasChanges())
            {
                if (MessageBox.Show("¿Guardar las modificaciones pendientes antes de salir?", "Guardar cambios", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    try
                    {
                        bicicletasBindingSource.EndEdit();
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
                if (fm.GetType() == typeof(InformeCatalogo))
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
                InformeCatalogo v2 = new InformeCatalogo();
                v2.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text.Equals("Id"))
                {

                    //Buscar por id
                    if (bicicletasBindingSource.Find("Id", buscarTextBox.Text) == -1)
                    {
                        MessageBox.Show("Error al encontrar el Id", "Id inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        buscarTextBox.Text = "";
                    }
                    else
                    {
                        bicicletasBindingSource.Position = bicicletasBindingSource.Find("Id", buscarTextBox.Text);
                    }
                }

                if (comboBox1.Text.Equals("Nombre"))
                {

                    //Buscar por nombre
                    if (bicicletasBindingSource.Find("Nombre", buscarTextBox.Text) == -1)
                    {
                        MessageBox.Show("Error al encontrar el nombre", "Nombre inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        buscarTextBox.Text = "";
                    }
                    else
                    {
                        bicicletasBindingSource.Position = bicicletasBindingSource.Find("Nombre", buscarTextBox.Text);
                    }
                }

                if (comboBox1.Text.Equals("Fabricante"))
                {

                    //Buscar por nombre
                    if (bicicletasBindingSource.Find("Fabricante", buscarTextBox.Text) == -1)
                    {
                        MessageBox.Show("Error al encontrar el fabricante", "Fabricante inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        buscarTextBox.Text = "";
                    }
                    else
                    {
                        bicicletasBindingSource.Position = bicicletasBindingSource.Find("Creador", buscarTextBox.Text);
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error al encontrar al bicicleta", "Bicicleta inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
