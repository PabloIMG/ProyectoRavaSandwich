namespace ProyectoRavaSandwich
{
    partial class MenuInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuInventario));
            this.tabla_Inventario = new System.Windows.Forms.DataGridView();
            this.ingreso_Producto = new System.Windows.Forms.Button();
            this.consumo_Producto = new System.Windows.Forms.Button();
            this.botonAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_Inventario)).BeginInit();
            this.SuspendLayout();
            // 
            // tabla_Inventario
            // 
            this.tabla_Inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_Inventario.Location = new System.Drawing.Point(12, 91);
            this.tabla_Inventario.Name = "tabla_Inventario";
            this.tabla_Inventario.Size = new System.Drawing.Size(591, 257);
            this.tabla_Inventario.TabIndex = 0;
            this.tabla_Inventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ingreso_Producto
            // 
            this.ingreso_Producto.Location = new System.Drawing.Point(631, 91);
            this.ingreso_Producto.Name = "ingreso_Producto";
            this.ingreso_Producto.Size = new System.Drawing.Size(157, 42);
            this.ingreso_Producto.TabIndex = 1;
            this.ingreso_Producto.Text = "Ingreso Producto";
            this.ingreso_Producto.UseVisualStyleBackColor = true;
            // 
            // consumo_Producto
            // 
            this.consumo_Producto.Location = new System.Drawing.Point(631, 139);
            this.consumo_Producto.Name = "consumo_Producto";
            this.consumo_Producto.Size = new System.Drawing.Size(157, 42);
            this.consumo_Producto.TabIndex = 2;
            this.consumo_Producto.Text = "Consumo Producto";
            this.consumo_Producto.UseVisualStyleBackColor = true;
            // 
            // botonAtras
            // 
            this.botonAtras.Location = new System.Drawing.Point(631, 187);
            this.botonAtras.Name = "botonAtras";
            this.botonAtras.Size = new System.Drawing.Size(157, 42);
            this.botonAtras.TabIndex = 3;
            this.botonAtras.Text = "Cerrar Sesión";
            this.botonAtras.UseVisualStyleBackColor = true;
            this.botonAtras.Click += new System.EventHandler(this.botonAtras_Click);
            // 
            // MenuInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonAtras);
            this.Controls.Add(this.consumo_Producto);
            this.Controls.Add(this.ingreso_Producto);
            this.Controls.Add(this.tabla_Inventario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuInventario";
            this.Text = "MenuInventario";
            ((System.ComponentModel.ISupportInitialize)(this.tabla_Inventario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tabla_Inventario;
        private System.Windows.Forms.Button ingreso_Producto;
        private System.Windows.Forms.Button consumo_Producto;
        private System.Windows.Forms.Button botonAtras;
    }
}