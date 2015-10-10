using System;
using KeepTeamAutotests;
using KeepTeamAutotests.Model;
using NUnit.Framework;

namespace KeepTeamTests
{
    [TestFixture()]
    public class LoginPageScreenTests : TestBase
    {

        
        [Test()]
        public void Compare_Image_LoginPage()
        {
            //Проверка соответствия скриншотов
            Assert.IsTrue(app.screenHelper.LoginPageScreen());
      
        }
        
        

    }
}
