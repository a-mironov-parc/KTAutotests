using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace KeepTeamAutotests.Pages
{
    public class NewAssetPopup : PopupPage
    {
                
        [FindsBy(How = How.XPath, Using = "//form[@name = 'assetsForm']/div[1]/div[1]/div/div/input")]
        private IWebElement nameField;
        
        [FindsBy(How = How.XPath, Using = "//form[@name = 'assetsForm']/div[1]/div[2]/div/div/div/div[1]/input")]
        private IWebElement categoryField;
        
        [FindsBy(How = How.XPath, Using = "//form[@name = 'assetsForm']/div[2]/div[1]/div/div/input")]
        private IWebElement IDField;

        [FindsBy(How = How.XPath, Using = "//form[@name = 'assetsForm']/div[2]/div[2]/div/div/div[1]/input")]
        private IWebElement dateField;

        [FindsBy(How = How.XPath, Using = "//form[@name = 'assetsForm']/div[2]/div[3]/div/div/div/div[1]/input")]
        private IWebElement employeeField;
                
        [FindsBy(How = How.XPath, Using = "//div[@class='b-textarea-container']/textarea")]
        private IWebElement descriptionField;
        
        [FindsBy(How = How.XPath, Using = "//form[@name = 'assetsForm']/div[4]/div/div/span/input")]
        private IWebElement onemoreBox;
        
        [FindsBy(How = How.XPath, Using = "//form[@name = 'assetsForm']/div[5]/div/button")]
        private IWebElement addButton; 

       
       


        
      
        public NewAssetPopup(PageManager pageManager)
            : base(pageManager)
        {
            pagename = "newassetpopup";

        }

        public void setNameField(string name)
        {
            setTextField(nameField, name);
        }


        public void setCategoryField(string category)
        {
            setSuggestField(categoryField,category);
        }

        public void setID(string ID)
        {
            setTextField(IDField, ID);
        }
        public void setDateField(string date)
        {
            setDateField(dateField, date);
        }

        public void addClick()
        {
            addButton.Click();
            waitSaveDone();
        }


        public void setEmployeeField(string employee)
        {
            setSuggestField(employeeField, employee);
        }

        public void setDescriptionField(string description)
        {
            setTextField(descriptionField, description);
        }
        public void setOneMoreCheckBox()
        {
            onemoreBox.Click();
        }
      
        public string getName()
        {
            return getTextField(nameField);
        }
        public string getCategory()
        {
            return getTextField(categoryField);
        }
        public string getID()
        {
            return getTextField(IDField);
        }
        public string getDate()
        {
            return getTextField(dateField);
        }

        public string getEmployee()
        {
            return getTextField(employeeField);
        }

        public string getDescription()
        {
            return getTextField(descriptionField);
        }



        internal void clearName()
        {
            nameField.Clear();
        }

        internal void clearCategory()
        {
            categoryField.Clear();
        }

        internal void clearID()
        {
            IDField.Clear();
        }

        internal void clearDate()
        {
            ClearManual(dateField);
        }

        internal void clearDescription()
        {
            descriptionField.Clear();
        }
    }
}
