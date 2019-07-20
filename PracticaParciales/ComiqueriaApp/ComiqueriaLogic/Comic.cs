using System;
using System.Collections.Generic;
using System.Text;

namespace ComiqueriaLogic
{
    class Comic :Producto
    {
        private string autor;
        private TipoComic tipoComic;

        public Comic(string descripcion, int stock, double precio, string autor, TipoComic tipoComic) : base(descripcion,stock,precio) {
            this.autor = autor;
            this.tipoComic = tipoComic;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.ToString());
            sb.AppendFormat("Autor: {0}", this.autor);
            sb.AppendLine();
            sb.AppendFormat("Tipo de Comic: {0}", this.tipoComic);
            return sb.ToString();
        }
    }
}
