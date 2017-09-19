using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases
{
    class Vehiculo
    {
        protected string _patente;
        protected byte _cantRuedas;
        protected EMarca _marca;

        public Vehiculo(string patente, byte ruedas, EMarca marca) 
        {
            this._cantRuedas = ruedas;
            this._marca = marca;
            this._patente = patente;
        }

        protected string Mostrar() 
        {
            string resultAux = string.Format("Marca: {0} Patente: {1} Cantidad de Ruedas: {2}",this._marca,this._patente,this._cantRuedas);
            return resultAux;
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            bool returnAux = false;
            if(v1._patente == v2._patente && v1._marca == v2._marca)
            {
                returnAux = true;
            }
            return returnAux;
        }
    }
}
