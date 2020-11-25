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
            this.botonGestion = new System.Windows.Forms.Button();
            this.botonAtras = new System.Windows.Forms.Button();
            this.botonInventario = new System.Windows.Forms.Button();
            this.botonVentas = new System.Windows.Forms.Button();
            this.botonCaja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonGestion
            // 
            this.botonGestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botonGestion.BackColor = System.Drawing.Color.Lime;
            this.botonGestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonGestion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.botonGestion.Location = new System.Drawing.Point(12, 12);
            this.botonGestion.Name = "botonGestion";
            this.botonGestion.Size = new System.Drawing.Size(140, 69);
            this.botonGestion.TabIndex = 0;
            this.botonGestion.Text = "Gestionar Personal";
            this.botonGestion.UseVisualStyleBackColor = false;
            this.botonGestion.Click += new System.EventHandler(this.botonAgregarUsuario_Click);
            // 
            // botonAtras
            // 
            this.botonAtras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botonAtras.BackColor = System.Drawing.Color.Lime;
            this.botonAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAtras.Location = new System.Drawing.Point(83, 162);
            this.botonAtras.Name = "botonAtras";
            this.botonAtras.Size = new System.Drawing.Size(140, 69);
            this.botonAtras.TabIndex = 2;
            this.botonAtras.Text = "Cerrar Sesión";
            this.botonAtras.UseVisualStyleBackColor = false;
            this.botonAtras.Click += new System.EventHandler(this.botonAtras_Click);
            // 
            // botonInventario
            // 
            this.botonInventario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botonInventario.BackColor = System.Drawing.Color.Lime;
            this.botonInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonInventario.Location = new System.Drawing.Point(158, 87);
            this.botonInventario.Name = "botonInventario";
            this.botonInventario.Size = new System.Drawing.Size(140, 69);
            this.botonInventario.TabIndex = 3;
            this.botonInventario.Text = "Inventario";
            this.botonInventario.UseVisualStyleBackColor = false;
            this.botonInventario.Click += new System.EventHandler(this.botonInventario_Click);
            // 
            // botonVentas
            // 
            this.botonVentas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botonVentas.BackColor = System.Drawing.Color.Lime;
            this.botonVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonVentas.Location = new System.Drawing.Point(158, 12);
            this.botonVentas.Name = "botonVentas";
            this.botonVentas.Size = new System.Drawing.Size(140, 69);
            this.botonVentas.TabIndex = 4;
            this.botonVentas.Text = "Ventas";
            this.botonVentas.UseVisualStyleBackColor = false;
            // 
            // botonCaja
            // 
            this.botonCaja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botonCaja.BackColor = System.Drawing.Color.Lime;
            this.botonCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCaja.Location = new System.Drawing.Point(12, 87);
            this.botonCaja.Name = "botonCaja";
            this.botonCaja.Size = new System.Drawing.Size(140, 69);
            this.botonCaja.TabIndex = 5;
            this.botonCaja.Text = "Caja";
            this.botonCaja.UseVisualStyleBackColor = false;
            // 
            // MenuPrincipalAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(312, 263);
            this.Controls.Add(this.botonCaja);
            this.Controls.Add(this.botonVentas);
            this.Controls.Add(this.botonInventario);
            this.Controls.Add(this.botonAtras);
            this.Controls.Add(this.botonGestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipalAdmin";
            this.Text = "Rava Sandwich";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonGestion;
        private System.Windows.Forms.Button botonAtras;
        private System.Windows.Forms.Button botonInventario;
        private System.Windows.Forms.Button botonVentas;
        private System.Windows.Forms.Button botonCaja;
    }
}