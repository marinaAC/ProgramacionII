using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Animal
    {
        protected int _cantidadPatas;
        protected static Random _distanciaRecorrida;
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
                    _cantidadPatas = 4;
                }
                else 
                {
                    _cantidadPatas = value; 
                }
                
            }
        }

        public int DistanciaRecorrida
        {
            get 
            {
                return _distanciaRecorrida.Next(10,VelocidadMaxima); 
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
                if (value > 60)
                {
                    _velocidadMaxima = 60;
                }
                else 
                {
                    _velocidadMaxima = value; 
                }
            }
        }
        
        #endregion

        #region Constructores
        static Animal() 
        {
            _distanciaRecorrida = new Random();
        }

        public Animal(int cantidadPatas, int velocidadMaxima) 
        {
            this._cantidadPatas = cantidadPatas;
            this._velocidadMaxima = velocidadMaxima;
        }
        #endregion

        #region Metodos
        public string MostrarDatos() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nCantidad de Patas: {0}", this._cantidadPatas);
            sb.AppendFormat("\nVelocidad Maxima: {0}",this._velocidadMaxima);
            sb.AppendFormat("\nDistancia recorrido: {0}",this.DistanciaRecorrida);
            return sb.ToString();
        }
        #endregion
    }
}
