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
    public class RelativesPage : PersonalPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@common-form='commonParentForm']/div/div[1]/div/div/div/div/div[1]")]
        private IWebElement relationDropDown; 
        
        [FindsBy(How = How.XPath, Using = "//*[@common-form='commonParentForm']/div/div[2]/div/div/input")]
        private IWebElement lastnameField;

        [FindsBy(How = How.XPath, Using = "//*[@common-form='commonParentForm']/div/div[3]/div/div/input")]
        private IWebElement nameField;

        [FindsBy(How = How.XPath, Using = "//*[@common-form='commonParentForm']/div/div[4]/div/div/input")]
        private IWebElement patronymicField;

        [FindsBy(How = How.XPath, Using = "//*[@common-form='commonParentForm']/div/div[5]/div/div/div/input")]
        private IWebElement birthdayField;
        //*[@id="content"]/div/div[1]/div[2]/div[2]/div[2]/div[1]/form/div/div[5]/div/div/div/input

        /* Поле удалено в 13 спринте
        [FindsBy(How = How.XPath, Using = "//*[@common-form='commonParentForm']/div/div[5]/div/div/div[1]")]
        private IWebElement sexDropDown;
        */
       


        public RelativesPage(PageManager pageManager)
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
        public void setRelationField(string relation)
        {
            setDropdownByText(relationDropDown, relation);
        }

        public string getRelationField()
        {
            return getDropDownText(relationDropDown);
        }
     /*   public void setSexField(string sex)
        {
            setDropdownByText(sexDropDown, sex);
        }
        */
       /* поле удалено в 13 спринте
        * public string getSexField()
        {
            return getDropDownText(sexDropDown);
        }*/

       

        public void clearLastnameField()
        {
            lastnameField.Clear();
        }


        public void clearNameField()
        {
            nameField.Clear();
        }

        public void clearPatronymicField()
        {
            patronymicField.Clear();
        }

        public void clearBirthdayField()
        {
            ClearManual(birthdayField);
        }
    }
}
