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
    public class LoginPositivePageTests : InternalPageTests
    {

        [Test, TestCaseSource(typeof(FileHelper), "user")]
        public void LoginPositive(User user)
        {
            app.userHelper.loginAs(user);
            //проверка выполняется методом логаут.
            Assert.IsTrue(app.userHelper.isLoggedIn());
        }
       
       





    }
}
