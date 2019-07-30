using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public sealed class Venta
    {
        #region Atributos
        private DateTime fecha;
        private static int porcentajelva;
        private double precioFinal;
        private Producto producto;
        #endregion

        #region Propiedades
        internal DateTime Fecha { get { return this.fecha; } }
        #endregion

        #region Constructores
        static Venta() {
            Venta.porcentajelva = 21;
        }
        internal Venta(Producto producto,int cantidad) {
            this.producto = producto;
            this.Vender(cantidad);       
        }
        #endregion

        #region Metodos
        public static double CalcularPrecioFinal(double precioUnidad, int cantidad) {
            double precioFinal = precioUnidad * cantidad;
            double ivaPorcentaje = precioFinal * Venta.porcentajelva /100;
            return precioFinal + ivaPorcentaje;
        }

        public string ObtenerDescripcionBreve() {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(" {0}, {1}, {2}", this.fecha,this.producto.Descripcion,this.precioFinal);
            return sb.ToString();

        }

        private void Vender(int cantidad) {
            this.producto.Stock -= cantidad;
            this.fecha = DateTime.Now;
            this.precioFinal = Venta.CalcularPrecioFinal(producto.Precio, cantidad);
        }
        #endregion
    }
}
