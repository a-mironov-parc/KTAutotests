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
    public class Setting_MenuTests : InternalPageTests
    {
        [SetUp]
        public void Login()
        {
            app.userHelper
             .loginAs(app.userHelper.getAdminUser());


        }

        [Test, TestCaseSource(typeof(FileHelper), "settingmenu")]
       
        public void Click_Menu(Menu menu)
        {
            app.userHelper.clickSettingMenu(menu.MenuName);
            Console.Out.WriteLine(app.userHelper.getURL().Contains(app.userHelper.getBaseURL() + menu.URL));
            Assert.IsTrue(app.userHelper.getURL().Contains(app.userHelper.getBaseURL() + menu.URL));
        }

        
  
    }
}
