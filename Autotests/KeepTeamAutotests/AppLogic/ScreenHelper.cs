using KeepTeamAutotests.Model;
using KeepTeamAutotests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepTeamAutotests.AppLogic
{
    public class ScreenHelper
    {
        private AppManager app;
        private PageManager pages;
        public ScreenHelper(AppManager app)
        {
            this.app = app;
            this.pages = app.Pages;

        }

        
        public bool NewDocumentPopupScreen(string docType)
        {
            return pages.passportPopup.CompareScreenShots(docType);
        }
        public bool NewEducationPopupScreen()
        {
            return pages.educationPopup.CompareScreenShots("Образование");
        }
        public bool NewTimeOffPopupScreen(string timeoffType)
        {
            return pages.newTimeOffPopup.CompareScreenShots(timeoffType);
        }
        public bool DeleteEmployeePopupScreen()
        {
            return pages.deleteEmployeePopup.CompareScreenShots("DeleteUser");
        }

        public bool LoginPageScreen()
        {
            return pages.loginPage.CompareScreenShots("login");
        }

        public bool AdditionalColumnsScreen()
        {
            return pages.employeesPage.CompareScreenShots("Дополнительные столбцы");
        }



        public bool OffEmployeePopupScreen()
        {
            return pages.deleteEmployeePopup.CompareScreenShots("OffUser"); 
        }

        public bool NewAssetPopupScreen()
        {
            return pages.newAssetPopup.CompareScreenShots("Asset"); 
        }

        public bool NewWorkInfoPopupScreen(string workinfotype)
        {
            return pages.workHistoryPopup.CompareScreenShots(workinfotype);
        }

        public bool DeleteMessageScreen()
        {
            return pages.deleteMessagePage.CompareScreenShots("assetDeleteMessage");
        }

        public bool NewVacancyPopupScreen()
        {
            return pages.newVacancyPopup.CompareScreenShots("Vacancy");
        }

        public bool NewCandidatePopupScreen()
        {
            return pages.newCandidatePopup.CompareScreenShots("Candidate");
        }

        public bool NewUserPopupScreen()
        {
            return pages.newUserPopup.CompareScreenShots("Users");
        }

        public bool CalendarScreen(string timeofftype)
        {
            return pages.calendarTimeOffPage.CompareScreenShots(timeofftype);
            
        }
        public bool NewTariffPopupScreen()
        {
            return pages.newTariffPopup.CompareScreenShots("Tariff");
        }

        public bool NewKPIPopupScreen()
        {
            return pages.newKPIPopup.CompareScreenShots("KPI");
        }

        public bool NewVacancyPopupCommentsScreen()
        {
            return pages.newVacancyPopup.CompareScreenShots("VacancyComments");
        }

        public bool NewCandidatePopupCommentsScreen()
        {
            return pages.newCandidatePopup.CompareScreenShots("CandidateComments");
        }

        public bool NewCandidatePopupResumeScreen()
        {
            return pages.newCandidatePopup.CompareScreenShots("ResumeComments");
        }
    }
}
