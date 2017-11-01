using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Persona
    {
        private int id;
        private string nombre;
        private string apellido;

        public int Id 
        {
            get 
            {
                return id;
            }
        }

        public string Nombre 
        { 
            get
            {
                return nombre;
            }
            set 
            {
                nombre = value;
            } 
        }

        public string Apellido 
        {
            get 
            {
                return apellido;
            }
            set 
            {
                apellido = value;
            } 
        }

        public Persona(string id,string nombre, string apellido) 
        {

            this.apellido = apellido;
            this.nombre = nombre;
            if (!int.TryParse(id, out this.id)) 
            {
                throw new Exception();
            }
        }


    }
}
