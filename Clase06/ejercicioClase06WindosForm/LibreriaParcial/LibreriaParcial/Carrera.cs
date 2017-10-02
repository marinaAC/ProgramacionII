using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaParcial
{
    public class Carrera
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

        
        public static Carrera operator +(Carrera c, Animal a)
        {
            Carrera carreraN = new Carrera();
            if (c != a && c.corredoresMax >= 0)
            {
                carreraN = c;
                carreraN.animales.Add(a);
            }
            return carreraN;
        }
         /* 
         * Retorno una nueva carrera, ya que lo que hago es una nueva carrera con una nueva lista
        */
        public string MostarCarrera(Carrera c)
        {
            //c.animales.Count
            //stringbuilder, consola -> tostring
            //chequear
            StringBuilder listaMostrar = new StringBuilder();
            int i;
            for (i = 0; i < c.animales.Count;i++ )
            {
                if (c.animales[i] is Humano) 
                {
                    listaMostrar.AppendFormat("{0}",c.animales[i].MostrarDatos());
                    listaMostrar.AppendLine();
                }
            }
            
            return listaMostrar.ToString();
        }
        
        #endregion

        
    }
}
