using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EntidadesHechas
{
    public class Correo:IMostrar<List<Paquete>>
    {
        private List<Paquete> paquetes;
        private List<Thread> mockPaquetes;

        public Correo()
        {
            paquetes = new List<Paquete>();
            mockPaquetes = new List<Thread>();
        }

        public List<Paquete> Paquetes
        {
            get
            {
                return this.paquetes;
            }
            set
            {
                this.paquetes = value;
            }
        }

        #region Alumno

        /// <summary>
        /// a.	Controlar si el paquete ya está en la lista. En el caso de que esté, se lanzará la excepción TrackingIdRepetidoException.
        /// b.	Agregar el paquete a la lista de paquetes.
        /// c.	Crear un hilo para el método MockCicloDeVida del paquete, y agregar dicho hilo a mockPaquetes.
        /// d.	Ejecutar el hilo.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Correo operator +(Correo c, Paquete p)
        {
            
            foreach (Paquete paquete in c.paquetes)
            {
                if (paquete == p)
                {
                    throw new TrackingRepetidoException("El paquete se encuentra repetido");
                }
            }

            c.paquetes.Add(p);
            Thread MockCicloDeVida = new Thread(p.MockCicloDeVida);
            MockCicloDeVida.Start();
            c.mockPaquetes.Add(MockCicloDeVida);


            return c;
        }

        /// <summary>
        /// Utilizará string.Format con el siguiente formato "{0} para {1} ({2})", p.TrackingID, p.DireccionEntrega, p.Estado.ToString()
        /// para retornar los datos de todos los paquetes de su lista
        /// </summary>
        /// <param name="elementos"></param>
        /// <returns></returns>
        public string MostrarDatos(IMostrar<List<Paquete>> elementos)
        {
            List<Paquete> l = (List<Paquete>)((Correo)elementos).paquetes;
            StringBuilder sb = new StringBuilder();
            foreach (Paquete paquete in l) {
                sb.AppendFormat("{0} ({1})", paquete.MostrarDatos(paquete), paquete.Estado.ToString());
                sb.AppendLine();
            }
            return sb.ToString();
        }

        /// <summary>
        /// Cerrará todos los hilos ACTIVOS
        /// </summary>
        public void FinEntregas()
        {
            foreach (Thread hilo in this.mockPaquetes)
            {
                if (hilo.IsAlive)
                {
                    hilo.Abort();
                }
            }
        }

        #endregion
    }
}
