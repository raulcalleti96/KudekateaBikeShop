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
    public partial class InformeCatalogo : Form
    {
        public InformeCatalogo()
        {
            InitializeComponent();
        }

        private void InformeCatalogo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'BBDDCiclismoDataSet.Bicicletas' Puede moverla o quitarla según sea necesario.
            this.BicicletasTableAdapter.Fill(this.BBDDCiclismoDataSet.Bicicletas);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text.Equals("Id"))
                {
                    BicicletasBindingSource.Filter = "Id = " + "'" + textBox1.Text + "'";
                    reportViewer1.RefreshReport();
                }
                if (comboBox1.Text.Equals("Nombre"))
                {
                    BicicletasBindingSource.Filter = "Nombre = " + "'" + textBox1.Text + "'";
                    reportViewer1.RefreshReport();
                }
                if (comboBox1.Text.Equals("Categoria"))
                {
                    BicicletasBindingSource.Filter = "Categoria = " + "'" + textBox1.Text + "'";
                    reportViewer1.RefreshReport();
                }

                if (comboBox1.Text.Equals("Creador"))
                {
                    BicicletasBindingSource.Filter = "Fabricante = " + "'" + textBox1.Text + "'";
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
            BicicletasBindingSource.Filter = "";
            reportViewer1.RefreshReport();
        }
    }
}
