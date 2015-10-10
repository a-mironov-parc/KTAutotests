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
    public class NewCandidatePopup : PopupPage
    {
        [FindsBy(How = How.XPath, Using = "//form[@name = 'applicantsForm']/div[2]/div[1]/div/div/input")]
        private IWebElement lastNameField;
        
        [FindsBy(How = How.XPath, Using = "//form[@name = 'applicantsForm']/div[2]/div[2]/div/div/input")]
        private IWebElement nameField;
        
        [FindsBy(How = How.XPath, Using = "//form[@name = 'applicantsForm']/div[2]/div[3]/div/div/input")]
        private IWebElement patronimycField;

        [FindsBy(How = How.XPath, Using = "//form[@name = 'applicantsForm']/div[3]/div[1]/div/div/div[1]/input")]
        private IWebElement dateField;

        [FindsBy(How = How.XPath, Using = "//form[@name = 'applicantsForm']/div[4]/div[1]/div/div/div[1]/div/input")]
        private IWebElement cityField;       
            
        [FindsBy(How = How.XPath, Using = "//form[@name = 'applicantsForm']/div[3]/div[2]/div/div/div/div/div[2]")]
        private IWebElement sexField;
        
        [FindsBy(How = How.XPath, Using = "//form[@name = 'applicantsForm']//*[@id='businessTrips']")]
        private IWebElement tripCheckBox;
        
        [FindsBy(How = How.XPath, Using = "//form[@name = 'applicantsForm']//*[@id='move']")]
        private IWebElement moveCheckBox; 
        
        [FindsBy(How = How.XPath, Using = "//form[@name = 'applicantsForm']/div[6]/div/div/div/div/div/div/div[2]/div/div/input")]
        private IWebElement contactField;
        
        [FindsBy(How = How.XPath, Using = "//form[@name = 'applicantsForm']/div[6]/div/div/div/div/div/div/div[1]/div/div/div[1]/div/input")]
        private IWebElement contactTypeField;
        
        [FindsBy(How = How.XPath, Using = "//form[@name = 'applicantsForm']/div[5]/div/div/div/textarea")]
        private IWebElement descriptionField;

        [FindsBy(How = How.XPath, Using = "//form[@name = 'applicantsForm']/div[4]/div[4]/div/div/div")]
        private IWebElement skillField;
        
        [FindsBy(How = How.XPath, Using = "//form[@name = 'applicantsForm']/div[3]/div[3]/div/div/input")]
        private IWebElement paymentField;

        [FindsBy(How = How.XPath, Using = "//form[@name = 'applicantsForm']/div[8]/div/button")]
        private IWebElement saveButton;
  
        public NewCandidatePopup(PageManager pageManager)
            : base(pageManager)
        {
            pagename = "newcandidatepopup";

        }

        public void setNameField(string name)
        {
            setTextField(nameField, name);
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
           // return getTextField(dateField,"","января . 45 лет");
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

        internal void setCityField(string city)
        {
            setSuggestField(cityField, city);
        }

        internal void setDateField(string date)
        {
            setDateFieldWithDatePicker(dateField, date);
        }

        internal string getCity()
        {
            return getTextField(cityField);
        }

        internal void setPatronimycField(string patronimyc)
        {
            setTextField(patronimycField, patronimyc);
        }
       
        internal string getContact()
        {
            return getTextField(contactField);
        }
        internal string getContactType()
        {
            return getTextField(contactTypeField);
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

        internal void clearCity()
        {
            cityField.Clear();
        }

      /*  internal void clearFounder()
        {
            founderField.Clear();
        }
        */
        internal void clearDescription()
        {
            descriptionField.Clear();
        }

       /* internal void clearPhone()
        {
            phoneField.Clear();
        }

      /*  internal void clearFound()
        {
            founderField.Clear();
        }
        */
        internal void clearSkill()
        {
            clearStarsField(skillField);
        }

        internal void setMinPay(string MinPay)
        {
            setTextField(paymentField, MinPay);
        }

     /*   internal void setMaxPay(string MaxPay)
        {
            setTextField(maxField, MaxPay);
        }
        */
      /*  internal string getMaxPay()
        {
            return getTextField(maxField);
        }
        */
        internal string getPayment()
        {
            return getTextField(paymentField,""," Р");
        }

       /* internal void clearMaxPay()
        {
            maxField.Clear();
        }
        */
        internal void clearPayment()
        {
            ClearManual(paymentField);//Firefox чудит, надо очищать вручную
           
        }

        internal string getPatronimyc()
        {
            return getTextField(patronimycField);
        }
        internal void clearPatronimyc()
        {
            patronimycField.Clear();
        }

        internal void setSexField(string sex)
        {
            setDropdownByText(sexField, sex);
        }


        internal string getSex()
        {
            return getDropDownText(sexField);
        }

        internal void setTrip(bool p)
        {
            setCheckBox(tripCheckBox,p);
        }

        internal void setMove(bool p)
        {
            setCheckBox(moveCheckBox, p);
        }

        internal void setContact(string contact)
        {
            setTextField(contactField, contact);
        }

        internal void setContactType(string type)
        {
            setSuggestField(contactTypeField, type);
        }

        internal bool getMove()
        {
            return getCheckBox(moveCheckBox);
        }

        internal bool getTrip()
        {
            return getCheckBox(tripCheckBox);
        }

        internal void clearContact()
        {
            contactField.Clear();
        }
        internal void clearContactType()
        {
            contactTypeField.Clear();
        }

    }
}
