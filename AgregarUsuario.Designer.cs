namespace ProyectoRavaSandwich
{
    partial class AgregarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarUsuario));
            this.ingresarNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ingresarPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ingresarRut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ingresarTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ingresarCorreo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ingresarDireccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ingresarRol = new System.Windows.Forms.ComboBox();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ingresarNombre
            // 
            this.ingresarNombre.AcceptsTab = true;
            this.ingresarNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ingresarNombre.Location = new System.Drawing.Point(130, 56);
            this.ingresarNombre.Name = "ingresarNombre";
            this.ingresarNombre.Size = new System.Drawing.Size(218, 20);
            this.ingresarNombre.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nombre";
            // 
            // ingresarPass
            // 
            this.ingresarPass.AcceptsTab = true;
            this.ingresarPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ingresarPass.Location = new System.Drawing.Point(130, 91);
            this.ingresarPass.Name = "ingresarPass";
            this.ingresarPass.Size = new System.Drawing.Size(218, 20);
            this.ingresarPass.TabIndex = 13;
            this.ingresarPass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Rol";
            // 
            // ingresarRut
            // 
            this.ingresarRut.AcceptsTab = true;
            this.ingresarRut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ingresarRut.Location = new System.Drawing.Point(130, 21);
            this.ingresarRut.Name = "ingresarRut";
            this.ingresarRut.Size = new System.Drawing.Size(218, 20);
            this.ingresarRut.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Rut";
            // 
            // ingresarTelefono
            // 
            this.ingresarTelefono.AcceptsTab = true;
            this.ingresarTelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ingresarTelefono.Location = new System.Drawing.Point(130, 163);
            this.ingresarTelefono.Name = "ingresarTelefono";
            this.ingresarTelefono.Size = new System.Drawing.Size(218, 20);
            this.ingresarTelefono.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Telefono";
            // 
            // ingresarCorreo
            // 
            this.ingresarCorreo.AcceptsTab = true;
            this.ingresarCorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ingresarCorreo.Location = new System.Drawing.Point(130, 201);
            this.ingresarCorreo.Name = "ingresarCorreo";
            this.ingresarCorreo.Size = new System.Drawing.Size(218, 20);
            this.ingresarCorreo.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Correo electrónico";
            // 
            // ingresarDireccion
            // 
            this.ingresarDireccion.AcceptsTab = true;
            this.ingresarDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ingresarDireccion.Location = new System.Drawing.Point(130, 237);
            this.ingresarDireccion.Name = "ingresarDireccion";
            this.ingresarDireccion.Size = new System.Drawing.Size(218, 20);
            this.ingresarDireccion.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Dirección";
            // 
            // ingresarRol
            // 
            this.ingresarRol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ingresarRol.FormattingEnabled = true;
            this.ingresarRol.Location = new System.Drawing.Point(130, 125);
            this.ingresarRol.Name = "ingresarRol";
            this.ingresarRol.Size = new System.Drawing.Size(217, 21);
            this.ingresarRol.TabIndex = 22;
            // 
            // botonAgregar
            // 
            this.botonAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botonAgregar.BackColor = System.Drawing.Color.Lime;
            this.botonAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAgregar.Location = new System.Drawing.Point(16, 372);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(96, 37);
            this.botonAgregar.TabIndex = 23;
            this.botonAgregar.Text = "Agregar";
            this.botonAgregar.UseVisualStyleBackColor = false;
            this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botonCancelar.BackColor = System.Drawing.Color.Lime;
            this.botonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCancelar.Location = new System.Drawing.Point(252, 372);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(96, 37);
            this.botonCancelar.TabIndex = 24;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = false;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // AgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(384, 421);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.botonAgregar);
            this.Controls.Add(this.ingresarRol);
            this.Controls.Add(this.ingresarDireccion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ingresarCorreo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ingresarTelefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ingresarNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ingresarPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ingresarRut);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgregarUsuario";
            this.Text = "Agregar Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ingresarNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ingresarPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ingresarRut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ingresarTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ingresarCorreo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ingresarDireccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ingresarRol;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.Button botonCancelar;
    }
}