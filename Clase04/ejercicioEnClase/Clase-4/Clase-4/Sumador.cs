using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_4
{
    class Sumador
    {
        private int _cantidadSumas;

        public Sumador() {
            this._cantidadSumas=0;
        }

        public Sumador(int num) {
            this._cantidadSumas = num;
        }

        public long Sumar(long a, long b) {
            long aux;
            this._cantidadSumas++;
            aux = a + b;
            return aux;
        }

        public string Sumar(string a, string b) {
            return a + b;
        }

        public int getCantidadSumas() {
            return this._cantidadSumas;
        }

        
    }
}
