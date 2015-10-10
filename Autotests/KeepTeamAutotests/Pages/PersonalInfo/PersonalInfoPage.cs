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
    public class PersonalInfoPage : PersonalPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@common-form='commonEmployeeForm']/div[1]/div[1]/div/div[2]/input")]
        private IWebElement lastnameField;

        [FindsBy(How = How.XPath, Using = "//*[@common-form='commonEmployeeForm']/div[1]/div[2]/div/div[2]/input")]
        private IWebElement nameField;

        [FindsBy(How = How.XPath, Using = "//*[@common-form='commonEmployeeForm']/div[1]/div[3]/div/div[2]/input")]
        private IWebElement patronymicField;

        [FindsBy(How = How.XPath, Using = "//*[@common-form='commonEmployeeForm']/div[1]/div[4]/div/div[2]/div/input")]
        private IWebElement birthdayField; 

        [FindsBy(How = How.XPath, Using = "//*[@common-form='commonEmployeeForm']/div[2]/div[3]/div/div/div/div[2]/div[1]")]
        private IWebElement sexDropDown; 

        [FindsBy(How = How.XPath, Using = "//*[@common-form='commonEmployeeForm']/div[1]/div[5]/div/div/div/div[2]/div[1]")]
        private IWebElement statusDropDown; //*[@id="content"]/div/div[1]/div[1]/div[2]/form/div[1]/div[5]/div/div/div/div[2]/div[1]

        [FindsBy(How = How.XPath, Using = "//*[@common-form='commonEmployeeForm']/div[1]/div[6]/div/div[2]/input")]
        private IWebElement employeeNumberField;
        
        [FindsBy(How = How.XPath, Using = "//*[@common-form='commonEmployeeForm']/div[2]/div[1]/div/div/div/div[2]/input")]
        private IWebElement nationalityField;

        [FindsBy(How = How.XPath, Using = "//*[@common-form='commonEmployeeForm']/div[2]/div[2]/div/div[2]/input")]
        private IWebElement bornplaceField;
        
        [FindsBy(How = How.XPath, Using = "//*[@common-form='commonEmployeeForm']/div[2]/div[4]/div/div/div/div[2]/div[1]")]
        private IWebElement maritalDropDown;
        
       

        public PersonalInfoPage(PageManager pageManager)
            : base(pageManager)
        {

        }

        public void setLastnameField(string lastname)
        {
            setTextField(lastnameField, lastname);
        }

        public string getLastnameField()
        {
            return getTextField(lastnameField);
        }
        public void setNameField(string name)
        {
            setTextField(nameField, name);
        }

        public string getNameField()
        {
            return getTextField(nameField);
        }

        public void setPatronymicField(string patronymic)
        {
            setTextField(patronymicField, patronymic);
        }

        public string getPatronymicField()
        {
            return getTextField(patronymicField);
        }
        public void setBirthdayField(string birthday)
        {
            setDateField(birthdayField, birthday);
        }

        public string getBirthdayField()
        {
            return getTextField(birthdayField);
        }
        public void setSexField(string sex)
        {
            setDropdownByText(sexDropDown, sex);
            
        }

        public string getSexField()
        {
            return getDropDownText(sexDropDown);
         
        }

        public void setStatusField(string status)
        {
            setDropdownByText(statusDropDown, status);
        }

        public string getStatusField()
        {
            return getDropDownText(statusDropDown);
        }

        public void setNationalityField(string nationality)
        {
            //попытка бороться с багом с исчезновением букв в хроме
            nationalityField.Click();
            setSuggestField(nationalityField, nationality);
        }

        public string getNationalityField()
        {
            return getTextField(nationalityField);
        }
        public void setBornPlaceField(string bornplace)
        {
            setTextField(bornplaceField, bornplace);
        }

        public string getBornPlaceField()
        {
            return getTextField(bornplaceField);
        }
        public void setEmployeeNumberField(string employeeNumber)
        {
            setTextField(employeeNumberField, employeeNumber);
        }

        public string getEmployeeNumberField()
        {
            return getTextField(employeeNumberField);
        }

        public void setMaritalField(string marital)
        {
            setDropdownByText(maritalDropDown, marital);
        }

        public string getMaritalField()
        {
            return getDropDownText(maritalDropDown);
        }

       

        public void clearLastname()
        {
            lastnameField.Clear();
        }

        public void clearName()
        {
            nameField.Clear();
        }

        public void clearPatronymic()
        {
            patronymicField.Clear();
        }

        public void clearBirthday()
        {
            ClearManual(birthdayField);
            //birthdayField.Clear();
        }

        public void clearEmployeeID()
        {
            employeeNumberField.Clear();
        }

        public void clearNationality()
        {
            nationalityField.Clear();
        }

        public void clearBornplace()
        {
            bornplaceField.Clear();
        }
    }
}
