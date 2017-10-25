using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO
{
    public class PuntoTxt:Archivo, IArchivo<string>
    {
        protected override bool ValidarArchivo(string ruta)
        {
            bool aux = true;
            if(base.ValidarArchivo(ruta))
            {
                string extension = Path.GetExtension(ruta);
                if(extension!=".txt")
                {
                    aux = false;
                    throw new ArchivoIncorrectoException("Formato incorrecto");
                }
            }
            return aux;
        }

        public bool Guardar(string ruta)
        {
            if(this.ValidarArchivo(ruta))
            {
                StreamWriter file = new StreamWriter(ruta);
                file.Write();
            }
            throw new NotImplementedException();
        }

        public string Leer(string ruta)
        {
            throw new NotImplementedException();
        }
    }
}
