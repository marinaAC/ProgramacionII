namespace ejercicioClase06WF
{
    partial class formEstanteria
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
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.txtCapacidadEstanteria = new System.Windows.Forms.TextBox();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.txtUbicacionEstanteria = new System.Windows.Forms.TextBox();
            this.btnCrearEstanteria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(23, 57);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(58, 13);
            this.lblCapacidad.TabIndex = 0;
            this.lblCapacidad.Text = "Capacidad";
            // 
            // txtCapacidadEstanteria
            // 
            this.txtCapacidadEstanteria.Location = new System.Drawing.Point(137, 54);
            this.txtCapacidadEstanteria.Name = "txtCapacidadEstanteria";
            this.txtCapacidadEstanteria.Size = new System.Drawing.Size(100, 20);
            this.txtCapacidadEstanteria.TabIndex = 1;
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Location = new System.Drawing.Point(26, 103);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(55, 13);
            this.lblUbicacion.TabIndex = 2;
            this.lblUbicacion.Text = "Ubicacion";
            // 
            // txtUbicacionEstanteria
            // 
            this.txtUbicacionEstanteria.Location = new System.Drawing.Point(137, 95);
            this.txtUbicacionEstanteria.Name = "txtUbicacionEstanteria";
            this.txtUbicacionEstanteria.Size = new System.Drawing.Size(100, 20);
            this.txtUbicacionEstanteria.TabIndex = 3;
            // 
            // btnCrearEstanteria
            // 
            this.btnCrearEstanteria.Location = new System.Drawing.Point(137, 181);
            this.btnCrearEstanteria.Name = "btnCrearEstanteria";
            this.btnCrearEstanteria.Size = new System.Drawing.Size(75, 23);
            this.btnCrearEstanteria.TabIndex = 4;
            this.btnCrearEstanteria.Text = "Crear";
            this.btnCrearEstanteria.UseVisualStyleBackColor = true;
            this.btnCrearEstanteria.Click += new System.EventHandler(this.btnCrearEstanteria_Click);
            // 
            // formEstanteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnCrearEstanteria);
            this.Controls.Add(this.txtUbicacionEstanteria);
            this.Controls.Add(this.lblUbicacion);
            this.Controls.Add(this.txtCapacidadEstanteria);
            this.Controls.Add(this.lblCapacidad);
            this.Name = "formEstanteria";
            this.Text = "formEstanteria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.TextBox txtCapacidadEstanteria;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.TextBox txtUbicacionEstanteria;
        private System.Windows.Forms.Button btnCrearEstanteria;
    }
}