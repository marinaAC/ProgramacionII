using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio56
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona person1 = new Persona("Pedro", "Perez");
            Persona.Guardar(person1);
            Persona aux = person1.Leer();
            Console.WriteLine("{0}", aux.ToString());
            Console.ReadLine();

        }
    }
}
