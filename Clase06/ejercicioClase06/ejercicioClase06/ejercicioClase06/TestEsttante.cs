using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioClase06
{
    class TestEsttante
    {
        static void Main(string[] args)
        {
            // Creo un estante 
            Estante estante = new Estante(3, 1); 
            // Creo 4 productos 
            Producto p1 = new Producto("Pepsi", "PESDS97413", (float)10.5); 
            Producto p2 = new Producto("Coca-Cola", "COSDS55752", (float)10.5); 
            Producto p3 = new Producto("Manaos", "MASDS51292", (float)10.5); 
            Producto p4 = new Producto("Crush", "CRSDS54861", (float)10.5);

            // Agrego los productos al estante 
            if (estante + p1) 
            { 
                Console.WriteLine("Agregó {0} {1} {2}", p1.GetMarca(), (string)p1, p1.GetPrecio()); 
            }
            else 
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p1.GetMarca(), (string)p1, p1.GetPrecio()); 
            } 
            
            if (estante + p1) 
            { 
                Console.WriteLine("Agregó {0} {1} {2}", p1.GetMarca(), (string)p1, p1.GetPrecio()); 
            } 
            else 
            { 
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p1.GetMarca(), (string)p1, p1.GetPrecio()); 
            } 
            
            if (estante + p2) 
            { 
                Console.WriteLine("Agregó {0} {1} {2}", p2.GetMarca(), (string)p2, p2.GetPrecio()); 
            } 
            else 
            { 
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p2.GetMarca(), (string)p2, p2.GetPrecio()); 
            } 
            
            if (estante + p3) 
            { 
                Console.WriteLine("Agregó {0} {1} {2}", p3.GetMarca(), (string)p3, p3.GetPrecio()); 
            } 
            else 
            { 
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p3.GetMarca(), (string)p3, p3.GetPrecio()); 
            } 

            if (estante + p4) 
            {
                Console.WriteLine("Agregó {0} {1} {2}", p4.GetMarca(), (string)p4, p4.GetPrecio()); 
            } 
            else 
            { 
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p4.GetMarca(), (string)p4, p4.GetPrecio()); 
            }
            /*
            // Muestro todo el estante 
            Console.WriteLine(); 
            Console.WriteLine("<------------------------------------------------->"); 
            Console.WriteLine(Estante.MostrarEstante(estante));
            Console.ReadKey();

            */
            Producto p11 = new Producto("Pepsi", "PESDS97413", (float)10.5);
            Producto p22 = new Producto("Coca-Cola", "COSDS55752", (float)10.5); 
            List<Producto> listaProd = new List<Producto>();
            listaProd.Add(p11);
            listaProd.Add(p22);

            foreach(Producto prod in listaProd)
            {
                Console.WriteLine("Nombre: {0}", prod.GetMarca());
                Console.ReadLine();
            }

            Dictionary<int, Producto> dProducto = new Dictionary<int, Producto>();
            dProducto.Add(0,p11);
            dProducto.Add(1, p22);

        }
    }
}
