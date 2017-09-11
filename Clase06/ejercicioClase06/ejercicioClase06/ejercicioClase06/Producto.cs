using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioClase06
{
    class Producto
    {
        protected string codigoDeBarra;
        protected string marca;
        protected float precio;

        public Producto(string marca, string codigo, float precio){
            this.codigoDeBarra = codigo;
            this.marca = marca;
            this.precio = precio;
        }

        public string GetMarca(){
            return this.marca;
        }

        public float GetPrecio(){
            return this.precio;
        }

        public static explicit operator string(Producto p){
            string returnAux;
            returnAux = p.codigoDeBarra;
            return returnAux;
        }

        public static bool operator ==(Producto p1 , Producto p2){
            bool returnAux = false;
            if(String.Compare(p1.GetMarca(),p2.GetMarca())==0 && p1.codigoDeBarra==p2.codigoDeBarra){
                returnAux = true;
            }
            return returnAux;
        }

        public static bool operator ==(Producto p , string marca){
            bool returnAux = false;
            if(String.Compare(p.GetMarca(),marca)==0){
                returnAux = true;
            }
            return returnAux;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            bool returnAux = true;
            if (p1==p2)
            {
                returnAux = false;
            }
            return returnAux;
        }

        public static bool operator !=(Producto p , string marca){
            bool returnAux = true;
            if(p==marca){
                returnAux = false;
             }
            return returnAux;
        }

        public static string MostrarProducto(Producto p) {
            string result;
            string marca = p.GetMarca();
            string codigoBarras = p.codigoDeBarra;
            string precio = p.GetPrecio().ToString();
            result = string.Format("{0}, {1}, {2}", marca, precio, codigoBarras);
            return result;
        }

    }
}
