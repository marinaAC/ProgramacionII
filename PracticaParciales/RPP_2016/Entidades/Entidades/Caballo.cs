using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Caballo: Animal
    {
        protected string _nombre;
        protected static int _patas;

        #region Constructores
        static Caballo() 
        {
            _patas = 4;
        }

        public Caballo(int velocidadMaixma)
            :base(_patas,velocidadMaixma) 
        {
        }

        public Caballo(string nombre, int velocidadMaxima)
            : this(velocidadMaxima) 
        {
            this._nombre = nombre;
        }
        #endregion

        #region Metodos
        public string MostrarCaballo() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Caballo");
            sb.AppendFormat("\nNombre: {0}", this._nombre);
            sb.AppendFormat("----------------------------");
            sb.AppendFormat("{0}", base.MostrarDatos());
            sb.AppendLine();
            return sb.ToString();
        }

        public static bool operator ==(Caballo c1, Caballo c2)
        {
            bool returnAux = false;
            if(c1._nombre==c2._nombre)
            {
                returnAux = true;
            }

            return returnAux;
        }

        public static bool operator !=(Caballo c1, Caballo c2)
        {
            bool returnAux = true;
            if(c1 == c2)
            {
                returnAux = false;
            }
            return returnAux;
        }
        #endregion
    }
}
