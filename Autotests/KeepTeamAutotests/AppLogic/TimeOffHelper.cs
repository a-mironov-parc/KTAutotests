using KeepTeamAutotests.Model;
using KeepTeamAutotests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepTeamAutotests.AppLogic
{
    public class TimeOffHelper
    {
        private AppManager app;
        private PageManager pages;
        public TimeOffHelper(AppManager app)
            
        {
            this.app = app;
            this.pages = app.Pages;
            
        }


        public void createTimeOff(TimeOff timeoff)
        {
            editTimeOff(timeoff);
        }
        public void editTimeOff(TimeOff timeoff)
        {
            //заполнение полей создания отпуска
            selectType(timeoff.TOtype);
            pages.newTimeOffPopup.setStartDateField(timeoff.TOstartDate);
            pages.newTimeOffPopup.setEndDateField(timeoff.TOendDate);
            pages.newTimeOffPopup.setInterested(timeoff.TODependsOn);
            pages.newTimeOffPopup.setDescription(timeoff.TODescription);

            if (timeoff.TOtype == "Больничный")
            {
                pages.newTimeOffPopup.setReasonField(timeoff.TOReason);
                pages.newTimeOffPopup.setNumber(timeoff.TONumber);

            }
            
            pages.newTimeOffPopup.saveClick();

        }



        public bool CompareTimeOffs(TimeOff T1, TimeOff T2)
        {
            T1.WriteToConsole();
            T2.WriteToConsole();
            return T1.TOtype == T2.TOtype &&  
                T1.TOstartDate == T2.TOstartDate &&
                T1.TOendDate == T2.TOendDate &&
                T1.TOReason == T2.TOReason &&
                T1.TONumber == T2.TONumber &&
                T1.TODependsOn == T2.TODependsOn
                 && T1.TODescription == T2.TODescription ;
                 
                 

        
        }

      /*  public TimeOff getTimeOff()
        {
            return getTimeOffPopupByType();
        }*/
        public TimeOff getTimeOffPopupByType(string TOtype)
        {
            //получение информации об отпуске
            pages.personalTimeOffPage.refreshPage();
            pages.personalTimeOffPage.ensurePageLoaded();
            pages.personalTimeOffPage.openTimeOffPopupByType(TOtype);

            //переход к первой записи
            pages.newTimeOffPopup.ensurePageLoaded();
            TimeOff timeoff = new TimeOff();
            timeoff.TOtype = pages.newTimeOffPopup.getTypeTO();
            timeoff.TOstartDate = pages.newTimeOffPopup.getStartDate();
            timeoff.TOendDate = pages.newTimeOffPopup.getEndDate();
            timeoff.TODescription = pages.newTimeOffPopup.getDescription();
            timeoff.TODependsOn = pages.newTimeOffPopup.getInterested();

            if (timeoff.TOtype == "Больничный")
            {
                timeoff.TONumber = pages.newTimeOffPopup.getNumber();
                timeoff.TOReason = pages.newTimeOffPopup.getReason();
            }
            
            pages.newTimeOffPopup.closePopup();
            return timeoff;

        }


        public void DeleteCurrentTimeOff()
        {
            openDeleteMessageFromThreeDots();
            pages.deleteMessagePage.waitSecond();//вставил чтобы удаление больничного было без ошибок
            pages.deleteMessagePage.yesButtonClick();
            pages.deleteMessagePage.waitSaveDone();
            pages.deleteMessagePage.waitSecond();//вставил чтобы удаление больничного было
        }
        public void openDeleteMessageFromThreeDots()
        {
            //Открытие меню удаления
            pages.personalTimeOffPage.ensurePageLoaded();
            pages.personalTimeOffPage.deleteFromThreeDots();

            pages.contextMenuPage.ensurePageLoaded();
            //pages.contextMenuPage.byTextClick("Удалить");
            pages.contextMenuPage.byIndexClick(0);
            pages.deleteMessagePage.ensurePageLoaded();

        }

        public void goToCalendarFromURL(string URL)
        {
            pages.employeesPage.ensureMenuLoaded();
            pages.goToURL(URL);
            pages.calendarTimeOffPage.ensurePageLoaded();
   
        }

        public void selectType(string type)
        {
            //выбор типа отпуска
            pages.newTimeOffPopup.ensurePageLoaded();
            pages.newTimeOffPopup.setTypeField(type);
            pages.newTimeOffPopup.ensurePageLoaded();
        }
    }
}
