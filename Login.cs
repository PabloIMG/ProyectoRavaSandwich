using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace ProyectoRavaSandwich
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void boton_Ingresar_Click(object sender, EventArgs e)
        {
            bool blnfound = false;//Booleano que indica la existencia de datos, por default es falso

            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password = rava;Database = Rava_Sandwich");//Datos de conexion a la BD
            conn.Open();// Abre la BD

            //Realiza la consulta si los datos ingresados por el textbox son iguales a las que están en la BD
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM Usuario WHERE PK_Rut ='" + IngresoRUT.Text + "' and pass = '" + IngresoPass.Text + "' and rol = 'Administrador'", conn);
            NpgsqlDataReader dr = cmd.ExecuteReader();//Guarda los resultados de la consulta

            if (dr.Read())//Si hay datos
            {
                blnfound = true;//la existencia de datos es verdadera
                MenuPrincipalAdmin f5 = new MenuPrincipalAdmin(); //Crea un objeto del menú
                f5.Show();// invoca la ventana del menú
                this.Hide();//Oculta la ventana del login
            }

            if (blnfound == false)//si no se encuentra
            {
                //muestra un lindo mensajito
                //MessageBox.Show("Usuario o contraseña incorrectos", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                dr.Close(); // Cierra el registro de la consulta
                conn.Close();// Cierra la consulta
            }

            /*                  Verificar.                  */
            bool blnfoundRol = false;//Booleano que indica la existencia de datos, por default es falso

            NpgsqlConnection conn1 = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password = rava;Database = Rava_Sandwich");//Datos de conexion a la BD
            conn1.Open();// Abre la BD

            //Realiza la consulta si los datos ingresados por el textbox son iguales a las que están en la BD
            NpgsqlCommand cmd1 = new NpgsqlCommand("SELECT * FROM Usuario WHERE PK_Rut ='" + IngresoRUT.Text + "' and pass = '" + IngresoPass.Text + "' and rol = 'Usuario'", conn1);
            NpgsqlDataReader dr1 = cmd1.ExecuteReader();//Guarda los resultados de la consulta

            if (dr1.Read())//Si hay datos
            {
                blnfoundRol = true;//la existencia de datos es verdadera
                MenuPrincipal menu = new MenuPrincipal(); //Crea un objeto del menú
                menu.Show();// invoca la ventana del menú
                this.Hide();//Oculta la ventana del login
            }

            if (blnfoundRol == false && blnfound == false)//si no se encuentra
            {
                //muestra un lindo mensajito
                MessageBox.Show("Usuario o contraseña incorrectos", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                dr1.Close(); // Cierra el registro de la consulta
                conn1.Close();// Cierra la consulta
            }
        }
    }
}
