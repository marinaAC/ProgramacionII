using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using System.Threading;


namespace Entidades
{
    class InfoHilo
    {
        #region Atributos
        protected IRespuesta<int> callback;
        protected Thread hilo;
        protected int id;
        protected static Random randomizer;
        #endregion

        #region Constructor
        static InfoHilo() 
        {
            randomizer = new Random();
        }

        public InfoHilo(int id, IRespuesta<int> callback) 
        {
            this.id = id;
            this.callback = callback;
            this.hilo = new Thread(this.Ejecturar);
            this.hilo.Start();
        }
        #endregion

        #region Metodos
        protected void Ejecturar() 
        {
            int random = InfoHilo.randomizer.Next(1,5)*1000;
            Thread.Sleep(random);
            callback.RespuestaHilo(this.id);
        }
        #endregion

    }
}
