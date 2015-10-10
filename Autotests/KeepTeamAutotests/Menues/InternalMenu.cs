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
    public class InternalMenu : BaseMenu
    {
     
        [FindsBy(How = How.ClassName, Using = "b-sidebar-menu")]
        private IWebElement Menu;

        
         public InternalMenu(PageManager pageManager)
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

       
    }
}
