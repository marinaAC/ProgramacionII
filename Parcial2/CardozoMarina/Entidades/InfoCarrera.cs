using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using System.Threading;

namespace Entidades
{
    public class InfoCarrera
    {
        protected IRespuesta<int> callback;
        protected Thread carrera;
        protected int id;
        protected static Random randomize;

        #region Constructores
        static InfoCarrera() 
        {
            randomize = new Random();
        }

        public InfoCarrera(int id, IRespuesta<int> callback) 
        {
            this.id = id;
            this.callback = callback;
            this.carrera = new Thread(Correr);
            carrera.Start();
        }
        #endregion

        #region Metodos
        public void Correr() 
        {
            int aux = randomize.Next(1, 5);
            Thread.Sleep(aux);
            this.callback.RespuestaCarrera(this.id);

        }

       #endregion
    }
}
