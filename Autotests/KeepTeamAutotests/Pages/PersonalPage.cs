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
    public class PersonalPage : Page
    {
        [FindsBy(How = How.ClassName, Using = "b-header-button")]
        private IWebElement saveButton;

        public PersonalPage(PageManager pageManager)
            : base(pageManager)
        {
            
        }
        public void ensurePageLoaded()
        {
            //загрузка всех персональных страниц определяется загрузкой панели с фото
            var wait = new WebDriverWait(pageManager.driver, TimeSpan.FromSeconds(PageManager.WAITTIMEFORFINDELEMENT));
            wait.Until(d => d.FindElement(By.ClassName("b-brief_info-content-photo-info-status")));
            //b-brief_info-content-photo-input
            Thread.Sleep(1000);
        }
        public virtual void saveClick()
        {
            saveButton.Click();
           
        }
    }
}
