using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KeepTeamAutotests.Pages
{
    public class DeleteMessagePage : Page
    {
        [FindsBy(How = How.ClassName, Using = "b-common_context_menu-content")]
        private IWebElement message;
        [FindsBy(How = How.ClassName, Using = "b-confirm_deletion-content--main")]
        private IWebElement headMessage;
        [FindsBy(How = How.ClassName, Using = "b-confirm_deletion-content--second")]
        private IWebElement textMessage;
        //[FindsBy(How = How.ClassName, Using = "b-confirm_deletion-submitters--right")]
        [FindsBy(How = How.XPath, Using = "//div[@class = 'b-confirm_deletion-submitters--right']/div")]//Firefox не хочет нормально по классу нажимать
        private IWebElement yesButton;                     
        [FindsBy(How = How.ClassName, Using = "b-confirm_deletion-submitters--left")]
        private IWebElement noButton;
        
        public DeleteMessagePage(PageManager pageManager)
            : base(pageManager)
        {
            pagename = "deletemessage";
        }

        public override void ensurePageLoaded()
        {
            var wait = new WebDriverWait(pageManager.driver, TimeSpan.FromSeconds(PageManager.WAITTIMEFORFINDELEMENT));
            wait.Until(d => d.FindElement(By.ClassName("b-common_context_menu-content")));
            //Ожидание пока табличка остановится
            waitForFixPosition(pageManager.driver.FindElement(By.ClassName("b-common_context_menu-content")));
        }
      
        public void noButtonClick()
        {
            noButton.Click();
        }
        public void yesButtonClick()
        {
            yesButton.Click();
            waitSecond();
        }
        
        public override List<IWebElement> GetWebElements()
        {

            // берём все элементы, которые определены для базовой страницы
            List<IWebElement> elements = base.GetWebElements();
            // скриншот попапа
            elements.Add(message); 
            return elements;
        }
        
    }
}
