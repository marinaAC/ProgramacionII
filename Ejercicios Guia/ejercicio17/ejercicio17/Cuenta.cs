using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio17
{
    class Cuenta
    {
        private string _nombre;
        private string _nrocuenta;
        private double _saldo;
        private ETipoInteres _tipoInteres;

        /// <summary>
        /// Constructor de cuenta
        /// </summary>
        /// <param name="nombre">nombre que recibira la nueva cuenta</param>
        /// <param name="numeroCuenta">numero que tendra la cuenta</param>
        /// <param name="saldo">valor que tendra el saldo</param>
        /// <param name="interes">el tipo de interes que tendra</param>
        public Cuenta(string nombre, string numeroCuenta, double saldo, ETipoInteres interes) 
        {
            this._nombre = nombre;
            this._nrocuenta = numeroCuenta;
            this._saldo = saldo;
            this._tipoInteres = interes;
        }

        /// <summary>
        /// Obtiene el nombre de la cuenta
        /// </summary>
        /// <returns>retorna el nombre de la cuenta</returns>
        public string getNombre() 
        {
            return this._nombre;
        }

        /// <summary>
        /// Obtiene el numero de la cuenta
        /// </summary>
        /// <returns>retorna el numero de la cuenta</returns>
        public string getNroCuenta() 
        {
            return this._nrocuenta;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double getSaldo() 
        {
            return this._saldo;
        }

        public ETipoInteres getTipoInteres() 
        {
            return this._tipoInteres;
        }

        public void setNombre(string nombre) 
        {
            this._nombre = nombre;
        }

        public void serNroCuenta(string nroCuenta) 
        {
            this._nrocuenta = nroCuenta;
        }

        public void setSaldo(double saldo) 
        {
            this._saldo = saldo;
        }

        public void setTipoInteres(ETipoInteres tipo) 
        {
            this._tipoInteres = tipo;
        }
    }
}
