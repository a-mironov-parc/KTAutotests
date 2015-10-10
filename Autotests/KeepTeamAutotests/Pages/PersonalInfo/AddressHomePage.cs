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
    public class AddressHomePage : PersonalPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@common-form='homeAddressEmployeeForm']/div[1]/div[1]/div/div/div/div[2]/input")]
        private IWebElement countryField;
        
        [FindsBy(How = How.XPath, Using = "//*[@common-form='homeAddressEmployeeForm']/div[1]/div[2]/div/div[2]/input")]
        private IWebElement postalCodeField;

        [FindsBy(How = How.XPath, Using = "//*[@common-form='homeAddressEmployeeForm']/div[1]/div[3]/div/div/div/div/div[2]/input")]
        private IWebElement regionField;

        [FindsBy(How = How.XPath, Using = "//*[@common-form='homeAddressEmployeeForm']/div[1]/div[4]/div/div/div/div/div[2]/input")]
        private IWebElement cityField;

        [FindsBy(How = How.XPath, Using = "//*[@common-form='homeAddressEmployeeForm']/div[2]/div[1]/div/div[2]/input")]
        private IWebElement streetField;
        [FindsBy(How = How.XPath, Using = "//*[@common-form='homeAddressEmployeeForm']/div[2]/div[2]/div/div[2]/input")]
        private IWebElement houseField;

        [FindsBy(How = How.XPath, Using = "//*[@common-form='homeAddressEmployeeForm']/div[2]/div[3]/div/div[2]/input")]
        private IWebElement blockField;
        [FindsBy(How = How.XPath, Using = "//*[@common-form='homeAddressEmployeeForm']/div[2]/div[4]/div/div[2]/input")]
        private IWebElement buildingField;

        [FindsBy(How = How.XPath, Using = "//*[@common-form='homeAddressEmployeeForm']/div[2]/div[5]/div/div[2]/input")]
        private IWebElement flatField;
        [FindsBy(How = How.XPath, Using = "//*[@common-form='homeAddressEmployeeForm']/div[2]/div[6]/div/div[2]/div[1]/input")]
        private IWebElement registrationDateField; 




        public AddressHomePage(PageManager pageManager)
            : base(pageManager)
        {

        }

        public void setCountryField(String country)
        {
            setSuggestField(countryField, country);
        }

        public string getCountryField()
        {
            return getTextField(countryField);
        }


        public void setPostalCodeField(string name)
        {
            setTextField(postalCodeField,name);
        }

        public string getPostalCodeField()
        {
            return getTextField(postalCodeField);
        }


        public void setRegistrationDateField(String regdate)
        {
            setDateField(registrationDateField, regdate);
        }

        public string getregistrationDateField()
        {
            return getTextField(registrationDateField);
        }

        public void setRegionField(String region)
        {
            setSuggestField(regionField, region);
        }

        public string getRegionField()
        {
            return getTextField(regionField);
        }
        public void setCityField(String city)
        {
            setSuggestField(cityField, city);
        }

        public String getCityField()
        {
            return getTextField(cityField);

        }


        public void clearCountryField()
        {
            countryField.Clear();
        }
        public void clearPostalCode()
        {
            postalCodeField.Clear();
        }
        public void clearRegionField()
        {
            regionField.Clear();
        }

        public void clearCity()
        {
            cityField.Clear();
        }
        public void clearStreet()
        {
            streetField.Clear();
        }
        public void clearHouse()
        {
            houseField.Clear();
        }

        public void clearBlock()
        {
            blockField.Clear();
        }
        public void clearBuilding()
        {
            buildingField.Clear();
        }
        public void clearFlat()
        {
            flatField.Clear();
        }
        public void clearRegistrationDate()
        {
            registrationDateField.Clear();
        }


        public void setBuildingField(string building)
        {
            setTextField(buildingField, building);
        }

        public string getBuildingField()
        {
            return getTextField(buildingField);
           
        }

        public void setBlockField(string block)
        {
            setTextField(blockField, block);
        }

        public string getBlockField()
        {
            return getTextField(blockField);
        }
        public void setHouseField(string house)
        {
            setTextField(houseField, house);
        }

        public string getHouseField()
        {
            return getTextField(houseField);
        }
        public void setStreetField(string street)
        {
            setTextField(streetField, street);
        }

        public string getStreetField()
        {
            return getTextField(streetField);
        }

        public void setFlatField(string flat)
        {
            setTextField(flatField, flat);
        }

        public string getFlatField()
        {
            return getTextField(flatField);
        }
         

        
    }
}
