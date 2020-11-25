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
    public partial class ConsumirProducto : Form
    {
        public ConsumirProducto()
        {
            InitializeComponent();
        }

        private void ConsumirProducto_Load(object sender, EventArgs e)
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

        private void aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((mostrarProductos.SelectedItem != null))
            {
                if (verificar())
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
                    comando.CommandText = "UPDATE producto SET consumo_producto = consumo_producto + " + cantidad.Value.ToString() + ", stock_final_producto = stock_final_producto - " + cantidad.Value.ToString() + " WHERE nombre_producto = '" + mostrarProductos.SelectedItem.ToString() + "'";

                    NpgsqlDataReader lector = comando.ExecuteReader();

                    MessageBox.Show("Se ha consumido " + cantidad.Value.ToString() + " al producto " + mostrarProductos.SelectedItem.ToString(), "Datos actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    MessageBox.Show("La cantidad a consumir es mayor al stock disponible", "Error en la operacion", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto ", "Casillero producto vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }

        }

        private bool verificar()
        {
            int stockNormal, stock; //stockNormal = Cantidad a consumir. stock = Cantidad disponible.

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
                "SELECT stock_final_producto FROM producto WHERE nombre_producto = '" + mostrarProductos.SelectedItem.ToString() + "'";

            //Leer BD
            NpgsqlDataReader dr = comm.ExecuteReader();

            dr.Read();//Si la tabla tiene 1 o más filas...

            stock = dr.GetInt16(0);

            //Cerrar comandos
            comm.Dispose();
            //Desconectar BD
            conn.Close();

            stockNormal = Int16.Parse(cantidad.Value.ToString());

            return stock >= stockNormal;
        }

        private void mostrarProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
