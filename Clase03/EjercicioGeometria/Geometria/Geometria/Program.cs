using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria;

namespace PruebaGeometria
{
    class Program
    {
        static void Main(string[] args)
        {
            string valorIngresado;
            int valor1;
            int valor2;
            int valor3;
            int valor4;

            Console.WriteLine("Ingrese el valor de x: ");
            valorIngresado = Console.ReadLine();
            valor1 = int.Parse(valorIngresado);

            Console.WriteLine("Ingrese el valor de x: ");
            while(!int.TryParse(Console.ReadLine(),out valor2)){
                Console.WriteLine("Error en el parametro");
            }

            Console.WriteLine("Ingrese el valor de y: ");
            while (!int.TryParse(Console.ReadLine(), out valor3))
            {
                Console.WriteLine("Error en el parametro");
            }

            Console.WriteLine("Ingrese el valor de y: ");
            while (!int.TryParse(Console.ReadLine(), out valor4))
            {
                Console.WriteLine("Error en el parametro");
            }

            Rectangulo rectangulo = new Rectangulo(new Punto(valor1, valor3), new Punto(valor2, valor4));

            Console.WriteLine("Area: {0:N}", rectangulo.area);
            Console.WriteLine("Perimetro: {0:N}", rectangulo.perimetro);
            Console.ReadLine();
        }
    }
}
