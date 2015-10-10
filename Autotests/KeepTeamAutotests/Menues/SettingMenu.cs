using KeepTeamAutotests.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepTeamAutotests.Menues
{
    public class SettingMenu : BaseMenu
    {
        [FindsBy(How = How.XPath, Using = "//ul[@class = 'b-sidebar-menu-list b-sidebar-menu-list--first'] ")]
        private IWebElement Menu;
        
        
         public SettingMenu(PageManager pageManager)
            : base(pageManager)
        {
               
        }

        public void ClickByText(String text)
        {
            Menu.FindElement(By.LinkText(text)).Click();
        }

        public void ClickByIndex(int index)
        {
            Menu.FindElements(By.ClassName("b-sidebar-menu-list-item"))[index].Click();
        }
        public void ensurePageLoaded()
        {
            var wait = new WebDriverWait(pageManager.driver, TimeSpan.FromSeconds(PageManager.WAITTIMEFORFINDELEMENT));
            wait.Until(d => d.FindElement(By.XPath("//*[contains(@class,'b-employees-personal-header')]")));
            
        }

       
    }
}
