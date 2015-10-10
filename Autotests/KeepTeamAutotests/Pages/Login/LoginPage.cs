using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeepTeamAutotests.Pages;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;


namespace KeepTeamAutotests
{
    public class LoginPage : Page
    {

      //  [FindsBy(How = How.Name, Using = "Login")]
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div/div[2]/div[1]/div/form/div[1]/div/div/div/input")]
        private IWebElement usernameField;
        
      //  [FindsBy(How = How.XPath, Using = "//*[@id='pass-field']/div[1]/div/input")]
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div/div[2]/div[1]/div/form/div[2]/div/div[1]/div/input")]
        
        private IWebElement passwordField;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div/div[2]/div[1]/div/form/div[3]/div/button")]
        private IWebElement submitButton;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div/div[1]/div")]
        private IWebElement logo;


        public LoginPage(PageManager pageManager)
            : base(pageManager)
        {
            pagename = "loginpage";
        }
          

        public LoginPage setUserNameField(string username)
        {
            usernameField.SendKeys(username);
            return this;
        }

        public LoginPage setPasswordField(string password)
        {
            passwordField.SendKeys(password);
            return this;
        }

        public void clearPassword()
        {
            passwordField.Clear();
        }

        public void clearLogin()
        {
            usernameField.Clear();
        } 

        public void submitClick()
        {
            submitButton.Click();
        }

        public LoginPage ensurePageLoaded()
        {
            base.ensurePageLoaded();
            var wait = new WebDriverWait(pageManager.driver, TimeSpan.FromSeconds(PageManager.WAITTIMEFORFINDELEMENT));
            wait.Until(d => d.FindElement(By.Name("Login")));
            return this;

        }
        //метод добавления элементов для сравнения
      
        public bool IsOnThisPage()
        {
            return IsElementPresent(By.Name("Login"));
        }




  
        public override List<IWebElement> GetWebElements()
        {

            // берём все элементы, которые определены для базовой страницы
            List<IWebElement> elements = base.GetWebElements();
            // скриншот попапа
            elements.Add(logo);
            elements.Add(submitButton);
            return elements;
        }
    }


}
