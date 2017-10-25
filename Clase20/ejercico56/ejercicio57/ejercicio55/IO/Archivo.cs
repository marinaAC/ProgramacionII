using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO
{
    public abstract class Archivo    
    {
        protected virtual bool ValidarArchivo(string ruta) 
        {
            bool returnAux = true;
            StreamReader file = new StreamReader(ruta);
            
            if (object.ReferenceEquals(file,null)) 
            {
                returnAux = false;
                throw new ArchivoIncorrectoException("El archivo no es correcto.",new FileNotFoundException);
            }
            file.Close();
            return returnAux;
        }
    }
}
