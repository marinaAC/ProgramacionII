using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_8_Library;


namespace Clase_10_Library
{
    public class PersonaExcepcion: Exception
    {
        public PersonaExcepcion(string men)
            : base(men)
       {
       }
    }
}
