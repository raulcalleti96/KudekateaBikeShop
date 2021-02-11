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
    public partial class InformeClientes : Form
    {
        public InformeClientes()
        {
            InitializeComponent();
        }

        private void InformeClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'BBDDCiclismoDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.ClientesTableAdapter.Fill(this.BBDDCiclismoDataSet.Clientes);

            this.reportViewer1.RefreshReport();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text.Equals("Id"))
                {
                    ClientesBindingSource.Filter = "Id = " + "'" + textBox1.Text + "'";
                    reportViewer1.RefreshReport();
                }
                if (comboBox1.Text.Equals("Nombre"))
                {
                    ClientesBindingSource.Filter = "Nombre = " + "'" + textBox1.Text + "'";
                    reportViewer1.RefreshReport();
                }
                if (comboBox1.Text.Equals("DNI"))
                {
                    ClientesBindingSource.Filter = "DNI = " + "'" + textBox1.Text + "'";
                    reportViewer1.RefreshReport();
                }

                if (comboBox1.Text.Equals("Email"))
                {
                    ClientesBindingSource.Filter = "Email = " + "'" + textBox1.Text + "'";
                    reportViewer1.RefreshReport();
                }
                if (comboBox1.Text.Equals("Provincia"))
                {
                    ClientesBindingSource.Filter = "Provincia = " + "'" + textBox1.Text + "'";
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
            ClientesBindingSource.Filter = "";
            reportViewer1.RefreshReport();
        }
    }
}
