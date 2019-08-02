using System;
using System.Xml.Serialization;

namespace BusinessLogic
{
    [Serializable]
    /// <summary>
    /// Representa a la cuenta de un usuario del sistema.
    /// </summary>
    [XmlInclude(typeof(Empleado))]
    [XmlInclude(typeof(Externo))]
    public class Usuario:Persona
    {
        /// <summary>
        /// Nombre de la cuenta.
        /// </summary>
        private string cuenta;
        /// <summary>
        /// Contraseña.
        /// </summary>
        private string clave;

        /// <summary>
        /// Constructor publico sin parametros para que pueda serializarse
        /// </summary>
        public Usuario() { }

        protected Usuario(string nombre, string cuenta, string clave):base(nombre)
        {
            this.cuenta = cuenta;
            this.clave = clave;
        }

        protected Usuario(string nombre, string cuenta) : this(nombre,cuenta,"EXTERNO") { }
        /// <summary>
        /// Nombre de la cuenta.
        /// </summary>
        public string Cuenta
        {
            get
            {
                return this.cuenta;
            }
            set
            {
                this.cuenta = value;
            }
        }

        /// <summary>
        /// Contraseña.
        /// </summary>
        public string Clave
        {
            get
            {
                return this.clave;
            }
            set
            {
                this.clave = value;
            }
        }
    }
}
