using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Entidades
{
    public delegate void CorrenCallback(int avance, Corredor corredor);
    public class Persona:Corredor
    {
        protected string _nombre;

        public Persona(string nombre, short velocidadMaxima, Carril carril) 
            : base(velocidadMaxima, carril) 
        {
            this._nombre = nombre;
        }

        #region Metodos
        public override void Correr() 
        {
            while(true)
            {
                int recorrido = _avance.Next(1,100);
                if (recorrido < 100)
                {
                    System.Threading.Thread.Sleep(300);
                    corriendo(recorrido, this);
                }
                else 
                {
                    break;
                }
            }

        }
        public override void Guardar(string path)
        {
            StreamWriter fl;
            if (!File.Exists(path))
            {
                fl = new StreamWriter(path);
                if (ReferenceEquals(fl, null))
                {
                    fl.WriteLine(this.ToString());
                }
                else 
                {
                    throw new Exception("no se pudo guardar");
                }
                
            }
            else 
            {
                fl = File.AppendText(path);
                fl.WriteLine(this.ToString());
            }

            fl.Close();
            
        }

        public override string ToString()
        {
            string aux = string.Format("{0} en el carril {1} a una velocidad maxima de {2}", this._nombre,this.CarrilElegido,this.VelocidadMaxima);
            return aux;
        }

        
        public event CorrenCallback corriendo;
        #endregion
    }
}
