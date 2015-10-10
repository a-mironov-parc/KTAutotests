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
    public class DictionariesPage : CommonPage
    {
        [FindsBy(How = How.ClassName, Using = "b-dictionaries-menu-list")]
        private IWebElement dictionaryList;

        [FindsBy(How = How.ClassName, Using = "b-textfield-input-border")]
        private IWebElement inputFirstField;
        
        

        public DictionariesPage(PageManager pageManager)
            : base(pageManager)
        {

        }

        public void setNewValue(String value)
        {
            setTextField(inputFirstField,value);
        }

        public List<string> getDictionaryList()
        {
            return getList(dictionaryList);
        }

        
    }
}
