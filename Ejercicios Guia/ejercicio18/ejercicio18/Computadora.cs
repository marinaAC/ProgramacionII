using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio18
{
    class Computadora
    {
        private bool _estaEncendida;
        private EMarca _marca;
        private float _peso;
        private EProcesador _procesador;

        public Computadora(bool encendida, float peso, EMarca marca, EProcesador procesador) 
        {
            this._estaEncendida = encendida;
            this._marca = marca;
            this._peso = peso;
            this._procesador = procesador;
        }

        public bool GetEstaEncendida() 
        {
            return this._estaEncendida;
        }

        public float GetPeso() 
        {
            return this._peso;
        }

        public EMarca GetMarca() 
        {
            return this._marca;
        }

        public EProcesador GetProcesador() 
        {
            return this._procesador;
        }

        public void SetEstaEncendida(bool encendida) 
        {
            this._estaEncendida = encendida;
        }

        public void SetPeso(float peso) 
        {
            this._peso = peso;
        }

        public void SetMarca(EMarca marca) 
        {
            this._marca = marca;
        }

        public void SetProcesador(EProcesador procesador) 
        {
            this._procesador = procesador;
        }

        public void InformarEstado() 
        {
            Console.WriteLine("Marca: {0} || Procesador: {1} || Peso: {2}", this._marca, this._procesador, this._peso);
            Console.WriteLine("------------------------------------------------");
            if (this._estaEncendida == true)
            {
                Console.WriteLine("Estado: Prendida");
            }
            else 
            {
                Console.WriteLine("Estado: Apagada");
            }
            Console.ReadLine();
        }

        public void Apagar() 
        {
            this._estaEncendida = false;
        }
        public void Encender() 
        {
            this._estaEncendida = true;
        }
    }
}
