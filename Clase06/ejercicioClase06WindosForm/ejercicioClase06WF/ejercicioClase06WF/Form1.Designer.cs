namespace ejercicioClase06WF
{
    partial class formPpal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumeroEstanteria = new System.Windows.Forms.Label();
            this.cmbNumeroEstanteria = new System.Windows.Forms.ComboBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.lblProductos = new System.Windows.Forms.Label();
            this.listProd = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumeroEstanteria
            // 
            this.lblNumeroEstanteria.AutoSize = true;
            this.lblNumeroEstanteria.Location = new System.Drawing.Point(24, 49);
            this.lblNumeroEstanteria.Name = "lblNumeroEstanteria";
            this.lblNumeroEstanteria.Size = new System.Drawing.Size(108, 13);
            this.lblNumeroEstanteria.TabIndex = 0;
            this.lblNumeroEstanteria.Text = "Numero de estanteria";
            // 
            // cmbNumeroEstanteria
            // 
            this.cmbNumeroEstanteria.FormattingEnabled = true;
            this.cmbNumeroEstanteria.Location = new System.Drawing.Point(139, 49);
            this.cmbNumeroEstanteria.Name = "cmbNumeroEstanteria";
            this.cmbNumeroEstanteria.Size = new System.Drawing.Size(121, 21);
            this.cmbNumeroEstanteria.TabIndex = 1;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(273, 49);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 2;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Location = new System.Drawing.Point(38, 109);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(55, 13);
            this.lblProductos.TabIndex = 3;
            this.lblProductos.Text = "Productos";
            // 
            // listProd
            // 
            this.listProd.FormattingEnabled = true;
            this.listProd.Location = new System.Drawing.Point(139, 109);
            this.listProd.Name = "listProd";
            this.listProd.Size = new System.Drawing.Size(120, 95);
            this.listProd.TabIndex = 4;
            this.listProd.SelectedIndexChanged += new System.EventHandler(this.listProd_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(273, 180);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // formPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 262);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.listProd);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.cmbNumeroEstanteria);
            this.Controls.Add(this.lblNumeroEstanteria);
            this.Name = "formPpal";
            this.Text = "frmPpal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroEstanteria;
        private System.Windows.Forms.ComboBox cmbNumeroEstanteria;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.ListBox listProd;
        private System.Windows.Forms.Button btnAgregar;
    }
}

