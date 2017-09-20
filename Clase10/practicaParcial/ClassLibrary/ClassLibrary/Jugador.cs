using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class Jugador: Persona
    {
        protected bool _esCapitan;
        protected int _numero;

        #region Properties
        

        public bool EsCapitan
        {
            get { return _esCapitan; }
            set { _esCapitan = value; }
        }

        
        public int Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }
        
        #endregion

        #region Constructores

        private Jugador(string nombre, string apellido):base(nombre,apellido) 
        {
            this._numero = 0;
            this._esCapitan = false;
        }

        public Jugador(string nombre, string apellido, int numero, bool esCap) : base(nombre,apellido) 
        {
            this._numero = numero;
            this._esCapitan = esCap;
        }
        #endregion

        protected override string FichaTecnica()
        {
            string resultAux;
            if (this._esCapitan == true)
            {
                resultAux = string.Format("{0}, capitán del equipo, camiseta número{2}", this.NombreCompleto(), this._numero);
            }
            else 
            {
                resultAux = string.Format("{0},camiseta número {1}",this.NombreCompleto(),this._numero);
            }

            return resultAux;
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            bool returnAux = false;

            if(j1._nombre == j2._nombre && j1._numero == j2._numero && j1._apellido == j2._apellido)
            {
                returnAux = true;
            }

            return returnAux;
        }

        public static bool operator !=(Jugador j1, Jugador j2) 
        {
            bool returnAux = true;
            if(j1==j2)
            {
                returnAux = false;
            }

            return returnAux;
        }

        public explicit operator int(Jugador j)
        {
            int returnAux;
            returnAux = j._numero;
            return returnAux;
        }

        public override string ToString()
        {
            return this.FichaTecnica();
        }
    }
}
