using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class MGeneral:Medico,IMedico
    {
        public MGeneral(string apellido, string nombre) 
            : base(apellido, nombre) { }

        protected override void Atender()
        {
            string men = this.EstoyAtendiendoA;
            int tiempo = tiempoAleatorio.Next(1500, 2200);
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
