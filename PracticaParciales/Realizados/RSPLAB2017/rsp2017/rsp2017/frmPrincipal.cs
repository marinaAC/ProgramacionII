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
using Entidades;

 
namespace rsp2017
{
    public partial class frmPrincipal : Form
    {
        protected LosHilos hilos;
        
        public frmPrincipal()
        {
            InitializeComponent();
            hilos = new LosHilos();
            hilos.eventoAvisar += MostrarMensajeFin;
        }

        private void btnLanzar_Click(object sender, EventArgs e)
        {

            try
            {
                hilos = hilos + 1;
                
                
            }
            catch (Exception)
            {

                throw;
            }
            //Se cargara un hilo
            //mostrara error
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            MostrarMensajeFin(hilos.Bitacora);
        }

        public void MostrarMensajeFin(string men) 
        {
            MessageBox.Show(men);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
        }
    }
}
