using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio22
{
    class Fahrenheit
    {
        public double cantidad;

        private Fahrenheit(double cantidad) 
        {
            this.cantidad = cantidad;
        }

        /// <summary>
        /// Sobre escribe el constructor privado para instanciarlo desde ahi adentro
        /// </summary>
        /// <param name="cant">la cantidad para inicializarlo</param>
        /// <returns>un objeto de tipo Fahrenheit</returns>
        public static implicit operator Fahrenheit(double cant)
        {
            Fahrenheit returnAux = new Fahrenheit(cant);

            return returnAux;
        }


    }
}
