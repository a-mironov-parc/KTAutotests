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
    public class ContextMenuPage : Page
    {
        [FindsBy(How = How.ClassName, Using = "b-general-context-menu-list")]
        private IWebElement menu;
        
        public ContextMenuPage(PageManager pageManager)
            : base(pageManager)
        {
            pagename = "contextmenu";
        }

        public virtual void ensurePageLoaded()
        {
            var wait = new WebDriverWait(pageManager.driver, TimeSpan.FromSeconds(PageManager.WAITTIMEFORFINDELEMENT));
            wait.Until(d => d.FindElement(By.ClassName("b-general-context-menu-list")));
            //Ожидание пока табличка остановится
           /* while (FixPosition(pageManager.driver.FindElement(By.ClassName("b-general-context-menu-list"))))
            { 
            };
           */
        }
       
        public void byTextClick(string text)
        {
           menu.FindElement(By.XPath("//ul[@class = 'b-general-context-menu-list']/li[text() ='" + text + "']")).Click();
          //    menu.FindElement(By.XPath("//li[@ng-click='logoff()']")).Click();
        }
        public void byIndexClick(int i)
        {
            //menu.FindElements(By.XPath("//ul[@class = 'b-general-context-menu-list']/li"))[i].Click();
            menu.FindElements(By.XPath("//*[contains(@class,'b-general-context-menu-list-item')]"))[i].Click(); 
        }
       
        public override List<IWebElement> GetWebElements()
        {

            // берём все элементы, которые определены для базовой страницы
            List<IWebElement> elements = base.GetWebElements();
            // скриншот попапа
            elements.Add(menu); 
            return elements;
        }
        
    }
}
