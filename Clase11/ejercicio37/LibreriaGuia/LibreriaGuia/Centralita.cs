﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaGuia
{
    public class Centralita
    {
        protected List<Llamada> listaLlamadas;
        protected string razonSocial;

        #region Propiedades
        
        public float GananciaPorTotal
        {
            get
            {
                float returnAux = CalcularGanancia(Llamada.TipoLlamada.Todas);
                return returnAux;
            }
        }
        
        public float GananciaPorLocal
        {
            get
            {
                float returnAux = CalcularGanancia(Llamada.TipoLlamada.Local);
                return returnAux;
            }
        }

        public float GananciaPorProvincial
        {
            get
            {
                float returnAux = CalcularGanancia(Llamada.TipoLlamada.Provincial);
                return returnAux;
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaLlamadas;
            }
          
        }
        #endregion

        #region Constructores
        public Centralita()
        {
            this.listaLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa)
            : this()
        {
            this.razonSocial = nombreEmpresa;
        }
        #endregion

        #region Metodos
        private float CalcularGanancia(Llamada.TipoLlamada tipoLlamada)
        {
            float returnAux = 0;

            foreach (Llamada element in this.listaLlamadas)
            {

                if (element is Local && tipoLlamada == Llamada.TipoLlamada.Local)
                {
                    returnAux += ((Local)element).CostoLlamada;
                }
                else if (element is Provincial && tipoLlamada == Llamada.TipoLlamada.Provincial)
                {
                    returnAux += ((Provincial)element).CostoLlamada;
                }
                else if (tipoLlamada == Llamada.TipoLlamada.Todas)
                {
                    if (element is Local)
                    {
                        returnAux += ((Local)element).CostoLlamada;
                    }
                    else
                    {
                        returnAux += ((Provincial)element).CostoLlamada;
                    }
                }
               
            }

            return returnAux;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendFormat("Ganancia Local ${0:N} ", this.GananciaPorLocal);
            sb.AppendLine();
            sb.AppendFormat("Ganancia Provincial ${0:N}", this.GananciaPorProvincial);
            sb.AppendLine();
            sb.AppendFormat("Ganancia Total ${0:N} ", this.GananciaPorTotal);
            sb.AppendLine();

            return sb.ToString();
        }

        /*
        public void OrdernarLlamada() 
        {
            int i;
            for (i = 0; i < this.listaLlamadas.Count;i++ )
            {
                Llamada l1 = this.listaLlamadas[i];
                Llamada l2 = this.listaLlamadas[i + 1];
                listaLlamadas.Sort(Llamada.OrdernarPorDuracion(l1, l2));
            }
        }
        */

        #endregion 

    }
}
