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
    public partial class InformeProveedores : Form
    {
        public InformeProveedores()
        {
            InitializeComponent();
        }

        private void InformeProveedores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'BBDDCiclismoDataSet.Proveedor' Puede moverla o quitarla según sea necesario.
            this.ProveedorTableAdapter.Fill(this.BBDDCiclismoDataSet.Proveedor);

            this.reportViewer1.RefreshReport();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text.Equals("Id"))
                {
                    ProveedorBindingSource.Filter = "Id = " + "'" + textBox1.Text + "'";
                    reportViewer1.RefreshReport();
                }
                if (comboBox1.Text.Equals("Nombre"))
                {
                    ProveedorBindingSource.Filter = "Nombre = " + "'" + textBox1.Text + "'";
                    reportViewer1.RefreshReport();
                }
                if (comboBox1.Text.Equals("Telefono"))
                {
                    ProveedorBindingSource.Filter = "Telefono = " + "'" + textBox1.Text + "'";
                    reportViewer1.RefreshReport();
                }

                if (comboBox1.Text.Equals("Email"))
                {
                    ProveedorBindingSource.Filter = "Email = " + "'" + textBox1.Text + "'";
                    reportViewer1.RefreshReport();
                }
                if (comboBox1.Text.Equals("Provincia"))
                {
                    ProveedorBindingSource.Filter = "Provincia = " + "'" + textBox1.Text + "'";
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
            ProveedorBindingSource.Filter = "";
            reportViewer1.RefreshReport();
        }
    }
}
