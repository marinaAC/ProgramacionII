using System;
using System.Text;

namespace BusinessLogic
{
    /// <summary>
    /// Representa a un usuario externo a la empresa.
    /// </summary>
    public class Externo:Usuario
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="nombre">Nombre de la persona.</param>
        /// <param name="cuenta">Nombre de la cuenta del usuario.</param>
        public Externo(string nombre, string cuenta):base(nombre,cuenta)
        {

        }

        /// <summary>
        /// Constructor publico sin parametros para que pueda serializarse
        /// </summary>
        public Externo() { }

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}-{1}",this.Clave,base.MostrarDatos());
            sb.AppendLine();
            return sb.ToString();
        }
    }
}
