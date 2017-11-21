namespace PractFinal2017
{
    partial class frmFinal
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
            this.btnAtenderMedicoGeneral = new System.Windows.Forms.Button();
            this.btnAtenderMedicoEspecialista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAtenderMedicoGeneral
            // 
            this.btnAtenderMedicoGeneral.Location = new System.Drawing.Point(13, 28);
            this.btnAtenderMedicoGeneral.Name = "btnAtenderMedicoGeneral";
            this.btnAtenderMedicoGeneral.Size = new System.Drawing.Size(396, 85);
            this.btnAtenderMedicoGeneral.TabIndex = 0;
            this.btnAtenderMedicoGeneral.Text = "Atender Medico General";
            this.btnAtenderMedicoGeneral.UseVisualStyleBackColor = true;
            this.btnAtenderMedicoGeneral.Click += new System.EventHandler(this.btnAtenderMedicoGeneral_Click);
            // 
            // btnAtenderMedicoEspecialista
            // 
            this.btnAtenderMedicoEspecialista.Location = new System.Drawing.Point(13, 138);
            this.btnAtenderMedicoEspecialista.Name = "btnAtenderMedicoEspecialista";
            this.btnAtenderMedicoEspecialista.Size = new System.Drawing.Size(396, 79);
            this.btnAtenderMedicoEspecialista.TabIndex = 1;
            this.btnAtenderMedicoEspecialista.Text = "Atender Medico Especialista";
            this.btnAtenderMedicoEspecialista.UseVisualStyleBackColor = true;
            this.btnAtenderMedicoEspecialista.Click += new System.EventHandler(this.btnAtenderMedicoEspecialista_Click);
            // 
            // frmFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 262);
            this.Controls.Add(this.btnAtenderMedicoEspecialista);
            this.Controls.Add(this.btnAtenderMedicoGeneral);
            this.Name = "frmFinal";
            this.Text = "Final";
            this.Load += new System.EventHandler(this.frmFinal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAtenderMedicoGeneral;
        private System.Windows.Forms.Button btnAtenderMedicoEspecialista;
    }
}

