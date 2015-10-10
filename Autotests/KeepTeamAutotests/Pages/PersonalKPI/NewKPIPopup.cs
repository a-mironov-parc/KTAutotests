using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace KeepTeamAutotests.Pages
{
    public class NewKPIPopup : PopupPage
    {
                
        [FindsBy(How = How.XPath, Using = "//form[@name = 'mainKpiForm']/div[1]/div[1]/div/div/input")]
        private IWebElement nameField;
        
        [FindsBy(How = How.XPath, Using = "//form[@name = 'mainKpiForm']/div[1]/div[2]/div/div/div[1]/input")]
        private IWebElement dateField;

        [FindsBy(How = How.XPath, Using = "//form[@name = 'mainKpiForm']/div[2]/div/div/div/div/div[1]/input")]
        private IWebElement employeeField;
        
        [FindsBy(How = How.XPath, Using = "//div[@class='b-textarea-container'][1]/textarea")]
        private IWebElement descriptionField;

        [FindsBy(How = How.XPath, Using = "//form[@name = 'mainKpiForm']/div[5]/div/div/div/div/div/div[2]/div/div")]
        private IWebElement progressBar;
        [FindsBy(How = How.XPath, Using = "//form[@name = 'mainKpiForm']/div[5]/div/div/div/div/div/div[2]/div")]
        private IWebElement progressBar1;

        [FindsBy(How = How.XPath, Using = "//form[@name = 'mainKpiForm']/div[6]/div/div/div[2]/textarea")]
        private IWebElement measureField;

        [FindsBy(How = How.XPath, Using = "//form[@name = 'mainKpiForm']/div[7]/div/div/div[2]/textarea")]
        private IWebElement actionField;
        
        [FindsBy(How = How.XPath, Using = "//form[@name = 'mainKpiForm']/div[8]/div/button")]
        private IWebElement addButton;

        
      
        public NewKPIPopup(PageManager pageManager)
            : base(pageManager)
        {
            pagename = "newkpipopup";
        }

        public void setNameField(string name)
        {
            setTextField(nameField, name);
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
     
      
        public string getName()
        {
            return getTextField(nameField);
        }
       
        public string getDate()
        {
            //клик в поле, чтобы убрать лишние записи
            dateField.Click();
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

      

        internal void clearDate()
        {
            ClearManual(dateField);
        }

        internal void clearDescription()
        {
            descriptionField.Clear();
        }

        internal void clearActions()
        {
            actionField.Clear();
        }

        internal void clearMeasuring()
        {
            measureField.Clear();
        }

        internal void clearProgress()
        {
            setProgressBar(0);
        }

        internal void setActionsField(string action)
        {
            setTextField(actionField, action);
        }

        internal void setMeasuringField(string measure)
        {
            setTextField(measureField, measure);
        }

        internal string getActions()
        {
            return getTextField(actionField);
        }

        internal string getMeasuring()
        {
            return getTextField(measureField);
        }

        internal int getProgress()
        {
            return getProgressBar(progressBar);
        }

        internal void setProgressBar(int p)
        {
            setProgressBar(progressBar1, p);
            
        }
    }
}
