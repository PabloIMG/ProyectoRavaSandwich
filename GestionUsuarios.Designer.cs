namespace ProyectoRavaSandwich
{
    partial class GestionUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionUsuarios));
            this.label1 = new System.Windows.Forms.Label();
            this.ListaUsuarios = new System.Windows.Forms.ComboBox();
            this.Rut = new System.Windows.Forms.Label();
            this.boxRut = new System.Windows.Forms.TextBox();
            this.boxNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boxCorreo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.boxTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.boxDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AgregarUsuario = new System.Windows.Forms.Button();
            this.eliminarUsuario = new System.Windows.Forms.Button();
            this.botonAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione personal";
            // 
            // ListaUsuarios
            // 
            this.ListaUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ListaUsuarios.FormattingEnabled = true;
            this.ListaUsuarios.Location = new System.Drawing.Point(140, 6);
            this.ListaUsuarios.Name = "ListaUsuarios";
            this.ListaUsuarios.Size = new System.Drawing.Size(234, 21);
            this.ListaUsuarios.TabIndex = 1;
            this.ListaUsuarios.SelectedIndexChanged += new System.EventHandler(this.ListaUsuarios_SelectedIndexChanged);
            // 
            // Rut
            // 
            this.Rut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Rut.AutoSize = true;
            this.Rut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rut.Location = new System.Drawing.Point(12, 113);
            this.Rut.Name = "Rut";
            this.Rut.Size = new System.Drawing.Size(27, 13);
            this.Rut.TabIndex = 2;
            this.Rut.Text = "Rut";
            // 
            // boxRut
            // 
            this.boxRut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boxRut.Location = new System.Drawing.Point(140, 110);
            this.boxRut.Name = "boxRut";
            this.boxRut.ReadOnly = true;
            this.boxRut.Size = new System.Drawing.Size(234, 20);
            this.boxRut.TabIndex = 3;
            // 
            // boxNombre
            // 
            this.boxNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boxNombre.Location = new System.Drawing.Point(140, 148);
            this.boxNombre.Name = "boxNombre";
            this.boxNombre.ReadOnly = true;
            this.boxNombre.Size = new System.Drawing.Size(234, 20);
            this.boxNombre.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // boxCorreo
            // 
            this.boxCorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boxCorreo.Location = new System.Drawing.Point(140, 223);
            this.boxCorreo.Name = "boxCorreo";
            this.boxCorreo.ReadOnly = true;
            this.boxCorreo.Size = new System.Drawing.Size(234, 20);
            this.boxCorreo.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Correo";
            // 
            // boxTelefono
            // 
            this.boxTelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boxTelefono.Location = new System.Drawing.Point(140, 185);
            this.boxTelefono.Name = "boxTelefono";
            this.boxTelefono.ReadOnly = true;
            this.boxTelefono.Size = new System.Drawing.Size(234, 20);
            this.boxTelefono.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefono";
            // 
            // boxDireccion
            // 
            this.boxDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boxDireccion.Location = new System.Drawing.Point(140, 256);
            this.boxDireccion.Name = "boxDireccion";
            this.boxDireccion.ReadOnly = true;
            this.boxDireccion.Size = new System.Drawing.Size(234, 20);
            this.boxDireccion.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dirección";
            // 
            // AgregarUsuario
            // 
            this.AgregarUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AgregarUsuario.BackColor = System.Drawing.Color.Lime;
            this.AgregarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarUsuario.Location = new System.Drawing.Point(49, 349);
            this.AgregarUsuario.Name = "AgregarUsuario";
            this.AgregarUsuario.Size = new System.Drawing.Size(85, 44);
            this.AgregarUsuario.TabIndex = 12;
            this.AgregarUsuario.Text = "Agregar Usuario";
            this.AgregarUsuario.UseVisualStyleBackColor = false;
            this.AgregarUsuario.Click += new System.EventHandler(this.AgregarUsuario_Click);
            // 
            // eliminarUsuario
            // 
            this.eliminarUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.eliminarUsuario.BackColor = System.Drawing.Color.Lime;
            this.eliminarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarUsuario.Location = new System.Drawing.Point(140, 349);
            this.eliminarUsuario.Name = "eliminarUsuario";
            this.eliminarUsuario.Size = new System.Drawing.Size(118, 44);
            this.eliminarUsuario.TabIndex = 13;
            this.eliminarUsuario.Text = "Eliminar usuario seleccionado";
            this.eliminarUsuario.UseVisualStyleBackColor = false;
            this.eliminarUsuario.Click += new System.EventHandler(this.eliminarUsuario_Click);
            // 
            // botonAtras
            // 
            this.botonAtras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botonAtras.BackColor = System.Drawing.Color.Lime;
            this.botonAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAtras.Location = new System.Drawing.Point(264, 349);
            this.botonAtras.Name = "botonAtras";
            this.botonAtras.Size = new System.Drawing.Size(85, 44);
            this.botonAtras.TabIndex = 14;
            this.botonAtras.Text = "Atras";
            this.botonAtras.UseVisualStyleBackColor = false;
            this.botonAtras.Click += new System.EventHandler(this.botonAtras_Click);
            // 
            // GestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(386, 405);
            this.Controls.Add(this.botonAtras);
            this.Controls.Add(this.eliminarUsuario);
            this.Controls.Add(this.AgregarUsuario);
            this.Controls.Add(this.boxDireccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.boxCorreo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boxTelefono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.boxNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxRut);
            this.Controls.Add(this.Rut);
            this.Controls.Add(this.ListaUsuarios);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GestionUsuarios";
            this.Text = "Gestion Usuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ListaUsuarios;
        private System.Windows.Forms.Label Rut;
        private System.Windows.Forms.TextBox boxRut;
        private System.Windows.Forms.TextBox boxNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boxCorreo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox boxTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox boxDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AgregarUsuario;
        private System.Windows.Forms.Button eliminarUsuario;
        private System.Windows.Forms.Button botonAtras;
    }
}