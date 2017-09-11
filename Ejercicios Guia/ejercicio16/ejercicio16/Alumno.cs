using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio16
{
    class Alumno
    {
        private byte _nota1;
        private byte _nota2;
        private float _notaFinal;
        public string apellido;
        public string nombre;
        public int legajo;

        /// <summary>
        /// Constructor Alumno, recibira tres parametros, el resto los inicializara con 0
        /// </summary>
        /// <param name="apellido">tendra el apellido recibido por param</param>
        /// <param name="nombre">tendra el nombre recibido por parametro</param>
        /// <param name="legajo">tendra el legajo recibido por parametro</param>
        public Alumno(string apellido, string nombre, int legajo) 
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
            this._nota1 = 0;
            this._nota2 = 0;
            this._notaFinal = 0;
        }

        /// <summary>
        /// Calcula la nota final, valida que la nota1 y nota2 sean mayores o igual a 4
        /// </summary>
        public void CalcularFinal() 
        {
            if (this._nota1 >= 4 && this._nota2 >= 4)
            {
                Random rnd = new Random();
                this._notaFinal = rnd.Next(4,10);
            }
            else 
            {
                this._notaFinal = -1;
            }
        }

        /// <summary>
        /// Carga las notas del alumno
        /// </summary>
        /// <param name="notaUno">vendra por parametro y se guardara en la nota1 del objeto</param>
        /// <param name="notaDos">vendra por parametro y se guardara en la nota2 del objeto</param>
        public void Estudiar(byte notaUno, byte notaDos) 
        {
            this._nota1 = notaUno;
            this._nota2 = notaDos;
        }

        /// <summary>
        /// Muestra los datos ingresados del alumno, pero valida que la nota final sea distinta a -1
        /// </summary>
        public void Mostrar() 
        {
            Console.WriteLine("Nombre: {0}| Apellido: {1}| Legajo: {2}", this.nombre, this.apellido, this.legajo);
            Console.WriteLine("----------------------------------------- ");
            Console.WriteLine("Nota 1: {0:N}", this._nota1.ToString());
            Console.WriteLine("Nota 2: {0:N}", this._nota2.ToString());
            if(this._notaFinal!=-1)
            {
                Console.WriteLine("Nota Final: {0:N}", this._notaFinal.ToString());
            }
            Console.ReadLine();
        }
    }
}
