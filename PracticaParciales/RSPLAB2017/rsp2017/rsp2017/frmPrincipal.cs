using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace rsp2017
{
    public partial class frmPrincipal : Form
    {
        protected Thread hilo;
        
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnLanzar_Click(object sender, EventArgs e)
        {

        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {

        }

        public void MostrarMensajeFin(string men) 
        {
            MessageBox.Show(men);
        }
    }
}
