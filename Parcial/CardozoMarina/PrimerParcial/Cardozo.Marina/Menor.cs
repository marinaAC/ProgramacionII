using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardozo.Marina
{
    public class Menor: Comensal
    {
        public enum eMenu { Milanesa, Hamburguesa }
        private eMenu _menu;

        #region Propiedades
        public eMenu Menu
        {
            get { return _menu; }
            set { _menu = value; }
        }
        #endregion

        #region Constructores
        private Menor(string nombre, string apellido)
            :base(nombre, apellido)
        {
        }

        public Menor(string nombre, string apellido, eMenu menu)
            : this (nombre, apellido) 
        {
            this._menu = menu;
        }
        #endregion

        #region Metodos
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("{0}", this._menu);
            return sb.ToString();
        }

        public static bool operator ==(Menor m1, Menor m2)
        {
            bool returnAux = false;
            if(m1.Nombre == m2.Nombre && m1.Apellido == m2.Apellido && m1._menu == m2._menu)
            {
                returnAux = true;
            }

            return returnAux;
        }

        public static bool operator !=(Menor m1, Menor m2)
        {
            bool returnAux = true;
            if(m1 == m2)
            {
                returnAux = true;
            }

            return returnAux;
        }

        public override string ToString()
        {
            string returnAux = this.Mostrar();
            return returnAux;
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
