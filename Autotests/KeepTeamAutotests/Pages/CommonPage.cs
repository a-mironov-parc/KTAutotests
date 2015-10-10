using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepTeamAutotests.Pages
{
    public class CommonPage : Page
    {
        public CommonPage(PageManager pageManager)
            : base(pageManager)
        {
            
        }

        public CommonPage ensurePageLoaded()
        {

            var wait = new WebDriverWait(pageManager.driver, TimeSpan.FromSeconds(PageManager.WAITTIMEFORFINDELEMENT));
            wait.Until(d => d.FindElement(By.ClassName("b-sidebar-header")));
            return this;
        }
    }
}
