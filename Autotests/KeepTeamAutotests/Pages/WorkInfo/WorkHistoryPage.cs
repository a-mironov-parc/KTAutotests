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
    public class WorkHistoryPage : PersonalPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='content']/div/div[1]/div[1]/div/div[1]/span")]
        private IWebElement addButton;
        [FindsBy(How = How.XPath, Using = "//*[@id='content']/div/div[1]/div/div/div[1]/div/div/div[2]/div")]
        private IWebElement addDocumentsMenu;
        
        [FindsBy(How = How.XPath, Using = "//*[@id='content']/div/div[1]/div[1]/div/div[2]/div[2]/div")]
        private IWebElement FirstDocument;


        [FindsBy(How = How.XPath, Using = "//*[@id='content']/div/div[1]/div[3]/div/div[2]/div[2]/div/div[1]/div/div")]
        private IWebElement typeField;
        [FindsBy(How = How.XPath, Using = "//*[@id='content']/div/div[1]/div[3]/div/div[2]/div[2]/div/div[2]/div/div")]
        private IWebElement dataField;
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[4]/div/div/div[1]/div[3]/div/div[2]/div[2]/div/div[3]/div/div/div[1]")]
        private IWebElement moreInfoField;
        [FindsBy(How = How.XPath, Using = "//*[@id='content']/div/div[1]/div[3]/div/div[2]/div[2]/div/div[4]/div/div/div")]
        private IWebElement dateField;

     

       
        public WorkHistoryPage(PageManager pageManager)
            : base(pageManager)
        {

        }


        public void addWorkHistoryPopup(string WorkHistoryType)
        {
            addButton.Click();
            addDocumentsMenu.FindElement(By.XPath("//li[@class = 'b-general-context-menu-list-item' and text() = '" + WorkHistoryType + "']")).Click();

            
        }

        public void openDocumentPopup(string WorkHistoryType)
        {
            FirstDocument.FindElement(By.XPath("//*[text() = '" + WorkHistoryType + "']")).Click();
        }

       

        public string getTypeField()
        {
            return getTextField(typeField);
        }
        public string getDataField()
        {
            return getTextField(dataField);
        }
        public string getMoreInfoField()
        {
            return getTextField(moreInfoField);
        }

        public string getDateField()
        {
            return getTextField(dateField);
        }

    }
}
