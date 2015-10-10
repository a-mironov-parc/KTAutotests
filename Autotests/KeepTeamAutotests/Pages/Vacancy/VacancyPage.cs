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
    public class VacancyPage : CommonPage
    {
        [FindsBy(How = How.ClassName, Using = "b-header-button-text")]
        private IWebElement newVacancyButton;

        [FindsBy(How = How.XPath, Using = "//*[@id='content']/div[1]/div[1]/div[2]")]
        private IWebElement table;
     
        public VacancyPage(PageManager pageManager)
            : base(pageManager)
        {
            pagename = "vacancy";
        }



        public void clickAddVacancy()
        {
            newVacancyButton.Click();

        }

        public void openThreeDotsMenu()
        {
              getCellByIndex(table, 1, 6).Click();
        }

        internal string getDepartment()
        {
            return getCellText(getCellByIndex(table, 1, 5));
        }
    

        internal string getStatus()
        {

            return "Открыта";
        }

        internal string getName()
        {
            return getCellText(getCellByIndex(table, 1, 1));
        }

        internal string getFilial()
        {
            return getCellText(getCellByIndex(table, 1, 4));
        }
    }
}
