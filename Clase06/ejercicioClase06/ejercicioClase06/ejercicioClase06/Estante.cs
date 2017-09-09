using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioClase06
{
    class Estante
    {
        private Producto[] _productos;
        private int _ubicacionEstante;

        private Estante(int capacidad){
            this._productos = new Producto[capacidad];
        }


        /// <summary>
        /// No necesita instanciar el producto, ya que lo hace 
        /// automaticamente con el this(capacidad) pasandoselo al
        /// constructor privado
        /// </summary>
        /// <param name="capacidad"></param>
        /// <param name="ubicacion"></param>
        public Estante(int capacidad, int ubicacion):this(capacidad){
            this._ubicacionEstante = ubicacion;
        }

        
        public Producto[] GetProductos(){
            return this._productos;
        }


        //object.ReferenceEquals para comparar un objeto con otro objeto
        public static string MostrarEstante(Estante e){
            int i;
            string[] result = new String[e._productos.Length];
            string ubicacion = e._ubicacionEstante.ToString();
            for (i = 0; i < e._productos.Length;i++ )
            {
                if(!object.ReferenceEquals(e._productos[i],null)){
                    result[i] = Producto.MostrarProducto(e._productos[i]);
                }
            }

            return ubicacion;
        }

        /// <summary>
        /// Sobreescribo el operador == para que pueda realizar una comparacion
        /// entre estante y producto, reutilizando el metodo que
        /// sobreescribe == de producto
        /// </summary>
        /// <param name="e">Estante</param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator ==(Estante e,Producto p){
            int i;
            bool returnAux = false;
            for (i = 0; i < e._productos.Length;i++ )
            {
                if(e._productos[i]==p){
                    returnAux = true;
                }
            }

            return returnAux;
        }

        public static bool operator !=(Estante e, Producto p){
            bool returnAux = true;
            if(e==p){
                returnAux = false;
            }
            return returnAux;
        }

        /// <summary>
        /// Recibe un estante y producto, recorre la lista de productos que hay en el estante
        /// si en el lugar de la lista esta en null quiere decir que tiene capacidad
        /// y luego se fija que el producto ubicado en esa posicion
        /// sea distinto al al producto que le estoy pasando por parametros
        /// </summary>
        /// <param name="e"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator +(Estante e, Producto p){
            bool returnAux = false;
            int i;

            for (i = 0; i < e._productos.Length; i++ )
            {
                if (!object.ReferenceEquals(e._productos[i], null)&& e!=p)
                {
                       e._productos[i] = p;
                       returnAux = true;
                       break;
                }
            }
            return returnAux;
        }
    }
}
