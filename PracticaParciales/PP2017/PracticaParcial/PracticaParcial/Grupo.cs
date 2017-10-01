using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial
{
    class Grupo
    {
        public enum TipoManada { UNICA , MIXTA }
        protected string nombre;
        protected List<Mascota> listaMascota;
        protected TipoManada tipo;

        #region Constructores
        /*Preguntar como es el constructor de clase
        public static Grupo() 
        {
            this.tipo = TipoManada.UNICA;
        }
        */
        private Grupo()
        {
            this.listaMascota = new List<Mascota>();
        }

        public Grupo(string nombre)
            : this() 
        {
            this.nombre = nombre;
        }

        public Grupo(string nombre, TipoManada tipo): this(nombre) 
        {
            this.tipo = tipo;
        }
        #endregion


        #region Propiedades
        public TipoManada Tipo
        {
            set 
            { 
                this.tipo = value; 
            }
        }
        #endregion

        #region Metodos
        public static bool operator ==(Grupo g, Mascota m)
        {
            bool returnAux = false;
            foreach(Mascota element in g.listaMascota)
            {
                if (element.GetType() == m.GetType() && element == m) 
                {
                     returnAux = true;
                     break;
                }             
            }

            return returnAux;
        }

        public static bool operator !=(Grupo g,Mascota m)
        {
            bool returnAux = true;
            if(g == m)
            {
                returnAux = false;
            }
            return returnAux;
        }

        public static Grupo operator +(Grupo g, Mascota m)
        {
            Grupo aux = null;
            if(g!=m)
            {
                aux = g;
                aux.listaMascota.Add(m);
            }
            return aux;
        }

        public static Grupo operator -(Grupo g, Mascota m)
        {
            Grupo aux = null;
            if(g==m)
            {
                aux = g;
                aux.listaMascota.Remove(m);
            }
            return aux;
        }

        public static implicit operator string(Grupo g)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}",g.nombre);
            sb.AppendFormat("\nIntegrantes: \n");
            foreach(Mascota element in g.listaMascota)
            {
                sb.AppendFormat("{0}",element.ToString());
                sb.AppendLine();
            }
            sb.AppendLine();
            return sb.ToString();

        }
        #endregion

    }
}
