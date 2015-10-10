using KeepTeamAutotests.Model;
using KeepTeamAutotests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepTeamAutotests.AppLogic
{
    public class EmployeeHelper
    {
        private AppManager app;
        private PageManager pages;
        public EmployeeHelper(AppManager app)
        {
            this.app = app;
            this.pages = app.Pages;

        }

        public void createEmployee(Employee employee)
        {
            //редактирование полей основной информации
            editGeneralInfo(employee);


        }

        public Employee getGeneralInfo()
        {
            refreshpage();
            //получение всей основной информации
            pages.personalInfoPage.ensurePageLoaded();
            Employee employee = new Employee();
            employee.lastname = pages.personalInfoPage.getLastnameField();
            employee.name = pages.personalInfoPage.getNameField();
            employee.patronymic = pages.personalInfoPage.getPatronymicField();
            employee.birthday = pages.personalInfoPage.getBirthdayField();
            employee.sex = pages.personalInfoPage.getSexField();
            employee.status = pages.personalInfoPage.getStatusField();
            employee.employeeNumber = pages.personalInfoPage.getEmployeeNumberField();
            employee.nationality = pages.personalInfoPage.getNationalityField();
            employee.bornplace = pages.personalInfoPage.getBornPlaceField();
            employee.maritalstatus = pages.personalInfoPage.getMaritalField();

            return employee;
        }

        public bool CompareGeneralInfo(Employee E1, Employee E2)
        {
            E1.WriteToConsole();
            E2.WriteToConsole();
            //сравнивает все поля основной информации.
            return E1.lastname == E2.lastname
                && E1.name == E2.name
                && E1.patronymic == E2.patronymic
                && E1.birthday == E2.birthday
                && E1.sex == E2.sex
                && E1.status == E2.status
                && E1.employeeNumber == E2.employeeNumber
                && E1.nationality == E2.nationality
                && E1.bornplace == E2.bornplace
                && E1.maritalstatus == E2.maritalstatus;


        }

        public void createEmployeeRelatives(Employee employee)
        {
            //заполнение минимальных полей
            addMinimalInfo(employee);

            //редактирование полей родственников
            editRelatives(employee);
        }

        public void addMinimalInfo(Employee employee)
        {
            //заполнение минимальных полей
            pages.personalInfoPage.ensurePageLoaded();
            pages.personalInfoPage.setLastnameField(employee.lastname);
            pages.personalInfoPage.setNameField(employee.name);
            pages.personalInfoPage.setStatusField(employee.status);
                
        }

        public Employee getRelatives()
        {
            refreshpage();
            //получение всей информации о родственниках
            pages.relativesPage.ensurePageLoaded();
            Employee employee = new Employee();
            employee.relation = pages.relativesPage.getRelationField();
            employee.relLastName = pages.relativesPage.getLastnameField();
            employee.relName = pages.relativesPage.getNameField();
            employee.relPatronymic = pages.relativesPage.getPatronymicField();
            employee.relBirthday = pages.relativesPage.getBirthdayField();
            //employee.relSex = pages.relativesPage.getSexField();
            return employee;
        }

        public bool CompareRelatives(Employee E1, Employee E2)
        {
            E1.WriteToConsole();
            E2.WriteToConsole();
            //сравнивает все поля основной информации.
            return E1.relation == E2.relation
                && E1.relBirthday == E2.relBirthday
                && E1.relLastName == E2.relLastName
                && E1.relName == E2.relName
                && E1.relPatronymic == E2.relPatronymic
                && E1.relSex == E2.relSex;
        }

        public void editRelatives(Employee employee)
        {
            //заполнение полей родство
            pages.relativesPage.ensurePageLoaded();
            pages.relativesPage.setRelationField(employee.relation);
            pages.relativesPage.setLastnameField(employee.relLastName);
            pages.relativesPage.setNameField(employee.relName);
            pages.relativesPage.setPatronymicField(employee.relPatronymic);
            pages.relativesPage.setBirthdayField(employee.relBirthday);
            //pages.relativesPage.setSexField(employee.relSex);
            pages.relativesPage.saveClick();

           

        }

        public void clearRelatives()
        {

            //Очистка полей родство
            pages.relativesPage.ensurePageLoaded();
            pages.relativesPage.clearLastnameField();
            pages.relativesPage.clearNameField();
            pages.relativesPage.clearPatronymicField();
            pages.relativesPage.clearBirthdayField();


        }

        public void refreshpage()
        {
            //перезагрузка страницы, для проверки введенных полей
            pages.personalInfoPage.waitSaveDone();
            pages.personalInfoPage.refreshPage();
        }

        public void clearGeneralInfo()
        {
            //Очистка полей основная информация
            pages.personalInfoPage.ensurePageLoaded();
            pages.personalInfoPage.clearLastname();
            pages.personalInfoPage.clearName();
            pages.personalInfoPage.clearPatronymic();
            pages.personalInfoPage.clearBirthday();
            pages.personalInfoPage.clearEmployeeID();
            pages.personalInfoPage.clearNationality();
            pages.personalInfoPage.clearBornplace();


        }

        public void editGeneralInfo(Employee employee)
        {
            //заполнение полей основной информации
            pages.personalInfoPage.ensurePageLoaded();
            pages.personalInfoPage.setLastnameField(employee.lastname);
            pages.personalInfoPage.setNameField(employee.name);
            pages.personalInfoPage.setPatronymicField(employee.patronymic);
            pages.personalInfoPage.setBirthdayField(employee.birthday);
            pages.personalInfoPage.setStatusField(employee.status);
            pages.personalInfoPage.setSexField(employee.sex);
            pages.personalInfoPage.setEmployeeNumberField(employee.employeeNumber);
            pages.personalInfoPage.setNationalityField(employee.nationality);
            pages.personalInfoPage.setBornPlaceField(employee.bornplace);
            pages.personalInfoPage.setMaritalField(employee.maritalstatus);
            pages.personalInfoPage.saveClick();
       

        }

        public void createEmployeeDocuments(Employee employee)
        {
            //заполнение минимальных полей
            addMinimalInfo(employee);
            //открытие нового попапа документов
            openNewDocumentsPopup(employee.typeDoc);
            //редактирование полей документы
            editDocuments(employee);
        }
        public void openNewDocumentsPopup(string typeDoc)
        {
            //заполнение полей документы
            pages.documentsPage.ensurePageLoaded();
            pages.documentsPage.addButtonClick();

            //Появление контекстного меню
            pages.contextMenuPage.ensurePageLoaded();
            pages.contextMenuPage.byTextClick(typeDoc);
            
            //Появление попапа документов
            pages.passportPopup.ensurePageLoaded();
        }
        public void editDocuments(Employee employee)
        {
            //заполнение полей документы
            pages.passportPopup.ensurePageLoaded();
            pages.passportPopup.setSeriesField(employee.seriesDoc);
            
            if (employee.typeDoc != "ИНН" || employee.typeDoc != "СНИЛС")
            {
                pages.passportPopup.setAuthorField(employee.authorDoc);
            }
            if (employee.typeDoc == "Паспорт")
            {
                pages.passportPopup.setCodeField(employee.codeDoc);
            }
            
            pages.passportPopup.setDescriptionField(employee.descriptionDoc);
            pages.passportPopup.setDateField(employee.dateDoc);
            pages.passportPopup.saveClick();
            
            pages.documentsPage.ensurePageLoaded();
            pages.documentsPage.saveClick();

            refreshpage();

        }
        /*
        public Employee getDocumentsTable()
        {
           //получение всей информации о документах
            pages.documentsPage.ensurePageLoaded();
            Employee employee = new Employee();
            employee.typeDoc = pages.documentsPage.getTypeField();
            employee.seriesDoc = pages.documentsPage.getDataField();
            employee.dateDoc = pages.documentsPage.getDateField();
            
            return employee;
        }*/

        
        public Employee getDocumentPopup(string docType)
        {

            //получение всей информации о документах
            pages.documentsPage.ensurePageLoaded();
            pages.documentsPage.openDocumentPopup(docType);

            //переход к первой записи.
            pages.passportPopup.ensurePageLoaded();
            Employee employee = new Employee();
            employee.dateDoc = pages.passportPopup.getDateField();
            employee.seriesDoc = pages.passportPopup.getSeriesField();

            if (docType == "Паспорт")
            {
                employee.codeDoc = pages.passportPopup.getCodeField();
            }

            if (docType != "ИНН" || docType != "СНИЛС")
            {
                employee.authorDoc = pages.passportPopup.getAuthorField();
            }
         
            employee.descriptionDoc = pages.passportPopup.getDescriptionField();
            employee.typeDoc = pages.passportPopup.getHeaderField();

            pages.passportPopup.closePopup();
            return employee;
        }

        public bool CompareDocuments(Employee E1, Employee E2)
        {
            E1.WriteToConsole();
            E2.WriteToConsole();
            return E1.dateDoc == E2.dateDoc
                 && E1.typeDoc == E2.typeDoc
                 && E1.seriesDoc == E2.seriesDoc
                 && E1.descriptionDoc == E2.descriptionDoc
                 && E1.codeDoc == E2.codeDoc
                 && E1.authorDoc == E2.authorDoc;

        }
        public void openPersonalPopup(string menu)
        {
            pages.photoEmployeePage.ensurePageLoaded();
            pages.photoEmployeePage.menuButtonClick();

            pages.contextMenuPage.ensurePageLoaded();
            pages.contextMenuPage.byTextClick(menu);

            pages.deleteEmployeePopup.ensurePageLoaded();
        }

  
        public void DeleteCurrentEmployee()
        {
            openPersonalPopup("Удалить карточку сотрудника");
           
            //удаление пользователя через попап.
            pages.deleteEmployeePopup.setCheckBoxAll();
            pages.deleteEmployeePopup.deleteButtonClick();


        }
      

        public void createEmployeeAddressRegistration(Employee employee)
        {
            //заполнение минимальных полей
            addMinimalInfo(employee);

            //редактирование полей родственников
            editAddressRegistration(employee);
        }
        public void editAddressRegistration(Employee employee)
        {
            //заполнение полей адрес регистрации
            pages.addressRegistrationPage.ensurePageLoaded();
            pages.addressRegistrationPage.setCountryField(employee.arcountry);
            pages.addressRegistrationPage.setPostalCodeField(employee.arpostcode);
            pages.addressRegistrationPage.setRegionField(employee.arregion);
            pages.addressRegistrationPage.setCityField(employee.arcity);
            pages.addressRegistrationPage.setStreetField(employee.arstreet);
            pages.addressRegistrationPage.setHouseField(employee.arhouse);
            pages.addressRegistrationPage.setBlockField(employee.arblock);
            pages.addressRegistrationPage.setBuildingField(employee.arbuilding);
            pages.addressRegistrationPage.setFlatField(employee.arflat);
            pages.addressRegistrationPage.setRegistrationDateField(employee.arregistrationdate);
            pages.addressRegistrationPage.saveClick();
            
            refreshpage();

        }

        public Employee getAddressRegistration()
        {
            //получение всей информации об адресе регистрации
            pages.addressRegistrationPage.ensurePageLoaded();
            Employee employee = new Employee();
            employee.arblock = pages.addressRegistrationPage.getBlockField();
            employee.arbuilding = pages.addressRegistrationPage.getBuildingField();
            employee.arcity = pages.addressRegistrationPage.getCityField();
            employee.arcountry = pages.addressRegistrationPage.getCountryField();
            employee.arflat = pages.addressRegistrationPage.getFlatField();
            employee.arhouse = pages.addressRegistrationPage.getHouseField();
            employee.arpostcode = pages.addressRegistrationPage.getPostalCodeField();
            employee.arregion = pages.addressRegistrationPage.getRegionField();
            employee.arregistrationdate = pages.addressRegistrationPage.getregistrationDateField();
            employee.arstreet = pages.addressRegistrationPage.getStreetField();

            return employee;
        }
        public void createEmployeeAddressHome(Employee employee)
        {
            //заполнение минимальных полей
            addMinimalInfo(employee);

            //редактирование полей родственников
            editAddressHome(employee);
        }
        public void editAddressHome(Employee employee)
        {
            //заполнение полей адрес регистрации
            pages.addressHomePage.ensurePageLoaded();
            pages.addressHomePage.setCountryField(employee.arcountry);
            pages.addressHomePage.setPostalCodeField(employee.arpostcode);
            pages.addressHomePage.setRegionField(employee.arregion);
            pages.addressHomePage.setCityField(employee.arcity);
            pages.addressHomePage.setStreetField(employee.arstreet);
            pages.addressHomePage.setHouseField(employee.arhouse);
            pages.addressHomePage.setBlockField(employee.arblock);
            pages.addressHomePage.setBuildingField(employee.arbuilding);
            pages.addressHomePage.setFlatField(employee.arflat);
            pages.addressHomePage.setRegistrationDateField(employee.arregistrationdate);
            pages.addressHomePage.saveClick();

            refreshpage();

        }
        public Employee getAddressHome()
        {
            //получение всей информации об адресе регистрации
            pages.addressHomePage.ensurePageLoaded();
            Employee employee = new Employee();
            employee.arblock = pages.addressHomePage.getBlockField();
            employee.arbuilding = pages.addressHomePage.getBuildingField();
            employee.arcity = pages.addressHomePage.getCityField();
            employee.arcountry = pages.addressHomePage.getCountryField();
            employee.arflat = pages.addressHomePage.getFlatField();
            employee.arhouse = pages.addressHomePage.getHouseField();
            employee.arpostcode = pages.addressHomePage.getPostalCodeField();
            employee.arregion = pages.addressHomePage.getRegionField();
            employee.arregistrationdate = pages.addressHomePage.getregistrationDateField();
            employee.arstreet = pages.addressHomePage.getStreetField();

            return employee;
        }

        public bool CompareAddressRegistration(Employee E1, Employee E2)
        {
            E1.WriteToConsole();
            E2.WriteToConsole();
            return E1.arblock == E2.arblock
                 && E1.arbuilding == E2.arbuilding
                 && E1.arcity == E2.arcity
                 && E1.arcountry == E2.arcountry
                 && E1.arflat == E2.arflat
                 && E1.arhouse == E2.arhouse
                 && E1.arpostcode == E2.arpostcode
                 && E1.arregion == E2.arregion
                 && E1.arregistrationdate == E2.arregistrationdate
                 && E1.arstreet == E2.arstreet;

        }





        public void createEmployeeContacts(Employee employee)
        {
            //заполнение минимальных полей
            addMinimalInfo(employee);

            //редактирование полей родственников
            editContacts(employee);
        }

        public void editContacts(Employee employee)
        {
            //заполнение полей контакты
            
            pages.contactsPage.ensurePageLoaded();
            pages.contactsPage.setContactField(employee.conType);
            pages.contactsPage.setValueField(employee.conValue);
            pages.contactsPage.setDescriptionField(employee.conDescription);
            pages.contactsPage.saveClick();

          
        }

        public Employee getContacts()
        {
            refreshpage();
            //получение всей информации о контактах
            pages.contactsPage.ensurePageLoaded();
            Employee employee = new Employee();
            employee.conType = pages.contactsPage.getContactField();
            employee.conValue = pages.contactsPage.getValueField();
            employee.conDescription = pages.contactsPage.getDescriptionField();
            return employee;
        }
       

        public bool CompareContacts(Employee E1, Employee E2)
        {
            E1.WriteToConsole();
            E2.WriteToConsole();
            return E1.conType == E2.conType
                 && E1.conValue == E2.conValue
                 && E1.conDescription == E2.conDescription;
        }

        public void clearContacts()
        {
            //Очистка полей контакты
            pages.contactsPage.ensurePageLoaded();
            pages.contactsPage.clearContactField();
            pages.contactsPage.clearValueField();
            pages.contactsPage.clearDescriptionField();
            //клик по заголовку, чтобы сработал перевод фокуса из поля
            pages.contactsPage.headerClick();
        }

        public void createEmployeeEducation(Employee employee)
        {
            //заполнение минимальных полей
            addMinimalInfo(employee);
            //открытие попапа образование
            openNewEducationPopup();
            //редактирование полей образование
            editEducation(employee);
        }

        public void openNewEducationPopup()
        {
            //Открытие попапа образования
            pages.educationPage.ensurePageLoaded();
            pages.educationPage.addEducationPopup();

            pages.educationPopup.ensurePageLoaded();
        }
        public Employee getEducation()
        {
            //получение всей информации о документах
            pages.educationPage.ensurePageLoaded();
            //переход к первой записи.
            pages.educationPage.openEducationPopup();
            pages.educationPopup.ensurePageLoaded();

            Employee employee = new Employee();
            employee.specialityEdu = pages.educationPopup.getSpecialityEdu();
            employee.typeEdu = pages.educationPopup.getTypeEdu();
            employee.universityEdu = pages.educationPopup.getUniversityEdu();
            employee.yearEdu = pages.educationPopup.getYearEdu();
            employee.diplomaNumberEdu = pages.educationPopup.getDiplomaNumber();
            employee.qualificationEdu = pages.educationPopup.getQualification();
            employee.descriptionEdu = pages.educationPopup.getDescription();

            pages.educationPopup.closePopup();
            return employee;
            
        }

        public void editEducation(Employee employee)
        {
            //заполнение основных полей
            pages.educationPopup.setTypeField(employee.typeEdu);
            pages.educationPopup.setUniversityField(employee.universityEdu);
            pages.educationPopup.setYearField(employee.yearEdu);
            pages.educationPopup.setSpecialityField(employee.specialityEdu);
            pages.educationPopup.setDiplomaField(employee.diplomaNumberEdu);
            pages.educationPopup.setQualificationField(employee.qualificationEdu);
            pages.educationPopup.setDescriptionField(employee.descriptionEdu);
            pages.educationPopup.saveClick();

            pages.educationPage.saveClick();

            refreshpage();

        }

        public void createEmployeeSkills(Employee employee)
        {
            //заполнение минимальных полей
            addMinimalInfo(employee);

            //редактирование полей образование
            editSkills(employee);
        }

        public void editSkills(Employee employee)
        {
            //заполнение полей навыки
            pages.skillsPage.ensurePageLoaded();
            pages.skillsPage.setNameField(employee.skillName);
            pages.skillsPage.setLevelField(employee.skillLevel);
            pages.skillsPage.setDescriptionField(employee.skillDescription);
            pages.skillsPage.saveClick();
            
            

        }

        public Employee getSkills()
        {
            refreshpage();
            //получение всей информации о навыках
            pages.skillsPage.ensurePageLoaded();
            
            Employee employee = new Employee();
            employee.skillDescription = pages.skillsPage.getDescriptionField();
            employee.skillLevel = pages.skillsPage.getLevelField();
            employee.skillName = pages.skillsPage.getNameField();
            return employee;
        }

        public bool CompareSkills(Employee E1, Employee E2)
        {
            E1.WriteToConsole();
            E2.WriteToConsole();
            return E1.skillName == E2.skillName
                 && E1.skillLevel == E2.skillLevel
                 && E1.skillDescription == E2.skillDescription;
        }



        public void clearSkills()
        {
            //Очистка полей контакты
            pages.skillsPage.ensurePageLoaded();
            pages.skillsPage.clearContactField();
            pages.skillsPage.clearDescriptionField();
            pages.skillsPage.clearValueField();
         
        }

        public void clearAddressRegistration()
        {
            pages.addressRegistrationPage.ensurePageLoaded();
            pages.addressRegistrationPage.clearCountryField();
            pages.addressRegistrationPage.clearPostalCode();
            pages.addressRegistrationPage.clearRegionField();
            pages.addressRegistrationPage.clearCity();
            pages.addressRegistrationPage.clearStreet();
            pages.addressRegistrationPage.clearHouse();
            pages.addressRegistrationPage.clearBlock();
            pages.addressRegistrationPage.clearBuilding();
            pages.addressRegistrationPage.clearFlat();
            pages.addressRegistrationPage.clearRegistrationDate();
           
        }

        //пока идет проверка только рабочего статуса
        public Employee getEmployeefromTable()
        {
            pages.employeesPage.ensurePageLoaded();
            Employee employee = new Employee();
            employee.status = pages.employeesPage.getStatus();
            employee.maritalstatus = pages.employeesPage.getMaritalStatus();
            employee.sex = pages.employeesPage.getSex();
            employee.department = pages.employeesPage.getDepartment();

            return employee;
        }



        public void openNewWorkInfoPopup(string workInfoType)
        {
            pages.workHistoryPage.ensurePageLoaded();
            pages.workHistoryPage.addWorkHistoryPopup(workInfoType);
            pages.workHistoryPopup.ensurePageLoaded();
            
        }


        public bool CompareEducations(Employee E1, Employee E2)
        {
            E1.WriteToConsole();
            E2.WriteToConsole();

            return E1.descriptionEdu == E2.descriptionEdu
                 && E1.diplomaNumberEdu == E2.diplomaNumberEdu
                 && E1.qualificationEdu == E2.qualificationEdu
                 && E1.specialityEdu == E2.specialityEdu
                 && E1.typeEdu == E2.typeEdu
                 && E1.universityEdu == E2.universityEdu
                 && E1.yearEdu == E2.yearEdu;
        }
    }
}
