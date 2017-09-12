using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase5
{
    public class MiClase
    {
        public int valor;
        public string nombre;

        MiClase()
        {
        }
        MiClase(int valor):this()
        {
            this.valor = valor;
        }

        public MiClase(int valor, string nombre):this(valor)
        {
            this.nombre = nombre;

        }

    }

    
}
