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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            label7.Text = "Bienvenido/a " + Properties.Settings.Default.Usuario;

            if (Properties.Settings.Default.Rol == "Administrador")
            {
                //habilitar y deshabilitar controles

            }
            if (Properties.Settings.Default.Rol == "Usuario")
            {
                //habilitar y deshabilitar controles
                btnEmpleados.Visible = false;
                btnCompras.Visible = false;
                btnProveedor.Visible = false;

                label4.Visible = false;
                label2.Visible = false;
                label6.Visible = false;

                comprasToolStripMenuItem.Visible = false;
                empleadosToolStripMenuItem.Visible = false;
                proveedoresToolStripMenuItem.Visible = false;

            }

        public static implicit operator System.Windows.Forms.Menu(Menu v)
        {
            throw new NotImplementedException();
        }
    }
}
