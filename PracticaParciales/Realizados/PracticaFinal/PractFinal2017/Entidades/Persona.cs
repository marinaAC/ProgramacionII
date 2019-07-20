using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        protected string nombre;
        protected string apellido;

        public Persona(string apellido, string nombre) 
        {
            this.apellido = apellido;
            this.nombre = nombre;
        }
    }
}
