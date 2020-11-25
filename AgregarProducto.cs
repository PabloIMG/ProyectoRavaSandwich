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
    public partial class AgregarProducto : Form
    {
        public AgregarProducto()
        {
            InitializeComponent();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AgregarProducto_Load(object sender, EventArgs e)
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
                "SELECT DISTINCT tipo_producto FROM producto ORDER BY tipo_producto ASC";
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

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            if (ingresoNombre.Text != null && mostrarProductos.SelectedItem != null)
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

                comando.CommandText = "INSERT INTO producto(nombre_producto, tipo_producto, stock_inicio_producto, stock_final_producto, ingreso_producto, consumo_producto) VALUES ('" + ingresoNombre.Text + "', '" + mostrarProductos.SelectedItem.ToString() + "', " + cantidad.Value.ToString() + ", " + cantidad.Value.ToString() + ", 0, 0)";

                //Guarda los resultados de la consulta
                NpgsqlDataReader lector = comando.ExecuteReader();

                MessageBox.Show("Se ha agregado el producto " + ingresoNombre.Text + " con exito", "Datos actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                MenuInventarioAdmin menuAdmin = new MenuInventarioAdmin();
                menuAdmin.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("No se puede realizar la operacion", "Casillero producto vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }


        }
    }
}
