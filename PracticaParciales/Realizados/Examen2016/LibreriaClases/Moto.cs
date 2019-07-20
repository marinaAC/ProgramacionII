using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases
{
    class Moto:Vehiculo
    {
        protected float _cilandra;

        public Moto(float cil, EMarca marca, byte cantRuedas, string patente)
            : base(patente, cantRuedas, marca)
        { 
            this._cilandra = cil;
        }

        public string MostrarMoto() 
        {
            string returnAux;
            string auxDos = Mostrar();
            returnAux = String.Format("Moto:{0} Cilandra:{1}", auxDos, this._cilandra);

            return returnAux;
        }
    }
}
