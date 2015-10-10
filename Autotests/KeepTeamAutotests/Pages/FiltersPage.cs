using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KeepTeamAutotests.Pages
{
    public class FiltersPage : Page
    {
        //[FindsBy(How = How.XPath, Using = "//div[contains(@class,'b-filters')]")]
        //[FindsBy(How = How.XPath, Using = "//div[@class = 'b-filters g-clearfix ng-scope']")]
        [FindsBy(How = How.XPath, Using = "//*[@id='subheader_pane']")]

        private IWebElement menu;
        
        public FiltersPage(PageManager pageManager)
            : base(pageManager)
        {
            pagename = "filterspage";
        }

        public virtual void ensurePageLoaded()
        {
            var wait = new WebDriverWait(pageManager.driver, TimeSpan.FromSeconds(PageManager.WAITTIMEFORFINDELEMENT));
            wait.Until(d => d.FindElement(By.XPath("//*[contains(@class,'b-filters-field')]")));
            
        }
        public IWebElement byIndex(int index)
        {
            
           // return menu.FindElements(By.XPath("./div[contains(@class,'b-filters-field')]"))[index];
            //return menu.FindElement(By.XPath("//div[contains(@class,'b-filters-field')]["+index+"]"));
            //return menu.FindElement(By.XPath("(//div[@class='b-sub-header-filter-label']//span)[" + index + "]"));
          //  return menu.FindElements(By.XPath("//div[@class='b-sub-header-filter-label']//span"))[index];
            return menu.FindElements(By.XPath("//div[@class='b-sub-header-filter-label']"))[index];
        }
        public IWebElement byText(string text)
        {
            return menu.FindElement(By.XPath("//span[text() ='" + text + "']//.."));//переход на родительский элемент
            //return menu.FindElement(By.XPath("//span[text() ='" + text + "']"));
            //return menu.FindElement(By.XPath("./div[@id='subheader_pane']//span[@text = '"+ text +"']"));
            // return menu.FindElements(By.XPath("./div[contains(@class,'b-filters-field')]"))[index];
           // return menu.FindElement(By.XPath("./div[contains(@class,'b-filters-field b-filters-field--search')]"));
        }
        internal IWebElement getSearchField()
        {
            return menu.FindElement(By.XPath("//div[@class = 'b-textfield-input-border']/input")); 
        }
        
       /*
        public void byTextClick(string text)
        {
           menu.FindElement(By.XPath("//ul[@class = 'b-general-context-menu-list']/li[text() ='" + text + "']")).Click();
          //    menu.FindElement(By.XPath("//li[@ng-click='logoff()']")).Click();
        }
        public void byIndexClick(int i)
        {
            //menu.FindElements(By.XPath("//ul[@class = 'b-general-context-menu-list']/li"))[i].Click();
            menu.FindElements(By.XPath("//*[contains(@class,'b-general-context-menu-list-item')]"))[i].Click(); 
        }
       */
        public override List<IWebElement> GetWebElements()
        {

            // берём все элементы, которые определены для базовой страницы
            List<IWebElement> elements = base.GetWebElements();
            // скриншот всей панели
            elements.Add(menu); 
            return elements;
        }

        internal void clearClick()
        {
            menu.FindElement(By.XPath("//div[@common-reset-filter='common-reset-filter']")).Click();
        }

        internal void clearSearchField()
        {
            menu.FindElement(By.XPath("//div[contains(@class, 'b-filters-field b-filters-field--search')]//i")).Click();
        }
    }
}
