using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ejercicio47
{
    class Program
    {
        static void Main(string[] args)
        {
            Contabilidad<Factura, Recibo> cont = new Contabilidad<Factura, Recibo>();

            Factura fac1 = new Factura(20);
            Recibo rec = new Recibo(50);

            cont = cont + fac1;
            
            Console.WriteLine("{0}", cont.CantidadT);
            Console.ReadLine();
        }
    }
}
