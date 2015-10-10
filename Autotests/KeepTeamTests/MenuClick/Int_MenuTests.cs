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
    public class Int_MenuTests : InternalPageTests
    {
        [SetUp]
        public void Login()
        {
            app.userHelper
             .loginAs(app.userHelper.getUserByRole("personalRW"));

            
        }

        [Test, TestCaseSource(typeof(FileHelper), "internalmenu")]
        
        public void Click_Menu(Menu menu)
        {
            app.userHelper.clickMenu(menu.MenuName);
            Console.Out.WriteLine(app.userHelper.getURL());
            Assert.IsTrue(app.userHelper.getURL().Contains(app.userHelper.getBaseURL() + menu.URL));
        }
      
       


    }
}
