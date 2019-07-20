using System;
using System.Collections.Generic;
using System.Text;

namespace ComiqueriaLogic
{
    sealed class Venta
    {
        private DateTime fecha;
        private static int porcentajelva;
        private double precioFinal;
        private Producto producto;

        internal DateTime Fecha {
            get { return this.fecha; }
        }

        static Venta()
        {
            porcentajelva = 21;
        }


        internal Venta(Producto producto, int cantidad) {
        }

        private void Vender(int cantidad) {
            int auxiliarCantidadStock = this.producto.Stock;
            if (cantidad<=auxiliarCantidadStock)
            {
                this.producto.Stock = cantidad - auxiliarCantidadStock;
            }
            this.fecha = new DateTime();
            this.fecha = DateTime.Today;
            this.precioFinal = CalcularPrecioFinal(30, cantidad);
        }

        public string ObtenerDescripcionBreve() {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Fecha {0} - descripcion {1}, precio {3:#.00}",this.fecha,this.producto.Descripcion,this.precioFinal);
            return sb.ToString();
        }

        public static double CalcularPrecioFinal(double precioUnidad, int cantidad)
        {
            double precioCalculado = precioUnidad * cantidad;
            return precioCalculado * porcentajelva;
        }




    }
}
