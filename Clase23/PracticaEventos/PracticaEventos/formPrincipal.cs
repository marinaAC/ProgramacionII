using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace PracticaEventos
{
    public partial class formPrincipal : Form
    {
      

        public formPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            this.IsMdiContainer = true;
            Form formSec = new Form();
            formSec.MdiParent = this;
            formSec.Show();*/
        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            Form formSecExecute = new formSec();
            formSecExecute.MdiParent = this;
            formSecExecute.Show();
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) 
            {
                if(item is formSec)
                {
                    this.IsMdiContainer = true;
                    formTercero formEventListener = new formTercero();
                    formEventListener.MdiParent = this;
                    //Parseo el item recibido, ya que en el formulario 2 se encuentra el evento
                    //con el delegado declarado, entonces realizo el metodo actualizar nombre
                    //realmente no entiendo bien como funciona aun
                    ((formSec)item).actualizoLbl += formEventListener.ActualizarNombre;
                    formEventListener.Show();
                }
            }
        }


    }
}
