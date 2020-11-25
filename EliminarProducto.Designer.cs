namespace ProyectoRavaSandwich
{
    partial class EliminarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarProducto));
            this.mostrarProductos = new System.Windows.Forms.ComboBox();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.aceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mostrarProductos
            // 
            this.mostrarProductos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mostrarProductos.FormattingEnabled = true;
            this.mostrarProductos.Location = new System.Drawing.Point(33, 49);
            this.mostrarProductos.Name = "mostrarProductos";
            this.mostrarProductos.Size = new System.Drawing.Size(248, 21);
            this.mostrarProductos.TabIndex = 1;
            // 
            // botonEliminar
            // 
            this.botonEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botonEliminar.BackColor = System.Drawing.Color.Lime;
            this.botonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonEliminar.ForeColor = System.Drawing.Color.Black;
            this.botonEliminar.Location = new System.Drawing.Point(118, 76);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(84, 35);
            this.botonEliminar.TabIndex = 7;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = false;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // aceptar
            // 
            this.aceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.aceptar.BackColor = System.Drawing.Color.Lime;
            this.aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceptar.Location = new System.Drawing.Point(118, 300);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(84, 38);
            this.aceptar.TabIndex = 8;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = false;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // EliminarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(323, 350);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.mostrarProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EliminarProducto";
            this.Text = "EliminarProducto";
            this.Load += new System.EventHandler(this.EliminarProducto_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox mostrarProductos;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Button aceptar;
    }
}