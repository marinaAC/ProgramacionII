using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dolar;
using Euro;

namespace ejercicio21
{
    class Dolar
    {
        public double cantidad;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cantidad"></param>
        private Dolar(double cantidad) {
            this.cantidad = cantidad;
        }

        public static implicit operator Dolar(double cant){

            Dolar returnAux = new Dolar(cant);

            return returnAux;
        }

        public static implicit operator double(Dolar d)
        {
            return d.cantidad;
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            return (Dolar)((double)d + ((double)e * 1.3642));
        }
    }
}
