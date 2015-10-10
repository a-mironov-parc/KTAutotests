using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using KeepTeamAutotests.Pages;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using KeepTeamAutotests.Model;
using System.Threading;

namespace KeepTeamAutotests
{
    public class EmployeesPage : CommonPage
    {
      
        [FindsBy(How = How.XPath, Using = "//*[@id='subheader_pane']/div/div/div[1]/div[8]/div/button/span")]
        private IWebElement ClearFiltersButton;
       
        [FindsBy(How = How.XPath, Using = "//button[@class = 'b-header-link b-header-link--light_zure']")]
        private IWebElement addEmployeeButton;
        
        [FindsBy(How = How.XPath, Using = "//div[@employees-right-panel-list='employees-right-panel-list']/div")]
        private IWebElement AdditionalColumnsSettindButton;

        [FindsBy(How = How.XPath, Using = "//li[@class='b-general-context-menu-list-item']")]
        private IWebElement AdditionalColumnsMenu;

        [FindsBy(How = How.XPath, Using = "//div[@class='b-confirm_columns b-employees-confirm_columns ng-scope b-common_context_menu-screen']")]
        private IWebElement AdditionalColumnsList;

     
        [FindsBy(How = How.XPath, Using = "//div[@class='b-right_panel-button']")]
        private IWebElement FastFinder;
   

        [FindsBy(How = How.ClassName, Using = "b-personal-context-menu-brief_info")]
        private IWebElement personalMenu;

        [FindsBy(How = How.XPath, Using = "//li[@ng-click='logoff()']")]
        private IWebElement logoutButton;

        [FindsBy(How = How.XPath, Using = "//*[@id='content']/div")]
        private IWebElement table;
        

        public EmployeesPage(PageManager pageManager)
            : base(pageManager)
        {
            pagename = "Employees";
        }
     
        public void clickAddEmployee()
        {
            addEmployeeButton.Click();

        }
        public void clickAdditionalColumnsSetting()
        {
            AdditionalColumnsSettindButton.Click();

        }
        public void clickAdditionalColumnsMenu()
        {
            AdditionalColumnsMenu.Click();
            //Ждем анимацию
            Thread.Sleep(1000);
        }

        public EmployeesPage ensurePageLoaded()
        {
            var wait = new WebDriverWait(pageManager.driver, TimeSpan.FromSeconds(PageManager.WAITTIMEFORFINDELEMENT));
            wait.Until(d => d.FindElement(By.XPath("//a[1]")));
            return this;
            
        }

      /*  public void findEmployee(Employee employee)
        {
            employeeLink.FindElement(By.LinkText(employee.lastname)).Click();

        }*/
        override public List<IWebElement> GetWebElements()
        {

            // берём все элементы, которые определены для базовой страницы
            List<IWebElement> elements = base.GetWebElements();
            // а затем добавляем ещё какие-то для данной конкретной страницы
            elements.Add(AdditionalColumnsList);
            elements.Add(addEmployeeButton);
            elements.Add(FastFinder);
            return elements;
        }

        internal void logout()
        {
            personalMenu.Click();

          //  logoutButton.Click();
          
        }
        override public List<IWebElement> GetFilters()
        {

            // берём все фильтры, которые определены для базовой страницы
            List<IWebElement> elements = base.GetFilters();
            // а затем добавляем ещё какие-то для данной конкретной страницы
            return elements;
        }
   
        //процедура ожидания меню
        internal void ensureMenuLoaded()
        {
            var wait = new WebDriverWait(pageManager.driver, TimeSpan.FromSeconds(PageManager.WAITTIMEFORFINDELEMENT));
            wait.Until(d => d.FindElement(By.ClassName("b-personal-context-menu-brief_info")));
            Thread.Sleep(1000);
        }
        internal string getDepartment()
        {
            return getCellText(getCellByIndex(table, 1, 2));
        }

        internal string getStatus()
        {
            return getCellText(getCellByIndex(table, 1, 5));
        }

        internal string getSex()
        {
            return getCellText(getCellByIndex(table, 1, 6));
        }

        internal string getMaritalStatus()
        {
            return getCellText(getCellByIndex(table, 1, 7));
        }
       
    }
}
