using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoRavaSandwich
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void botonInventario_Click(object sender, EventArgs e)
        {
            //Se crea objeto.
            MenuInventario inventario = new MenuInventario();

            //Abrir ventana de menu inventario.
            inventario.Show();

            //Cerrar ventana actual.
            this.Close();
        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            //Mostrar login
            login.Show();

            //Cerrar ventana actual.
            this.Close();
        }
    }
}
