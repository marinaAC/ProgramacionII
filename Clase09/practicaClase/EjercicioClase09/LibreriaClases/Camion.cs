using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases
{
    class Camion:Vehiculo
    {
        protected float _tara;

        public Camion(float tara, EMarca marca, byte cantRuedas, string patente):base( patente, cantRuedas, marca)
        {
            this._tara = tara;
        }

        public string MostrarCamion() 
        {
            string returnAux;
            string auxDos = Mostrar();
            returnAux = String.Format("Camion:{0} Tara:{1}", auxDos, this._tara);

            return returnAux;
        }
    }
}
