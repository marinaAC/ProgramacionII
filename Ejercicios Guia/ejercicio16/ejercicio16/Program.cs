using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alum1 = new Alumno("Cardozo", "Mariana", 0001);
            Alumno alum2 = new Alumno("Cardozo", "Laura", 0002);

            alum1.Estudiar(5, 7);
            alum2.Estudiar(3,10);

            alum1.CalcularFinal();
            alum2.CalcularFinal();

            alum1.Mostrar();
            alum2.Mostrar();

        }
    }
}
