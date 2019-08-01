using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesHechas
{
    public static class GuardaString
    {
        public static bool Guardar(this String value,string archivo)
        {
            StreamWriter w = null;
            bool exito = false;
            try
            {
                string path = String.Format("{0}{1}.txt", Environment.GetFolderPath(Environment.SpecialFolder.Desktop),archivo);
                w = new StreamWriter(path,true,Encoding.UTF8);
                w.Write(value);
                exito = true;
            }
            catch (Exception e)
            {
                throw new Exception("Ocurrio un error al agregar un archivo de texto Error: "+e.Message);
            }
            finally
            {
                if (w !=null)
                {
                    w.Close();
                }
            }
            return exito;
        }
    }
}
