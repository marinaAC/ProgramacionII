using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComiqueriaLogic
{
    class Comiqueria
    {
        private List<Producto> productos;
        private List<Venta> ventas;
        public Producto this[Guid codigo] {
            get {
                Producto producto = null;
                foreach (Producto p in this.productos)
                {
                    if ((Guid)p == codigo) {
                        producto = p;
                    }
                }
                return producto;
            }
        }

        public Comiqueria()
        {
            this.productos = new List<Producto>();
            this.ventas = new List<Venta>();
        }

        public static bool operator ==(Comiqueria comiqueria, Producto producto)
        {
            bool retorno = false;
            foreach(Producto p in comiqueria.productos)
            {
                if (p.Descripcion == producto.Descripcion) {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Comiqueria comiqueria,Producto producto)
        {
            bool retorno = true;
            if (comiqueria==producto)
            {
                retorno = false;
            }
            return retorno;
        }

        public static Comiqueria operator +(Comiqueria comiqueria,Producto producto)
        {
            if (comiqueria!=producto) {
                comiqueria.productos.Add(producto);
            }
            return comiqueria;
        }

        public void Vender(Producto producto) {
            this.Vender(producto, 1);
        }

        public void Vender(Producto producto,int cantidad)
        {
            if (!object.ReferenceEquals(null,producto) && cantidad>0) {
                Venta v = new Venta(producto, cantidad);
                this.ventas.Add(v);
            }
        }

        public string ListarVentas()
        {

            List<Venta> listaOrdenada = this.ventas.OrderByDescending(x => x.Fecha).ToList();
            StringBuilder sb = new StringBuilder();
            foreach (Venta v in listaOrdenada) {
                sb.AppendLine(v.ObtenerDescripcionBreve());
            }
            return sb.ToString();
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
    }
}
