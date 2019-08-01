using System;
using EntidadesHechas;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCorreo
{
    [TestClass]
    public class PruebasUnitariasCorreo
    {
        [TestMethod]
        public void TestCorreo()
        {
            Correo correo = new Correo();
            
            Assert.IsNotNull(correo);
            Paquete p = new Paquete("calle falsa 123", "1112121212");
            correo += p;
            int cantidadPaquetes = correo.Paquetes.Count;

            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(TrackingRepetidoException))]
        public void TestPaquete()
        {
            Correo correo = new Correo();
            Paquete p = new Paquete("calle falsa 123", "1112121212");
            correo += p;
            Paquete p2 = new Paquete("calle falsa 123", "1112121212");
            correo += p2;
        }

         
    }
}
