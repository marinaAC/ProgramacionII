using System;
using System.Text;

namespace ComiqueriaLogic
{
    public abstract class Producto
    {
        #region atributos
        private Guid codigo;
        private string descripcion;
        private double precio;
        private int stock;
        #endregion

        #region Propiedades
        public string Descripcion
        {
            get { return this.descripcion; }
        }
        public double Precio
        {
            get { return this.precio; }
        }
        public int Stock
        {
            get
            {
                return this.stock;
            }
            set
            {
                if (value >= 0)
                    this.stock = value;
            }
        }
        #endregion

        protected Producto(string descripcion, int stock, double precio)
        {
            this.descripcion = descripcion;
            this.stock = stock;
            this.precio = precio;
            this.codigo = Guid.NewGuid();
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Descripcion: {0}", this.descripcion);
            sb.AppendLine();
            sb.AppendFormat("Codigo: {0}", this.codigo);
            sb.AppendLine();
            sb.AppendFormat("Precio: {0}", this.precio);
            sb.AppendLine();
            sb.AppendFormat("Stock: {0}", this.stock);
            return sb.ToString();
        }

        public static explicit operator Guid(Producto p)
        {
            return p.codigo;
        }




    }
}
