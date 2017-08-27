using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Validation
    {
        
        public static Boolean Validar(int min, int max, int valor)
        {
            Boolean rta = false;

            if(valor>min && valor<max)
                rta = true;

            return rta;
        }
        
    }
}
