using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Login : Form
    {

        public static Login f;

        public Login()
        {
            InitializeComponent();
        }

        private void empleadosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.empleadosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bBDDVideojuegosDataSet);

        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bBDDVideojuegosDataSet.Empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this.bBDDVideojuegosDataSet.Empleados);

            CenterToScreen();

            usuarioTextBox.Text = "";
            passwordTextBox.Text = "";

            f = this;

        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            BBDDVideojuegosDataSet.EmpleadosRow fila;//creamos una variable de tipo fila

            if (empleadosBindingSource.Find("Usuario", usuarioTextBox.Text) != -1)//comprobamos que es distinto de no es correcto
            {
                //hacemos que busque al usuario
                fila = (BBDDVideojuegosDataSet.EmpleadosRow)bBDDVideojuegosDataSet.Empleados.Rows[empleadosBindingSource.Find("Usuario", usuarioTextBox.Text)];

                if (fila.Password == passwordTextBox.Text)//comprbamos que la clave es correcta
                {
                    Properties.Settings.Default.Rol = fila.Rol;//guardamos el rol en la variable global
                    Properties.Settings.Default.Usuario = fila.Usuario;

                    //MessageBox.Show(fila.Password, "Error");
                    //MessageBox.Show(passwordTextBox.Text, "Error");

                    //escondemos esta ventana y vaciamos los txt
                    f.Hide();
                    usuarioTextBox.Text = "";
                    passwordTextBox.Text = "";

                    //abrimos la ventana
                    Menu p = new Menu();
                    p.ShowDialog();


                }
                else
                {
                    MessageBox.Show("La contraseña es incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (usuarioTextBox.Text.Equals("") | passwordTextBox.Text.Equals(""))
            {
                MessageBox.Show("No puede haber campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("El usuario es incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            Boolean abierta = false;

            foreach (Form fm in Application.OpenForms)
            {
                if (fm.GetType() == typeof(Informacion))
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
                Informacion v2 = new Informacion();
                v2.Show();
            }
        }
    }
}
