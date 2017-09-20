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
        protected Deportes deporte;

        public Deportes Deporte
        {
            set 
            { 
                deporte = value; 
            }
        }

        
        public static Equipo() 
        {
            Equipo equ = new Equipo();
            equ.deporte = Deportes.Futbol;
            
        }
         
        private Equipo() 
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(string nombre, DirectorTecnico dt):this() 
        {
            this.dt = dt;
            this.nombre = nombre;
        }

        public Equipo(string nombre, DirectorTecnico dt, Deportes dep)
            : this()
        {
            this.dt = dt;
            this.nombre = nombre;
            this.deporte = dep;
        }





    }
}
