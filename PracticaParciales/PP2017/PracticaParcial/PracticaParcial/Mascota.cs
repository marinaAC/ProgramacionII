using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial
{
    public abstract class Mascota
    {
        protected string nombre;
        protected string raza;

        #region Constructor
        public Mascota(string nombre, string raza) 
        {
            this.nombre = nombre;
            this.raza = raza;
        }
        #endregion

        #region Propiedades
        public string Nombre 
        { 
            get
            {
                return this.nombre;
            }
        }

        public string Raza 
        {
            get 
            {
                return this.raza;
            }
        }
        #endregion

        #region Metodos
        protected abstract string Ficha();

        protected virtual string DatosCompletos() 
        {
            string returnAux = string.Format("Nombre: {0}, Raza: {1}",this.nombre, this.raza);
            return returnAux;
        }
        #endregion

    }
}
