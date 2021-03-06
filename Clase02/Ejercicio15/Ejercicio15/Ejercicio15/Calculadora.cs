﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Calculadora
    {
        public static float Calcular(string num1, string num2, string operador)
        {
            float numeroPareado1, numeroPareado2;
            float rta = 0;
            numeroPareado1 = float.Parse(num1);
            numeroPareado2 = float.Parse(num2);
            rta = Calculadora.parseOperador(numeroPareado1,numeroPareado2,rta,operador);
            return rta;
        }

        private static float parseOperador(float num1, float num2, float rta, string operador)
        {
            rta = 0;
            switch(operador){
                case "+":
                    rta = num1 + num2;
                    
                    break;
                case "-":
                    rta = num1 - num2;
                    break;
                case "*":
                    rta = num1 * num2;
                    break;
                case "/":
                    if (!Calculadora.Validar(num2)) {
                        Console.WriteLine("No se puede dividir por 0");
                        Console.ReadLine();
                    }
                    rta = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Operador no valido");
                    Console.ReadLine();
                    break;
            }

            return rta;

        }

        private static Boolean Validar(float num2)
        {
            Boolean retorno = false;
            if (num2 != 0) {
                retorno = true;
                return retorno;
            }
            return retorno;
        }

        public static void Mostrar(float respuesta) {
            Console.WriteLine("El resultado es: {0:N}", respuesta);
            Console.ReadLine();
        }
    }
}
