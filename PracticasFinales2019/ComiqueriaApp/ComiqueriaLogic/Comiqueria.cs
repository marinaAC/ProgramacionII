using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comiqueria
    {
        #region Atributos
        private List<Producto> productos;
        private List<Venta> ventas;
        #endregion

        #region Propiedades
        public Producto this[Guid codigo] {
            get
            {
                foreach (Producto producto in this.productos)
                {
                    if ((Guid)producto == codigo)
                    {
                        return producto;
                    }
                }

                return null;
            }
        }
        #endregion

        public Comiqueria() {
            this.productos = new List<Producto>();
            this.ventas = new List<Venta>();
        }

        #region Metodos
        public static bool operator ==(Comiqueria comiqueria,Producto producto) {
            bool equals = false;
           
                foreach (Producto p in comiqueria.productos) {
                    if (p.Descripcion == producto.Descripcion) {
                        equals = true;
                    }
                }


            return equals;
        }

        public static bool operator !=(Comiqueria comiqueria,Producto producto) {
            bool equals = !(comiqueria == producto);
            return equals;
        }

        public static Comiqueria operator +(Comiqueria comiqueria,Producto producto) {
            if (comiqueria != producto) {
                comiqueria.productos.Add(producto);
            }
            return comiqueria;
        }
        public Dictionary<Guid, string> ListarProductos()
        {
            Dictionary<Guid, string> respuesta = new Dictionary<Guid, string>();

            foreach (Producto producto in this.productos)
            {
                respuesta.Add((Guid)producto, producto.Descripcion);
            }

            return respuesta;
        }
        public string ListarVentas()
        {
            List<Venta> ventasOrdenadas = this.ventas.OrderByDescending(x => x.Fecha).ToList();

            StringBuilder sb = new StringBuilder();
            foreach (Venta venta in ventasOrdenadas)
            {
                sb.AppendLine(venta.ObtenerDescripcionBreve());
            }

            return sb.ToString();
        }
        public void Vender(Producto producto) {
            this.Vender(producto, 1);
        }

        public void Vender(Producto producto, int cantidad) {
            Venta nuevaVenta = new Venta(producto, cantidad);
            this.ventas.Add(nuevaVenta);
        }



        #endregion

    }
}
