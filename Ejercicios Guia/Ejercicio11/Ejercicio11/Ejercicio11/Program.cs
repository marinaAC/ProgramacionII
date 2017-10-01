using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, auxNum;
            int[] numerosIngresados = new int[10];
            string ingresoTeclado;
            int max = 100;
            int min = -100;
            int suma = 0;
            float promedio;
            for (i = 0; i < 10; i++ )
            {
                Console.WriteLine("Ingrese su numero: ");
                ingresoTeclado = Console.ReadLine();
                auxNum = int.Parse(ingresoTeclado);
                if(!Validation.Validar(min,max,auxNum)){
                    Console.WriteLine("Error: El numero no se encuentra en el rango");
                    Console.ReadLine();
                }
                numerosIngresados[i] = auxNum;
                suma = suma + auxNum;
            }

            promedio = (float)suma / 10;

            for (i = 0; i < 10; i++){
                min = numerosIngresados[0];
                max = numerosIngresados[0];
                if(numerosIngresados[i]<min){
                    min = numerosIngresados[i];
                }
                
                if(numerosIngresados[i]>max){
                    max = numerosIngresados[i];
                }
            }

            Console.WriteLine("El valor minimo es: {0:N}", min);
            Console.WriteLine("El valor minimo es: {0:N}", max);
            Console.WriteLine("El valor minimo es: {0:N}", promedio);
            Console.ReadLine();

        }

       
    }
}
