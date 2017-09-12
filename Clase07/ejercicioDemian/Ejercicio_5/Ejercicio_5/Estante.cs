using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Estante
    {
        private Producto[] _productos;
        private int _ubicacionEstante;

        private Estante(int capacidad)
        {
            this._productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion)
            : this(capacidad)
        {
            this._ubicacionEstante = ubicacion;
        }


        Producto[] GetProductos()
        {
            return this._productos;
        }
        public int GetCapacidadEstante()
        {
            return this._productos.Length;
        }

        public int GetUbicacionEstante()
        {
            return this._ubicacionEstante;
        }

        public string MostrarEstante()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendLine("Ubicacion: " + this.GetUbicacionEstante() + " -- Capacidad: !" + this.GetCapacidadEstante());
            for (int i = 0; i < this._productos.Length; i++)
            {
                if(!Array.ReferenceEquals(null, this._productos[i]))
                {
                    string[] arrayAtributos = this._productos[i].MostrarProducto();
                    retorno.AppendLine("Marca: " + arrayAtributos[i] + " -- Codigo: " + arrayAtributos[i] + " -- Precio" + arrayAtributos[i]);
                }
                
            }

            return retorno.ToString();
        }
        public static bool operator ==(Estante estante, Producto producto)
        {
            bool retorno = false;
            for (int i = 0; i < estante._productos.Length; i++)
                if (estante._productos[i] == producto)
                {
                    retorno = true;
                    break;
                }
            return retorno;
        }
        public static bool operator !=(Estante estante, Producto producto)
        {
            bool retorno = true;
            for (int i = 0; i < estante._productos.Length; i++)
            {
                if (estante._productos[i] == producto)
                {
                    retorno = false;
                    break;
                }
            }
            return retorno;
        }
        public static bool operator +(Estante estante, Producto producto)
        {
            bool retorno = false;
            int indice = 0;
            for (int i = 0; i < estante._productos.Length; i++)
            {
                if (Array.ReferenceEquals(estante._productos[i], null) && indice == -1)
                    indice = i;
                if (!Array.ReferenceEquals(estante._productos[i], null) && estante._productos[i] == producto)
                {
                    indice = -1;
                    break;
                }
            }
            if (indice >= 0 )
            {
                retorno = true;
                estante._productos[indice] = producto;
            }
            return retorno;
        }
        public static Estante operator -(Estante estante, Producto producto)
        {
            for (int i = 0; i < estante._productos.Length; i++)
            {
                if (producto == estante._productos[i])
                {
                    estante._productos[i] = null;
                    break;
                }
            }
            return estante;
        }
    }
}
