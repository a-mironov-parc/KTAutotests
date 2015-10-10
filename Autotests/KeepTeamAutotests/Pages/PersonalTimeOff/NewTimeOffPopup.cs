using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepTeamAutotests.Pages
{
    public class NewTimeOffPopup : PopupPage
    {

        [FindsBy(How = How.XPath, Using = "//form[@name = 'timeOffsForm']/div[1]/div[1]/div[2]/div[1]/div/div/div/div/div/div[1]")]
        private IWebElement typeField; 
        
        [FindsBy(How = How.XPath, Using = "//form[@name = 'timeOffsForm']/div[1]/div[1]/div[2]/div[4]/div[1]/div/div/div[1]/input")]
        private IWebElement startDateField;
        
        [FindsBy(How = How.XPath, Using = "//form[@name = 'timeOffsForm']/div[1]/div[1]/div[2]/div[4]/div[2]/div/div/div[1]/input")]
        private IWebElement endDateField;

        [FindsBy(How = How.XPath, Using = "//div[@class='b-textarea-container']/textarea")]
        private IWebElement descriptionField;
        
        [FindsBy(How = How.XPath, Using = "//form[@name = 'timeOffsForm']/div[1]/div[2]/div[2]/div/div/div/div/div/div/div[1]/input")]
        private IWebElement interestedField;   //Поле для заполнения заинтересованного                         
                                                                     
        [FindsBy(How = How.XPath, Using = "//form[@name = 'timeOffsForm']/div[1]/div[2]/div[2]/div/div/div/div/div")]
        private IWebElement interestedField1;  //Поле для чтения поля заинтересованного                           

        [FindsBy(How = How.XPath, Using = "//form[@name = 'timeOffsForm']/div[1]/div[1]/div[2]/div[2]/div/div/div/div[1]/div/div[1]")]
        private IWebElement reasonField; 
        
        [FindsBy(How = How.XPath, Using = "//form[@name = 'timeOffsForm']/div[1]/div[1]/div[2]/div[3]/div/div/div/input")]
        private IWebElement numberField;
        
        [FindsBy(How = How.XPath, Using = "//form[@name = 'timeOffsForm']/div[3]/div/div[1]")]
        private IWebElement saveButton;
        
        public NewTimeOffPopup(PageManager pageManager)
            : base(pageManager)
        {
            pagename = "timeoffpopup";

        }

        public void setStartDateField(string date)
        {
            setDateFieldWithDatePicker(startDateField, date);
        }


        public void setEndDateField(string date)
        {
            setDateFieldWithDatePicker(endDateField, date);
        }

        public void setInterested(string interested)
        {
            setSuggestField(interestedField, interested);
        }
        public void setDescription(string description)
        {
            setTextField(descriptionField, description);
        }

        public void saveClick()
        {
            saveButton.Click();
            waitSaveDone();
        }


        public void setTypeField(string type)
        {
            setDropdownByText(typeField, type);
        }

        public void setReasonField(string reason)
        {
            setDropdownByText(reasonField, reason);
        }
        public void setNumber(string number)
        {
            setTextField(numberField, number);
        }
      

        public string getTypeTO()
        {
            return typeField.Text;
        }
        public string getInterested()
        {
            return getCellText(interestedField1);
            
        }
        public string getReason()
        {
            return getDropDownText(reasonField);
        }
        public string getNumber()
        {
            return getTextField(numberField);
        }

        public string getStartDate()
        {
            return getTextField(startDateField, "С ");
        }

        public string getEndDate()
        {
            return getTextField(endDateField, "По ");
        }

        public string getDescription()
        {
            return getTextField(descriptionField);
        }

       
    }
}
