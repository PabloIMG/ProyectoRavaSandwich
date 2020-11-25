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

/* Apuntes rancios 
 
    Botones.
        Ingreso Producto: Agregar stock.
        Consumo Producto: Quitar stock.
        Agregar Ingrediente: Agregar un nuevo producto a la BD.
        Eliminar Ingrediente: Eliminar producto de la BD.
*/

namespace ProyectoRavaSandwich
{
    public partial class MenuInventarioAdmin : Form
    {
        public MenuInventarioAdmin()
        {
            InitializeComponent();
            llenarTabla();
        }

        private void tabla_Inventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            //Mostrar login
            login.Show();

            //Cerrar ventana actual.
            this.Close();
        }

        private void irMenu_Click(object sender, EventArgs e)
        {
            MenuPrincipalAdmin menu = new MenuPrincipalAdmin();

            menu.Show();

            this.Close();
        }

        private void ingreso_Producto_Click(object sender, EventArgs e)
        {
            IngresarProducto ingresar = new IngresarProducto();

            if (Application.OpenForms[ingresar.Name] == null)
            {
                ingresar.Show();
            }
            else
            {
                Application.OpenForms[ingresar.Name].Activate();
            }

        }

        private void llenarTabla()
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
            comm.CommandText = "SELECT * FROM vista_inventario ORDER BY \"Nombre\" ASC";
            //Leer BD
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)//Si la tabla tiene 1 o más filas...
            {
                //Crear objeto referente a la tabla
                DataTable dt = new DataTable();
                //Cargar Tabla
                dt.Load(dr);
                //Mostrar tabla
                tabla_Inventario.DataSource = dt;
            }
            //Cerrar comandos
            comm.Dispose();
            //Desconectar BD
            conn.Close();
        }

        private void actualizarTabla_Click(object sender, EventArgs e)
        {
            llenarTabla();
        }

        private void consumo_Producto_Click(object sender, EventArgs e)
        {
            ConsumirProducto consumir = new ConsumirProducto();
            
            if (Application.OpenForms[consumir.Name] == null)
            {
                consumir.Show();
            }
            else
            {
                Application.OpenForms[consumir.Name].Activate();
            }
        }

        private void agregar_Ingrediente_Click(object sender, EventArgs e)
        {
            AgregarProducto agregar = new AgregarProducto();

            if (Application.OpenForms[agregar.Name] == null)
            {
                agregar.Show();
            }
            else
            {
                Application.OpenForms[agregar.Name].Activate();
            }
        }

        private void eliminar_Ingrediente_Click(object sender, EventArgs e)
        {
            EliminarProducto eliminar = new EliminarProducto();

            if (Application.OpenForms[eliminar.Name] == null)
            {
                eliminar.Show();
            }
            else
            {
                Application.OpenForms[eliminar.Name].Activate();
            }

        }
    }
}
