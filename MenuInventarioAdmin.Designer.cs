namespace ProyectoRavaSandwich
{
    partial class MenuInventarioAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuInventarioAdmin));
            this.irMenu = new System.Windows.Forms.Button();
            this.tabla_Inventario = new System.Windows.Forms.DataGridView();
            this.botonAtras = new System.Windows.Forms.Button();
            this.consumo_Producto = new System.Windows.Forms.Button();
            this.ingreso_Producto = new System.Windows.Forms.Button();
            this.eliminar_Ingrediente = new System.Windows.Forms.Button();
            this.agregar_Ingrediente = new System.Windows.Forms.Button();
            this.actualizarTabla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_Inventario)).BeginInit();
            this.SuspendLayout();
            // 
            // irMenu
            // 
            this.irMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.irMenu.BackColor = System.Drawing.Color.Lime;
            this.irMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.irMenu.Location = new System.Drawing.Point(631, 293);
            this.irMenu.Name = "irMenu";
            this.irMenu.Size = new System.Drawing.Size(157, 42);
            this.irMenu.TabIndex = 11;
            this.irMenu.Text = "Volver al menú";
            this.irMenu.UseVisualStyleBackColor = false;
            this.irMenu.Click += new System.EventHandler(this.irMenu_Click);
            // 
            // tabla_Inventario
            // 
            this.tabla_Inventario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabla_Inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_Inventario.Location = new System.Drawing.Point(12, 101);
            this.tabla_Inventario.Name = "tabla_Inventario";
            this.tabla_Inventario.Size = new System.Drawing.Size(591, 282);
            this.tabla_Inventario.TabIndex = 12;
            this.tabla_Inventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_Inventario_CellContentClick);
            // 
            // botonAtras
            // 
            this.botonAtras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botonAtras.BackColor = System.Drawing.Color.Lime;
            this.botonAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAtras.Location = new System.Drawing.Point(631, 341);
            this.botonAtras.Name = "botonAtras";
            this.botonAtras.Size = new System.Drawing.Size(157, 42);
            this.botonAtras.TabIndex = 15;
            this.botonAtras.Text = "Cerrar Sesión";
            this.botonAtras.UseVisualStyleBackColor = false;
            this.botonAtras.Click += new System.EventHandler(this.botonAtras_Click);
            // 
            // consumo_Producto
            // 
            this.consumo_Producto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.consumo_Producto.BackColor = System.Drawing.Color.Lime;
            this.consumo_Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consumo_Producto.Location = new System.Drawing.Point(631, 149);
            this.consumo_Producto.Name = "consumo_Producto";
            this.consumo_Producto.Size = new System.Drawing.Size(157, 42);
            this.consumo_Producto.TabIndex = 14;
            this.consumo_Producto.Text = "Consumo Producto";
            this.consumo_Producto.UseVisualStyleBackColor = false;
            this.consumo_Producto.Click += new System.EventHandler(this.consumo_Producto_Click);
            // 
            // ingreso_Producto
            // 
            this.ingreso_Producto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ingreso_Producto.BackColor = System.Drawing.Color.Lime;
            this.ingreso_Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingreso_Producto.Location = new System.Drawing.Point(631, 101);
            this.ingreso_Producto.Name = "ingreso_Producto";
            this.ingreso_Producto.Size = new System.Drawing.Size(157, 42);
            this.ingreso_Producto.TabIndex = 13;
            this.ingreso_Producto.Text = "Ingreso Producto";
            this.ingreso_Producto.UseVisualStyleBackColor = false;
            this.ingreso_Producto.Click += new System.EventHandler(this.ingreso_Producto_Click);
            // 
            // eliminar_Ingrediente
            // 
            this.eliminar_Ingrediente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.eliminar_Ingrediente.BackColor = System.Drawing.Color.Lime;
            this.eliminar_Ingrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminar_Ingrediente.Location = new System.Drawing.Point(631, 245);
            this.eliminar_Ingrediente.Name = "eliminar_Ingrediente";
            this.eliminar_Ingrediente.Size = new System.Drawing.Size(157, 42);
            this.eliminar_Ingrediente.TabIndex = 17;
            this.eliminar_Ingrediente.Text = "Eliminar Ingrediente";
            this.eliminar_Ingrediente.UseVisualStyleBackColor = false;
            this.eliminar_Ingrediente.Click += new System.EventHandler(this.eliminar_Ingrediente_Click);
            // 
            // agregar_Ingrediente
            // 
            this.agregar_Ingrediente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.agregar_Ingrediente.BackColor = System.Drawing.Color.Lime;
            this.agregar_Ingrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar_Ingrediente.Location = new System.Drawing.Point(631, 197);
            this.agregar_Ingrediente.Name = "agregar_Ingrediente";
            this.agregar_Ingrediente.Size = new System.Drawing.Size(157, 42);
            this.agregar_Ingrediente.TabIndex = 16;
            this.agregar_Ingrediente.Text = "Agregar Ingrediente";
            this.agregar_Ingrediente.UseVisualStyleBackColor = false;
            this.agregar_Ingrediente.Click += new System.EventHandler(this.agregar_Ingrediente_Click);
            // 
            // actualizarTabla
            // 
            this.actualizarTabla.BackColor = System.Drawing.Color.Lime;
            this.actualizarTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualizarTabla.Location = new System.Drawing.Point(12, 65);
            this.actualizarTabla.Name = "actualizarTabla";
            this.actualizarTabla.Size = new System.Drawing.Size(97, 30);
            this.actualizarTabla.TabIndex = 18;
            this.actualizarTabla.Text = "Actualizar";
            this.actualizarTabla.UseVisualStyleBackColor = false;
            this.actualizarTabla.Click += new System.EventHandler(this.actualizarTabla_Click);
            // 
            // MenuInventarioAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.actualizarTabla);
            this.Controls.Add(this.eliminar_Ingrediente);
            this.Controls.Add(this.agregar_Ingrediente);
            this.Controls.Add(this.botonAtras);
            this.Controls.Add(this.consumo_Producto);
            this.Controls.Add(this.ingreso_Producto);
            this.Controls.Add(this.tabla_Inventario);
            this.Controls.Add(this.irMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuInventarioAdmin";
            this.Text = "MenuInventarioAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.tabla_Inventario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button irMenu;
        private System.Windows.Forms.DataGridView tabla_Inventario;
        private System.Windows.Forms.Button botonAtras;
        private System.Windows.Forms.Button consumo_Producto;
        private System.Windows.Forms.Button ingreso_Producto;
        private System.Windows.Forms.Button eliminar_Ingrediente;
        private System.Windows.Forms.Button agregar_Ingrediente;
        private System.Windows.Forms.Button actualizarTabla;
    }
}