using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaGuia
{
    public class Provincial : Llamada
    {
        public enum Franja { Franja_1, Franja_2, Franja_3 }

        protected Franja franjaHoraria;

        #region Propiedades
        
        public float CostoLlamada
        {
            get
            {
                float returnAux = CalcularCosto();
                return returnAux;
            }
        }

        #endregion

        #region Constructores
        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : base (duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(Franja miFranja, Llamada llamada)
            : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino) { }
        #endregion

        #region Metodos
        private float CalcularCosto()
        {
            float returnAux;
            if (this.franjaHoraria == Franja.Franja_1)
            {
                returnAux = 0.99F * this.Duracion;
            }
            else if (this.franjaHoraria == Franja.Franja_2)
            {
                returnAux = 1.25F * this.Duracion;
            }
            else
            {
                returnAux = 0.66F * this.Duracion;
            }
            return returnAux;
        }


        //preguntar lo mismo para local
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            //string aux = Mostrar();
            //sb.AppendFormat("{0}", aux);

            sb.AppendFormat("Duracion: {0}", this.Duracion);
            sb.AppendFormat("Numero Destino: {0}", this.NroDestino);
            sb.AppendFormat("Numero Origen: {0}", this.NroOrigen);
            sb.AppendFormat("Franja: {0}", this.franjaHoraria);
            sb.AppendFormat("Costo de la llamada: {0}", this.CostoLlamada);
            sb.AppendLine();
            return sb.ToString();
        }
        #endregion  


    }
}
