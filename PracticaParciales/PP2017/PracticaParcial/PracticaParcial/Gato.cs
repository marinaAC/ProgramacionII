using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial
{
    public class Gato : Mascota
    {
        #region Constructor
        public Gato(string nombre, string raza) : base(nombre, raza) { }
        #endregion

        #region Metodos
        protected override string Ficha() 
        {
            string returnAux = base.DatosCompletos();
            return returnAux;
        }

        public static bool operator ==(Gato g1, Gato g2)
        {
            bool returnAux = false;
            if(g1.Nombre == g2.Nombre && g1.Raza == g2.Raza)
            {
                returnAux = true;
            }

            return returnAux;
        }

        public static bool operator !=(Gato g1, Gato g2)
        {
            bool returnAux = true;
            if(g1 == g2)
            {
                returnAux = false;
            }

            return returnAux;
        }

        public override string ToString()
        {
            string returnAux = Ficha();
            return returnAux;
        }

        public override bool Equals(object obj)
        {
            bool returnAux = false;
            if (obj == typeof(Gato)) 
            {
                returnAux = true;
            }
            return returnAux;
        }
        #endregion



    }
}
