namespace ProyectoRavaSandwich
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.botonCaja = new System.Windows.Forms.Button();
            this.botonVentas = new System.Windows.Forms.Button();
            this.botonInventario = new System.Windows.Forms.Button();
            this.botonAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonCaja
            // 
            this.botonCaja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botonCaja.BackColor = System.Drawing.Color.Lime;
            this.botonCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCaja.Location = new System.Drawing.Point(304, 12);
            this.botonCaja.Name = "botonCaja";
            this.botonCaja.Size = new System.Drawing.Size(140, 69);
            this.botonCaja.TabIndex = 8;
            this.botonCaja.Text = "Caja";
            this.botonCaja.UseVisualStyleBackColor = false;
            // 
            // botonVentas
            // 
            this.botonVentas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botonVentas.BackColor = System.Drawing.Color.Lime;
            this.botonVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonVentas.Location = new System.Drawing.Point(158, 12);
            this.botonVentas.Name = "botonVentas";
            this.botonVentas.Size = new System.Drawing.Size(140, 69);
            this.botonVentas.TabIndex = 7;
            this.botonVentas.Text = "Ventas";
            this.botonVentas.UseVisualStyleBackColor = false;
            // 
            // botonInventario
            // 
            this.botonInventario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botonInventario.BackColor = System.Drawing.Color.Lime;
            this.botonInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonInventario.Location = new System.Drawing.Point(12, 12);
            this.botonInventario.Name = "botonInventario";
            this.botonInventario.Size = new System.Drawing.Size(140, 69);
            this.botonInventario.TabIndex = 6;
            this.botonInventario.Text = "Inventario";
            this.botonInventario.UseVisualStyleBackColor = false;
            this.botonInventario.Click += new System.EventHandler(this.botonInventario_Click);
            // 
            // botonAtras
            // 
            this.botonAtras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botonAtras.BackColor = System.Drawing.Color.Lime;
            this.botonAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAtras.Location = new System.Drawing.Point(158, 87);
            this.botonAtras.Name = "botonAtras";
            this.botonAtras.Size = new System.Drawing.Size(140, 69);
            this.botonAtras.TabIndex = 9;
            this.botonAtras.Text = "Cerrar Sesión";
            this.botonAtras.UseVisualStyleBackColor = false;
            this.botonAtras.Click += new System.EventHandler(this.botonAtras_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(458, 174);
            this.Controls.Add(this.botonAtras);
            this.Controls.Add(this.botonCaja);
            this.Controls.Add(this.botonVentas);
            this.Controls.Add(this.botonInventario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonCaja;
        private System.Windows.Forms.Button botonVentas;
        private System.Windows.Forms.Button botonInventario;
        private System.Windows.Forms.Button botonAtras;
    }
}