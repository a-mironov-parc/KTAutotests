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
    public class PersonalAssetPage : PersonalPage
    {
        [FindsBy(How = How.ClassName, Using = "b-header-button-text")]
        private IWebElement newAssetButton;

        [FindsBy(How = How.XPath, Using = "//*[@id='content']/div")]
        private IWebElement table;
        
        public PersonalAssetPage(PageManager pageManager)
            : base(pageManager)
        {
            
        }



        public void clickAddAsset()
        {
            newAssetButton.Click();

        }

        public void openAssetPopup()
        {
            getCellByIndex(table, 1, 1).Click();
        }
 

        public void deleteFromThreeDots()
        {
            getCellByIndex(table, 1,5).Click();

        }

        internal string getASCategory()
        {
            return getCellText(getCellByIndex(table, 1, 4));

        }

       

        internal string getASName()
        {
            return getCellText(getCellByIndex(table, 1, 1));
        }

        internal string getASID()
        {
            return getCellText(getCellByIndex(table, 1, 2));
        }

        internal string getASDate()
        {
            return getCellText(getCellByIndex(table, 1, 3));
        }
    }
}
