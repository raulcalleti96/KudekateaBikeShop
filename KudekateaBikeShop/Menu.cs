using ProyectoFinal;
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
            label1.Text = "Bienvenido/a " + Properties.Settings.Default.Usuario;

            if (Properties.Settings.Default.Rol == "Administrador")
            {
                //habilitar y deshabilitar controles

            }
            if (Properties.Settings.Default.Rol == "Usuario")
            {
                //habilitar y deshabilitar controles
                empleadosbtn.Visible = false;
                comprabtn.Visible = false;
                proovedoresbtn.Visible = false;

                label4.Visible = false;
                label2.Visible = false;
                label6.Visible = false;

                //  comprasToolStripMenuItem.Visible = false;
                //  empleadosToolStripMenuItem.Visible = false;
                //  proveedoresToolStripMenuItem.Visible = false;

            } 
        }

        public static implicit operator System.Windows.Forms.Menu(Menu v)
        {
            throw new NotImplementedException();
        }

        private void ventabtn_Click(object sender, EventArgs e)
        {
            Boolean abierta = false;

            foreach (Form fm in Application.OpenForms)
            {
                if (fm.GetType() == typeof(Ventas))
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
                Ventas v2 = new Ventas();
                v2.Show();
            }
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login.ventanaLogin.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comprabtn_Click(object sender, EventArgs e)
        {
            Boolean abierta = false;

            foreach (Form fm in Application.OpenForms)
            {
                if (fm.GetType() == typeof(Compras))
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
                Compras v2 = new Compras();
                v2.Show();
            }
        }

        private void catalogobtn_Click(object sender, EventArgs e)
        {
            Boolean abierta = false;

            foreach (Form fm in Application.OpenForms)
            {
                if (fm.GetType() == typeof(Catalogo))
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
                Catalogo v2 = new Catalogo();
                v2.Show();
            }
        }

        private void empleadosbtn_Click(object sender, EventArgs e)
        {
            Boolean abierta = false;

            foreach (Form fm in Application.OpenForms)
            {
                if (fm.GetType() == typeof(Empleados))
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
                Empleados v2 = new Empleados();
                v2.Show();
            }
        }

        private void proovedoresbtn_Click(object sender, EventArgs e)
        {
            Boolean abierta = false;

            foreach (Form fm in Application.OpenForms)
            {
                if (fm.GetType() == typeof(Proveedores))
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
                Proveedores v2 = new Proveedores();
                v2.Show();
            }
        }

        private void clientesbtn_Click(object sender, EventArgs e)
        {
            Boolean abierta = false;

            foreach (Form fm in Application.OpenForms)
            {
                if (fm.GetType() == typeof(Clientes))
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
                Clientes v2 = new Clientes();
                v2.Show();
            }
        }
    }
}
