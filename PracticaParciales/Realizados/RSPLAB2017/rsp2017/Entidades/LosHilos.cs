using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Entidades
{
    
    public class LosHilos:IRespuesta<int>
    {
        protected int id;
        protected List<InfoHilos> misHilos;

        public List<InfoHilos> MisHilos 
        {
            get 
            {
                return misHilos;
            } 
        }


        public string Bitacora 
        {
            get 
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop).ToString();
                string fileName = "bitacora.txt";
                string pathWithName = string.Format("{0}{1}", path, fileName);
                StreamReader fl = new StreamReader(pathWithName);
                if (ReferenceEquals(fl, null))
                {
                    throw new Exception();
                }
                else 
                {
                    string aux = (string)fl.ReadToEnd();
                    return aux;
                }
            }
            set
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop).ToString();
                string fileName = "bitacora.txt";
                string pathWithName = string.Format("{0}{1}", path, fileName);
                if (!File.Exists("bitacora.txt"))
                {
                    
                    StreamWriter fl = new StreamWriter(pathWithName);
                    if (ReferenceEquals(fl, null) || value == "")
                    {
                        throw new Exception();
                    }
                    else
                    {
                        fl.WriteLine(value);
                    }
                    fl.Close();
                }
                else 
                {
                    StreamWriter fl = File.AppendText(pathWithName);
                    if (ReferenceEquals(fl, null) || value == "")
                    {
                        throw new Exception();
                    }
                    else 
                    {
                        fl.WriteLine(value);
                    }
                    fl.Close();
                }
                
            } 
        }

        public LosHilos() 
        {
            this.id = 0;
            this.misHilos = new List<InfoHilos>();
        }


        public delegate void AvisoFin(string men);
        public event AvisoFin eventoAvisar;
        public void RespuestaHilo(int id)
        {
            string men = string.Format("Terminó el hilo {0}", id);
            this.Bitacora = men;
            eventoAvisar(men);
        }

        private LosHilos AgregarHilo(LosHilos hilos) 
        {
            hilos.id++;
            InfoHilos nuevoHilo = new InfoHilos(hilos.id,hilos);
            hilos.MisHilos.Add(nuevoHilo);
            return hilos;
        }

        public static LosHilos operator +(LosHilos hilos, int cantidad)
        {
            if (cantidad <= 0)
            {
                throw new Exception();
            }
            else 
            {
                int i;
                for (i = 0; i < cantidad; i++) 
                {
                    hilos = hilos.AgregarHilo(hilos);
                }
            }

            return hilos;
        }
    }
}
