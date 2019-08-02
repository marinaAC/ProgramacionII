using System;
using System.IO;

namespace BusinessLogic
{
    /// <summary>
    /// Genera archivos de texto.
    /// </summary>
    public class Impresora
    {
        /// <summary>
        /// Ruta donde se almacenará el archivo.
        /// </summary>
        private string ruta;
        /// <summary>
        /// Indica si anexa el texto al final de un archivo existente o sobrescribe.
        /// </summary>
        private bool anexaTexto;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ruta">Ruta donde se almacenará el archivo.</param>
        /// <param name="anexaTexto">
        /// true: Anexará el texto al final de un archivo existente (si existe).
        /// false: Sobrescribirá el archivo (si existe) con el texto.
        /// </param>
        public Impresora(string ruta, bool anexaTexto)
        {
            this.ruta = ruta;
            this.anexaTexto = anexaTexto;
        } 

        /// <summary>
        /// Genera un archivo de texto.
        /// </summary>
        /// <param name="texto">Texto a almacenar en el archivo.</param>
        public void GenerarArchivo(string texto)
        {
            StreamWriter w = null;
            try
            {
                w = new StreamWriter(this.ruta, this.anexaTexto, System.Text.Encoding.UTF8);
                w.Write(texto);
            }
            catch (Exception e)
            {
                //lanzar error
            }
            finally
            {
                if (w!=null)
                {
                    w.Close();
                }
            }

        }

        public void GenerarArchivo(IImpresora imprimir)
        {
            string texto = imprimir.Imprimir();
            this.GenerarArchivo(texto);
        }
    }
}
