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
    public class CandidatePage : CommonPage
    {
        [FindsBy(How = How.XPath, Using = "//button[contains(@class, 'b-header-btn b-header-btn--text')]")]
        private IWebElement newCandidateButton;
        [FindsBy(How = How.XPath, Using = "//h1")]
        private IWebElement header;
        [FindsBy(How = How.XPath, Using = "//*[@id='content']/div[1]/div[1]/div[2]/div[1]/div[5]")]
        private IWebElement menu; 
        [FindsBy(How = How.XPath, Using = "//*[@id='content']/div[1]/div[1]/div[2]")]
        private IWebElement table;
        [FindsBy(How = How.XPath, Using = "//menu/div[2]")]
        private IWebElement directoriesList; //список папок
      //  [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[1]/div/div[3]/div/div/menu/div[2]/div/ul/li[4]/div/div/div")]
        private IWebElement newDirectory; //Кнопка Новая папка
     
        
        public CandidatePage(PageManager pageManager)
            : base(pageManager)
        {
            pagename = "candidate";
        }
      
        public void clickAddCandidate()
        {
            newCandidateButton.Click();

        }

        public void openCandidatePopup(string text)
        {
            getCellByText(table, text).Click();
        
        }

        public void deleteFromThreeDots()
        {
            menu.Click();
       
        }

        internal void openThreeDotsMenu()
        {
            getCellByIndex(table, 1, 18).Click();

        }

        internal void setDirectoryName(string p)
        {
            newDirectory = directoriesList.FindElement(By.XPath("//div[@class='b-sidebar']//span[normalize-space(.)='Новая папка']"));
            newDirectory.Click();
            newDirectory = directoriesList.FindElement(By.XPath("//li//input"));
            setTextField(newDirectory, p);
            newDirectory = directoriesList.FindElement(By.XPath("//span[contains(text(),'Все')]"));
            newDirectory.Click();
            //header.Click();
           
            
        }

        internal string getLastDirectoryName()
        {

            return getCellText(directoriesList.FindElement(By.XPath("//li[3]/div[2]/a/span")),"","\r\n0");
            
        }
  

        internal void DirectorymenuClick()
        {
            directoriesList.FindElement(By.XPath("//li[3]/div[2]/a/div")).Click();
            // contains(@class,b-basket)
                                                    
        }

        internal void openFirstCandidatePopup()
        {
            getCellByIndex(table, 1, 1).Click();
        }
    }
}
