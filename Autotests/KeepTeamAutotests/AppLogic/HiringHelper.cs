using KeepTeamAutotests.Model;
using KeepTeamAutotests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepTeamAutotests.AppLogic
{
    public class HiringHelper
    {
        private AppManager app;
        private PageManager pages;
        public HiringHelper(AppManager app)
            
        {
            this.app = app;
            this.pages = app.Pages;
            
        }


        public void createVacancy(Vacancy vacancy)
        {
            editVacancy(vacancy);
        }
        public void editVacancy(Vacancy vacancy)
        {
            //заполнение полей создания вакансии
            pages.newVacancyPopup.ensurePageLoaded();
            pages.newVacancyPopup.setNameField(vacancy.VacName);
            pages.newVacancyPopup.setDepartment(vacancy.VacDepartment);
          //  pages.newVacancyPopup.setJobType(vacancy.VacJobType);
            pages.newVacancyPopup.setFilial(vacancy.VacFilial);
            //pages.newVacancyPopup.setEmployees(vacancy.VacEmployees);
           // pages.newVacancyPopup.setVacancyLink(vacancy.VacLink);
            pages.newVacancyPopup.setRequirementsField(vacancy.VacRequirements);
            pages.newVacancyPopup.setConditionsField(vacancy.VacConditions);
            pages.newVacancyPopup.setResponsibilitiesField(vacancy.VacResponsibilities);
            /*pages.newVacancyPopup.setFile(vacancy.VacFile);
            pages.newVacancyPopup.setFileDiscription(vacancy.VacFileDescription);
            */
           
            pages.newVacancyPopup.saveClick();

           

        }


        public bool CompareVacancy (Vacancy V1, Vacancy V2)
        {
            V1.WriteToConsole();
            V2.WriteToConsole();
            return V1.VacName == V2.VacName &&
              //  V1.VacLink == V2.VacLink &&
              //  V1.VacJobType == V2.VacJobType &&
                V1.VacFilial == V2.VacFilial &&
                V1.VacFileDescription == V2.VacFileDescription &&
                V1.VacFile == V2.VacFile &&
                V1.VacEmployees == V2.VacEmployees &&
                V1.VacRequirements == V2.VacRequirements &&
                V1.VacResponsibilities == V2.VacResponsibilities &&
                V1.VacConditions == V2.VacConditions &&
                V1.VacDepartment == V2.VacDepartment;
        
        }
        public void openFirstVacancy()
        {
            //открытие первой вакансии на редактирование
            pages.vacancyPage.ensurePageLoaded();
            pages.vacancyPage.openThreeDotsMenu();

            pages.contextMenuPage.ensurePageLoaded();
            pages.contextMenuPage.byIndexClick(0);

            pages.newVacancyPopup.ensurePageLoaded();
            
        }
        public Vacancy getVacancyPopup()
        {
            pages.newVacancyPopup.refreshPage();
            openFirstVacancy();

            //переход к первой записи
            pages.newVacancyPopup.ensurePageLoaded();
            Vacancy vacancy = new Vacancy();
            vacancy.VacName = pages.newVacancyPopup.getName();
            vacancy.VacDepartment = pages.newVacancyPopup.getDepartment();
            vacancy.VacConditions = pages.newVacancyPopup.getConditions();
            vacancy.VacRequirements = pages.newVacancyPopup.getRequrements();
            vacancy.VacResponsibilities = pages.newVacancyPopup.getResponsibilities();

            vacancy.VacEmployees = pages.newVacancyPopup.getEmployee();
            vacancy.VacFilial = pages.newVacancyPopup.getFilial();
           // vacancy.VacJobType = pages.newVacancyPopup.getVacJob();
          //  vacancy.VacLink = pages.newVacancyPopup.getVacLink();
            /*vacancy.VacFile = pages.newVacancyPopup.getFile();
            vacancy.VacFileDescription = pages.newVacancyPopup.getFileDiscription();
            */
            pages.newVacancyPopup.closePopup();

            return vacancy;

        }

        public void CloseCurrentVacancy()
        {
            //Открытие меню для закрытия
            pages.vacancyPage.ensurePageLoaded();
            pages.vacancyPage.openThreeDotsMenu();

            pages.contextMenuPage.ensurePageLoaded();
            pages.contextMenuPage.byIndexClick(1);
        }
        public void DeleteCurrentVacancy()
        {
            //Удаление через троеточие
            openDeleteMessageVacancyFromThreeDots();
            pages.deleteMessagePage.yesButtonClick();
            pages.deleteMessagePage.waitSaveDone();
        }
        
        public void openDeleteMessageVacancyFromThreeDots()
        {
            //Открытие меню удаления
            pages.vacancyPage.ensurePageLoaded();
            pages.vacancyPage.openThreeDotsMenu();
            
            pages.contextMenuPage.ensurePageLoaded();
            //меню удаления
            pages.contextMenuPage.byIndexClick(2);
            pages.deleteMessagePage.ensurePageLoaded();

        }
        public void openDeleteMessageCandidateFromThreeDots()
        {
            //Открытие меню удаления
            pages.candidatePage.ensurePageLoaded();
            pages.candidatePage.openThreeDotsMenu();

            pages.contextMenuPage.ensurePageLoaded();
            //меню удаления
            pages.contextMenuPage.byIndexClick(0);
            pages.deleteMessagePage.ensurePageLoaded();

        }
        public void clearVacancyPopup()
        {
            //Очистка полей попапа вакансии
            pages.newVacancyPopup.ensurePageLoaded();
            pages.newVacancyPopup.clearName();
          /*  pages.newVacancyPopup.clearDepartment();
            
            pages.newVacancyPopup.clearEmployee();
           */ pages.newVacancyPopup.clearFilial();
          /*  pages.newVacancyPopup.clearVacJob();*/
          //  pages.newVacancyPopup.clearVacLink();
            pages.newVacancyPopup.clearConditions();
            pages.newVacancyPopup.clearRequirements();
            pages.newVacancyPopup.clearResponsibilities();
            
        }


        public void createCandidate(Candidate candidate)
        {
            editCandidate(candidate);
        }
        
        public void editCandidate(Candidate candidate)
        {
            //заполнение полей создания кандидата
            pages.newCandidatePopup.ensurePageLoaded();
            pages.newCandidatePopup.setNameField(candidate.CanName);
            pages.newCandidatePopup.setLastNameField(candidate.CanLastName);
            pages.newCandidatePopup.setPatronimycField(candidate.CanPatronimyc);
            pages.newCandidatePopup.setTrip(candidate.CanTrip);
            pages.newCandidatePopup.setMove(candidate.CanMove);
            pages.newCandidatePopup.setDateField(candidate.CanDateBirhtday);
            pages.newCandidatePopup.setCityField(candidate.CanCity);
            pages.newCandidatePopup.setSexField(candidate.CanSex);
            pages.newCandidatePopup.setDescriptionField(candidate.CanDescription);
            pages.newCandidatePopup.setSkill(candidate.CanSkill);
            pages.newCandidatePopup.setMinPay(candidate.CanPayment);
            pages.newCandidatePopup.setContactType(candidate.CanTypeOfContact);
            pages.newCandidatePopup.setContact(candidate.CanContact);
            
            
            pages.newCandidatePopup.saveClick();
           
   
        }
        public void closeCandidatePopup()
        {
            pages.newCandidatePopup.closePopup();
        }

        public Candidate getCandidatePopup(Candidate cand)
        {
            pages.newCandidatePopup.refreshPage();
            openCandidateByName(cand);

            //переход к записи
            pages.newCandidatePopup.ensurePageLoaded();
            Candidate candidate = new Candidate();
            candidate.CanName = pages.newCandidatePopup.getName();
            candidate.CanLastName = pages.newCandidatePopup.getLastName();
            candidate.CanPatronimyc = pages.newCandidatePopup.getPatronimyc();

            candidate.CanCity = pages.newCandidatePopup.getCity();
            
            candidate.CanSex = pages.newCandidatePopup.getSex();
            candidate.CanDescription = pages.newCandidatePopup.getDescription();
            candidate.CanContact = pages.newCandidatePopup.getContact();
            candidate.CanTypeOfContact = pages.newCandidatePopup.getContactType();
            candidate.CanSkill = pages.newCandidatePopup.getSkill();
            candidate.CanPayment = pages.newCandidatePopup.getPayment();
            candidate.CanDateBirhtday = pages.newCandidatePopup.getDate();
            candidate.CanTrip = pages.newCandidatePopup.getTrip();
            candidate.CanMove = pages.newCandidatePopup.getMove();
            

            pages.newCandidatePopup.closePopup();
            return candidate;
        }
        public void openFirstCandidate()
        {
            //открытие первого кандидата на редактирование
            pages.candidatePage.ensurePageLoaded();
            pages.candidatePage.openFirstCandidatePopup();
            
            pages.newCandidatePopup.ensurePageLoaded();

        }
        public void openCandidateByName(Candidate candidate)
        {
            //открытие кандидата по имени и фамилии
            pages.candidatePage.ensurePageLoaded();
            pages.candidatePage.openCandidatePopup(candidate.CanName);

            pages.newCandidatePopup.ensurePageLoaded();

        }


        public bool CompareCandidate(Candidate C1, Candidate C2)
        {
            C1.WriteToConsole("Тестовый кандидат");
            C2.WriteToConsole("Кандидат из формы");
            return
                C1.CanLastName == C2.CanLastName &&
                C1.CanName == C2.CanName &&
                C1.CanPatronimyc == C2.CanPatronimyc &&
                C1.CanDateBirhtday == C2.CanDateBirhtday &&
                C1.CanSex == C2.CanSex &&
                C1.CanPayment == C2.CanPayment &&
                C1.CanCity == C2.CanCity &&
                C1.CanTrip == C2.CanTrip &&
                C1.CanMove == C2.CanMove &&
                C1.CanSkill == C2.CanSkill &&
                C1.CanDescription == C2.CanDescription &&
                C1.CanContact == C2.CanContact &&
                C1.CanTypeOfContact == C2.CanTypeOfContact;
                
        }


        public void DeleteCurrentCandidate()
        {
           //Удаление через троеточие
            openDeleteMessageCandidateFromThreeDots();
            pages.deleteMessagePage.yesButtonClick();
            pages.deleteMessagePage.waitSaveDone();

        }
        public Vacancy getVacancyFromTable()
        {
            pages.vacancyPage.ensurePageLoaded();

            Vacancy vacancy = new Vacancy();
            vacancy.VacDepartment = pages.vacancyPage.getDepartment();
            vacancy.VacStatus = pages.vacancyPage.getStatus();
            vacancy.VacName = pages.vacancyPage.getName();
            vacancy.VacFilial = pages.vacancyPage.getFilial();
            return vacancy;
        }

        public void createCandidateDirectories(SimpleString directories)
        {
            pages.candidatePage.ensurePageLoaded();

            pages.candidatePage.setDirectoryName(directories.value);
            //секунда ожидания для создания папки
            pages.newCandidatePopup.waitSecond();
         
            
        }

        public string getDirectoryName()
        {
            return pages.candidatePage.getLastDirectoryName();
        }

        public void DeleteLastCandidateDirecories()
        {
            //клик по корзинке
            pages.candidatePage.DirectorymenuClick();
            pages.contextMenuPage.ensurePageLoaded();
            pages.contextMenuPage.byIndexClick(1);
            pages.deleteMessagePage.ensurePageLoaded();
            pages.deleteMessagePage.yesButtonClick();
            
            

        }

        public void clearCandidatePopup()
        {
            //Очистка полей попапа кандидата
            pages.newCandidatePopup.ensurePageLoaded();
            pages.newCandidatePopup.clearName();
            pages.newCandidatePopup.clearLastname();
            pages.newCandidatePopup.clearPayment();
            pages.newCandidatePopup.clearDateBirthday();
            pages.newCandidatePopup.clearCity();
            pages.newCandidatePopup.clearPatronimyc();
            pages.newCandidatePopup.clearDescription();
            pages.newCandidatePopup.clearSkill();
            pages.newCandidatePopup.clearContact();
            pages.newCandidatePopup.clearContactType();

        }
    }
}
