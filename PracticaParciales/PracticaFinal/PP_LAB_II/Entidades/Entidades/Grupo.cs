using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Grupo
    {
        #region Enum
        public enum TipoManada{ Unica, Mixta }
        #endregion
        #region Atributos
        protected List<Mascota> manada;
        protected string nombre;
        protected static TipoManada tipo;
        #endregion

        #region Propiedades
        public TipoManada Tipo 
        {
            set
            {
                tipo = value;
            }
        }
        #endregion

        #region Constructores
        static Grupo() 
        {
            Grupo.tipo = TipoManada.Unica;
        }

        private Grupo() 
        {
            this.manada = new List<Mascota>();
        }

        public Grupo(string nombre):this() 
        {
            this.nombre = nombre;
        }

        public Grupo(string nombre, TipoManada tipo) 
            : this(nombre) 
        {
            this.Tipo = tipo;
        }
        #endregion

        #region Metodos
        public static bool operator ==(Grupo g, Mascota m)
        {
            bool aux = false;
            foreach(Mascota element in g.manada)
            {
                if(m == element)
                {
                    aux = true;
                }
            }
            return aux;
        }

        public static bool operator !=(Grupo g, Mascota m)
        {
            bool aux = true;
            if(g == m)
            {
                aux = false;
            }

            return aux;
        }

        public static Grupo operator +(Grupo g, Mascota m)
        {
            if(g.manada.Count <= 0)
            {
                g.manada.Add(m);
            }
            else if(g!=m)
            {
                g.manada.Add(m);
            }
            return g;
        }

        public static Grupo operator -(Grupo g, Mascota m)
        {
            if(g.manada.Count > 0 && g == m)
            {
                g.manada.Remove(m);
            }
            return g;
        }

        public static implicit operator String(Grupo g)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}", g.nombre);
            sb.AppendLine();
            foreach (Mascota element in g.manada) 
            {
                sb.AppendFormat("{0}", element.ToString());
                sb.AppendLine();
            }

            return sb.ToString();
        }
        #endregion
    }
}
