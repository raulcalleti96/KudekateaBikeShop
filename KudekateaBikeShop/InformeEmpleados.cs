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
    public partial class InformeEmpleados : Form
    {
        public InformeEmpleados()
        {
            InitializeComponent();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text.Equals("Id"))
                {
                    EmpleadosBindingSource.Filter = "Id = " + "'" + textBox1.Text + "'";
                    reportViewer1.RefreshReport();
                }
                if (comboBox1.Text.Equals("Nombre"))
                {
                    EmpleadosBindingSource.Filter = "Nombre = " + "'" + textBox1.Text + "'";
                    reportViewer1.RefreshReport();
                }
                if (comboBox1.Text.Equals("DNI"))
                {
                    EmpleadosBindingSource.Filter = "DNI = " + "'" + textBox1.Text + "'";
                    reportViewer1.RefreshReport();
                }

                if (comboBox1.Text.Equals("Usuario"))
                {
                    EmpleadosBindingSource.Filter = "Usuario = " + "'" + textBox1.Text + "'";
                    reportViewer1.RefreshReport();
                }
                if (comboBox1.Text.Equals("Rol"))
                {
                    EmpleadosBindingSource.Filter = "Rol = " + "'" + textBox1.Text + "'";
                    reportViewer1.RefreshReport();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al realizar el filtro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReinicio_Click(object sender, EventArgs e)
        {
            EmpleadosBindingSource.Filter = "";
            reportViewer1.RefreshReport();
        }

        private void InformeEmpleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'BBDDCiclismoDataSet.Empleados' Puede moverla o quitarla según sea necesario.
            this.EmpleadosTableAdapter.Fill(this.BBDDCiclismoDataSet.Empleados);

            this.reportViewer1.RefreshReport();
        }
    }
}
