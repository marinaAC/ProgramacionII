using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Corredor
    {
        public enum Carril { Carril_1, Carril_2}
        protected static Random _avance;
        protected Carril _carrilElegido;
        private short _velocidadMaxima;

        #region Propiedades
        public short VelocidadMaxima 
        {
            get 
            {
                return _velocidadMaxima;
            }
            set 
            {
                if (value < 11)
                {
                    _velocidadMaxima = value;
                }
               
            } 
        }

        public Carril CarrilElegido
        {
            get
            {
                return _carrilElegido;
            }
        }

        #endregion

        
       
        #region Constructores

        static Corredor() 
        {
            _avance = new Random();
        }

        public Corredor(short velocidadMaxima, Carril carril)
        {
            this._carrilElegido = carril;
            this.VelocidadMaxima = velocidadMaxima;
        }
        #endregion

        #region Metodos
        public abstract void Correr();

        public virtual void Guardar(string path) 
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
