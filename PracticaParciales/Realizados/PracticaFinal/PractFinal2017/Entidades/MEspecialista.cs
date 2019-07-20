using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class MEspecialista: Medico,IMedico
    {

        public enum Especialidad { Traumatologo, Odontologo}

        protected Especialidad especialidad;

        public MEspecialista(string apellido, string nombre, Especialidad especialidad)
            :base(apellido,nombre) 
        {
            this.especialidad = especialidad;
        }

        protected override void Atender()
        {
            string men = this.EstoyAtendiendoA;
            int tiempo = tiempoAleatorio.Next(5000, 10000);
            Thread.Sleep(tiempo);
            FinalizarAtencion();
        }

        public void IniciarAtencionPaciente(Paciente p)
        {
            this.AtenderA = p;
            Thread hilo = new Thread(Atender);
            hilo.Start();
        }
    }
}
