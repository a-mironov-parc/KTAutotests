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
    public class DeleteEmployeePopup : PopupPage
    {

        [FindsBy(How = How.XPath, Using = "//li[1]/span/input")]
        private IWebElement CheckBox1;   

        [FindsBy(How = How.XPath, Using = "//li[2]/span/input")]
        private IWebElement CheckBox2;

        [FindsBy(How = How.XPath, Using = "//li[3]/span/input")]
        private IWebElement CheckBox3;

        [FindsBy(How = How.XPath, Using = "//li[4]/span/input")]
        private IWebElement CheckBox4;

        [FindsBy(How = How.XPath, Using = "//div[@class ='l-right']/button")]
        private IWebElement DeleteButton;


        public DeleteEmployeePopup(PageManager pageManager)
            : base(pageManager)
        {
            pagename = "deleteuserpopup";

        }

        public void setCheckBoxAll()
        {
            CheckBox1.Click();
            CheckBox2.Click();
            CheckBox3.Click();
            CheckBox4.Click();
        }
       

        public void deleteButtonClick()
        {

            DeleteButton.Click();
            waitSaveDone();
        
        }
       
    }
}
