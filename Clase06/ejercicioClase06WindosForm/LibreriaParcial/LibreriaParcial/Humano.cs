using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaParcial
{
    public class Humano:Animal
    {
        protected string nombre;
        protected string apellido;
        protected static int piernas;

        #region Constructores
        /// <summary>
        /// Constructor estatico, inicializa el atributo estatico con el valor 2
        /// </summary>
        static Humano() 
        {
            piernas = 2;
        }

        /// <summary>
        /// Constructor privado que inicializa el que recibe por herencia de animal
        /// </summary>
        /// <param name="velocidadMaxima">solo necesita velocidad maxima para crear el objeto</param>
        Humano(int velocidadMaxima):base(piernas,velocidadMaxima) { }

        /// <summary>
        /// Constructor publico que inicializa el objeto con el nombre y apellido pasado por paremtros
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="ap"></param>
        /// <param name="velocidadMaxima"></param>
        public Humano(string nom, string ap, int velocidadMaxima):base(piernas,velocidadMaxima) 
        {
            this.nombre = nom;
            this.apellido = ap;
        }
        #endregion

        #region Metodos

        public string MostrarHumano() 
        {
            string returnAux;
            string aux = MostrarDatos();
            returnAux = string.Concat("Nombre: {0}, Apellido {1}, {2}", this.nombre,this.apellido,aux);
            return returnAux;
        }

        public static bool operator ==(Humano h1, Humano h2)
        {
            bool returnAux = false;
            if(h1.apellido == h2.apellido && h1.nombre == h2.nombre)
            {
                returnAux = true;
            }
            return returnAux;
        }

        public static bool operator !=(Humano h1, Humano h2)
        {
            bool returnAux = true;
            if(h1 == h2)
            {
                returnAux = false;
            }
            return returnAux;
        }
        #endregion
    }
}
