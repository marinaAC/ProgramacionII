namespace PractParcial
{
    partial class frmRsp
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
            this.lblCarril1 = new System.Windows.Forms.Label();
            this.lblCarril2 = new System.Windows.Forms.Label();
            this.btnCorrer = new System.Windows.Forms.Button();
            this.pgbCarril1 = new System.Windows.Forms.ProgressBar();
            this.pgbCarril2 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lblCarril1
            // 
            this.lblCarril1.AutoSize = true;
            this.lblCarril1.Location = new System.Drawing.Point(32, 24);
            this.lblCarril1.Name = "lblCarril1";
            this.lblCarril1.Size = new System.Drawing.Size(39, 13);
            this.lblCarril1.TabIndex = 0;
            this.lblCarril1.Text = "Carril 1";
            // 
            // lblCarril2
            // 
            this.lblCarril2.AutoSize = true;
            this.lblCarril2.Location = new System.Drawing.Point(32, 59);
            this.lblCarril2.Name = "lblCarril2";
            this.lblCarril2.Size = new System.Drawing.Size(39, 13);
            this.lblCarril2.TabIndex = 1;
            this.lblCarril2.Text = "Carril 2";
            // 
            // btnCorrer
            // 
            this.btnCorrer.Location = new System.Drawing.Point(322, 93);
            this.btnCorrer.Name = "btnCorrer";
            this.btnCorrer.Size = new System.Drawing.Size(115, 45);
            this.btnCorrer.TabIndex = 4;
            this.btnCorrer.Text = "Correr";
            this.btnCorrer.UseVisualStyleBackColor = true;
            this.btnCorrer.Click += new System.EventHandler(this.btnCorrer_Click);
            // 
            // pgbCarril1
            // 
            this.pgbCarril1.Location = new System.Drawing.Point(78, 19);
            this.pgbCarril1.Name = "pgbCarril1";
            this.pgbCarril1.Size = new System.Drawing.Size(382, 23);
            this.pgbCarril1.TabIndex = 5;
            // 
            // pgbCarril2
            // 
            this.pgbCarril2.Location = new System.Drawing.Point(78, 54);
            this.pgbCarril2.Name = "pgbCarril2";
            this.pgbCarril2.Size = new System.Drawing.Size(382, 23);
            this.pgbCarril2.TabIndex = 6;
            // 
            // frmRsp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 150);
            this.Controls.Add(this.pgbCarril2);
            this.Controls.Add(this.pgbCarril1);
            this.Controls.Add(this.btnCorrer);
            this.Controls.Add(this.lblCarril2);
            this.Controls.Add(this.lblCarril1);
            this.Name = "frmRsp";
            this.Text = "Rsp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCarril1;
        private System.Windows.Forms.Label lblCarril2;
        private System.Windows.Forms.Button btnCorrer;
        private System.Windows.Forms.ProgressBar pgbCarril1;
        private System.Windows.Forms.ProgressBar pgbCarril2;
    }
}

