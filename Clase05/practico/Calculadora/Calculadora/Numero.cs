using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Numero
    {
        public double numero;


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double getNumero() {
            return this.numero;
        }

        /// <summary>
        /// 
        /// </summary>
        public Numero() {
            this.numero = 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="num"></param>
        public Numero(double num) {
            this.numero = num;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="num"></param>
        public Numero(string num) {
            this.numero = double.Parse(num);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numeroString"></param>
        private void setNumero(string numeroString) {
            this.numero = validarNumero(numeroString);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numeroString"></param>
        /// <returns></returns>
        private double validarNumero(string numeroString) {

            double returnAux;

            while (!double.TryParse(numeroString, out returnAux)){
                returnAux = 0;
            }

            return returnAux;
        }

    }
}
