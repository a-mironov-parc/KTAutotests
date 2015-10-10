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
    public class DocumentsPage : PersonalPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='content']/div/div[1]/div[3]/div/div[1]/span")]
        private IWebElement addButton;
        [FindsBy(How = How.XPath, Using = "//*[@id='content']/div/div[1]/div[3]/div/div[1]/div/div[2]/div/div/ul/li[1]")]
        private IWebElement addDocumentsMenu;
        [FindsBy(How = How.XPath, Using = "//*[@id='content']/div/div[1]/div[3]/div/div[2]/div[2]")]
        private IWebElement FirstDocument;
        [FindsBy(How = How.XPath, Using = "//*[@id='content']/div/div[1]/div[3]/div/div[2]/div[2]/div/div[1]/div/div")]
        private IWebElement typeField;
        [FindsBy(How = How.XPath, Using = "//*[@id='content']/div/div[1]/div[3]/div/div[2]/div[2]/div/div[2]/div/div")]
        private IWebElement dataField;
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[4]/div/div/div[1]/div[3]/div/div[2]/div[2]/div/div[3]/div/div/div[1]")]
        private IWebElement moreInfoField;
        [FindsBy(How = How.XPath, Using = "//*[@id='content']/div/div[1]/div[3]/div/div[2]/div[2]/div/div[4]/div/div/div")]
        private IWebElement dateField;

        
   

       
        public DocumentsPage(PageManager pageManager)
            : base(pageManager)
        {

        }

       /* public void openFirstDocumentPopup()
        {
            //FirstDocument.Click();
            openDocumentPopup("Паспорт");
        }
        */
        public void openDocumentPopup(string docType)
        {
            FirstDocument.FindElement(By.XPath("//*[text() = '" + docType + "']")).Click();
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


        internal void addButtonClick()
        {
            addButton.Click();
        }
    }
}
