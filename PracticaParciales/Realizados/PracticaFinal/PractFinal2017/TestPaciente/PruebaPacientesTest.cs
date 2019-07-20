using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestPaciente
{
    [TestClass]
    public class PruebaPacientesTest
    {
        [TestMethod]
        public void PruebaPacientes()
        {
            Paciente p1 = new Paciente("apellido", "nombre");
            Assert.AreEqual(p1.Turno, 1);
            Paciente p5 = new Paciente("apellido","nombre",5);
            Assert.AreEqual(p5.Turno,5);
            Paciente p6 = new Paciente("apellido", "nombre");
            Assert.AreEqual(p6.Turno, 6);
        }
    }
}
