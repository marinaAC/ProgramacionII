using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            Computadora pc1 = new Computadora(false, 20 , EMarca.Apple, EProcesador.Intel_Core_i7);

            Computadora pc2 = new Computadora(true, 10, EMarca.Samsung, EProcesador.ADM_Phenom_II);

            pc1.Encender();
            pc2.Apagar();

            pc1.InformarEstado();
            pc2.InformarEstado();

        }
    }
}
