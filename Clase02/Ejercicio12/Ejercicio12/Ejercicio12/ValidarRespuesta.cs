using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class ValidarRespuesta
    {
        public static Boolean ValidarS_N(){
            string letra;
            letra = Console.ReadLine();
            Boolean rta = false;
            if (letra == "S" || letra == "s") {
                rta = true;
            }
            if(letra == "N" || letra == "n"){
                rta = false;
            }

            return rta;
        }
    }
}
