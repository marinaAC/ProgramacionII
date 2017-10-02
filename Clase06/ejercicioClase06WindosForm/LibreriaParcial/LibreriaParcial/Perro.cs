using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaParcial
{
    public class Perro:Animal
    {
        protected static int patas;
        protected ERazas raza;

        #region Constructores
        static Perro()
        {
            patas = 4;
        }

        Perro(int velocidadMaxima) : base(patas,velocidadMaxima) { }

        public Perro(ERazas raza, int velocidadMaxima):base(patas,velocidadMaxima) 
        {
            this.raza = raza;
        }
        #endregion

        #region Metodos
        public string MostrarPerro() 
        {
            string returnAux;
            string aux = base.MostrarDatos();
            returnAux = string.Format("Raza: {0}, Patas: {1}, {2}", this.raza, this.CantidadPatas, aux);
            return returnAux;
        }

        public static bool operator ==(Perro p1, Perro p2)
        {
            bool returnAux = false;
            if (p1.raza == p2.raza && p1.velocidadMaxima == p2.velocidadMaxima)
            {
                returnAux = true;
            }
            return returnAux;
        }

        public static bool operator !=(Perro p1, Perro p2)
        {
            bool returnAux = true;
            if (p1==p2)
            {
                returnAux = false;
            }

            return returnAux;
        }
        #endregion
    }
}
