using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_4
{
    class Program
    {
        static void Main(string[] args)
        {   
            Sumador operacion = new Sumador();

            long aux, aux2, suma;
            int contador;
            string numeroIngresado;

            string ingreso2;

            Console.WriteLine("Ingrese el valor A: ");
            numeroIngresado = Console.ReadLine();
            aux = long.Parse(numeroIngresado);

            Console.WriteLine("Ingrese el valor B: ");
            numeroIngresado = Console.ReadLine();
            aux2 = long.Parse(numeroIngresado);

            suma = operacion.Sumar(aux,aux2);
            Console.WriteLine("La suma es: {0:N}",suma);
            Console.ReadLine();
            contador = operacion.getCantidadSumas();

            Console.WriteLine("Contador: {0:N}",contador);
            Console.ReadLine();

            Console.WriteLine("Ingrese su primera palabra: ");
            numeroIngresado = Console.ReadLine();

            Console.WriteLine("Ingrese su segunda palabra: ");
            ingreso2 = Console.ReadLine();

            ingreso2 = operacion.Sumar(numeroIngresado, ingreso2);
            Console.WriteLine(ingreso2);
            Console.ReadLine();

        }
    }
}
