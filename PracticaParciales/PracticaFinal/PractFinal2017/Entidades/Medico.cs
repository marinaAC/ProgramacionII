using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Medico: Persona
    {
        protected Paciente paciente;
        protected static Random tiempoAleatorio;

        #region Properties
        public Paciente AtenderA 
        {
            set 
            {
                if(!ReferenceEquals(value,null))
                {
                    paciente = value;
                }
            }
        }

        public string EstoyAtendiendoA 
        {
            get
            {
                return paciente.ToString();
            }  
        }
        #endregion

        #region Constructor
        static Medico() 
        {
            tiempoAleatorio = new Random();
        }

        public Medico(string apellido, string nombre)
            : base(apellido, nombre) { }
        #endregion

        #region Metodos
        protected abstract void Atender();
        public void FinalizarAtencion() 
        {
            FinAtencionPaciente(this.paciente,this);
            this.paciente = null;
        }

        public delegate void AtencionFinalizada(Paciente p, Medico m);
        public event AtencionFinalizada FinAtencionPaciente;
        #endregion
    }
}
