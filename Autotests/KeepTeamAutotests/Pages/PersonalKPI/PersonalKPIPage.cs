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
    public class PersonalKPIPage : PersonalPage
    {
        [FindsBy(How = How.ClassName, Using = "b-header-button-text")]
        private IWebElement newKPIButton;

        [FindsBy(How = How.XPath, Using = "//*[@id='content']/div")]
        private IWebElement table;
      /*  [FindsBy(How = How.XPath, Using = "//*[@id='subheader_pane']/div/div/div[1]/div/div/span[2]/span")]
        private IWebElement FilterCategory;
        [FindsBy(How = How.XPath, Using = "//*[@id='subheader_pane']/div/div/div[3]/div/div/input")]
        private IWebElement Find;
        */
       
        public PersonalKPIPage(PageManager pageManager)
            : base(pageManager)
        {
            
        }



        public void clickAddKPI()
        {
            newKPIButton.Click();

        }

        public void openKPIPopup()
        {
            getCellByIndex(table, 1, 1).Click();
        }
 

        public void deleteFromThreeDots()
        {
            getCellByIndex(table, 1,6).Click();
        }

   /*     internal void setCategoryFilterValue(string status, string defaultstatus)
        {
            //здесь должна происходить установка фильтра категория
            setCheckBoxFilter(FilterCategory, status, defaultstatus);
        }
        
        internal string getASCategory()
        {
           return getCellText(getCellByIndex(table, 1, 4));

        }

        internal void setFindText(string p)
        {
            setTextField(Find,p);
        }

        internal string getASName()
        {
            return getCellText(getCellByIndex(table, 1, 1));
        }

        internal string getASID()
        {
            return getCellText(getCellByIndex(table, 1, 2));
        }

        internal string getASDate()
        {
            return getCellText(getCellByIndex(table, 1, 3));
        }*/

        internal string getKPIName()
        {
            return getCellText(getCellByIndex(table, 1, 1));
        }

        internal string getKPIDate()
        {
            return getCellText(getCellByIndex(table, 1, 3));
        }

        internal int getKPIProgress()
        {
             return getProgressBar(table.FindElement(By.XPath("//*[@class='b-kpi-progress-bar']")));
        }

        internal string getKPIEmployee()
        {
            return getCellText(getCellByIndex(table, 1, 5));
        }
    }
}
