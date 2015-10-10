using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KeepTeamAutotests.Pages
{
    public class GeneralSettingsPage : CommonPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='content']/div[1]/div/div[4]/div[2]/div/div/div[2]/div[1]/div")]
        private IWebElement openNewTariffButton; 
        
       
        public GeneralSettingsPage(PageManager pageManager)
            : base(pageManager)
        {
            pagename = "generalsettings";
        }

        public void openNewTariff()
        {
            openNewTariffButton.Click();
        }

        
    }
}
