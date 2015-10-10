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
    public class UsersPage : CommonPage
    {
        [FindsBy(How = How.ClassName, Using = "b-header-button-text")]
        private IWebElement addUserButton;

       
        public UsersPage(PageManager pageManager)
            : base(pageManager)
        {
            pagename = "users";
        }
        public void clickAddUser()
        {
            addUserButton.Click();

        }

      

        
    }
}
