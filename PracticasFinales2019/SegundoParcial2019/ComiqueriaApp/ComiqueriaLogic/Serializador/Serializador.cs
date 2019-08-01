using ComiqueriaLogic.Execpciones;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ComiqueriaLogic.Serializador
{
    public abstract class Serializador<T> where T : class, new ()
    {
        public static void SerializarBinario(T objecto, string ruta) {
            FileStream fs = null;
            try
            {
                fs = new FileStream(ruta, FileMode.Create);
                BinaryFormatter ser = new BinaryFormatter();
                ser.Serialize(fs, objecto);
            }
            catch (ArgumentException a)
            {
                throw a;
            }
            catch (DirectoryNotFoundException d)
            {
                throw new ComiqueriaException("Error: Directorio no encontrado", d);
            }
            catch (Exception e)
            {
                throw new ComiqueriaException(" Ocurrio un error, contacte al administrador ",e);
            }
            finally
            {
                if (fs != null) {
                    fs.Close();
                }
            }
        }

        public static void SerializarXml(T objeto, string ruta) {
            XmlTextWriter writer = null;
            try
            {
                writer = new XmlTextWriter(ruta,Encoding.UTF8);
                XmlSerializer ser = new XmlSerializer(typeof(T));
                ser.Serialize(writer,objeto);
            }
            catch (ArgumentException a)
            {
                throw a;
            }
            catch (DirectoryNotFoundException d)
            {
                throw new ComiqueriaException("Error: Directorio no encontrado", d);
            }
            catch (Exception e)
            {
                throw new ComiqueriaException(" Ocurrio un error, contacte al administrador ", e);
            }
            finally
            {
                if (writer!=null) {
                    writer.Close();
                }
            }
        }

        public static T DeserializarXml(string ruta) {
            XmlTextReader reader = null;
            T objeto = null;
            try
            {
                reader = new XmlTextReader(ruta);
                XmlSerializer ser = new XmlSerializer(typeof(T));
               // objeto = new T();
                objeto = (T)ser.Deserialize(reader);
            }
            catch (Exception e)
            {
                throw new ComiqueriaException(" Ocurrio un error al deseralizar el xml ", e);
            }
            finally
            {
                if ( reader != null)
                {
                    reader.Close();
                }
            }
            return objeto;
        }

        public static T DeserializarBinario(string ruta) {
            FileStream fs = null;
            T objeto = null;
            try
            {
                fs = new FileStream(ruta,FileMode.Open);
                BinaryFormatter ser = new BinaryFormatter();
                objeto = (T)ser.Deserialize(fs);
            }
            catch (Exception e)
            {
                throw new ComiqueriaException(" Ocurrio un error al deseralizar el binario", e);
            }
            finally
            {
                if (fs!=null)
                {
                    fs.Close();
                }
            }
            return objeto;
        }
    }
}
