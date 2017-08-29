using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            Boligrafo lapiceraAzul = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo lapiceraRoja = new Boligrafo(50,ConsoleColor.Red);

            lapiceraAzul.Pintar(20);
            Console.WriteLine("La cantidad de tinta que tiene la lapicera Azul es: {0:N}",lapiceraAzul.getTinta());
            Console.ReadLine();

            lapiceraRoja.Recargar();
            Console.WriteLine("La cantidad de tinta que tiene la lapicera Roja es: {0:N}", lapiceraRoja.getTinta());
            Console.ReadLine();

            lapiceraAzul.Recargar();
            Console.WriteLine("La cantidad de tinta que tiene la lapicera Azul es: {0:N}", lapiceraAzul.getTinta());
            Console.ReadLine();

            lapiceraAzul.Recargar(ConsoleColor.Red);
            Console.WriteLine("El color de la anterior lapicera azul es: {0:N}", lapiceraAzul.getColor().ToString());
            Console.ReadLine();

            lapiceraAzul.Recargar(ConsoleColor.Gray);
            Console.WriteLine("El color de la anterior lapicera azul es: {0:N}", lapiceraAzul.getColor().ToString());
            Console.ReadLine();
        }
    }
}
