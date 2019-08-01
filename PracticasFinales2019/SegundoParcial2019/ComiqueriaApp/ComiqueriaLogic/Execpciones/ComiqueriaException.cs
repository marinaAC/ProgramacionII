using ComiqueriaLogic.Interfaces;
using ComiqueriaLogic.Serializador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic.Execpciones
{
    class ComiqueriaException : Exception, IArchivoTexto
    {
        public ComiqueriaException(string mensaje, Exception innerException) : base(mensaje,innerException) {
            ArchivoTexto.Escribir(this,true);
        }

        #region propiedadesImplementadas
        public string Ruta
        {
            get {
                return String.Format("{0}log.txt", Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            }    
        }

        public string Texto{

            get {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(DateTime.Now.ToString() + ": ");
                sb.AppendLine(this.Message);
                Exception e = this.InnerException;
                while (e != null) {
                    sb.AppendLine(e.Message);
                    e = e.InnerException;
                }
                return sb.ToString();
            }
           

        }
        #endregion
    }
}
