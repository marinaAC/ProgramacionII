namespace PracticaEventos
{
    partial class formPrincipal
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
            this.mStripPrincipal = new System.Windows.Forms.MenuStrip();
            this.AltaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testDelegadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mStripPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mStripPrincipal
            // 
            this.mStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AltaToolStripMenuItem,
            this.mostrarToolStripMenuItem});
            this.mStripPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mStripPrincipal.Name = "mStripPrincipal";
            this.mStripPrincipal.Size = new System.Drawing.Size(384, 24);
            this.mStripPrincipal.TabIndex = 0;
            this.mStripPrincipal.Text = "menuStrip1";
            // 
            // AltaToolStripMenuItem
            // 
            this.AltaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testDelegadosToolStripMenuItem,
            this.alumnoToolStripMenuItem});
            this.AltaToolStripMenuItem.Name = "AltaToolStripMenuItem";
            this.AltaToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.AltaToolStripMenuItem.Text = "Alta";
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.mostrarToolStripMenuItem.Text = "Mostrar";
            this.mostrarToolStripMenuItem.Click += new System.EventHandler(this.mostrarToolStripMenuItem_Click);
            // 
            // testDelegadosToolStripMenuItem
            // 
            this.testDelegadosToolStripMenuItem.Name = "testDelegadosToolStripMenuItem";
            this.testDelegadosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.testDelegadosToolStripMenuItem.Text = "Test Delegados";
            this.testDelegadosToolStripMenuItem.Click += new System.EventHandler(this.testDelegadosToolStripMenuItem_Click);
            // 
            // alumnoToolStripMenuItem
            // 
            this.alumnoToolStripMenuItem.Name = "alumnoToolStripMenuItem";
            this.alumnoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.alumnoToolStripMenuItem.Text = "Alumno";
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 273);
            this.Controls.Add(this.mStripPrincipal);
            this.MainMenuStrip = this.mStripPrincipal;
            this.Name = "formPrincipal";
            this.Text = "formPrincipal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mStripPrincipal.ResumeLayout(false);
            this.mStripPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mStripPrincipal;
        private System.Windows.Forms.ToolStripMenuItem AltaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testDelegadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnoToolStripMenuItem;

    }
}

