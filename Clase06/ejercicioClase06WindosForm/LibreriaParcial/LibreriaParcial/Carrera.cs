using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaParcial
{
    class Carrera
    {
        protected List<Animal> animales;
        protected int corredoresMax;


        #region Constructores
        private Carrera()
        {
            animales = new List<Animal>();
        }

        public Carrera(int corredores) : this()
        {
            this.corredoresMax = corredores;
        }
        #endregion

        #region Metodos
        public static bool operator ==(Carrera c1, Animal a1)
        {
            bool returnAux = false;
            foreach (Animal element in c1.animales)
            {
                if (element.GetType() == a1.GetType() && element == a1)
                {
                    returnAux = true;
                    break;
                }
                 
                /*Una forma mas extensa de comparar
                if (element is Perro && a1 is Perro)
                {
                    if (element == a1)
                    {
                        returnAux = true;
                        break;
                    }
                }
                else if (element is Caballo && a1 is Caballo)
                {
                    if (element == a1)
                    {
                        returnAux = true;
                        break;
                    }
                }
                else
                {
                    if (element == a1)
                    {
                        returnAux = true;
                        break;
                    }
                }*/
            }
            return returnAux;
        }

        public static bool operator !=(Carrera c, Animal a)
        {
            bool returnAux = true;
            if (c==a)
            {
                returnAux = false;
            }
            return returnAux;
        }

        /** Preguntar
        public static Carrera operator +(Carrera c, Animal a)
        {
            if (c != a && c.corredoresMax > 0)
            {
                c.animales.Add(a);
            }
        }
         * 
         * Retorno una nueva carrera, ya que lo que hago es una nueva carrera con una nueva lista
        
        public string MostarCarrera(Carrera c)
        {
            //c.animales.Count
            //stringbuilder, consola -> tostring
           /* string resultAux;
            resultAux = mostrarDatos();
            return resultAux;
        }
        */
        #endregion

        
    }
}
