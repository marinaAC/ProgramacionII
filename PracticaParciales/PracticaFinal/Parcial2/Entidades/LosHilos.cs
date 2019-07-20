using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using System.IO;

namespace Entidades
{
    public class LosHilos : IRespuesta<int>
    {
        #region Atributos
        protected int id;
        protected List<InfoHilo> misHilos;
        #endregion

        #region Propiedades
        public List<InfoHilo> MisHilos 
        {
            get 
            {
                return misHilos;
            }
            set 
            {
                misHilos = value;
            } 
        }

        public string Bitacora 
        {
            get 
            {
                string fileName = "bitacora.txt";
                StreamReader fl = new StreamReader(fileName);
                string aux = (string)fl.ReadToEnd();
                fl.Close();
                return aux;
            }
            set 
            {
                string fileName = "bitacora.txt";
                StreamWriter fl = new StreamWriter(fileName);
                fl.Write(value);
                fl.Close();
            } 
        }
        #endregion

        #region Constructor
        public LosHilos() 
        {
            this.id = 0;
            this.misHilos = new List<InfoHilo>;
        }
        #endregion

        #region Metodos
        public static LosHilos operator +(LosHilos hilos, int cantiad)
        {
        }

        public LosHilos AgregarHilo(LosHilos hilos) 
        {
            hilos.id++;
            InfoHilo nuevoHilo = new InfoHilo(hilos.id, hilos);
            hilos.misHilos.Add(nuevoHilo);
            return hilos;
        }

        public int RespuestaHilo(int id)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
