using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Carrera
    {
        protected List<Animal> _listAnimales;
        protected int _corredoresMaximo;

        #region Constructores
        private Carrera() 
        {
            this._listAnimales= new List<Animal>();
        }

        public Carrera(int corredoresMaximo):this() 
        {
            this._corredoresMaximo = corredoresMaximo;
        }
        #endregion

        #region Metodos
        public static bool operator ==(Carrera c, Animal a)
        {
            bool returnAux = false;
            if(c._listAnimales.Count >0)
            {
                foreach(Animal element in c._listAnimales)
                {
                    if(element.GetType() == a.GetType() && element == a)
                    {
                        returnAux = true;
                        break;
                    }
                }
            }
            return returnAux;
        }

        public static bool operator !=(Carrera c, Animal a)
        {
            bool returnAux = true;
            if(c==a)
            {
                returnAux = false;
            }
            return returnAux;
        }

        public static Carrera operator +(Carrera c, Animal a)
        {
            Carrera aux = null;
            if (c != a && c._corredoresMaximo > c._listAnimales.Count)
            {
                aux = c;
                aux._listAnimales.Add(a);
            }
            else 
            {
                aux = c;
            }
            return aux;
        }

        public string MostrarCarrera() 
        {
            StringBuilder sb = new StringBuilder();
            int i;
            sb.AppendFormat("Carrera---------------------");
            sb.AppendFormat("\nCantidad de corredores {0}",this._corredoresMaximo);
            for (i = 0; i < this._listAnimales.Count;i++ )
            {
                if(this._listAnimales[i] is Perro)
                {
                    sb.AppendFormat("{0}",((Perro)this._listAnimales[i]).MostrarPerro());
                }
                if(this._listAnimales[i] is Humano)
                {
                    sb.AppendFormat("{0}",((Humano)this._listAnimales[i]).MostrarHumano());
                }
                if(this._listAnimales[i] is Caballo)
                {
                    sb.AppendFormat("{0}",((Caballo)this._listAnimales[i]).MostrarCaballo());
                }
            }
            sb.AppendLine("------------------------------------------------");
            return sb.ToString();
        }
        #endregion
    }
}
