using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KeepTeamAutotests;
using KeepTeamAutotests.AppLogic;
using KeepTeamAutotests.Model;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
namespace KeepTeamTests
{
    [TestFixture()]
    public class InternalPageTests: TestBase
    {
       
        [TearDown()]
        public void logout()
        {
            app.userHelper.logout();

        }
      
       
    }
}
