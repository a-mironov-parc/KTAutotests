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
    public class EducationPopup : PopupPage
    {
        
        [FindsBy(How = How.XPath, Using = "//form[@common-form = 'popupEmployeeForm']/div[1]/div[1]/div/div/div/div[1]/input")]
        private IWebElement typeField;
        [FindsBy(How = How.XPath, Using = "//form[@common-form = 'popupEmployeeForm']/div[1]/div[2]/div/div/div/div[1]/input")]
        private IWebElement universityField;
        [FindsBy(How = How.XPath, Using = "//form[@common-form = 'popupEmployeeForm']/div[2]/div[1]/div/div/div/input")]
        private IWebElement dateField;
        [FindsBy(How = How.XPath, Using = "//form[@common-form = 'popupEmployeeForm']/div[2]/div[2]/div/div/div/div[1]/input")]
        private IWebElement specialityField;
        [FindsBy(How = How.XPath, Using = "//form[@common-form = 'popupEmployeeForm']/div[3]/div[1]/div/div/input")]
        private IWebElement diplomaNumberField;
        [FindsBy(How = How.XPath, Using = "//form[@common-form = 'popupEmployeeForm']/div[3]/div[2]/div/div/input")]
        private IWebElement qualificationField;
        [FindsBy(How = How.XPath, Using = "//div[@class='b-textarea-container']/textarea")]
        private IWebElement descriptionField;
        [FindsBy(How = How.XPath, Using = "//form[@common-form = 'popupEmployeeForm']/div[5]/div/button")]
        private IWebElement saveButton;
       
        public EducationPopup(PageManager pageManager)
            : base(pageManager)
        {
            pagename = "education";
            
        }
        public void setTypeField(string type)
        {
            setSuggestField(typeField, type);
        }
        public string getTypeField()
        {
            return getTextField(typeField);
        }
       
        public void clearTypeField()
        {
            typeField.Clear();
        }
       

        internal string getSpecialityEdu()
        {
            return getTextField(specialityField);
        }

        internal string getTypeEdu()
        {
            return getTextField(typeField);
        }

        internal string getUniversityEdu()
        {
            return getTextField(universityField);
        }

        internal string getYearEdu()
        {
            return getTextField(dateField,"Окончено в "," году");
        }

       

        internal string getDiplomaNumber()
        {
            return getTextField(diplomaNumberField, "Документ № ");
        }

        internal string getQualification()
        {
            return getTextField(qualificationField,"Квалификация: ");
        }

        internal string getDescription()
        {
            return getTextField(descriptionField);
        }

        internal void saveClick()
        {
            saveButton.Click();
            waitSaveDone();
        }

        internal void setUniversityField(string university)
        {
            setSuggestField(universityField, university);
        }

        internal void setYearField(string year)
        {
            setDateField(dateField, year);
        }

        internal void setSpecialityField(string speciality)
        {
            setSuggestField(specialityField, speciality);
        }

        internal void setDiplomaField(string diplomaNumber)
        {
            setTextField(diplomaNumberField, diplomaNumber);
        }

        internal void setQualificationField(string qualification)
        {
            setTextField(qualificationField, qualification);
        }

        internal void setDescriptionField(string description)
        {
            setTextField(descriptionField, description);
        }
    }
}
