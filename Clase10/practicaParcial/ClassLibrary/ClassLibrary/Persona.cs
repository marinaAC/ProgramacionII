using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    abstract class Persona
    {
        protected string _apellido;
        protected string _nombre;

        #region Propiedades
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        #endregion 

        #region Constructor
        public Persona(string nombre, string apellido) 
        {
            this._apellido = apellido;
            this._nombre = nombre;
        }
        #endregion

        #region Metodos
        protected abstract string FichaTecnica();

        protected virtual string NombreCompleto() 
        {
            string resultAux;
            resultAux = string.Format("{0}, {1}",this._nombre, this._apellido);
            return resultAux;
        }
        #endregion


    }
}
