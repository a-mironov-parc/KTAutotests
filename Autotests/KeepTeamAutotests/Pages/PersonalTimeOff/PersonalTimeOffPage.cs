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
    public class PersonalTimeOffPage : PersonalPage
    {
        [FindsBy(How = How.ClassName, Using = "b-header-button-text")]
        private IWebElement newTimeOffButton; 
       
        [FindsBy(How = How.XPath, Using = "//*[@id='content']/div/div/div[2]")]
        private IWebElement table;
       
        public PersonalTimeOffPage(PageManager pageManager)
            : base(pageManager)
        {
            
        }



        public void clickAddTimeOff()
        {
            newTimeOffButton.Click();

        }

        public void openTimeOffPopup()
        {
            getCellByIndex(table, 1, 1).Click();
                //FindElement(By.XPath("//*[text() = '" + TOtype + "']")).Click();
        }
        public void openTimeOffPopupByType(string type)
        {
            getCellByText(table, type).Click();
        }
       

     
        internal void deleteFromThreeDots()
        {
            getCellByIndex(table, 1, 5).Click();
        }
    }
}
