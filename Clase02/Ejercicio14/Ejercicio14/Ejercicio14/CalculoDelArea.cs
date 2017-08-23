using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class CalculoDelArea
    {
        public static double CalcularCuadrado(double num) {
            double rta;
            rta = num * num;
            return rta;
        }

        public static double CalcularTriangulo(double num, double num2) { 
            double rta;
            rta = (num*num2)/2;
            return rta;
        }

        public static double CalcularCircula(double num){
            double rta;
            rta = (num * num) * 3.14;
            return rta;
        }
    }
}
