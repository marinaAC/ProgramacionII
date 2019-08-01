using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic.Comun
{
    /// <summary>
    /// Clase Estatica que contendra un metodo de extension de double para formatear su valor
    /// </summary>
    public static class ExtensionNumerica
    {
        /// <summary>
        /// Metodo de extension
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static string FormatearPrecio(this Double valor) {
            return String.Format("$(0:0.00)", valor);
        }
    }
}
