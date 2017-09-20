using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class DirectorTecnico:Persona
    {
        public DirectorTecnico(string nombre, string apellido): base (nombre,apellido){}

        protected override string FichaTecnica()
        {
            string returnAux = string.Format("{0} {1}", this._nombre, this._apellido);
            return returnAux;
        }

        public override string ToString()
        {
            return this.FichaTecnica();
        }
        
        
    }
}
