using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaGuia
{
    public class Local: Llamada
    {
        protected float costo;

        #region Propiedades
        public float CostoLlamada
        {
            get 
            {
                float resultAux = CalcularCosto();
                return resultAux; 
            }
        }
        #endregion

        #region Constructores
        public Local(string origen, float duracion, string destino, float costo)
            : base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        public Local(Llamada llamada, float costo)
            : this(llamada.NroOrigen,llamada.Duracion,llamada.NroDestino,costo)
        {
        }
        #endregion

        #region Metodos
        private float CalcularCosto()
        {
            float resultAux;
            resultAux = this.costo * this.Duracion;
            return resultAux;
        }

        //Consultar como puedo reutilizar el metodo si se llaman igual, sin sobreescribirlo
        //ya que me quiero traer los datos utilizando el mostrar de llamada;
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            string aux = Mostrar();
            sb.AppendFormat("{0}", aux);
            sb.AppendFormat("Costo: {0}", this.costo);
            sb.AppendFormat("Costo de la llamada: {0}", this.CostoLlamada);
            sb.AppendLine();
            return sb.ToString();
        }
        #endregion



    }
}
