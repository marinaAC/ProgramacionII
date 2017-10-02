using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaParcial
{
    public class Caballo:Animal
    {
        protected static int patas;
        protected string nombre;

        #region Constructores
        static Caballo()
        {
            patas = 4;
        }

        public Caballo(string nombre, int velocidadMaxima) : base(patas, velocidadMaxima)
        {
            this.nombre = nombre;
        }
        #endregion

        #region Metodos
        public string MostrarCaballo()
        {
            string aux = base.MostrarDatos();
            string resultAux = string.Format("Nombre: {0}, Patas: {1}, {2}",this.nombre,patas, aux);
            return resultAux;
        }

        public static bool operator ==(Caballo c1, Caballo c2)
        {
            bool returnAux = false;
            if (c1.nombre == c2.nombre)
            {
                returnAux = true;
            }
            return returnAux;
        }

        public static bool operator !=(Caballo c1, Caballo c2)
        {
            bool returnAux = true;
            if (c1 == c2)
            {
                returnAux = false;
            }
            return returnAux;
        }
        #endregion


    }
}
