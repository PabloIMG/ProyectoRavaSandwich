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
    public partial class AgregarUsuario : Form
    {
        public AgregarUsuario()
        {
            InitializeComponent();

            ingresarRol.Items.Add("Administrador");
            ingresarRol.Items.Add("Usuario");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            GestionUsuarios gestion = new GestionUsuarios();

            gestion.Show();

            this.Close();
        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            if (ingresarRut.Text != null && ingresarNombre.Text != null && ingresarPass.Text != null && ingresarRol.SelectedItem != null && ingresarTelefono != null && ingresarCorreo != null && ingresarDireccion != null)
            {
                //Conexion a BD.
                NpgsqlConnection conexion = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password = rava;Database = Rava_Sandwich");//Datos de conexion a la BD

                //Abre la BD.
                conexion.Open();

                //Creo objeto comando.
                NpgsqlCommand comando = new NpgsqlCommand();

                //Se crea conexion.
                comando.Connection = conexion;

                comando.CommandType = CommandType.Text;

                comando.CommandText = "INSERT INTO usuario VALUES ('" + ingresarRut.Text + "', '" + ingresarNombre.Text + "', '" + ingresarPass.Text + "', '" + ingresarRol.SelectedItem + "', '" + ingresarTelefono.Text + "', '" + ingresarCorreo.Text + "', '" + ingresarDireccion.Text + "')";

                //Guarda los resultados de la consulta
                NpgsqlDataReader lector = comando.ExecuteReader();

                MessageBox.Show("Se ha agregado el usuario '" + ingresarNombre.Text + "' con exito", "Datos actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                comando.Dispose();
                conexion.Close();

                GestionUsuarios gestion = new GestionUsuarios();
                gestion.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("No se puede realizar la operacion", "Casillero vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
