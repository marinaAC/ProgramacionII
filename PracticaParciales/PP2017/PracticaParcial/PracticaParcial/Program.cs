using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            Grupo g = new Grupo("Prueba1", Grupo.TipoManada.MIXTA);
            Mascota perro = new Perro("Negro", "Labrador", 10, false);
            g = g + perro;
            string aux = (string)g;
            Console.WriteLine(aux);
            Console.ReadLine();

            Gato gato = new Gato("Chiqui","de la calle");
            g = g + gato;
            string aux2 = (string)g;
            Console.WriteLine(aux2);
            Console.ReadLine();

            Grupo g2 = new Grupo("Mis mascotas", Grupo.TipoManada.MIXTA);
            Gato milo = new Gato("Mimi", "de la calle");
            g2 = g2 + milo;
            string aux3 = (string)g2;
            Console.WriteLine(aux3);
            Console.ReadLine();


            
        }
    }
}
