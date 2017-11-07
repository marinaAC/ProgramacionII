using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Eventos
    {
        public delegate void ActualizarNombre(string nombre);

        public event ActualizarNombre actualizoLbl;

        public void EventoActualizarNombre(string nombre) 
        {
            actualizoLbl.Invoke(nombre);
        }


    }
}
