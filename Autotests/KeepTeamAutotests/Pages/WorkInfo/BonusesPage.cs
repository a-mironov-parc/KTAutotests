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
    public class BonusesPage : PersonalPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='content']/div/div[1]/div[1]/div/div[1]/span")]
        private IWebElement dateField;
        [FindsBy(How = How.XPath, Using = "//*[@id='content']/div/div[1]/div[1]/div/div[1]/div/div[2]/div")]
        private IWebElement typeField;
        [FindsBy(How = How.XPath, Using = "//*[@id='content']/div/div[1]/div[1]/div/div[2]/div[2]/div")]
        private IWebElement valueField;
        [FindsBy(How = How.XPath, Using = "//*[@id='content']/div/div[1]/div[3]/div/div[2]/div[2]/div/div[1]/div/div")]
        private IWebElement reasonField;
        [FindsBy(How = How.XPath, Using = "//*[@id='content']/div/div[1]/div[3]/div/div[2]/div[2]/div/div[2]/div/div")]
        private IWebElement descriptionField;
        
      

       
        public BonusesPage(PageManager pageManager)
            : base(pageManager)
        {

        }
        public string getDateField()
        {
            return getTextField(dateField);
        }

        public string getPaymentTypeField()
        {
            return getTextField(typeField);
        }
        
        public string getValueField()
        {
            return getTextField(valueField);
        }

        public string getReasonField()
        {
            return getTextField(reasonField);
        }
        public string getDescriptionField()
        {
            return getTextField(descriptionField);
        }


    }
}
