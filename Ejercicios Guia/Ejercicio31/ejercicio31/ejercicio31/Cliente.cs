using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio31
{
    class Cliente
    {
        
        private string _nombre;
        private int _numero;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }  

        public int Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        private Cliente(int num) 
        {
            this._numero = num;
        }

        public Cliente(int num, string client) : this(num) 
        {
            this._nombre = client;
        }
    }
}
