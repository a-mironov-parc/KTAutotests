using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace KeepTeamAutotests.Pages
{
    public class NewUserPopup : PopupPage
    {
                
        [FindsBy(How = How.XPath, Using = "//form[@name = 'usersForm']/div[1]/div/div/div/input")]
        private IWebElement emailField;
        
        [FindsBy(How = How.XPath, Using = "//form[@name = 'usersForm']/div[2]/div/div/textarea")]
        private IWebElement messageField;
        
        [FindsBy(How = How.XPath, Using = "//form[@name = 'usersForm']/div[3]/div/div/div/div")]
        private IWebElement groupList;

        [FindsBy(How = How.XPath, Using = "//form[@name = 'usersForm']/div[4]/div/button")]
        private IWebElement addButton;
      
        public NewUserPopup(PageManager pageManager)
            : base(pageManager)
        {
            pagename = "newuserpopup";

        }

        public void setEmailField(string email)
        {
            setTextField(emailField, email);
        }


        public void setMessageField(string message)
        {
            setTextField(messageField,message);
        }

       
        public void addClick()
        {
            addButton.Click();
            waitSaveDone();
        }

      
        public string getEmail()
        {
            return getTextField(emailField);
        }
        public string getMessage()
        {
            return getTextField(messageField);
        }
       
    }
}
