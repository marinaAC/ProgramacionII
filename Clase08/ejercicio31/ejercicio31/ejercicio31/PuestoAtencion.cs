using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ejercicio31
{
    class PuestoAtencion
    {
        
        private int _numeroActual;
        private Puesto _puesto;

       
        private PuestoAtencion() 
        {
            this._numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto) 
        {
            this._puesto = puesto;
        }

        public void Atender(Cliente client)
        {
            Thread.Sleep(10);
        }

        public int NumeroAtencion 
        {
            get 
            {
                this._numeroActual = this._numeroActual + 1;
                return this._numeroActual;
            }
        }


        
    }
}
