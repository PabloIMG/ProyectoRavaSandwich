﻿using System;
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
    public partial class MenuInventario : Form
    {
        public MenuInventario()
        {
            InitializeComponent();
            llenarTabla();
        }

        private void tabla_Inventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MenuInventario_Load(object sender, EventArgs e)
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
            MenuPrincipal menu = new MenuPrincipal();

            menu.Show();

            this.Close();
        }

        private void ingreso_Producto_Click(object sender, EventArgs e)
        {
            IngresarProducto ingresar = new IngresarProducto();

            ingresar.Show();
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

            consumir.Show();
        }
    }
}
