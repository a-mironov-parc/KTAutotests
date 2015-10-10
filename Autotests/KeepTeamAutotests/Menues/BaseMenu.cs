using KeepTeamAutotests.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepTeamAutotests.Menues
{
    public class BaseMenu : Page
    {
        public BaseMenu(PageManager pageManager)
            : base(pageManager)
        {
               
        }
        public void ensurePageLoaded()
        {
            var wait = new WebDriverWait(pageManager.driver, TimeSpan.FromSeconds(PageManager.WAITTIMEFORFINDELEMENT));
            wait.Until(d => d.FindElement(By.ClassName("b-sidebar-menu")));
        }
    }


   
         
}


