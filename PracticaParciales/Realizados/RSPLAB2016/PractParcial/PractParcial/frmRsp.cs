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
using System.Threading;

namespace PractParcial
{
    public partial class frmRsp : Form
    {
        protected List<Persona> _corredores;
        protected List<Thread> _corredoresActivos;
        protected bool _hayGanador;
        

        public frmRsp()
        {
            InitializeComponent();
            this._corredores = new List<Persona>();
            this._corredoresActivos = new List<Thread>();
            this._corredores.Add(new Persona("Fernando", 9, Corredor.Carril.Carril_1));
            this._corredores.Add(new Persona("Claudio", 15, Corredor.Carril.Carril_2));
            this._hayGanador = false;
        }

        private void PersonaCorriendo(int avance, Corredor corredor) 
        {
            if (pgbCarril1.InvokeRequired || pgbCarril2.InvokeRequired)
            {
                CorrenCallback d = new CorrenCallback(PersonaCorriendo);
                this.Invoke(d, new object[] { avance, corredor });
            }
            else
            {
                if (corredor.CarrilElegido == Corredor.Carril.Carril_1)
                {
                    AnalizarCarrera(pgbCarril1, avance, corredor);
                }
                else 
                {
                    AnalizarCarrera(pgbCarril2, avance, corredor);
                }               
            }
        }

        private void LimpiarCarriles() 
        {
            pgbCarril1.Value = 0;
            pgbCarril2.Value = 0;
        }

        public delegate void CorrenCallback(int avance, Corredor corredor);

        private void btnCorrer_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Persona p in this._corredores)
                {
                    p.corriendo += PersonaCorriendo;
                    Thread corredorAux = new Thread(p.Correr);
                    this._corredoresActivos.Add(corredorAux);
                    corredorAux.Start();

                }
            }
            catch (Exception)
            {

                MessageBox.Show("error");
            }
     
        }

        private void AnalizarCarrera(ProgressBar carril, int avance, Corredor corredor) 
        {
            int auxAvance = carril.Value + avance;
            if (auxAvance > 100)
            {
                this._hayGanador = true;
                HayGanador(corredor);
            }
            else 
            {
                carril.Value = carril.Value + avance;
            }
        }

        private void HayGanador(Corredor corredor) 
        {
            foreach (Thread hilo in this._corredoresActivos) 
            {
              
                hilo.Abort();
            }
            string aux = string.Format("Gano el corredor {0}", corredor.ToString());
            MessageBox.Show(aux);
            LimpiarCarriles();
        }
    }
}
