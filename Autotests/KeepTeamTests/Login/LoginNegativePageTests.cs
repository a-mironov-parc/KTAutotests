using System;
using KeepTeamAutotests;
using KeepTeamAutotests.Model;
using NUnit.Framework;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using KeepTeamAutotests.AppLogic;

namespace KeepTeamTests
{
    [TestFixture()]
    public class LoginNegativePageTests : TestBase
    {


        [Test, TestCaseSource(typeof(FileHelper), "loginincorrect")]
        public void LoginNegative(User user)
        {
            app.userHelper.loginAs(user);
            Assert.AreEqual(user.role, app.userHelper.isNotLogged());
        }

        [TearDown]
        public void ClearLogin()
        {
            app.userHelper.loginClear();

        }
      
  

    }
}
