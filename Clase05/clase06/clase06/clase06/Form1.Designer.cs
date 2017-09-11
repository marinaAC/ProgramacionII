namespace clase06
{
    partial class form
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblNombreUsurio = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblConfirmPass = new System.Windows.Forms.Label();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dateNacimiento = new System.Windows.Forms.DateTimePicker();
            this.rbtbMasculino = new System.Windows.Forms.RadioButton();
            this.rbtbFemenino = new System.Windows.Forms.RadioButton();
            this.lblTelMovil = new System.Windows.Forms.Label();
            this.txtTelMovil = new System.Windows.Forms.TextBox();
            this.lblDireccionMail = new System.Windows.Forms.Label();
            this.txtCorreoActual = new System.Windows.Forms.TextBox();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.listUbicacion = new System.Windows.Forms.ListBox();
            this.btbEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(24, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(151, 46);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(21, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(24, 103);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(227, 20);
            this.txtNombreUsuario.TabIndex = 4;
            // 
            // lblNombreUsurio
            // 
            this.lblNombreUsurio.AutoSize = true;
            this.lblNombreUsurio.Location = new System.Drawing.Point(21, 87);
            this.lblNombreUsurio.Name = "lblNombreUsurio";
            this.lblNombreUsurio.Size = new System.Drawing.Size(96, 13);
            this.lblNombreUsurio.TabIndex = 5;
            this.lblNombreUsurio.Text = "Nombre de usuario";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(21, 138);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(61, 13);
            this.lblPass.TabIndex = 6;
            this.lblPass.Text = "Contraseña";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(24, 156);
            this.txtPass.Name = "txtPass";
            this.txtPass.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPass.Size = new System.Drawing.Size(227, 20);
            this.txtPass.TabIndex = 7;
            // 
            // lblConfirmPass
            // 
            this.lblConfirmPass.AutoSize = true;
            this.lblConfirmPass.Location = new System.Drawing.Point(21, 194);
            this.lblConfirmPass.Name = "lblConfirmPass";
            this.lblConfirmPass.Size = new System.Drawing.Size(107, 13);
            this.lblConfirmPass.TabIndex = 8;
            this.lblConfirmPass.Text = "Confirmar contraseña";
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(24, 213);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConfirmPass.Size = new System.Drawing.Size(227, 20);
            this.txtConfirmPass.TabIndex = 9;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(21, 253);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(106, 13);
            this.lblFecha.TabIndex = 10;
            this.lblFecha.Text = "Fecha de nacimiento";
            // 
            // dateNacimiento
            // 
            this.dateNacimiento.Location = new System.Drawing.Point(24, 275);
            this.dateNacimiento.Name = "dateNacimiento";
            this.dateNacimiento.Size = new System.Drawing.Size(227, 20);
            this.dateNacimiento.TabIndex = 11;
            this.dateNacimiento.Value = new System.DateTime(2017, 9, 1, 0, 0, 0, 0);
            // 
            // rbtbMasculino
            // 
            this.rbtbMasculino.AutoSize = true;
            this.rbtbMasculino.Location = new System.Drawing.Point(24, 319);
            this.rbtbMasculino.Name = "rbtbMasculino";
            this.rbtbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbtbMasculino.TabIndex = 12;
            this.rbtbMasculino.TabStop = true;
            this.rbtbMasculino.Text = "Masculino";
            this.rbtbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtbFemenino
            // 
            this.rbtbFemenino.AutoSize = true;
            this.rbtbFemenino.Location = new System.Drawing.Point(115, 319);
            this.rbtbFemenino.Name = "rbtbFemenino";
            this.rbtbFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbtbFemenino.TabIndex = 13;
            this.rbtbFemenino.TabStop = true;
            this.rbtbFemenino.Text = "Femenino";
            this.rbtbFemenino.UseVisualStyleBackColor = true;
            // 
            // lblTelMovil
            // 
            this.lblTelMovil.AutoSize = true;
            this.lblTelMovil.Location = new System.Drawing.Point(21, 364);
            this.lblTelMovil.Name = "lblTelMovil";
            this.lblTelMovil.Size = new System.Drawing.Size(77, 13);
            this.lblTelMovil.TabIndex = 14;
            this.lblTelMovil.Text = "Telefono Movil";
            // 
            // txtTelMovil
            // 
            this.txtTelMovil.Location = new System.Drawing.Point(24, 380);
            this.txtTelMovil.Name = "txtTelMovil";
            this.txtTelMovil.Size = new System.Drawing.Size(227, 20);
            this.txtTelMovil.TabIndex = 15;
            // 
            // lblDireccionMail
            // 
            this.lblDireccionMail.AutoSize = true;
            this.lblDireccionMail.Location = new System.Drawing.Point(21, 423);
            this.lblDireccionMail.Name = "lblDireccionMail";
            this.lblDireccionMail.Size = new System.Drawing.Size(146, 13);
            this.lblDireccionMail.TabIndex = 16;
            this.lblDireccionMail.Text = "Tu direccion de correo actual";
            // 
            // txtCorreoActual
            // 
            this.txtCorreoActual.Location = new System.Drawing.Point(24, 439);
            this.txtCorreoActual.Name = "txtCorreoActual";
            this.txtCorreoActual.Size = new System.Drawing.Size(227, 20);
            this.txtCorreoActual.TabIndex = 17;
            this.txtCorreoActual.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Location = new System.Drawing.Point(21, 479);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(55, 13);
            this.lblUbicacion.TabIndex = 18;
            this.lblUbicacion.Text = "Ubicacion";
            // 
            // listUbicacion
            // 
            this.listUbicacion.FormattingEnabled = true;
            this.listUbicacion.Items.AddRange(new object[] {
            "Argentina",
            "Brasil",
            "Uruguay",
            "Chile"});
            this.listUbicacion.Location = new System.Drawing.Point(24, 497);
            this.listUbicacion.Name = "listUbicacion";
            this.listUbicacion.Size = new System.Drawing.Size(227, 17);
            this.listUbicacion.TabIndex = 19;
            // 
            // btbEnviar
            // 
            this.btbEnviar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btbEnviar.ForeColor = System.Drawing.Color.Snow;
            this.btbEnviar.Location = new System.Drawing.Point(151, 562);
            this.btbEnviar.Name = "btbEnviar";
            this.btbEnviar.Size = new System.Drawing.Size(100, 23);
            this.btbEnviar.TabIndex = 20;
            this.btbEnviar.Text = "Siguiente Paso";
            this.btbEnviar.UseVisualStyleBackColor = false;
            this.btbEnviar.Click += new System.EventHandler(this.btbEnviar_Click);
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 623);
            this.Controls.Add(this.btbEnviar);
            this.Controls.Add(this.listUbicacion);
            this.Controls.Add(this.lblUbicacion);
            this.Controls.Add(this.txtCorreoActual);
            this.Controls.Add(this.lblDireccionMail);
            this.Controls.Add(this.txtTelMovil);
            this.Controls.Add(this.lblTelMovil);
            this.Controls.Add(this.rbtbFemenino);
            this.Controls.Add(this.rbtbMasculino);
            this.Controls.Add(this.dateNacimiento);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.lblConfirmPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblNombreUsurio);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtName);
            this.Name = "form";
            this.Text = "Formulario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label lblNombreUsurio;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblConfirmPass;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dateNacimiento;
        private System.Windows.Forms.RadioButton rbtbMasculino;
        private System.Windows.Forms.RadioButton rbtbFemenino;
        private System.Windows.Forms.Label lblTelMovil;
        private System.Windows.Forms.TextBox txtTelMovil;
        private System.Windows.Forms.Label lblDireccionMail;
        private System.Windows.Forms.TextBox txtCorreoActual;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.ListBox listUbicacion;
        private System.Windows.Forms.Button btbEnviar;
    }
}

