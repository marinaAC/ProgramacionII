using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace IO
{
    [Serializable]
    public class PuntoDat:Archivo,IArchivo<PuntoDat>
    {
        protected string contenido;

        public string Contenido
        {
            get 
            {
                return contenido;
            }

            set 
            {
                contenido = value;
            }
        }

        public PuntoDat() { }

        protected override bool ValidarArchivo(string ruta)
        {
            bool aux = true;
            if(base.ValidarArchivo(ruta))
            {
                string extension = Path.GetExtension(ruta);
                if(extension != ".dat")
                {
                    throw new ArchivoIncorrectoException("El archivo no es un dat.");
                    aux = false;
                }
            }
            return aux;
        }



        public bool Guardar(string ruta)
        {
            bool returnAux = false;
            if(this.ValidarArchivo(ruta))
            {
                FileStream file = new FileStream(ruta,FileMode.Create);
                BinaryFormatter ser = new BinaryFormatter();
                ser.Serialize(file, this.contenido);
                file.Close();
                returnAux = true;
            }

            return returnAux;
        }

        public PuntoDat Leer(string ruta)
        {
            PuntoDat p = null;
            if(this.ValidarArchivo(ruta))
            {
                PuntoDat p = new PuntoDat();
                FileStream file = new FileStream(ruta, FileMode.Open);
                BinaryFormatter ser = new BinaryFormatter();
                p = (PuntoDat)ser.Deserialize(file);

            }

            return p;
        }
    }
}
