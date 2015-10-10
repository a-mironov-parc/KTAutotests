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
    public class CommentsTab : PopupPage
    {
        [FindsBy(How = How.XPath, Using = "//form[@name = 'applicantsForm']/div[2]/div[1]/div/div/input")]
        private IWebElement lastNameField;

        [FindsBy(How = How.XPath, Using = "//form[@name = 'applicantsForm']/div/div/div/div/div[1]/div/div[2]/div/div/div/div/div/input")]
        private IWebElement commentsField;

        [FindsBy(How = How.XPath, Using = "//form[@name = 'applicantsForm']/div/div/div/div/div[1]/div/div[2]/div/div[1]/div/div/textarea")]
        private IWebElement commentsField1;

        [FindsBy(How = How.XPath, Using = "/html/body/div[5]/div/div/div/div/section[3]/form/div/div/div/div/div[2]/div/div[2]/div/div/div[1]/span[2]")]
        private IWebElement commentsField2;



        [FindsBy(How = How.XPath, Using = "//form[@name = 'applicantsForm']/div/div/div/div/div[1]/div/div[2]/div/div[2]/div/div[1]")]
        private IWebElement saveButton;

        [FindsBy(How = How.XPath, Using = "//form[@name = 'applicantsForm']/div[3]/div[1]/div/div/div[1]/input")]
        private IWebElement dateField;///html/body/div[3]/div/div/div/div/section/form/div[3]/div[1]/div/div/div[1]/input
        
        [FindsBy(How = How.XPath, Using = "//form[@name = 'applicantsForm']/div[3]/div[2]/div/div/input")]
        private IWebElement placeField;

        [FindsBy(How = How.XPath, Using = "//form[@name = 'applicantsForm']/div[4]/div[2]/div/div/input")]
        private IWebElement founderField;
        
        [FindsBy(How = How.XPath, Using = "//form[@name = 'applicantsForm']/div[5]/div/div/div/textarea")]
        private IWebElement descriptionField;

        [FindsBy(How = How.XPath, Using = "//form[@name = 'applicantsForm']/div[6]/div[1]/div/div/input")]
        private IWebElement phoneField;

        [FindsBy(How = How.XPath, Using = ".//*[@id='foundIndependently']")]
        private IWebElement foundCheckBox;
  
        [FindsBy(How = How.XPath, Using = "//form[@name = 'applicantsForm']/div[4]/div[3]/div/div/div")]
        private IWebElement skillField;

        [FindsBy(How = How.XPath, Using = "//form[@name = 'applicantsForm']/div[3]/div[3]/div/div/input")]
        private IWebElement minField;

        [FindsBy(How = How.XPath, Using = "//form[@name = 'applicantsForm']/div[3]/div[4]/div/div/input")]
        private IWebElement maxField; 
       
        
        


        
      
        public CommentsTab(PageManager pageManager)
            : base(pageManager)
        {
            pagename = "commentscandidate";

        }
        internal void addComment(string text)
        {
            commentsField.Click();
            setTextField(commentsField1, text);
            saveButton.Click();
        }

        internal string getMessage()
        {
            waitSecond();
            return getTextField(commentsField2);
        }
/*
        public void setComments(string name)
        {
            setTextField(commentsField, name);
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
            return getTextField(dateField,""," . 45 лет");
        }

    

        public string getDescription()
        {
            return getTextField(descriptionField);
        }


        internal void saveClick()
        {
            saveButton.Click();
            waitSaveDone();
        }

        internal void setLastNameField(string lastname)
        {
            setTextField(lastNameField, lastname);
        }

        internal string getLastName()
        {
            return getTextField(lastNameField);
        }

      

        internal void setPlaceField(string place)
        {
            setTextField(placeField, place);
        }

        internal void setDateField(string date)
        {
            setDateFieldWithDatePicker(dateField, date);
        }

        internal string getPlace()
        {
            return getTextField(placeField);
        }

        internal void setFounderField(string founder)
        {
            setTextField(founderField, founder);
        }

        internal string getFounder()
        {
            return getTextField(founderField,"Источник: ");
        }

        internal string getPhone()
        {
            return getTextField(phoneField);
        }

        internal void setPhoneField(string phone)
        {
            setTextField(phoneField, phone); 
        }

        internal void setFounderCheckbox(bool found)
        {
            setCheckBox(foundCheckBox, found);
          
        }

        internal bool getFound()
        {
            return getCheckBox(foundCheckBox);
        }

        internal void setSkill(int skill)
        {
            setStarsField(skillField, skill);
        }

        internal int getSkill()
        {
            return getStarsField(skillField);
        }

        internal void clearName()
        {
            nameField.Clear();
        }

        internal void clearLastname()
        {
            lastNameField.Clear();
        }

        internal void clearDateBirthday()
        {
            ClearManual(dateField);
        }

        internal void clearPlace()
        {
            placeField.Clear();
        }

        internal void clearFounder()
        {
            founderField.Clear();
        }

        internal void clearDescription()
        {
            descriptionField.Clear();
        }

        internal void clearPhone()
        {
            phoneField.Clear();
        }

        internal void clearFound()
        {
            founderField.Clear();
        }

        internal void clearSkill()
        {
            clearStarsField(skillField);
        }

        internal void setMinPay(string MinPay)
        {
            setTextField(minField, MinPay);
        }

        internal void setMaxPay(string MaxPay)
        {
            setTextField(maxField, MaxPay);
        }

        internal string getMaxPay()
        {
            return getTextField(maxField);
        }

        internal string getMinPay()
        {
            return getTextField(minField);
        }

        internal void clearMaxPay()
        {
            maxField.Clear();
        }

        internal void clearMinPay()
        {
            minField.Clear();
        }
 */
    }
 
}
