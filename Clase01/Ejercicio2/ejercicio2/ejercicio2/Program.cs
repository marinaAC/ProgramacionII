using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            float numero;
            string numeroIngresado;
            Console.WriteLine("Ingrese un numero: ");
            numeroIngresado = Console.ReadLine();
            numero = float.Parse(numeroIngresado);
            if (numero > 0)
            {
                numero = (long)Math.Pow(numero, 2);
                Console.WriteLine("El numero al cuadrado es: {0:N}", numero);
                Console.ReadLine();
            }
            else {
                Console.WriteLine("ERROR EL NUMERO TIENE QUE SER MENOR QUE 0!!");
                Console.ReadLine();
            }
        }
    }
}
