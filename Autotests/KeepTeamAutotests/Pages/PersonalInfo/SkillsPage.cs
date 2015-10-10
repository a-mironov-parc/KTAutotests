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
    public class SkillsPage : PersonalPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@common-form='commonSkillForm']/div/div[1]/div/div/div/div[1]/input")]
        private IWebElement nameField;

        [FindsBy(How = How.XPath, Using = "//*[@common-form='commonSkillForm']/div/div[2]/div/div/div")]
        private IWebElement levelField;

        [FindsBy(How = How.XPath, Using = "//*[@common-form='commonSkillForm']/div/div[3]/div/div/input")]
        private IWebElement descriptionField;

      

        public SkillsPage(PageManager pageManager)
            : base(pageManager)
        {

        }

        public void setNameField(string name)
        {
            setSuggestField(nameField, name);
        }

        public string getNameField()
        {
            return getTextField(nameField);
        }
        public void setLevelField(int level)
        {
            setStarsField(levelField, level);
        }

        public int getLevelField()
        {
            return getStarsField(levelField);
        }
        public void setDescriptionField(string description)
        {
            setTextField(descriptionField, description);
        }

        public string getDescriptionField()
        {
            return getTextField(descriptionField);
        }

       
       

        public void clearValueField()
        {
            nameField.Clear();
        }


        public void clearDescriptionField()
        {
            descriptionField.Clear();
        }
        public void clearContactField()
        {
            
        }

       
    }
}
