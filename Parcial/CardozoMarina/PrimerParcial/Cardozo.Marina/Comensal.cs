using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardozo.Marina
{
    public abstract class Comensal
    {
        private string _nombre;
        private string _apellido;

        #region Propiedades

        public string Nombre
        {
            get 
            { 
                return _nombre; 
            }
        }

        public string Apellido 
        {
            get 
            {
                return _apellido;
            }
        }
        
        #endregion

        #region Constructores
        public Comensal(string nombre, string apellido) 
        {
            this._apellido = apellido;
            this._nombre = nombre;
        }
        #endregion

        #region Metodos
        public virtual string Mostrar() 
        {
            string returnAux = string.Format("Nombre: {0}, Apellido{0}", this._nombre, this._apellido);
            return returnAux;
        }
        #endregion

    }
}
