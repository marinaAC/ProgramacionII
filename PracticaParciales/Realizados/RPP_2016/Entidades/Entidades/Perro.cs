using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Perro: Animal
    {
        protected static int _patas;
        protected Raza raza;

        #region Constructores
        static Perro() 
        {
            _patas = 4;
        }

        public Perro(int velocidadMaxima)
            : base(_patas, velocidadMaxima)
        {
        }

        public Perro(Raza raza, int velocidadMaxima)
            : this(velocidadMaxima) 
        {
            this.raza = raza;
        }
        #endregion

        #region Metodos
        public string MostrarPerro() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Perro");
            sb.AppendFormat("\nRaza: {0}",this.raza);
            sb.AppendFormat("------------------------");
            sb.AppendFormat("{0}", base.MostrarDatos());
            sb.AppendLine();

            return sb.ToString();
        }

        public static bool operator ==(Perro p1, Perro p2)
        {
            bool returnAux = false;
            if(p1.raza == p2.raza && p1.VelocidadMaxima == p2.VelocidadMaxima)
            {
                returnAux = true;
            }
            return returnAux;
        }

        public static bool operator !=(Perro p1, Perro p2)
        {
            bool returnAux = true;
            if(p1==p2)
            {
                returnAux = false;
            }
            return returnAux;
        }
        #endregion
    }
}
