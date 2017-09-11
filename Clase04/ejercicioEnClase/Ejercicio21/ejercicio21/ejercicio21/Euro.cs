using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio21
{
    class Euro
    {
        public double cantidad;

        private Euro(double cantidad) {
            this.cantidad = cantidad;
        }

        public static explicit operator Euro(double cant)
        {
            Euro retValue = new Euro(cant);
            return retValue;
        }

        public static explicit operator double(Euro e)
        {
            return e.cantidad;
        }


        public static Euro operator + (Euro euro, Dolar dolar){
            Euro aux;
<<<<<<< HEAD

            aux = (Euro)(((double)dolar / 1.3642) + (double)euro);
            
=======
            aux = euro + dolar * 1.3642;
>>>>>>> 45daa0215986491edaba3da01509fdee013061e3
            return aux;
        }

    }
}
