using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            string continuar = "s";
            string numero;
            while(continuar == "s" || continuar == "S"){
                Console.WriteLine("Ingrese el numero: ");
                numero = Console.ReadLine();
                Console.WriteLine("Desea continuar S/N: ");
                if (!ValidarRespuesta.ValidarS_N())
                    continuar = "N";
            }
        }
    }
}
