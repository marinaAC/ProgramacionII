using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Perro:Mascota
    {
        #region Atributos
        protected int edad;
        protected bool esAlfa;
        #endregion

        #region Propiedades
        public int Edad 
        {
            get 
            {
                return edad;
            }
            set 
            {
                edad = value;
            } 
        }

        public bool EsAlfa 
        {
            get 
            {
                return esAlfa;
            }

            set 
            {
                esAlfa = value;
            }
        }
        #endregion

        #region Constructores
        public Perro(string nombre, string raza) 
            : base(nombre, raza) 
        {
            this.edad = 0;
            this.esAlfa = false;
        }

        public Perro(string nombre, string raza, int edad, bool esAlfa)
            : this(nombre, raza) 
        {
            this.edad = edad;
            this.esAlfa = esAlfa;
        }
        #endregion

        #region Metodos

        public static bool operator ==(Perro p1, Perro p2)
        {
            bool returnAux = false;
            if(p1.Nombre == p2.Nombre && p1.Edad == p2.Edad && p1.Raza == p2.Raza)
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

        public static explicit operator int(Perro p) 
        {
            return p.Edad;
        }


        protected override string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            string aux = this.DatosCompletos();
            string edad = this.Edad.ToString();
            if (this.EsAlfa)
            {
                sb.AppendFormat("{0}, es alfa de la manada, edad {1}", aux, edad);
                sb.AppendLine();
            }
            else 
            {
                sb.AppendFormat("{0}, edad {1}", aux, edad);
                sb.AppendLine();
            }
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Ficha();
        }

        public override bool Equals(object obj)
        {
            bool returnAux = false;
            if(this == obj)
            {
                returnAux = true;
            }
            return returnAux;
        }
        #endregion 
    }
}
