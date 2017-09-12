using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio07
{
    class Fruta
    {
        private float _peso;
        private int _volumen;

        public Fruta() 
        {
            Random rnd = new Random();
            this._peso = rnd.Next(1,5);
            this._volumen = rnd.Next(1,10);
        }


    }
}
