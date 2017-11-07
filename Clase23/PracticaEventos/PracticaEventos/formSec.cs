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
    public partial class formSec : Form
    {
        
        public formSec()
        {
            InitializeComponent();
        }

        private void formSec_Load(object sender, EventArgs e)
        {
           
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Eventos myEvento = new Eventos();
            myEvento.EventoActualizarNombre(this.txtDelegado.Text);
        }


    }
}
