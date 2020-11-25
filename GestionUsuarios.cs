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
    public partial class GestionUsuarios : Form
    {
        public GestionUsuarios()
        {
            InitializeComponent();

            //Datos de conexión a BD
            NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; Port = 5432; User Id = postgres; Password = rava; Database = Rava_Sandwich");
            //Abrir BD
            conn.Open();
            //Crear objeto de comandos
            NpgsqlCommand comm = new NpgsqlCommand();
            //Crear objeto conexión
            comm.Connection = conn;
            //No se que hace xd
            comm.CommandType = CommandType.Text;
            //Consulta
            comm.CommandText =
                "SELECT nombre FROM usuario ORDER BY nombre ASC";
            //Leer BD
            NpgsqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())//Si la tabla tiene 1 o más filas...
            {
                ListaUsuarios.Items.Add(dr.GetString(0));
            }
            //Cerrar comandos
            comm.Dispose();
            //Desconectar BD
            conn.Close();
        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            MenuPrincipalAdmin menu = new MenuPrincipalAdmin();

            menu.Show();

            this.Close();
        }

        private void ListaUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Datos de conexión a BD
            NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; Port = 5432; User Id = postgres; Password = rava; Database = Rava_Sandwich");
            //Abrir BD
            conn.Open();
            //Crear objeto de comandos
            NpgsqlCommand comm = new NpgsqlCommand();
            //Crear objeto conexión
            comm.Connection = conn;
            //No se que hace xd
            comm.CommandType = CommandType.Text;
            //Consulta
            comm.CommandText =
                "SELECT PK_Rut, nombre, telefono, correo, direccion FROM usuario WHERE nombre = '" + ListaUsuarios.SelectedItem.ToString() + "'";
            //Leer BD
            NpgsqlDataReader dr = comm.ExecuteReader();
            dr.Read();//Si la tabla tiene 1 o más filas...

                //Mostrar datos en los label.
            boxRut.Text = dr.GetString(0);
            boxNombre.Text = dr.GetString(1);
            boxTelefono.Text = dr.GetString(2);
            boxCorreo.Text = dr.GetString(3);
            boxDireccion.Text = dr.GetString(4);

            //Cerrar comandos
            comm.Dispose();
            //Desconectar BD
            conn.Close();
        }

        private void eliminarUsuario_Click(object sender, EventArgs e)
        {
            if ((ListaUsuarios.SelectedItem != null))
            {
                // Conexion a BD
                NpgsqlConnection conexion = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password = rava;Database = Rava_Sandwich");

                // Abrir la BD
                conexion.Open();

                // Se crea objeto de comando
                NpgsqlCommand comando = new NpgsqlCommand();

                // Se crea objeto de conexion
                comando.Connection = conexion;

                comando.CommandType = CommandType.Text;

                // Actualizar el producto
                comando.CommandText = "DELETE FROM usuario WHERE nombre = '" + ListaUsuarios.SelectedItem.ToString() + "'";

                DialogResult confirmacion = MessageBox.Show("¿Desea eliminar '" + ListaUsuarios.SelectedItem.ToString() + "'?", "Eliminar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                if (confirmacion == DialogResult.Yes)
                {
                    //Se ejecuta DELETE.
                    NpgsqlDataReader lector = comando.ExecuteReader();

                    //Se cierran los comandos.
                    comando.Dispose();

                    //Se cierra la BD.
                    conexion.Close();

                    MessageBox.Show("El usuario '" + ListaUsuarios.SelectedItem.ToString() + "' se ha eliminado con exito", "Eliminar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                    GestionUsuarios gestion = new GestionUsuarios();
                    gestion.Show();
                    this.Close();
                }
                else
                {
                    //Se cierran los comandos.
                    comando.Dispose();

                    //Se cierra la BD.
                    conexion.Close();

                    MessageBox.Show("Operacion cancelada", "Eliminar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }

            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario ", "Casillero usuario vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void AgregarUsuario_Click(object sender, EventArgs e)
        {
            AgregarUsuario agregar = new AgregarUsuario();

            agregar.Show();

            this.Close();
        }
    }
}
