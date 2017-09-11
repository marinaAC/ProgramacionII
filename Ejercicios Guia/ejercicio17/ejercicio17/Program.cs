using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio17
{
    class Program
    {

        static void Main(string[] args)
        {
            
            Cuenta cuenta1 = new Cuenta("primera","000AAA1",20000,ETipoInteres.TAE);

            Console.WriteLine("Nombre de la cuenta: {0}", cuenta1.getNombre());
            Console.ReadLine();
        }
    }
}
