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
    public class PopupPage : Page
    {
        [FindsBy(How = How.ClassName, Using = "b-icon-close")]
        private IWebElement closeButton;
        [FindsBy(How = How.ClassName, Using = "b-popup-outline")]
        private IWebElement popup;

        public PopupPage(PageManager pageManager)
            : base(pageManager)
        {
            
        }

        public override void waitSaveDone()
        {
            Thread.Sleep(3000);
            //Ждем скрытия попапа
            /* Слишком долго и не стабильно работает
            var wait = new WebDriverWait(pageManager.driver, TimeSpan.FromSeconds(PageManager.waitTimeForClosePopup));
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated((By.ClassName("b-popup-overlay-content"))));
            */
            
        }
        public virtual void ensurePageLoaded()
        {
            var wait = new WebDriverWait(pageManager.driver, TimeSpan.FromSeconds(PageManager.WAITTIMEFORFINDELEMENT));
            wait.Until(d => d.FindElement(By.ClassName("b-icon-close")));
            //Ожидание пока попап остановится
            waitForFixPosition(pageManager.driver.FindElement(By.ClassName("b-icon-close")));
            
        }
        internal void clickTabByName(string p)
        {
            pageManager.driver.FindElement(By.XPath("//div[text() ='"+p+"']")).Click();
        }
      
        public void closePopup()
        {
            closeButton.Click();
            waitSaveDone();
        }
      
        public override List<IWebElement> GetWebElements()
        {

            // берём все элементы, которые определены для базовой страницы
            List<IWebElement> elements = base.GetWebElements();
            // скриншот попапа
            elements.Add(popup);
            return elements;
        }


    }
}
