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
    public class EducationPage : PersonalPage
    {
        [FindsBy(How = How.XPath, Using = "//div[@class='b-employees-personal-header']/span")]
        private IWebElement addButton;
        
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[4]/div/div/div[1]/div[3]/div/div[2]/div[2]/div/div[2]/div/div")]
        private IWebElement yearField;
        
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[4]/div/div/div[1]/div[3]/div/div[2]/div[2]/div/div[3]/div/div/div[1]")]
        private IWebElement specialField;
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[4]/div/div/div[1]/div[3]/div/div[2]/div[2]/div/div[4]/div/div/div")]
        private IWebElement universityField;

        [FindsBy(How = How.XPath, Using = "//*[@id='content']/div/div[1]/div/div/div[2]/div[2]/div")]
        private IWebElement FirstEducation;
        
     


        public EducationPage(PageManager pageManager)
            : base(pageManager)
        {

        }


        public void addEducationPopup()
        {
            addButton.Click();
        }

      

        public string getYearField()
        {
            return getTextField(yearField);
        }
        public string getSpecialField()
        {
            return getTextField(specialField);
        }
        public string getUniversityField()
        {
            return getTextField(universityField);
        }



        public void openEducationPopup()
        {
            FirstEducation.Click();
        }
        
    }
}
