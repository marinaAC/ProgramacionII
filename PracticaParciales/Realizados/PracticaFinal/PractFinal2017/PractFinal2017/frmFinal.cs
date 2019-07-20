using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using System.Threading;

namespace PractFinal2017
{
    public partial class frmFinal : Form
    {
        protected MGeneral medicoGeneral;
        protected MEspecialista medicoEspecialista;
        protected Thread mocker;
        protected Queue<Paciente> pacientesEnEspera;

        public frmFinal()
        {
            InitializeComponent();
            this.medicoGeneral = new MGeneral("Luis", "Salinas");
            this.medicoEspecialista = new MEspecialista("Jorge", "Iglesias", MEspecialista.Especialidad.Traumatologo);
            medicoEspecialista.FinAtencionPaciente += FinAtencion;
            medicoGeneral.FinAtencionPaciente += FinAtencion;
        }

        private void btnAtenderMedicoGeneral_Click(object sender, EventArgs e)
        {
            AtenderPacientes(this.medicoGeneral);

        }

        private void btnAtenderMedicoEspecialista_Click(object sender, EventArgs e)
        {
            AtenderPacientes(this.medicoEspecialista);
            
        }

        private void frmFinal_Load(object sender, EventArgs e)
        {
            mocker = new Thread(MockPacientes);
            mocker.Start();
            //inicializar hilo moker
        }

        private void frmFinal_FormClosing(object sender, FormClosingEventArgs e) 
        {
            if(mocker.IsAlive)
            {
                mocker.Abort();
            }
            //cerrara si hay hilos abiertos
        }

        private void MockPacientes() 
        {
            pacientesEnEspera = new Queue<Paciente>();
            Paciente p1 = new Paciente("Cardozo", "Lucia");
            Paciente p2 = new Paciente("Perez", "Ezequiel");
            Paciente p3 = new Paciente("Menganito", "sarasa", 4);
            pacientesEnEspera.Enqueue(p1);
            pacientesEnEspera.Enqueue(p2);
            pacientesEnEspera.Enqueue(p3);
            Thread.Sleep(500);
            //se agregan pacientes cola de espera
        }

        private void AtenderPacientes(IMedico iMedico) 
        {
            int cantidad = pacientesEnEspera.Count();
              if (cantidad > 0)
                {
                    iMedico.IniciarAtencionPaciente(this.pacientesEnEspera.Dequeue());
                }
            
            //llamado en los clicks

        }

        private void FinAtencion(Paciente p, Medico m) 
        {
            string aux = string.Format("Finalizó la atención de {0} por {1}", p.ToString(),m.ToString());
            MessageBox.Show(aux);
        }

    }
}
