using System;
using BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestPrueba
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestUsuario()
        {
            Usuario u = new Empleado("usuario1","usuario","1234",Empleado.Area.RRHH);
            Assert.IsNotNull(u);
            Usuario u2 = new Externo("usuario","sadsad");
            Assert.IsNotNull(u2);
        }



        [TestMethod]
        [ExpectedException(typeof(BusinessException))]
        public void TestExecpcion()
        {
            
            UsuarioDAO.Autenticar("sadsad", "ssadsad");
            
            

        }
    }
}
