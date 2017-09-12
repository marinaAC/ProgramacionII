using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Producto
    {
        public String _codigoDeBarra;
        private String _marca = String.Empty;
        private float _precio;

        public static explicit operator string(Producto p)
        {
            return p._codigoDeBarra;
        }
        public String GetMarca()
        {
            return this._marca;
        }
        public float GetPrecio()
        {
            return this._precio;
        }
        public String[] MostrarProducto()
        {
            String[] retorno = new String[3];
            retorno[0] = this._marca;
            retorno[1] = this._codigoDeBarra;
            retorno[2] = this._precio.ToString();
            return retorno;
        }


        public static bool operator ==(Producto producto, string marca)
        {
            bool retorno = false;
            if (producto.GetMarca() == marca)
                retorno = true;
            return retorno;
        }
        public static bool operator !=(Producto producto, string marca)
        {
            bool retorno = false;
            if (producto.GetMarca() != marca)
                retorno = true;
            return retorno;
        }


        public static bool operator == (Producto p1, Producto p2)
        {
            if (p1._codigoDeBarra == p2._codigoDeBarra)
                return true;
            else return false;
        }
        public static bool operator != (Producto p1, Producto p2)
        {
            bool retorno = false;
            if (p1.GetCodigoDeBarra() != p2.GetCodigoDeBarra())
                retorno = true;
            return retorno;
        }


        private string GetCodigoDeBarra()
        {
            return this._codigoDeBarra;
        }
        public Producto(string marca, string codigo, float precio)
        {
            this._marca = marca;
            this._codigoDeBarra = codigo;
            this._precio = precio;
        }
    }
}
