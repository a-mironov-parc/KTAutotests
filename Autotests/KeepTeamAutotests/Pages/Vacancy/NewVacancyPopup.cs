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
    public class NewVacancyPopup : PopupPage
    {
                
        [FindsBy(How = How.XPath, Using = "//form[@name = 'vacanciesForm']/div[1]/div[1]/div/div/input")]
        private IWebElement nameField;
        
        [FindsBy(How = How.XPath, Using = "//form[@name = 'vacanciesForm']/div[2]/div[3]/div/div/div/div/div[2]")]
        private IWebElement departmentDropdown;
        
        [FindsBy(How = How.XPath, Using = "//form[@name = 'vacanciesForm']/div[2]/div[1]/div/div/div/div/div[1]")]
        private IWebElement jobTypeDropdown; 
        
        [FindsBy(How = How.XPath, Using = "//form[@name = 'vacanciesForm']/div[2]/div[1]/div/div/div[1]/div/input")]
        private IWebElement cityField; 
        
        [FindsBy(How = How.XPath, Using = "//form[@name = 'vacanciesForm']/div[2]/div[2]/div/div/div[1]/div/input")]
        private IWebElement filialField; 

        [FindsBy(How = How.XPath, Using = "//form[@name = 'vacanciesForm']/div[2]/div[3]/div/div/div/span[2]/span")]
        private IWebElement employeeField;
        [FindsBy(How = How.XPath, Using = "//form[@name = 'vacanciesForm']/div[3]/div/div/div[1]")]
        private IWebElement deleteField;
       /* [FindsBy(How = How.XPath, Using = "//form[@name = 'vacanciesForm']/div[3]/div/div/div[2]/div/input")]
        private IWebElement vacancyLinkField;
        */
        [FindsBy(How = How.XPath, Using = "//form[@name = 'vacanciesForm']/div[6]//div[@class='b-textarea-container']/textarea")]
        private IWebElement responsibilitiesField;
        [FindsBy(How = How.XPath, Using = "//form[@name = 'vacanciesForm']/div[7]//div[@class='b-textarea-container']/textarea")]
        private IWebElement requirementsField;
        [FindsBy(How = How.XPath, Using = "//form[@name = 'vacanciesForm']/div[8]//div[@class='b-textarea-container']/textarea")]
        private IWebElement conditionsField;
        
        [FindsBy(How = How.XPath, Using = "//form[@name = 'vacanciesForm']/div[5]/div/div/div/div[1]/div/div/div[4]")]
        private IWebElement fileField;
        
        [FindsBy(How = How.XPath, Using = "//form[@name = 'vacanciesForm']/div[5]/div/div/div/div[2]/div/div/input")]
        private IWebElement fileDescriptionField;
        
        [FindsBy(How = How.XPath, Using = "//form[@name = 'vacanciesForm']/div[9]/div/button")]
        private IWebElement saveButton; 
        
        
        
      
        public NewVacancyPopup(PageManager pageManager)
            : base(pageManager)
        {
            pagename = "newvacancypopup";

        }

        public void setNameField(string name)
        {
            setTextField(nameField, name);
        }


        public void setRequirementsField(string description)
        {
            setTextField(requirementsField, description);
        }
       
        public string getName()
        {
            return getTextField(nameField);
        }
       
        public string getEmployee()
        {
            return getTextField(employeeField);
        }

      

        internal void setDepartment(string department)
        {
            setCheckBoxDropDown(departmentDropdown, department, "Все подразделения");
        }

        internal void saveClick()
        {
            saveButton.Click();
            waitSaveDone();
        }


        internal void clearName()
        {
            nameField.Clear();
        }

        internal void setJobType(string jobType)
        {
           // setDropdownByText(jobTypeDropdown, jobType); убрали поле вид занятости
        }

        internal void setFilial(string filial)
        {
            setSuggestField(filialField, filial);
        }

        internal void setEmployees(string employee)
        {
            setCheckBoxFilter(employeeField, employee, "Все ответственные");
        }

       /* internal void setVacancyLink(string link)
        {
            setTextField(vacancyLinkField, link);
        }*/

        internal void setFile(string p)
        {
            //throw new NotImplementedException();
        }

        internal void setFileDiscription(string p)
        {
            //throw new NotImplementedException();
        }

        internal string getDepartment()
        {
            return getDropDownText(departmentDropdown,"В ","");
        }

        internal string getFilial()
        {
            return getTextField(filialField);
        }

        internal string getVacJob()
        {
            return getDropDownText(jobTypeDropdown);
        }

     /*   internal string getVacLink()
        {
            return getTextField(vacancyLinkField);
        }
        */
        internal void clearDepartment()
        {
            departmentDropdown.Clear();          
        }

        internal void clearRequirements()
        {
            requirementsField.Clear();
        }
        internal void clearResponsibilities()
        {
            responsibilitiesField.Clear();
        }
        internal void clearConditions()
        {
            conditionsField.Clear();
        }

        internal void clearEmployee()
        {
            employeeField.Clear();
        }

        internal void clearFilial()
        {
            filialField.Clear();
        }

        internal void clearVacJob()
        {
            jobTypeDropdown.Clear();
        }

    /*    internal void clearVacLink()
        {
            try
            {
                deleteField.Click();
            }
            
            catch (ElementNotVisibleException)
            {
                Console.WriteLine("Поле ссылка на вакансию не заполнено");
            }
            vacancyLinkField.Clear();
        }
        */
        internal string getResponsibilities()
        {
            return getTextField(responsibilitiesField);
        }

        internal string getRequrements()
        {
            return getTextField(requirementsField);
        }

        internal string getConditions()
        {
            return getTextField(conditionsField);
        }

        internal void setConditionsField(string conditions)
        {
            setTextField(conditionsField, conditions);
        }

        internal void setResponsibilitiesField(string responsibilities)
        {
            setTextField(responsibilitiesField, responsibilities);
        }
    }
}
