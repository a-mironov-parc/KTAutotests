using KeepTeamAutotests.Model;
using KeepTeamAutotests.Pages;
using Newtonsoft.Json;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KeepTeamAutotests.AppLogic
{
    public class UserHelper
    {
        private AppManager app;
        private PageManager pages;

        public string EMPTYINPUTMSG = "Необходимо заполнить поле";
        public string EMPTYSUDJESTMSG = "Выберите значение из списка";
        public UserHelper(AppManager app)
            
        {
            this.app = app;
            this.pages = app.Pages;
            
        }

        //Метод возвращает полного админа(с доступом к админке)
        public User getSuperAdminUser()
        {
                  
            return getUserByRole("Администраторы");
        }

        public User getUserByRole(string role)
        {
            List<User> users = JsonConvert.DeserializeObject<List<User>>(File.ReadAllText(@"data\user.json"));
            return users.Find(x => x.role == role);

        }

        public User getAdminUser()
        {
            return getUserByRole("Администраторы");
        }
        //метод возвращает пользователя у которого есть только персональные права

       


      /*  public void loginAs(string username, string password)
        {
            pages.loginPage.ensurePageLoaded()
                .setUserNameField(username)
                .setPasswordField(password)
                .submitClick();

        }*/
        public void loginAs(User user)
        {
            if (!pages.loginPage.IsOnThisPage())
            {
                logout();
            }
            pages.loginPage.ensurePageLoaded()
                .setUserNameField(user.login)
                .setPasswordField(user.password)
                .submitClick();


        }
        public void clickAddButton()
        {
            pages.employeesPage
                .ensurePageLoaded()
                .clickAddEmployee();
        }



        public void logout()
        {
            WebDriverFactory.DismissAll();
           /*
            try
            {
                pages.driver.Navigate().GoToUrl(pages.baseUrl + "/#/employees/list");
                pages.employeesPage.ensureMenuLoaded();
                pages.employeesPage.logout();
                pages.contextMenuPage.ensurePageLoaded();
                pages.contextMenuPage.byTextClick("Выйти");
                pages.loginPage.ensurePageLoaded();
               
            }
            catch 
            {
                Console.Out.WriteLine("Ошибка при логауте");
            }
            finally
            {
                WebDriverFactory.DismissAll();
            }
            
            */
            
        }

        //клик для открытия попапа отпусков
        public void clickNewTimeOffsButton()
        {
            pages.personalTimeOffPage.ensurePageLoaded();
            pages.personalTimeOffPage.clickAddTimeOff();
            pages.newTimeOffPopup.ensurePageLoaded();
        }

        public void clickMenu(String text)
        {
            pages.extMenu.ensurePageLoaded();
            pages.extMenu.ClickByText(text);

        }

       


        public string getURL()
        {
            return pages.driver.Url;
        }
        public string getBaseURL()
        {
            return pages.baseUrl;
        }

        public void clickSettingMenu(string text)
        {
            pages.extMenu.ensurePageLoaded();
            pages.extMenu.ClickByText("НАСТРОЙКИ");
            pages.settingMenu.ensurePageLoaded();
            pages.settingMenu.ClickByText(text);
        }



        public string isNotLogged()
        {
            return pages.loginPage.getValidationMessage();
            
        }
        public void loginClear()
        {
            pages.loginPage.clearLogin();
            pages.loginPage.clearPassword();
        }

        public void clickAdditionalColumnsButton()
        {
            pages.employeesPage.ensurePageLoaded();
            pages.employeesPage.clickAdditionalColumnsSetting();
            pages.employeesPage.clickAdditionalColumnsMenu();
        }

        public void clickAddAssetsButton()
        {
            pages.personalAssetPage.ensurePageLoaded();
            pages.personalAssetPage.clickAddAsset();
            pages.newAssetPopup.ensurePageLoaded();
        }

        public bool isLoggedIn()
        {
            pages.employeesPage.ensureMenuLoaded();
            return true;
        }

        public void closePopup()
        {
            pages.deleteEmployeePopup.closePopup();
            pages.deleteEmployeePopup.waitSaveDone();
            
        }

        public void clickAddVacancyButton()
        {
            pages.vacancyPage.ensurePageLoaded();
            pages.vacancyPage.clickAddVacancy();

            pages.newVacancyPopup.ensurePageLoaded();
        }

        public void clickAddCandidateButton()
        {
            pages.candidatePage.ensurePageLoaded();
            pages.candidatePage.clickAddCandidate();

            pages.newCandidatePopup.ensurePageLoaded();
        }

        public List<string> getListDictionaries()
        {
            pages.dictionariesPage.ensurePageLoaded();
            return pages.dictionariesPage.getDictionaryList();

        }

        public bool CompareList(List<string> list, List<string> value)
        {
            Console.WriteLine(string.Join(", ", CompareListString(list, value)));
            return list.SequenceEqual(value);
        }
        //функция от Никиты
        public IEnumerable<string> CompareListString(IEnumerable<string> list, IEnumerable<string> value)
        {
            return list.Except(value).Union(value.Except(list));
        }
        //функция от Женьки
       /* public List<string> CompareListString(List<string> list, List<string> value)
        {
            var bigList = list.Count > value.Count ? list : value;  // Выбираем самый длинный массив
            var smallList = bigList == list ? value : list;         // Массив меньше размером

            return bigList.Where((item, index) =>
            {
                var valueItem = smallList.Count <= index ? null : smallList[index];
                return !item.Equals(valueItem); ;
            })
                            .ToList();
        }*/

      

        public void clickAddUserButton()
        {
            pages.usersPage.ensurePageLoaded();
            pages.usersPage.clickAddUser();

            pages.newUserPopup.ensurePageLoaded();

        }

        public void clickChangeTariff()
        {
            pages.generalSettingsPage.ensurePageLoaded();
            pages.generalSettingsPage.openNewTariff();

            pages.newTariffPopup.ensurePageLoaded();
        }

        public void clickAddKPIButton()
        {
            pages.personalKPIPage.ensurePageLoaded();
            pages.personalKPIPage.clickAddKPI();
            pages.newKPIPopup.ensurePageLoaded();
        }

        public void setAllFilters()
        {
            pages.employeesPage.ensureMenuLoaded();
            pages.goToURL("/#/employees/list?Name=&State=true&MoreFilters=DateOfBirth&MoreFilters=DismissalDate&MoreFilters=Citizenships&MoreFilters=Payment&MoreFilters=Companies&MoreFilters=Skills&MoreFilters=EducationKinds&MoreFilters=Genders&MoreFilters=Projects&MoreFilters=Roles&MoreFilters=MaritalStatuses&MoreFilters=Branches");
            pages.employeesPage.refreshPage();
            pages.employeesPage.ensurePageLoaded();
   
        }



        public object getValidationMessage()
        {
            return pages.loginPage.getValidationMessage();
        }

        public void clickTabByName(string TabName)
        {
            pages.newVacancyPopup.clickTabByName(TabName);
            pages.commentsTab.ensurePageLoaded();
   
        }
    }
}
