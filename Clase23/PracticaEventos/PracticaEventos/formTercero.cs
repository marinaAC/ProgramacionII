using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaEventos
{
    public partial class formTercero : Form
    {

        public formTercero()
        {
            InitializeComponent();
        }

        private void formTercero_Load(object sender, EventArgs e)
        {

        }

        public void ActualizarNombre(string nombre) 
        {
            this.lblActualizar.Text = nombre;
        }
    }
}
