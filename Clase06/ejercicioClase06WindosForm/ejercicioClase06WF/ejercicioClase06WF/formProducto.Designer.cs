namespace ejercicioClase06WF
{
    partial class formProducto
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
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCodigoBarras = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtProductoMarca = new System.Windows.Forms.TextBox();
            this.txtProductoBarras = new System.Windows.Forms.TextBox();
            this.txtProductoPrecio = new System.Windows.Forms.TextBox();
            this.btnAceptarProd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(42, 64);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca";
            // 
            // lblCodigoBarras
            // 
            this.lblCodigoBarras.AutoSize = true;
            this.lblCodigoBarras.Location = new System.Drawing.Point(45, 105);
            this.lblCodigoBarras.Name = "lblCodigoBarras";
            this.lblCodigoBarras.Size = new System.Drawing.Size(37, 13);
            this.lblCodigoBarras.TabIndex = 1;
            this.lblCodigoBarras.Text = "Barras";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(45, 151);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio";
            // 
            // txtProductoMarca
            // 
            this.txtProductoMarca.Location = new System.Drawing.Point(106, 64);
            this.txtProductoMarca.Name = "txtProductoMarca";
            this.txtProductoMarca.Size = new System.Drawing.Size(100, 20);
            this.txtProductoMarca.TabIndex = 3;
            // 
            // txtProductoBarras
            // 
            this.txtProductoBarras.Location = new System.Drawing.Point(106, 105);
            this.txtProductoBarras.Name = "txtProductoBarras";
            this.txtProductoBarras.Size = new System.Drawing.Size(100, 20);
            this.txtProductoBarras.TabIndex = 4;
            // 
            // txtProductoPrecio
            // 
            this.txtProductoPrecio.Location = new System.Drawing.Point(106, 143);
            this.txtProductoPrecio.Name = "txtProductoPrecio";
            this.txtProductoPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtProductoPrecio.TabIndex = 5;
            // 
            // btnAceptarProd
            // 
            this.btnAceptarProd.Location = new System.Drawing.Point(117, 198);
            this.btnAceptarProd.Name = "btnAceptarProd";
            this.btnAceptarProd.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarProd.TabIndex = 6;
            this.btnAceptarProd.Text = "Aceptar";
            this.btnAceptarProd.UseVisualStyleBackColor = true;
            this.btnAceptarProd.Click += new System.EventHandler(this.btnAceptarProd_Click);
            // 
            // formProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnAceptarProd);
            this.Controls.Add(this.txtProductoPrecio);
            this.Controls.Add(this.txtProductoBarras);
            this.Controls.Add(this.txtProductoMarca);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCodigoBarras);
            this.Controls.Add(this.lblMarca);
            this.Name = "formProducto";
            this.Text = "formProducto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCodigoBarras;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtProductoMarca;
        private System.Windows.Forms.TextBox txtProductoBarras;
        private System.Windows.Forms.TextBox txtProductoPrecio;
        private System.Windows.Forms.Button btnAceptarProd;
    }
}