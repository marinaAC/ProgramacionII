using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaGuia
{
    class Local: Llamada
    {
        protected float costo;
        
        public float CostoLlamada
        {
            get 
            { 
                return costo; 
            }
        }

        public Local(Llamada llamada, float costo)
            : base(
        {
            this.costo = costo;
        }

        public Local(string origen, float duracion, string destino, float costo)
            : this(
        {
        }
        /*
        /// <summary>
        /// 
        /// </summary>
        /// <param name="llamada"></param>
        /// <param name="costo"></param>
        public Local(Llamada llamada, float costo):this(llamada.NroOrigen,llamada.Duracion,llamada.NroDestino,costo)
        {
        
        }

        public Local(string origen, float duracion, string destino, float costo):base(duracion, destino, origen) 
        {
            this.costo = costo;
        }*/
    }
}
