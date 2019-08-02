using System;

namespace BusinessLogic
{
    [Serializable]
    /// <summary>
    /// Representa a una persona. No debe poderse instanciar, sólo heredar. 
    /// </summary>
    /// 
    public abstract class Persona
    {
        /// <summary>
        /// Nombre de la persona.
        /// </summary>
        private string nombre;
        
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="nombre">Nombre de la persona.</param>
        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        /// <summary>
        /// Constructor publico sin parametros para que pueda serializarse
        /// </summary>
        public Persona() { }

        public virtual string MostrarDatos() {
            return this.nombre;
        }
    }
}
