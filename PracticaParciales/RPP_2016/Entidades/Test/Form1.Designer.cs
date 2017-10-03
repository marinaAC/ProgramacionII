namespace Test
{
    partial class FormTest
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
            this.btnPruebaClases = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.rtxtMuestra = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnPruebaClases
            // 
            this.btnPruebaClases.Location = new System.Drawing.Point(12, 38);
            this.btnPruebaClases.Name = "btnPruebaClases";
            this.btnPruebaClases.Size = new System.Drawing.Size(260, 38);
            this.btnPruebaClases.TabIndex = 0;
            this.btnPruebaClases.Text = "Prueba Clases";
            this.btnPruebaClases.UseVisualStyleBackColor = true;
            this.btnPruebaClases.Click += new System.EventHandler(this.btnPruebaClases_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(12, 83);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(260, 39);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar Clases";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // rtxtMuestra
            // 
            this.rtxtMuestra.Location = new System.Drawing.Point(13, 129);
            this.rtxtMuestra.Name = "rtxtMuestra";
            this.rtxtMuestra.Size = new System.Drawing.Size(259, 121);
            this.rtxtMuestra.TabIndex = 2;
            this.rtxtMuestra.Text = "";
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.rtxtMuestra);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnPruebaClases);
            this.Name = "FormTest";
            this.Text = "RPP";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPruebaClases;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.RichTextBox rtxtMuestra;
    }
}

