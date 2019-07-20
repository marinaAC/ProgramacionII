using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gato: Mascota
    {
        #region Constructor
        public Gato(string nombre, string raza) 
            : base(nombre, raza) { }
        #endregion
        #region Metodos

        protected override string Ficha()
        {
            return this.DatosCompletos();
        }

        public static bool operator ==(Gato g1, Gato g2)
        {
            bool aux = false;
            if(g1.Nombre == g2.Nombre && g1.Raza == g2.Raza)
            {
                aux = true;
            }
            return aux;
        }

        public static bool operator !=(Gato g1, Gato g2)
        {
            bool aux = true;
            if(g1 == g2)
            {
                aux = false;
            }

            return aux;
        }

        public override string ToString()
        {
            return this.Ficha();
        }

        public override bool Equals(object obj)
        {
            bool aux = false;
            if (this == obj) 
            {
                aux = true;
            }
            return aux;
        }
        #endregion
     
    }
}
