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
    public class TestBase
    {
        protected AppManager app;

        [SetUp]
        public void Init()
        {

            string browserType = System.Environment.GetEnvironmentVariable("BROWSER");
            string baseUrl = System.Environment.GetEnvironmentVariable("BASE_URL");
            string hubUrl = System.Environment.GetEnvironmentVariable("HUB_URL");

            if (baseUrl == null)
            {
                baseUrl = "http://autotest.test.keepteam.ru";
            }
            
            DesiredCapabilities capabilities = new DesiredCapabilities();

            //Mac 48
            //Win8 49
            //hubUrl = "http://192.168.0.48:4444/wd/hub"; browserType = "chrome";

            capabilities.SetCapability(CapabilityType.BrowserName,
                browserType != null ? browserType : "chrome");

            app = new AppManager(capabilities, baseUrl, hubUrl);

        }

       
      
       
    }
}
