using KeepTeamAutotests.AppLogic;
using KeepTeamAutotests.Menues;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KeepTeamAutotests.Pages
{
    public class PageManager
    {
        internal IWebDriver driver;
        internal string baseUrl;
        internal string globalpath = "Snapshot";
        internal string browsername = "Default";
        internal string versionname = "defaultversion";
        internal string standartpath = "standart";
        internal string resultpath = "resultcompare";
        internal string currentpath = "current";
        //время в секундах используемое для ожиданий на страницах
        public const int WAITTIMEFORFINDELEMENT = 23;//ожидание элемента
        public const int WAITTIMEFORCLOSEPOPUP = 3;//таймаут для ожидания закрытия попапа, пока не работает
        public const int WAITPAGELOADTIME = 127; //таймаут для рефреша
    

        public PageManager(ICapabilities capabilities, string baseUrl, string hubUrl)
        {
            driver = WebDriverFactory.GetDriver(hubUrl, capabilities);
            browsername = capabilities.BrowserName;
            versionname = capabilities.Version;
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(PageManager.WAITTIMEFORFINDELEMENT));
            driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(PageManager.WAITPAGELOADTIME));
            driver.Manage().Window.Size = new System.Drawing.Size(1280,900);
           // driver.Manage().Window.Size = new System.Drawing.Size(1920, 1080);
           // driver.Manage().Window.Maximize();
            
            if (!driver.Url.StartsWith(baseUrl))
            {
                driver.Navigate().GoToUrl(baseUrl);
            }

            this.baseUrl = baseUrl;

            
            loginPage = InitElements(new LoginPage(this));
            personalInfoPage = InitElements(new PersonalInfoPage(this));
            employeesPage = InitElements(new EmployeesPage(this));
            personalTimeOffPage = InitElements(new PersonalTimeOffPage(this));
            newTimeOffPopup = InitElements(new NewTimeOffPopup(this));
            extMenu = InitElements(new ExternalMenu(this));
            settingMenu = InitElements(new SettingMenu(this));
            relativesPage = InitElements(new RelativesPage(this));
            documentsPage = InitElements(new DocumentsPage(this));
            deleteEmployeePopup = InitElements(new DeleteEmployeePopup(this));
            photoEmployeePage = InitElements(new PhotoEmployeePage(this));
            addressRegistrationPage = InitElements(new AddressRegistrationPage(this));
            addressHomePage = InitElements(new AddressHomePage(this));
            passportPopup = InitElements(new DocumentsPopup(this));
            contactsPage = InitElements(new ContactsPage(this));
            educationPage = InitElements(new EducationPage(this));
            educationPopup = InitElements(new EducationPopup(this));
            skillsPage = InitElements(new SkillsPage(this));
            newAssetPopup = InitElements(new NewAssetPopup(this));
            personalAssetPage = InitElements(new PersonalAssetPage(this));
            workHistoryPage = InitElements(new WorkHistoryPage(this));
            workHistoryPopup = InitElements (new WorkHistoryPopup(this));
            deleteMessagePage = InitElements(new DeleteMessagePage(this));
            contextMenuPage = InitElements(new ContextMenuPage(this));
            vacancyPage = InitElements(new VacancyPage(this));
            newVacancyPopup = InitElements(new NewVacancyPopup(this));
            candidatePage = InitElements(new CandidatePage(this));
            newCandidatePopup = InitElements(new NewCandidatePopup(this));
            dictionariesPage = InitElements(new DictionariesPage(this));
            usersPage = InitElements(new UsersPage(this));
            newUserPopup = InitElements(new NewUserPopup(this));
            calendarTimeOffPage = InitElements(new CalendarTimeOffPage(this));
            generalSettingsPage = InitElements(new GeneralSettingsPage(this));
            newTariffPopup = InitElements(new NewTariffPopup(this));
            personalKPIPage = InitElements(new PersonalKPIPage(this));
            newKPIPopup = InitElements(new NewKPIPopup(this));
            filtersPage = InitElements(new FiltersPage(this));
            commentsTab = InitElements(new CommentsTab(this));
        }

        private T InitElements<T>(T page) where T : Page
        {
            PageFactory.InitElements(driver, page);
            return page;
        }
        public void goToURL(string URL)
        {
            driver.Navigate().GoToUrl(baseUrl + URL);        
        }


        public LoginPage loginPage { get; set; }
        public PersonalInfoPage personalInfoPage { get; set; }
        public EmployeesPage employeesPage { get; set; }
        public PersonalTimeOffPage personalTimeOffPage { get; set; }
        public NewTimeOffPopup newTimeOffPopup { get; set; }
        public ExternalMenu extMenu { get; set; }
        public SettingMenu settingMenu { get; set; }
        public RelativesPage relativesPage { get; set; }
        public DocumentsPage documentsPage { get; set; }
        public DeleteEmployeePopup deleteEmployeePopup { get; set; }
        public PhotoEmployeePage photoEmployeePage { get; set; }
        public AddressRegistrationPage addressRegistrationPage { get; set; }
        public AddressHomePage addressHomePage { get; set; }
        public DocumentsPopup passportPopup { get; set; }
        public ContactsPage contactsPage { get; set; }
        public EducationPage educationPage { get; set; }
        public EducationPopup educationPopup { get; set; }
        public SkillsPage skillsPage { get; set; }
        public NewAssetPopup newAssetPopup { get; set; }
        public PersonalAssetPage personalAssetPage { get; set; }
        public WorkHistoryPage workHistoryPage { get; set; }
        public WorkHistoryPopup workHistoryPopup { get; set; }
        public DeleteMessagePage deleteMessagePage { get; set; }
        public ContextMenuPage contextMenuPage { get; set; }
        public VacancyPage vacancyPage { get; set; }
        public NewVacancyPopup newVacancyPopup { get; set; }
        public CandidatePage candidatePage { get; set; }
        public NewCandidatePopup newCandidatePopup { get; set; }
        public DictionariesPage dictionariesPage { get; set; }
        public UsersPage usersPage { get; set; }
        public NewUserPopup newUserPopup { get; set; }
        public CalendarTimeOffPage calendarTimeOffPage { get; set; }
        public GeneralSettingsPage generalSettingsPage { get; set; }
        public NewTariffPopup newTariffPopup { get; set; }
        public PersonalKPIPage personalKPIPage { get; set; }
        public NewKPIPopup newKPIPopup { get; set; }
        public FiltersPage filtersPage { get; set; }
        public CommentsTab commentsTab { get; set; }

       
    }
}
