using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases
{
    class Auto:Vehiculo
    {
        protected int _cantidadAsientos;
        
       
        public Auto(int cantidadAsientos,EMarca marca, byte cantRuedas, string patente) : base(patente,cantRuedas,marca) 
        {
            this._cantidadAsientos = cantidadAsientos;
        }

        public string MostrarAuto()
        {
            string returnAux;
            string auxDos = Mostrar();
            returnAux = String.Format("Auto:{0} Cantidad de Asientos{1}", auxDos, this._cantidadAsientos);

            return returnAux;
        }

    }
}
