using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente: Persona
    {
        protected int turno;
        protected static int ultimoTurnoDado;

        public int Turno 
        {
            get 
            {
                return turno;
            } 
        }

        #region Constructores
        static Paciente() 
        {
            ultimoTurnoDado = 0;
        }

        public Paciente(string apellido, string nombre)
            :base(apellido,nombre) 
        {
            ultimoTurnoDado++;
            this.turno = ultimoTurnoDado;
        }
        public Paciente(string apellido, string nombre, int turno)
            :base(apellido, nombre) 
        {
            ultimoTurnoDado = turno;
            this.turno = turno;
        }
        #endregion

        #region Metodos
        public override string ToString()
        {
            string aux = string.Format("Turno N°: {0}: {1}, {2}", this.turno, this.apellido, this.nombre);
            return aux;
        }
        #endregion
    }
}
