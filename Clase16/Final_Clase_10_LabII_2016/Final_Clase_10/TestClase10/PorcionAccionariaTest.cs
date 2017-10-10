using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Clase_10_Library;
using Clase_8_Library;

namespace TestClase10
{
    [TestClass]
    public class PorcionAccionariaTest
    {
        [TestMethod]
        public void PorcionAccionariaTest()
        {
            Accionista accCorrecta = new Accionista("Pedro","Alberto", 20);
            Assert.AreEqual(accCorrecta.PorcionAccionaria, 20);

            Accionista accCorrecta2 = new Accionista("Pedro", "Alberto", 50);
            Assert.AreEqual(accCorrecta2.PorcionAccionaria, 50);


            try
            {
                Accionista fueraRango = new Accionista("Pedro", "Alberto", -1);
            }
            catch (AccionMenorCeroEx e)
            {

                Console.WriteLine(e.ToString());
            }


            try
            {
                Accionista fueraRango = new Accionista("Pedro", "Alberto", 10000);
            }
            catch (AccionMayorACienEx e)
            {

                Console.WriteLine(e.ToString());
            }

        }
    }
}
