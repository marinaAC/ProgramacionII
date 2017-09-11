using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresadoUno = "";
            string numeroIngresadoDos = "";
            float respuesta;
            string operaciones = "";
            string mensajeIngreso = "Ingrese el numero con el que desea operar: ";
            string operadorString = "Ingrese el operador que desea utilizar: ";

            numeroIngresadoUno = Consulta(mensajeIngreso);
            numeroIngresadoDos = Consulta( mensajeIngreso);
            operaciones = Consulta(operadorString);
            respuesta = Calculadora.Calcular(numeroIngresadoUno, numeroIngresadoDos, operaciones);
            Calculadora.Mostrar(respuesta);

            
        }

        static string Consulta(string men) {
            string var;
            Console.WriteLine(men);
            var = Console.ReadLine();
            return var;
        }

    }
}
