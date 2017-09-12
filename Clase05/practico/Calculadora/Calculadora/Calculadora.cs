using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Calculadora
    {
        
        public double Operar(Numero numero1, Numero numero2, string operador) 
        {

            double returnAux=0;

            switch(ValidarOperador(operador))
            {
                case "+":
                    returnAux = numero1.getNumero() + numero2.getNumero();
                    break;
                case "-":
                    returnAux = numero1.getNumero() - numero2.getNumero();
                    break;
                case "*":
                    returnAux = numero1.getNumero() * numero2.getNumero();
                    break;
                case "/":
                    if (numero2.getNumero() > 0)
                    {
                        returnAux = numero1.getNumero() / numero2.getNumero();
                    }
                    else 
                    {
                        returnAux = 0;
                    }
                    break;
            }
            
            return returnAux;
        }

        private string ValidarOperador(string operador) 
        {
            
            if(operador != "+" && operador != "-"  && operador != "/" && operador != "*")
            {
                operador = "+";
            }

            return operador;
        }

        

    }
}
