using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    /// <summary>
    /// Métodos de extensión.
    /// </summary>
    public static class Extension
    {
        public static string ListarUsuarios(this String value,List<Usuario>lista)
        {
            StringBuilder sb = new StringBuilder();
            if (!object.ReferenceEquals(lista,null))
            {
                foreach (Usuario u in lista)
                {
                    // POLIMORFISMO
                    sb.AppendLine(u.MostrarDatos());
                    /*if (u is Externo)
                    {
                        sb.AppendLine(((Externo)u).MostrarDatos());
                    } else if (u is Empleado) {
                        sb.AppendLine(((Empleado)u).MostrarDatos());
                    }*/
                }
                
            }
            return sb.ToString();
        }
    }
}
