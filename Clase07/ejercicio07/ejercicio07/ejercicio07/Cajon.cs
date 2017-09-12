using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio07
{
    class Cajon
    {
        private Fruta[] _frutas;
        private int _volumen;

        Cajon(int cantidad) 
        {
            this._frutas = new Fruta[cantidad];
        }

        public Cajon(int vol, int cantidad):this(cantidad) 
        {
            this._volumen = vol;
        }

        
    }
}
