using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Interfaces;


namespace Entidades
{
    public class InfoHilos
    {
        protected int id;
        protected static Random randomizer;
        protected Thread hilo;
        protected IRespuesta<int> callback;

        static InfoHilos() 
        {
            randomizer = new Random();
        }

        public InfoHilos(int id, IRespuesta<int> callback) : base() 
        {
            this.id = id;
            this.callback = callback;
            this.hilo = new Thread(this.Ejecutar);
            this.hilo.Start();
        }

        public void Ejecutar() 
        {
            int timeSleep = randomizer.Next(1, 5) * 1000; 
            Thread.Sleep(timeSleep);
            callback.RespuestaHilo(this.id);
        }

        
    }
}
