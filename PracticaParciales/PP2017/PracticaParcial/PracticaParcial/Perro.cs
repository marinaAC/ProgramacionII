using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial
{
    public class Perro : Mascota
    {
        protected int edad;
        protected bool esAlfa;

        #region Propiedades
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
        #endregion 

        #region Constructores
        /*
        public Perro() 
        {
            this.edad = 0;
            this.esAlfa = false;
        }*/

        public Perro(string nombre, string raza, int edad, bool esAlfa) 
            : base(nombre, raza)
        {
            this.edad = edad;
            this.esAlfa = esAlfa;
        }
        #endregion

        #region Metodos
        public static bool operator ==(Perro p1, Perro p2)
        {
            bool returnAux = false;
            if(p1.Edad == p2.Edad && p1.Nombre == p2.Nombre && p1.Raza == p2.Raza)
            {
                returnAux = true;
            }
            return returnAux;
        }

        public static bool operator !=(Perro p1, Perro p2)
        {
            bool returnAux = true;
            if(p1 == p2)
            {
                returnAux = false;
            }
            return returnAux;
        }

        public static explicit operator int(Perro p1)
        {
            return p1.Edad;
        }


        protected override string Ficha() 
        {
            string returnAux, aux;
            aux = base.DatosCompletos();
            if (this.EsAlfa == true)
            {
                string alfa = "es alfa de la manada";
                returnAux = string.Format("{0}, {1}, Edad: {2:N}", aux, alfa, this.edad);
            }
            else 
            {
                returnAux = string.Format("{0}, Edad: {1:N}", aux, this.edad);
            }
            
            return returnAux;
        }

        public override string ToString()
        {
            string returnAux = Ficha();
            return returnAux;
        }

        //Preguntar
        public override bool Equals(Object obj)
        {
            bool returnAux = false;
            if(obj == typeof (Perro))
            {
                returnAux = true;
            }
            return returnAux;
        }

        #endregion


    }
}
