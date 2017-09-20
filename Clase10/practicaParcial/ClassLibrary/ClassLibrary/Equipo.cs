using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    
    class Equipo
    {
        public enum Deportes{  Basquet, Futbol, Handball, Rugby  }

        protected DirectorTecnico dt;
        protected List<Jugador> jugadores;
        protected string nombre;
        protected Deportes deportes;

        public Deportes Deporte
        {
            set 
            { 
                deportes = value; 
            }
        }

        public static Equipo() 
        {
            
        }
        


    }
}
