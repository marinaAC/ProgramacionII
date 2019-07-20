using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Mascota
    {
        #region Atributos
        protected string nombre;
        protected string raza;
        #endregion

        #region Propiedades
        public string Nombre 
        {
            get 
            {
                return nombre;
            } 
        }

        public string Raza 
        {
            get 
            {
                return raza;
            }    
        }
        #endregion

        #region Constructor

        public Mascota(string nombre, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }
        #endregion

        #region Metodos
        protected abstract string Ficha();

        protected virtual string DatosCompletos()
        {
            string aux = string.Format("{0}, {1}",this.Nombre,this.Raza);
            return aux;
        }
        #endregion
    }
}
