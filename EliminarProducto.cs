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
    public partial class EliminarProducto : Form
    {
        public EliminarProducto()
        {
            InitializeComponent();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EliminarProducto_Load(object sender, EventArgs e)
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
                "SELECT nombre_producto FROM producto ORDER BY nombre_producto ASC";
            //Leer BD
            NpgsqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())//Si la tabla tiene 1 o más filas...
            {
                mostrarProductos.Items.Add(dr.GetString(0));
            }
            //Cerrar comandos
            comm.Dispose();
            //Desconectar BD
            conn.Close();
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            if ((mostrarProductos.SelectedItem != null))
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
                comando.CommandText = "DELETE FROM producto WHERE nombre_producto = '" + mostrarProductos.SelectedItem.ToString() + "'";

                DialogResult confirmacion = MessageBox.Show("¿Desea eliminar '" + mostrarProductos.SelectedItem.ToString() + "'?", "Eliminar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                
                if(confirmacion == DialogResult.Yes)
                {
                    //Se ejecuta DELETE.
                    NpgsqlDataReader lector = comando.ExecuteReader();

                    //Se cierran los comandos.
                    comando.Dispose();

                    //Se cierra la BD.
                    conexion.Close();

                    MessageBox.Show("El producto '" + mostrarProductos.SelectedItem.ToString() + "' se ha eliminado con exito", "Eliminar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    //Se cierran los comandos.
                    comando.Dispose();

                    //Se cierra la BD.
                    conexion.Close();

                    MessageBox.Show("Operacion cancelada", "Eliminar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto ", "Casillero producto vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
