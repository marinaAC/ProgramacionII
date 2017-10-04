using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardozo.Marina
{
    public class Mesa
    {
        private List<Comensal> _comensales;
        private int _numero;
        public static int capacidad;

        #region Propiedades


        public int Cantidad
        {
            get 
            { 
                return capacidad; 
            }
        }

        public List<Comensal> Comensales 
        {
            get
            {
                return _comensales;
            }
        }

        public int Numero 
        {
            get 
            {
                return _numero;
            }

            set 
            {
                _numero = value;
            }
        }
        
        #endregion

        #region Constructores
        static Mesa() 
        {
            capacidad = 12;
        }

        private Mesa() 
        {
            this._comensales = new List<Comensal>();
        }

        public Mesa(int numero):this() 
        {
            this._numero = numero;
        }
        #endregion


        #region Metodos
        public static bool operator ==(Mesa a, Mesa b)
        {
            bool returnAux = false;
            if(a._numero == b._numero)
            {
                returnAux = true;
            }
            return returnAux;
        }

        public static bool operator !=(Mesa a, Mesa b)
        {
            bool returnAux = true;
            if(a == b)
            {
                returnAux = true;
            }
            return returnAux;
        }

        public static Mesa operator +(Mesa a, Menor b)
        {
            Mesa aux = a;
            if(a.Comensales.Count >0 && a.Comensales.Count < a.Cantidad)
            {
                foreach(Comensal element in a.Comensales)
                {
                    if(element is Menor && element == b)
                    {
                        aux.Comensales.Add(b);
                    }
                }
            }
            else if (a.Comensales.Count == 0) 
            {
                aux.Comensales.Add(b);
            }

            return aux;
        }

        public static Mesa operator +(Mesa a, Mayor b)
        {
            Mesa aux = a;
            if (a.Comensales.Count > 0 && a.Comensales.Count < a.Cantidad)
            {
                foreach (Comensal element in a.Comensales)
                {
                    if (element is Mayor && element == b)
                    {
                        aux.Comensales.Add(b);
                    }
                }
            }
            else if (a.Comensales.Count == 0)
            {
                aux.Comensales.Add(b);
            }

            return aux;
        }

        public override string ToString()
        {
            string returnAux = Numero.ToString();
            return returnAux;
        }

        public static implicit operator string(Mesa a)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nMesa {0} Comensales {1}", a.ToString(), a.Cantidad);
            foreach(Comensal element in a.Comensales)
            {
                if(element.GetType() == typeof(Mayor))
                {
                    sb.AppendFormat("{0}", ((Mayor)element).ToString());
                }
                if (element.GetType() == typeof(Menor))
                {
                    sb.AppendFormat("{0} Menor", ((Menor)element).ToString());
                }
            }

            return sb.ToString();
        }

        #endregion

    }
}
