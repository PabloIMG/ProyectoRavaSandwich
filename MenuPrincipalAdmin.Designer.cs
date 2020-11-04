namespace ProyectoRavaSandwich
{
    partial class MenuPrincipalAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipalAdmin));
            this.botonAgregarUsuario = new System.Windows.Forms.Button();
            this.botonEliminarUsuario = new System.Windows.Forms.Button();
            this.botonAtras = new System.Windows.Forms.Button();
            this.botonInventario = new System.Windows.Forms.Button();
            this.botonVentas = new System.Windows.Forms.Button();
            this.botonCaja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonAgregarUsuario
            // 
            this.botonAgregarUsuario.Location = new System.Drawing.Point(12, 40);
            this.botonAgregarUsuario.Name = "botonAgregarUsuario";
            this.botonAgregarUsuario.Size = new System.Drawing.Size(140, 69);
            this.botonAgregarUsuario.TabIndex = 0;
            this.botonAgregarUsuario.Text = "Agregar Usuario";
            this.botonAgregarUsuario.UseVisualStyleBackColor = true;
            this.botonAgregarUsuario.Click += new System.EventHandler(this.botonAgregarUsuario_Click);
            // 
            // botonEliminarUsuario
            // 
            this.botonEliminarUsuario.Location = new System.Drawing.Point(12, 136);
            this.botonEliminarUsuario.Name = "botonEliminarUsuario";
            this.botonEliminarUsuario.Size = new System.Drawing.Size(140, 69);
            this.botonEliminarUsuario.TabIndex = 1;
            this.botonEliminarUsuario.Text = "Eliminar Usuario";
            this.botonEliminarUsuario.UseVisualStyleBackColor = true;
            // 
            // botonAtras
            // 
            this.botonAtras.Location = new System.Drawing.Point(12, 228);
            this.botonAtras.Name = "botonAtras";
            this.botonAtras.Size = new System.Drawing.Size(140, 69);
            this.botonAtras.TabIndex = 2;
            this.botonAtras.Text = "Cerrar Sesión";
            this.botonAtras.UseVisualStyleBackColor = true;
            this.botonAtras.Click += new System.EventHandler(this.botonAtras_Click);
            // 
            // botonInventario
            // 
            this.botonInventario.Location = new System.Drawing.Point(648, 40);
            this.botonInventario.Name = "botonInventario";
            this.botonInventario.Size = new System.Drawing.Size(140, 69);
            this.botonInventario.TabIndex = 3;
            this.botonInventario.Text = "Inventario";
            this.botonInventario.UseVisualStyleBackColor = true;
            this.botonInventario.Click += new System.EventHandler(this.botonInventario_Click);
            // 
            // botonVentas
            // 
            this.botonVentas.Location = new System.Drawing.Point(648, 136);
            this.botonVentas.Name = "botonVentas";
            this.botonVentas.Size = new System.Drawing.Size(140, 69);
            this.botonVentas.TabIndex = 4;
            this.botonVentas.Text = "Ventas";
            this.botonVentas.UseVisualStyleBackColor = true;
            // 
            // botonCaja
            // 
            this.botonCaja.Location = new System.Drawing.Point(648, 228);
            this.botonCaja.Name = "botonCaja";
            this.botonCaja.Size = new System.Drawing.Size(140, 69);
            this.botonCaja.TabIndex = 5;
            this.botonCaja.Text = "Caja";
            this.botonCaja.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipalAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonCaja);
            this.Controls.Add(this.botonVentas);
            this.Controls.Add(this.botonInventario);
            this.Controls.Add(this.botonAtras);
            this.Controls.Add(this.botonEliminarUsuario);
            this.Controls.Add(this.botonAgregarUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipalAdmin";
            this.Text = "Rava Sandwich";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonAgregarUsuario;
        private System.Windows.Forms.Button botonEliminarUsuario;
        private System.Windows.Forms.Button botonAtras;
        private System.Windows.Forms.Button botonInventario;
        private System.Windows.Forms.Button botonVentas;
        private System.Windows.Forms.Button botonCaja;
    }
}