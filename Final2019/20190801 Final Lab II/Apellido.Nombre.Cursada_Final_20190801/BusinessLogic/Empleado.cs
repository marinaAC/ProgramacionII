using System;
using System.Text;

namespace BusinessLogic
{
    /// <summary>
    /// Representa a un Empleado.
    /// </summary>
    public class Empleado:Usuario
    {
        public enum Area { RRHH,Sistemas,Gerencia,Finanzas }
        private Area areaTrabajo;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nombre">Nombre de la persona.</param>
        /// <param name="cuenta">Nombre de cuenta del usuario.</param>
        /// <param name="clave">Clave del usuario.</param>
        /// <param name="areaTrabajo">Área de trabajo del empleado.</param>
        public Empleado(string nombre, string cuenta, string clave, Area areaTrabajo) : base(nombre,cuenta,clave)
        {
            this.areaTrabajo = areaTrabajo;
        }

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("EMPLEADO-{0}-{1}",base.MostrarDatos(),this.areaTrabajo.ToString());
            sb.AppendLine();
            return sb.ToString();
        }
    }
}
