using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuesta;
            int opcion;
            Console.WriteLine("Que calculo desea hacer?: ");
            Console.WriteLine("1-Calcular el cuadrado");
            Console.WriteLine("2-Calcular el triangulo");
            Console.WriteLine("3-Calcular el circulo");
            respuesta = Console.ReadLine();
            opcion = int.Parse(respuesta);
            double valor;
            string numeroIngresado;
            switch (opcion) {
                case 1:
                    Console.WriteLine("Ingrese el numero: ");
                    numeroIngresado = Console.ReadLine();
                    valor = double.Parse(numeroIngresado);
                    valor = CalculoDelArea.CalcularCuadrado(valor);
                    Console.WriteLine("El valor del cuadrado es: {0:N}", valor);
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Ingrese el primer numero: ");
                    numeroIngresado = Console.ReadLine();
                    valor = double.Parse(numeroIngresado);
                    double valor2;
                    Console.WriteLine("Ingrese el segundo numero: ");
                    numeroIngresado = Console.ReadLine();
                    valor2 = double.Parse(numeroIngresado);
                    valor = CalculoDelArea.CalcularTriangulo(valor,valor2);
                    Console.WriteLine("El resultado es: {0.N}", valor);
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Ingrese el numero: ");
                    numeroIngresado = Console.ReadLine();
                    valor = double.Parse(numeroIngresado);
                    valor = CalculoDelArea.CalcularCircula(valor);
                    Console.WriteLine("El valor del circulo es: {0:N}", valor);
                    Console.ReadLine();
                    break;
            }

        }
    }
}
