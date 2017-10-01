using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio numero 1";
            

            int[] datos = new int[5];
            string ingresados;
            int valorGuardar;
            int valorMinimo = 0; 
            int valorMaximo = 0;
            int flag = 0;
            int suma = 0;
            float promedio;
            int i;
            for (i = 0; i < 5;i++ )
            {   
                Console.WriteLine("Ingrese un numero");
                ingresados = Console.ReadLine();
                valorGuardar = int.Parse(ingresados);
                datos[i] = valorGuardar;
            }

            for (i = 0; i < 5; i++ )
            {   
                if(flag == 0){
                    valorMaximo = datos[i];
                    valorMinimo = datos[i];
                    flag = 1;
                }
                if (datos[i] > valorMaximo)
                {
                    valorMaximo = datos[i];
                }
                if(valorMinimo > datos[i]){
                    valorMinimo = datos[i];
                }
                suma = datos[i] + suma;
            }

            promedio = suma / 5;

            Console.WriteLine("El valor maximo es: {0:N}",valorMaximo);
            Console.WriteLine("El valor minimo es: {0:N}", valorMinimo);
            Console.WriteLine("El promedio es de: {0:#.00}", promedio);
            Console.ReadLine();


 

        }
    }
}
