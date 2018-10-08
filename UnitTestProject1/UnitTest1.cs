using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using POCV2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            LoginCls log = new LoginCls(); 
            Assert.AreEqual(log.autenticacionDeUsuarios("",""), true);
        }
    }
}
