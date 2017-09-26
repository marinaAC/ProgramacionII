using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaParcial
{
    class Perro:Animal
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
            string aux = MostrarDatos();
            returnAux = string.Concat("{0}");
            return returnAux;
        }
        #endregion
    }
}
