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
    public class ContactsPage : PersonalPage
    {
        [FindsBy(How = How.XPath, Using = "//h1")]
        private IWebElement headerField; 
        
        [FindsBy(How = How.XPath, Using = "//*[@common-form='commonContactEmployeeForm']/div/div[1]/div/div/div/div[1]/input")]
        private IWebElement contactField;
        
        [FindsBy(How = How.XPath, Using = "//*[@common-form='commonContactEmployeeForm']/div/div[2]/div/div/input")]
        private IWebElement valueField;

        [FindsBy(How = How.XPath, Using = "//*[@common-form='commonContactEmployeeForm']/div/div[3]/div/div/input")]
        private IWebElement descriptionField;

     


        public ContactsPage(PageManager pageManager)
            : base(pageManager)
        {

        }

        public void setValueField(string value)
        {
            setTextField(valueField, value);
        }

        public string getValueField()
        {
            return getTextField(valueField);
        }
        public void setDescriptionField(string description)
        {
            setTextField(descriptionField, description);
        }

        public string getDescriptionField()
        {
            return getTextField(descriptionField);
        }

        
        public void setContactField(String contact)
        {
            setSuggestField(contactField, contact);          
        }

        public string getContactField()
        {
            return getTextField(contactField);
        }
       
      

        public void clearValueField()
        {
            valueField.Clear();
        }


        public void clearDescriptionField()
        {
            descriptionField.Clear();
        }
        public void clearContactField()
        {
            contactField.Clear();
        }

        public void headerClick()
        {
            headerField.Click();
        }
        

       
    }
}
