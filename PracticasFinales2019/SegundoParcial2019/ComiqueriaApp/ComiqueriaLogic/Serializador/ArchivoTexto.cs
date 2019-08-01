using ComiqueriaLogic.Execpciones;
using ComiqueriaLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic.Serializador
{
    public abstract class ArchivoTexto
    {
        public static void Escribir(IArchivoTexto objeto, bool append) {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(objeto.Ruta, append, Encoding.UTF8);
                sw.Write(objeto.Texto);
            }
            catch (Exception e)
            {

                throw new ComiqueriaException("Error ",e);
            }
            finally
            {
                sw.Close();
            }
        }

        public static string Leer(string ruta)
        {
            StreamReader reader = null;
            string texto = null;
            try
            {
                reader = new StreamReader(ruta);
                texto = reader.ReadToEnd();
            }
            catch (Exception e)
            {
                throw new ComiqueriaException("Error ", e);
            }
            finally
            {
                if (reader!=null)
                {
                    reader.Close();
                }
            }

            return texto;
        }
    }
}
