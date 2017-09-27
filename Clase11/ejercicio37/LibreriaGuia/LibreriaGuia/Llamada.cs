using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaGuia
{
    public class Llamada
    {
        public enum TipoLlamada { Local, Provincial, Todas }
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        #region Propiedades
        
        public float Duracion
        {
            get 
            { 
                return duracion; 
            }
        }


        public string NroDestino
        {
            get 
            { 
                return nroDestino; 
            }
        }

        public string NroOrigen
        {
            get 
            { 
                return nroOrigen; 
            }
        }
        
        #endregion

        #region Constructores
        public Llamada(float duracion, string nroDestino, string nroOrigen) 
        {
            this.nroOrigen = nroOrigen;
            this.nroDestino = nroDestino;
            this.duracion = duracion;
        }
        #endregion

        #region Metodos
        public string Mostrar() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Duracion {0:N}", this.duracion);
            sb.AppendFormat("Nro Origen {0}", this.nroOrigen);
            sb.AppendFormat("Nro Destino {0}", this.nroDestino);
            sb.AppendLine();

            return sb.ToString();
        }

        public int OrdernarPorDuracion(Llamada l1, Llamada l2) 
        {
            int returnAux;
            if(l1.Duracion == l2.Duracion)
            {
                returnAux = 0;
            }
            else if (l1.Duracion > l2.Duracion)
            {
                returnAux = 1;
            }
            else 
            {
                returnAux = -1;
            }

            return returnAux;
        } 
        #endregion
    }
}
