using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace BusinessLogic
{
    /// <summary>
    /// Serialización a XML.
    /// </summary>
    /// <typeparam name="T">Clase a serializar. Debe tener un constructor sin parámetros.</typeparam>
    public sealed class Serializador<T> where T : class, new()
    {
        /// <summary>
        /// Ruta donde se guardará el archivo.
        /// </summary>
        private string ruta;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ruta">Ruta donde se guardará el archivo.</param>
        public Serializador(string ruta)
        {
            this.ruta = ruta;
        }

        public void Serializar(T objeto)
        {
            XmlTextWriter xml = null;
            try
            {
                xml = new XmlTextWriter(this.ruta,System.Text.Encoding.UTF8);
                XmlSerializer ser = new XmlSerializer(typeof(T));
                ser.Serialize(xml, objeto);
            }
            catch (Exception e)
            {
               //tratar la exception

            }
            finally
            {
                if (xml != null)
                {
                    xml.Close();
                }
            }
        }

        public T Deserializar()
        {
            XmlTextReader reader = null;
            T objeto = null;
            try
            {
                reader = new XmlTextReader(this.ruta);
                XmlSerializer ser = new XmlSerializer(typeof(T));
                objeto = (T)ser.Deserialize(reader);
            }
            catch (Exception e)
            {
                objeto = default(T); 
            }
            finally
            {
                if (reader!=null) {
                    reader.Close();
                }
            }
            return objeto;
        }

    }
}
