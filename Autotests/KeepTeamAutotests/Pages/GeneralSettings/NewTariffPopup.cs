using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepTeamAutotests.Pages
{
    public class NewTariffPopup : PopupPage
    {
              
      
        [FindsBy(How = How.XPath, Using = "//form[@name = 'settingsMainChangeTariff']/div/div/div/div/div[3]/div/div")]
        private IWebElement changeButton;

        public NewTariffPopup(PageManager pageManager)
            : base(pageManager)
        {
            pagename = "tariffpopup";

        }
   
    }
}
