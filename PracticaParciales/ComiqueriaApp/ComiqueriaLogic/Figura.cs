using System;
using System.Collections.Generic;
using System.Text;

namespace ComiqueriaLogic
{
    class Figura : Producto
    {
        private double altura;

       
        public Figura(string descripcion,int stock, double precio,double altura) : base(descripcion,stock,precio)
        {
            this.altura = altura;

        }

        public Figura(int stock, double precio, double altura) : this("Figura "+altura+" cm",stock,precio,altura) { }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.ToString());
            sb.AppendFormat("altura {0}",this.altura);
            return sb.ToString();
        }

    }
}
