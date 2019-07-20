using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace TestExamen
{
    class Program
    {
        static void Main(string[] args)
        {
            Grupo g1 = new Grupo("Mascotas Cardozo", Grupo.TipoManada.Mixta);
            Perro negro = new Perro("Negro", "Labrador", 12, false);
            Perro rock = new Perro("Rocky", "LaCalle", 10, true);
            Gato lupe = new Gato("Lupe", "LaCalle");

            g1 = g1 + negro;
            g1 = g1 + rock;

            string lista = (string)g1;
            Console.WriteLine("{0}",lista);
            Console.ReadLine();
            g1 = g1 + lupe;

            lista = (string)g1;
            Console.WriteLine("{0}", lista);
            Console.ReadLine();

            g1 = g1 - negro;

            lista = (string)g1;
            Console.WriteLine("{0}", lista);
            Console.ReadLine();
        }
    }
}
