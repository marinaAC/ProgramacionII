using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using System.IO;
using System.Data.SqlClient;

namespace Entidades
{
    public class LasCarreras:IRespuesta<int>
    {
        protected int id;
        protected List<InfoCarrera> misCarreras;

        #region Propiedades
        public string Detalle 
        {
            get 
            {
                string pathName = "carrera.txt";
                string path = Environment.SpecialFolder.Desktop.ToString();
                string pathComplete = string.Format("{0}.{1}", path, pathName);
                StreamReader fl = new StreamReader(path);
                string aux = "";
                if(!ReferenceEquals(fl,null))
                {
                    aux = (string)fl.ReadToEnd();
                }
                return aux;
            } 
            set
            {
                string pathName = "carrera.txt";
                string path = Environment.SpecialFolder.Desktop.ToString();
                string pathComplete = string.Format("{0}.{1}",path,pathName);
                StreamWriter fl;
                if (!File.Exists(path))
                {
                    fl = new StreamWriter(pathComplete);
                    if (value != "")
                    {
                        fl.WriteLine(value);
                    }

                }
                else 
                {
                    fl = File.AppendText(pathComplete);
                    if(value != "")
                    {
                        fl.WriteLine(value);
                    }
                }
                fl.Close();
            } 
        }
        #endregion

        #region Constructores
        public LasCarreras() 
        {
            this.id = 0;
            this.misCarreras = new List<InfoCarrera>();
        }

        #endregion

        #region Metodos
        protected LasCarreras AgregarCarrera(LasCarreras carreras)
        {
            carreras.id++;
            InfoCarrera aux = new InfoCarrera(carreras.id,carreras);
            misCarreras.Add(aux);
            return carreras;
        }

        public static LasCarreras operator +(LasCarreras carreras, int cantidad) 
        {
            if (cantidad > 0)
            {
                int i;
                for (i = 0; i < cantidad; i++)
                {
                    carreras.AgregarCarrera(carreras);
                }
            }
            else 
            {
                throw new CantidadInvalidaException();
            }

            return carreras;
        }
        public void RespuestaCarrera(int id)
        {
            string mensaje = string.Format("Termino el hilo {0}", this.id);       
            this.Detalle = mensaje;
            AvisoFin(mensaje);
        }

        public delegate void correrCalback(string men);
        public event correrCalback AvisoFin;
        #endregion
    }
}
