using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ejercicio19
{
    class Boligrafo
    {
        private ConsoleColor _color;
        private int _tinta;

        public Boligrafo(int tinta, ConsoleColor color) {
            this._tinta = tinta;
            this._color = color;
        }

        public bool Pintar(int gasto) {
            bool returnAux = false;
            if(this._tinta>gasto){
                this._tinta = this._tinta - gasto;
                return returnAux = true;
            }
            return returnAux;
        }

        public void Recargar() {
            if (this._tinta < 100) {
                this._tinta = 100;
            }
            
        }

        public void Recargar(ConsoleColor color) {
            if(this._tinta>0 && this._tinta<=100){
                mezclarColor(color);
            }
        }

        public void mezclarColor(ConsoleColor color) {
            switch(color){
                case ConsoleColor.Red:
                    switch (this._color) {
                        case ConsoleColor.Blue:
                            this._color = ConsoleColor.Magenta;
                            break;
                        case ConsoleColor.Yellow:
                            this._color = ConsoleColor.Green;
                            break;
                    }
                    break;
                case ConsoleColor.Yellow:
                    switch (this._color)
                    {
                        case ConsoleColor.Blue:
                            this._color = ConsoleColor.Green;
                            break;
                        case ConsoleColor.Red:
                            this._color = ConsoleColor.DarkYellow;
                            break;

                    }
                    break;
                case ConsoleColor.Blue:
                    switch (this._color)
                    {
                        case ConsoleColor.Yellow:
                            this._color = ConsoleColor.Green;
                            break;
                        case ConsoleColor.Red:
                            this._color = ConsoleColor.Magenta;
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Color no valido");
                    Console.ReadLine();
                    break;
            }
        }

        public ConsoleColor getColor(){
            return this._color;
        }

        public int getTinta() {
            return this._tinta;
        }
    }
}
