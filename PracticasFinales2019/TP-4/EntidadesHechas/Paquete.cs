﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EntidadesHechas
{
    public class Paquete : IMostrar<Paquete>
    {

        public delegate void DelegadoEstado(object sender, EventArgs e);
        public delegate void DelegadoDAOException(Paquete paquete, Exception exception);
        public event DelegadoEstado InformarEstado;
        public event DelegadoDAOException InformarDAO;
        public enum EEstado
        {
            Ingresado, EnViaje, Entregado
        }

        private string direccionEntrega;
        private string trackingID;
        private EEstado estado;

        public Paquete(string direccionEntrega, string trackingID)
        {
            this.DireccionEntrega = direccionEntrega;
            this.TrackingID = trackingID;
        }

        public string DireccionEntrega
        {
            get
            {
                return this.direccionEntrega;
            }
            set
            {
                this.direccionEntrega = value;
            }
        }

        public string TrackingID
        {
            get
            {
                return this.trackingID;
            }
            set
            {
                this.trackingID = value;
            }
        }

        public EEstado Estado
        {
            get
            {
                return this.estado;
            }
            set
            {
                this.estado = value;
            }
        }

        public override string ToString()
        {
            return this.MostrarDatos(this);
        }

        /// <summary>
        /// Dos paquetes serán el mismo si su tracking ID es igual.
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator ==(Paquete p1, Paquete p2)
        {
            return (p1.trackingID == p2.trackingID);
        }

        /// <summary>
        /// Dos paquetes serán distintos si su tracking ID es distinto.
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator !=(Paquete p1, Paquete p2)
        {
            return !(p1 == p2);
        }

        #region Alumno

        /// <summary>
        /// MostrarDatos utilizará string.Format con el siguiente formato "{0} para {1}", p.trackingID, p.direccionEntrega
        /// </summary>
        /// <param name="elemento"></param>
        /// <returns></returns>
        public string MostrarDatos(IMostrar<Paquete> elemento)
        {
            string datos = String.Format("{0} para {1}",((Paquete)elemento).TrackingID,((Paquete)elemento).DireccionEntrega);
            return datos;
        }

        /// <summary>
        /// a.	Colocar una demora de 10 segundos.
        /// b.	Pasar al siguiente estado.
        /// c.	Informar el estado a través de InformarEstado. EventArgs no tendrá ningún dato extra.
        /// d.	Repetir las acciones desde el punto A hasta que el estado sea Entregado.
        /// e.	Finalmente guardar los datos del paquete en la base de datos.
        /// </summary>
        public void MockCicloDeVida()
        {
            this.InformarEstado(this, null);
            while (this.estado != EEstado.Entregado)
            {
                this.estado++;
                Thread.Sleep(1000);
                this.InformarEstado(this, null);
                try
                {
                    PaqueteDao.Insertar(this);
                }
                catch (Exception e)
                {
                    this.InformarDAO(this, e);
                }
            }
            
            
        }

        #endregion
    }
}
