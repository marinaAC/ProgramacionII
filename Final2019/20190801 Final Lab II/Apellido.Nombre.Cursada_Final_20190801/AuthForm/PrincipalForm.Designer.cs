namespace View
{
    partial class PrincipalForm
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
            this.lblListaUsuarios = new System.Windows.Forms.Label();
            this.txtListaUsuarios = new System.Windows.Forms.RichTextBox();
            this.lblAltaUsuarios = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.groupTipoUsuario = new System.Windows.Forms.GroupBox();
            this.radioExterno = new System.Windows.Forms.RadioButton();
            this.radioEmpleado = new System.Windows.Forms.RadioButton();
            this.comboArea = new System.Windows.Forms.ComboBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtSalida = new System.Windows.Forms.RichTextBox();
            this.lblSalida = new System.Windows.Forms.Label();
            this.groupTipoUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblListaUsuarios
            // 
            this.lblListaUsuarios.AutoSize = true;
            this.lblListaUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaUsuarios.Location = new System.Drawing.Point(13, 13);
            this.lblListaUsuarios.Name = "lblListaUsuarios";
            this.lblListaUsuarios.Size = new System.Drawing.Size(105, 13);
            this.lblListaUsuarios.TabIndex = 0;
            this.lblListaUsuarios.Text = "Lista de Usuarios";
            // 
            // txtListaUsuarios
            // 
            this.txtListaUsuarios.Location = new System.Drawing.Point(14, 39);
            this.txtListaUsuarios.Name = "txtListaUsuarios";
            this.txtListaUsuarios.ReadOnly = true;
            this.txtListaUsuarios.Size = new System.Drawing.Size(360, 398);
            this.txtListaUsuarios.TabIndex = 1;
            this.txtListaUsuarios.Text = "";
            // 
            // lblAltaUsuarios
            // 
            this.lblAltaUsuarios.AutoSize = true;
            this.lblAltaUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaUsuarios.Location = new System.Drawing.Point(435, 13);
            this.lblAltaUsuarios.Name = "lblAltaUsuarios";
            this.lblAltaUsuarios.Size = new System.Drawing.Size(100, 13);
            this.lblAltaUsuarios.TabIndex = 2;
            this.lblAltaUsuarios.Text = "Alta de Usuarios";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(436, 44);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(439, 60);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(293, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(439, 112);
            this.txtCuenta.MaxLength = 50;
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(293, 20);
            this.txtCuenta.TabIndex = 6;
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Location = new System.Drawing.Point(436, 96);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(41, 13);
            this.lblCuenta.TabIndex = 5;
            this.lblCuenta.Text = "Cuenta";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(438, 165);
            this.txtClave.MaxLength = 50;
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(293, 20);
            this.txtClave.TabIndex = 8;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(436, 149);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(34, 13);
            this.lblClave.TabIndex = 7;
            this.lblClave.Text = "Clave";
            // 
            // groupTipoUsuario
            // 
            this.groupTipoUsuario.Controls.Add(this.radioExterno);
            this.groupTipoUsuario.Controls.Add(this.radioEmpleado);
            this.groupTipoUsuario.Location = new System.Drawing.Point(439, 210);
            this.groupTipoUsuario.Name = "groupTipoUsuario";
            this.groupTipoUsuario.Size = new System.Drawing.Size(288, 41);
            this.groupTipoUsuario.TabIndex = 9;
            this.groupTipoUsuario.TabStop = false;
            this.groupTipoUsuario.Text = "Tipo de Usuario";
            // 
            // radioExterno
            // 
            this.radioExterno.AutoSize = true;
            this.radioExterno.Location = new System.Drawing.Point(85, 18);
            this.radioExterno.Name = "radioExterno";
            this.radioExterno.Size = new System.Drawing.Size(61, 17);
            this.radioExterno.TabIndex = 1;
            this.radioExterno.TabStop = true;
            this.radioExterno.Text = "Externo";
            this.radioExterno.UseVisualStyleBackColor = true;
            // 
            // radioEmpleado
            // 
            this.radioEmpleado.AutoSize = true;
            this.radioEmpleado.Location = new System.Drawing.Point(7, 18);
            this.radioEmpleado.Name = "radioEmpleado";
            this.radioEmpleado.Size = new System.Drawing.Size(72, 17);
            this.radioEmpleado.TabIndex = 0;
            this.radioEmpleado.TabStop = true;
            this.radioEmpleado.Text = "Empleado";
            this.radioEmpleado.UseVisualStyleBackColor = true;
            this.radioEmpleado.CheckedChanged += new System.EventHandler(this.radioEmpleado_CheckedChanged);
            // 
            // comboArea
            // 
            this.comboArea.FormattingEnabled = true;
            this.comboArea.Location = new System.Drawing.Point(438, 284);
            this.comboArea.Name = "comboArea";
            this.comboArea.Size = new System.Drawing.Size(288, 21);
            this.comboArea.TabIndex = 10;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(436, 268);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(96, 13);
            this.lblArea.TabIndex = 11;
            this.lblArea.Text = "Área del Empleado";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(438, 332);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(116, 30);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtSalida
            // 
            this.txtSalida.Location = new System.Drawing.Point(436, 395);
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.ReadOnly = true;
            this.txtSalida.Size = new System.Drawing.Size(347, 41);
            this.txtSalida.TabIndex = 13;
            this.txtSalida.Text = "";
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalida.Location = new System.Drawing.Point(436, 379);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(42, 13);
            this.lblSalida.TabIndex = 2;
            this.lblSalida.Text = "Salida";
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.txtSalida);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.comboArea);
            this.Controls.Add(this.groupTipoUsuario);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.txtCuenta);
            this.Controls.Add(this.lblCuenta);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblAltaUsuarios);
            this.Controls.Add(this.txtListaUsuarios);
            this.Controls.Add(this.lblListaUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrincipalForm";
            this.Text = "Gestión de Usuarios";
            this.Load += new System.EventHandler(this.PrincipalForm_Load);
            this.groupTipoUsuario.ResumeLayout(false);
            this.groupTipoUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListaUsuarios;
        private System.Windows.Forms.RichTextBox txtListaUsuarios;
        private System.Windows.Forms.Label lblAltaUsuarios;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.Label lblCuenta;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.GroupBox groupTipoUsuario;
        private System.Windows.Forms.RadioButton radioExterno;
        private System.Windows.Forms.RadioButton radioEmpleado;
        private System.Windows.Forms.ComboBox comboArea;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.RichTextBox txtSalida;
        private System.Windows.Forms.Label lblSalida;
    }
}