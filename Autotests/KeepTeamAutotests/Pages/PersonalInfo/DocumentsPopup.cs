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
    public class DocumentsPopup : PopupPage
    {
        
        [FindsBy(How = How.XPath, Using = "//header/div")]
        private IWebElement headerField;

        [FindsBy(How = How.XPath, Using = "//form[@common-form = 'popupEmployeeForm']/div[1]/div[2]/div/div/input")]
        private IWebElement seriesField;
        [FindsBy(How = How.XPath, Using = "//form[@common-form = 'popupEmployeeForm']/div[1]/div[1]/div/div/div[1]/input")]
        private IWebElement dateField;
        [FindsBy(How = How.XPath, Using = "//input[@name = 'IssuedBy']")]
        private IWebElement authorField; 
        [FindsBy(How = How.XPath, Using = "//form[@common-form = 'popupEmployeeForm']/div[2]/div[2]/div/div/input")]
        private IWebElement codeField;
        [FindsBy(How = How.XPath, Using = "//div[@class='b-textarea-container']/textarea")]
        private IWebElement descriptionField;
        
        [FindsBy(How = How.XPath, Using = "//*[contains(@class,'b-button b-employees-form-button')]")]
        private IWebElement saveButton;


        public DocumentsPopup(PageManager pageManager)
            : base(pageManager)
        {
            pagename = "document";
        }
        public void setSeriesField(string series)
        {
            setTextField(seriesField, series);
        }
        public string getSeriesField()
        {
            return getTextField(seriesField);
        }
        public void setDescriptionField(string description)
        {
            setTextField(descriptionField, description);
        }

        public string getDescriptionField()
        {
            return getTextField(descriptionField);
        }
     
        public void setDateField(string date)
        {
            setDateFieldWithDatePicker(dateField, date);
        }

        public string getDateField()
        {
            return getTextField(dateField);
        }

        public void setAuthorField(string author)
        {
            setTextField(authorField, author);
        }
        public string getAuthorField()
        {
            return getTextField(authorField, "Выдан ");
            
        }
        public void setCodeField(string code)
        {
            setTextField(codeField, code);
        }
        public string getCodeField()
        {
            return getTextField(codeField);
        }
        public string getHeaderField()
        {
            return headerField.Text;
        }
        

        public void saveClick()
        {
            saveButton.Click();
            waitSaveDone();
        }

       
 
        public void clearSeriesField()
        {
            seriesField.Clear();
        }

        public void clearDateField()
        {
            dateField.Clear();
        }
        public void clearAuthorField()
        {
            authorField.Clear();
        }
        public void clearCodeField()
        {
            codeField.Clear();
        }
        public void clearDescriptionField()
        {
            descriptionField.Clear();
        }
      

    }
}
