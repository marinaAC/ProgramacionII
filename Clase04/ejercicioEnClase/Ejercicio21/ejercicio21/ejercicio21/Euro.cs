using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio21
{
    class Euro
    {
        private int _cantidad;

        private Euro(int cantidad) {
            this._cantidad = cantidad;
        }

        public static Euro operator + (Euro euro, Dolar dolar){
            Euro aux;
            aux = euro + dolar * 1.3642;
            return aux;
        }

    }
}
