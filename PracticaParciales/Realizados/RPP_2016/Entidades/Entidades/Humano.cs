using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Humano:Animal
    {
        protected string _nombre;
        protected string _apellido;
        protected static int _cantidadPiernas;

        #region Constructores
        static Humano() 
        {
            _cantidadPiernas = 2;
        }

        public Humano(int velocidadMaxima) 
            :base(_cantidadPiernas, velocidadMaxima)
        {
        }

        public Humano(string nombre, string apellido, int velocidadMaxima)
            :this(velocidadMaxima) 
        {
            this._apellido = apellido;
            this._nombre = nombre;
        } 
        #endregion

        #region Metodos
        public string MostrarHumano() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Humano");
            sb.AppendFormat("Nombre: {0}",this._nombre);
            sb.AppendFormat("Apellido: {0}", this._apellido);
            sb.AppendFormat("-----------------------------");
            sb.AppendFormat("{0}", base.MostrarDatos());
            return sb.ToString();
        }

        public static bool operator ==(Humano h1, Humano h2)
        {
            bool returnAux=false;
            if(h1._nombre == h2._nombre && h1._apellido == h2._apellido)
            {
                returnAux = true;
            }
            return returnAux;
        }

        public static bool operator !=(Humano h1, Humano h2)
        {
            bool returnAux = true;
            if(h1 == h2)
            {
                returnAux = false;
            }
            return returnAux;
        }
        #endregion
    }
}
