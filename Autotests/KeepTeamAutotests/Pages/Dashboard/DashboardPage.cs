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
    public class DashboardPage : PersonalPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='content']/div/div[1]/table[1]/tbody/tr/td[1]")]
        private IWebElement AgeField;


        public DashboardPage(PageManager pageManager)
            : base(pageManager)
        {

        }

        
    }
}
