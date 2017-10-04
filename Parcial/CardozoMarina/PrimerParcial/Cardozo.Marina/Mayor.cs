using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardozo.Marina
{
    public class Mayor : Comensal
    {
        public enum eBebidas { Agua, Cerveza, Vino, Gaseosa }
        private eBebidas _bebida;

        #region Propiedades
        public eBebidas Bebida
        {
            get 
            { 
                return _bebida; 
            }
        }
        #endregion

        #region Constructor
        public Mayor(string nombre, string apellido, eBebidas bebida)
            : base(nombre, apellido) 
        {
            this._bebida = bebida;
        }
        #endregion

        #region Metodos
        public static bool operator ==(Mayor a, Mayor b)
        {
            bool returnAux = false;
            if(a.Nombre == b.Nombre && a.Apellido == b.Apellido)
            {
                returnAux = true;
            }
            return returnAux;
        }

        public static bool operator !=(Mayor a, Mayor b)
        {
            bool returnAux = true;
            if(a == b)
            {
                returnAux = false;
            }
            return returnAux;
        }

        public static explicit operator string(Mayor a)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(a.ToString());
            sb.AppendFormat("{0}", a._bebida);
            return sb.ToString();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            bool returnAux = false;
            if(obj == this)
            {
                returnAux = true;
            }
            return returnAux;
        }
        #endregion

    }
}
