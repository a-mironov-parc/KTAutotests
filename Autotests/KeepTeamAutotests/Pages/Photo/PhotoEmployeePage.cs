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
    public class PhotoEmployeePage : PersonalPage
    {
        [FindsBy(How = How.ClassName, Using = "b-brief_info-content-photo-info-menu-icon")]
        private IWebElement menuButton;
                
        [FindsBy(How = How.ClassName, Using = "b-header-button")]
        private IWebElement saveButton;

        public PhotoEmployeePage(PageManager pageManager)
            : base(pageManager)
        {

        }

        public void menuButtonClick()
        {
            menuButton.Click();
        }

        public void saveClick()
        {
            saveButton.Click();
        }
   
        
    }
}
