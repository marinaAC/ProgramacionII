using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace CardozoMarina
{
    public partial class frmPPal : Form
    {
        protected LasCarreras carrera;
        public frmPPal()
        {
            InitializeComponent();
            carrera = new LasCarreras();
            carrera.AvisoFin += MostrarMensajeFin;
        }

        private void btnCorrer_Click(object sender, EventArgs e)
        {
            carrera = carrera + 1;
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            MessageBox.Show(carrera.Detalle);
        }

        private void MostrarMensajeFin(string mens) 
        {
            MessageBox.Show(mens);
        }
        
    }
}
