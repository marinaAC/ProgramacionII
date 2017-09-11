using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Rectangulo
    {
        public float area;
        public float lado;
        public float perimetro;
        public Punto vertice1;
        public Punto vertice2;
        public Punto vertice3;
        public Punto vertice4;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="vertice1"></param>
        /// <param name="vertice3"></param>
        public Rectangulo(Punto vertice1, Punto vertice3) {

            float h;

            this.vertice1 = vertice1;
            this.vertice2 = new Punto(vertice1.getX(), vertice3.getY());
            this.vertice3 = vertice3;
            this.vertice4 = new Punto(vertice3.getX(), vertice1.getY());

            this.lado = Math.Abs(this.vertice1.getX() - this.vertice3.getX());
            h = Math.Abs(this.vertice1.getY() - this.vertice3.getY());

            this.perimetro = lado * 2 + h * 2;
            this.area = lado * h;

        }
    }
}
