using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public abstract class Producto
    {
        private Guid codigo;
        private string descripcion;
        private double precio;
        private int stock;

        #region Propiedades

        public string Descripcion
        {
            get { return this.descripcion; }
        }

        public double Precio
        {
            get{ return this.precio; }
        }

        public int Stock
        {
            get {
                return this.stock;
            }
            set {
                if (value > 0) {
                    this.stock = value;
                }
            }
        }
        #endregion

        #region Constructores
        protected Producto(string descripcion, int stock, double precio) {
            this.stock = stock;
            this.descripcion = descripcion;
            this.precio = precio;
            this.codigo = Guid.NewGuid();
        }
        #endregion

        #region Metodos
        /// <summary>
        /// sobre escitura de Guid, retorna el codigo de un producto
        /// </summary>
        /// <param name="p">Producto</param>
        public static explicit operator Guid(Producto p){
            return p.codigo;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(String.Format("Descripción: {0}", this.descripcion));
            sb.AppendLine(String.Format("Código: {0}", this.codigo));
            sb.AppendLine(String.Format("Precio: ${0:0.00}", this.precio));
            sb.AppendLine(String.Format("Stock: {0} unidades", this.stock));
            return sb.ToString();
        }
        #endregion


    }
}
