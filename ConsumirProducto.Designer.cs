namespace ProyectoRavaSandwich
{
    partial class ConsumirProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsumirProducto));
            this.botonIngresar = new System.Windows.Forms.Button();
            this.aceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cantidad = new System.Windows.Forms.NumericUpDown();
            this.mostrarProductos = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // botonIngresar
            // 
            this.botonIngresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botonIngresar.BackColor = System.Drawing.Color.Lime;
            this.botonIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonIngresar.ForeColor = System.Drawing.Color.Black;
            this.botonIngresar.Location = new System.Drawing.Point(224, 78);
            this.botonIngresar.Name = "botonIngresar";
            this.botonIngresar.Size = new System.Drawing.Size(84, 35);
            this.botonIngresar.TabIndex = 10;
            this.botonIngresar.Text = "Ingresar";
            this.botonIngresar.UseVisualStyleBackColor = false;
            this.botonIngresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // aceptar
            // 
            this.aceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.aceptar.BackColor = System.Drawing.Color.Lime;
            this.aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceptar.Location = new System.Drawing.Point(224, 273);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(84, 38);
            this.aceptar.TabIndex = 9;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = false;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Producto a actualizar";
            // 
            // cantidad
            // 
            this.cantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cantidad.Location = new System.Drawing.Point(266, 52);
            this.cantidad.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(42, 20);
            this.cantidad.TabIndex = 7;
            // 
            // mostrarProductos
            // 
            this.mostrarProductos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mostrarProductos.FormattingEnabled = true;
            this.mostrarProductos.Location = new System.Drawing.Point(12, 52);
            this.mostrarProductos.Name = "mostrarProductos";
            this.mostrarProductos.Size = new System.Drawing.Size(248, 21);
            this.mostrarProductos.TabIndex = 6;
            this.mostrarProductos.SelectedIndexChanged += new System.EventHandler(this.mostrarProductos_SelectedIndexChanged);
            // 
            // ConsumirProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(320, 346);
            this.Controls.Add(this.botonIngresar);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.mostrarProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsumirProducto";
            this.Text = "ConsumirProducto";
            this.Load += new System.EventHandler(this.ConsumirProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonIngresar;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown cantidad;
        private System.Windows.Forms.ComboBox mostrarProductos;
    }
}