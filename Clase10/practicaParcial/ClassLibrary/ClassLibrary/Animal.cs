using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    abstract class Animal
    {
        protected int _cantidadPatas;
        protected Random _distanciaRecorrida;
        protected int _velocidadMaxima;


        #region Propiedades
        public int CantidadPatas
        {
            get 
            { 
                return _cantidadPatas; 
            }
            set 
            {
                if (value > 4) 
                {
                    value = 4;
                }
                _cantidadPatas = value; 
            }
        }


        public int DistanciRecorrida
        {
            get 
            { 
                return _distanciaRecorrida.Next(1,10); 
            }
        }

        

        public int VelocidadMaxima
        {
            get 
            { 
                return _velocidadMaxima; 
            }
            set 
            { 
                if(value > 60)
                {
                    value = 60;
                }
                _velocidadMaxima = value; 
            }
        }
        #endregion

        #region Constructores
        private Animal() 
        {
            this._distanciaRecorrida = new Random();
        }

        public Animal(int cantPatas, int velMaxima):this() 
        {
            this._cantidadPatas = cantPatas;
            this._velocidadMaxima = velMaxima;
        }
        #endregion

        public string MostrarDatos() 
        {
            string returnAux = string.Format("Cantidad de Patas:{0} Velocidad: {1} Distancia: {2}", this._cantidadPatas,this._velocidadMaxima,this._distanciaRecorrida);
            return returnAux;
        }
    }
}
