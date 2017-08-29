using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int valor1, valor2, valor3;
            string numeroIngresado;
            valor1 = 0;
            valor2 = 0;
            valor3 = 0;
           /* Console.WriteLine("Ingrese el valor: ");
            numeroIngresado = Console.ReadLine();
            valor1 = int.Parse(numeroIngresado);
            Console.WriteLine("Ingrese el valor: ");
            numeroIngresado = Console.ReadLine(                                                                                                                                                                                                                   );
            valor2 = int.Parse(numeroIngresado);
            Console.WriteLine("Ingrese el valor: ");
            numeroIngresado = Console.ReadLine();
            valor3 = int.Parse(numeroIngresado);

            Calculadora calculo = new Calculadora(valor1, valor2, valor3);

            int rta = 0;
            rta = calculo.suma();
            Console.WriteLine("La suma es: {0:N}", rta);
            Console.ReadLine();

            Calculadora calculo2 = new Calculadora(valor2, valor1, valor3);

            rta = calculo2.suma();

            Console.WriteLine("La suma del calculo dos es: {0:N}", rta);
            Console.ReadLine();
            */
            int i;
            int rta = 0;
            int flag = 0;
            for (i = 0; i < 2; i++ )
            {
                if (flag == 0) {
                    Console.WriteLine("Ingrese el valor: ");
                    numeroIngresado = Console.ReadLine();
                    valor1 = int.Parse(numeroIngresado);
                    Console.WriteLine("Ingrese el valor: ");
                    numeroIngresado = Console.ReadLine();
                    valor2 = int.Parse(numeroIngresado);
                    Console.WriteLine("Ingrese el valor: ");
                    numeroIngresado = Console.ReadLine();
                    valor3 = int.Parse(numeroIngresado);
                    flag = 1;
                    Calculadora calculo3 = new Calculadora(valor1, valor2, valor3);
                    rta = calculo3.suma();
                    Console.WriteLine("La suma del calculo dos es: {0:N}", rta);
                    Console.ReadLine();
                }

                Calculadora calculo5 = new Calculadora(valor3, valor1, valor3);
                rta = calculo5.suma();
                Console.WriteLine("La suma del calculo: {0:N}", rta);
                Console.ReadLine();

            }




        }
    }
}
