using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio número 3";
            int numero;
            string numeroIngresado;
            int i;
            for (i = 0; i < 10; i++ )
            {
                Console.WriteLine("Ingrese el numero: ");
                numeroIngresado = Console.ReadLine();
                numero = int.Parse(numeroIngresado);
                while (numero < 0)
                {
                    Console.WriteLine("No se puede calcular, ingresar otro numero que sea mayor a 0");
                    Console.WriteLine("Ingrese el numero: ");
                    numeroIngresado = Console.ReadLine();
                    numero = int.Parse(numeroIngresado);
                }
                if (numero == 2)
                {
                    Console.WriteLine("Es un numero primo");
                    Console.ReadLine();
                }
                int moduloDos, moduloTres;
                moduloDos = numero % 2;
                moduloTres = numero % 3;
                if (moduloDos == 0 || moduloTres == 0)
                {
                    Console.WriteLine("No es un numero primo");
                    Console.ReadLine();
                }

            }
        }
    }
}
