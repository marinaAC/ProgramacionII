using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_8_Library;

namespace Clase_10_Library
{
    public class Accionista:Persona
    {
        protected int _porcionAccionaria;

        #region Propiedades
        public int PorcionAccionaria
        {
            get 
            { 
                return _porcionAccionaria; 
            }
            set 
            {

                if(value <= 0)
                {
                    throw new AccionMenorCeroEx("Valor menor o igual a cero, ERROR!");
                }
                else if (value >= 100)
                {
                    throw new AccionMayorACienEx("Valor mayor o igual a 100. Error!");
                }
                else 
                {
                    _porcionAccionaria = value;
                }
                    
                
                 
            }
        }
        #endregion

        #region Constructores
        public Accionista(string nombre, string apellido, int porccionAccionaria):base(nombre,apellido) 
        {
            this._porcionAccionaria = porccionAccionaria;
        }
        #endregion

        #region Metodos
        public override string PosicionSocietaria()
        {
            string returnAux = string.Format("Accionista con el {0:N}% de la porción accionaria",this._porcionAccionaria);
            return returnAux;
        }

        public static bool operator ==(Accionista a1, Accionista a2)
        {
            bool returnAux = false;
            if(a1._nombre == a2.Nombre && a1.Apellido == a2.Apellido && a1._porcionAccionaria == a2._porcionAccionaria)
            {
                returnAux = true;
            }
            return returnAux;
        }

        public static bool operator !=(Accionista a1, Accionista a2)
        {
            bool returnAux = true;
            if(a1==a2)
            {
                returnAux = false;
            }
            return returnAux;
        }
        #endregion
    }
}
