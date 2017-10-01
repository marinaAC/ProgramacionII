using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio38
{
    class Sobreescrito
    {
        public override string ToString()
        {
            string returnAux = "¡Este es mi método ToString sobreescrito!";
            return returnAux;
        }

        public override bool Equals(object obj)
        {
            bool returnAux = false;
            if(obj.GetType() != typeof(Sobreescrito))
            {
                returnAux = false;
            }
            if (ReferenceEquals(this, obj))
            {
                returnAux = true;
            }
            return returnAux;
        }

        public override int GetHashCode()
        {
            int returnAux = 1142510187;
            return returnAux;
        }
    }
}
