using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace ClassLibrary1
{
    class test
    {
        [TestFixture]
        public class LoginTestCls
        {
            [TestCase]
            public void Autenticacion_de_usuario_correcta()
            {
                var login = new LoginCls();

                Assert.AreEqual("Autenticacion de usuario correcta.", login.autenticacionDeUsuarios("uswe", "Pass1258/*"));

            }

        }
    }
}
