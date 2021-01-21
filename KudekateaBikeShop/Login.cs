using KudekateaBikeShop;
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


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
            BBDDCiclismoDataSet.EmpleadosRow fila;//creamos una variable de tipo fila

            if (empleadosBindingSource.Find("Usuario", usuarioTextBox.Text) != -1)//comprobamos que es distinto de no es correcto
            {
                //hacemos que busque al usuario
                fila = (BBDDCiclismoDataSet.EmpleadosRow)bBDDCiclismoDataSet.Empleados.Rows[empleadosBindingSource.Find("Usuario", usuarioTextBox.Text)];

                if (fila.Password == passwordTextBox.Text)//comprbamos que la clave es correcta
                {
                    KudekateaBikeShop.Properties.Settings.Default.Rol = fila.Rol;//guardamos el rol en la variable global
                    KudekateaBikeShop.Properties.Settings.Default.Usuario = fila.Usuario;

                    //MessageBox.Show(fila.Password, "Error");
                    //MessageBox.Show(passwordTextBox.Text, "Error");

                    //escondemos esta ventana y vaciamos los txt
                    f.Hide();
                    usuarioTextBox.Text = "";
                    passwordTextBox.Text = "";

                    //abrimos la ventana
                  //  Menu p = new Menu();
                  //  p.ShowDialog();


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

        private void empleadosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.empleadosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bBDDCiclismoDataSet);

        }

        private void Login_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bBDDCiclismoDataSet.Empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this.bBDDCiclismoDataSet.Empleados);


            CenterToScreen();

            usuarioTextBox.Text = "";
            passwordTextBox.Text = "";

            f = this;

        }
    }
}
