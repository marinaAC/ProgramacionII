using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Calculadora
    {
        /// <summary>
        /// Atributos
        /// </summary>
        private int _value1;
        private int _value2;
        private int _value3;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <param name="value3"></param>
        /// 
       
        public Calculadora(int numeroUno, int numeroDos, int numeroTres) {
            this._value1 = numeroUno;
            this._value2 = numeroDos;
            this._value3 = numeroTres;
        }
      
        /// <summary>
        /// Metodo
        /// </summary>
        /// <returns></returns>
        public int suma(){
            int rta;
            rta = this._value1 + this._value2 + this._value3;
            return rta;
        }

      

    }
}
