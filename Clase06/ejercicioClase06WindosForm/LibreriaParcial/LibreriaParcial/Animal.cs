using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaParcial
{
    abstract class Animal
    {
        protected int cantidadPatas;
        protected Random distanciaRecorrida;
        protected int velocidadMaxima;

        #region Propiedades
        public int CantidadPatas
        {
            get 
            { 
                return cantidadPatas; 
            }
            set 
            {
                if (value > 4)
                {
                    cantidadPatas = 4;
                }
                else 
                {
                    cantidadPatas = value;
                }
            }
        }


        public int VelocidadMaxima
        {
            get 
            { 
                return velocidadMaxima; 
            }
            set 
            {
                if (value > 60)
                {
                    velocidadMaxima = 60;
                }
                else 
                {
                    velocidadMaxima = value;
                }
                 
            }
        }

        public int DistanciaRecorrida
        {
            get 
            { 
                return distanciaRecorrida.Next(10,velocidadMaxima); 
            }
        }
        #endregion

        #region Constructores

        Animal() 
        {
            distanciaRecorrida = new Random();
        }

        public Animal(int cantPatas, int velMaxima):this() 
        {
            this.cantidadPatas = cantPatas;
            this.velocidadMaxima = velMaxima;

        }
        #endregion

        #region Metodos
        public string MostrarDatos()
        {
            string resultAux;
            resultAux = string.Concat("Cantidad de Patas: {0}, Velocidad: {1}, Distancia Recorrida: {2}", this.cantidadPatas,this.velocidadMaxima,this.distanciaRecorrida);
            return resultAux;
        }
        #endregion

    }
}
