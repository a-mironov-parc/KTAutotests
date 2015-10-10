using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using KeepTeamAutotests.Pages;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using KeepTeamAutotests.Model;
using System.Threading;

namespace KeepTeamAutotests
{
    public class CalendarTimeOffPage : CommonPage
    {
        [FindsBy(How = How.XPath, Using = "//canvas")]
        private IWebElement calendar;
        
        public CalendarTimeOffPage(PageManager pageManager)
            : base(pageManager)
        {
            pagename = "calendar";
        }
     
        public void ensurePageLoaded()
        {
            var wait = new WebDriverWait(pageManager.driver, TimeSpan.FromSeconds(PageManager.WAITTIMEFORFINDELEMENT));
            wait.Until(d => d.FindElement(By.XPath("//canvas")));
            Thread.Sleep(2000);
            
        }
        override public List<IWebElement> GetWebElements()
        {
            // берём все элементы, которые определены для базовой страницы
            List<IWebElement> elements = base.GetWebElements();
            // а затем добавляем ещё какие-то для данной конкретной страницы
            elements.Add(calendar);
            return elements;
        }
        
    }
}
