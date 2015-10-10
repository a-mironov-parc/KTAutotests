using KeepTeamAutotests.Model;
using KeepTeamAutotests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepTeamAutotests.AppLogic
{
    public class KPIHelper
    {
        private AppManager app;
        private PageManager pages;
        public KPIHelper(AppManager app)
            
        {
            this.app = app;
            this.pages = app.Pages;
            
        }


        public void createKPI(KPI kpi)
        {
            editKPI(kpi);
        }
        public void editKPI(KPI kpi)
        {
            //заполнение полей создания KPI
            pages.newKPIPopup.ensurePageLoaded();
            pages.newKPIPopup.setNameField(kpi.KPIName);
            pages.newKPIPopup.setDateField(kpi.KPIDate);
            pages.newKPIPopup.setDescriptionField(kpi.KPIDescription);
            //pages.newKPIPopup.setEmployeeField(kpi.KPIEmployee);
            pages.newKPIPopup.setProgressBar(kpi.KPIProgress);
            pages.newKPIPopup.setActionsField(kpi.KPIActions);
            pages.newKPIPopup.setMeasuringField(kpi.KPIMeasuring);
            pages.newKPIPopup.addClick();
            refreshpage();

        }

        public void refreshpage()
        {
            //перезагрузка страницы, для проверки введенных полей
            pages.newKPIPopup.waitSaveDone();
            pages.newKPIPopup.refreshPage();
        }



        public bool CompareKPI(KPI KPI1, KPI KPI2)
        {
            KPI1.WriteToConsole();
            KPI2.WriteToConsole();
            return
                KPI1.KPIName == KPI2.KPIName &&
                KPI1.KPIDate == KPI2.KPIDate &&
                KPI1.KPIEmployee == KPI2.KPIEmployee &&
                KPI1.KPIDescription == KPI2.KPIDescription &&
                KPI1.KPIProgress == KPI2.KPIProgress &&
                KPI1.KPIMeasuring == KPI2.KPIMeasuring &&
                KPI1.KPIActions == KPI2.KPIActions;
               
        }

        public KPI getKPIPopup()
        {
            openFirstKPI();
            //переход к первой записи
            pages.newKPIPopup.ensurePageLoaded();
            KPI kpi = new KPI();
            kpi.KPIDate = pages.newKPIPopup.getDate();
            kpi.KPIDescription = pages.newKPIPopup.getDescription();
            kpi.KPIEmployee = pages.newKPIPopup.getEmployee();
            kpi.KPIMeasuring = pages.newKPIPopup.getMeasuring();
            kpi.KPIActions = pages.newKPIPopup.getActions();
            kpi.KPIName = pages.newKPIPopup.getName();
            kpi.KPIProgress = pages.newKPIPopup.getProgress();

            pages.newKPIPopup.closePopup();
            
            return kpi;

        }


        public void DeleteCurrentKPI()
        {
            //Удаление через троеточие
            openDeleteMessageFromThreeDots();
            pages.deleteMessagePage.yesButtonClick();
            pages.deleteMessagePage.waitSaveDone();

        }
        public void openDeleteMessageFromThreeDots()
        {
            //Открытие меню удаления
            pages.personalKPIPage.ensurePageLoaded();
            pages.personalKPIPage.deleteFromThreeDots();
            //клик по кнопке удаления
            pages.contextMenuPage.ensurePageLoaded();
            pages.contextMenuPage.byIndexClick(0);
            pages.deleteMessagePage.ensurePageLoaded();

        }

      /*  public KPI getKPIFromPersonalTable() пока закомментировал, потому как нет разницы в персональной и общей таблице
        {
            KPI kpi = new KPI();
            kpi.KPIName = pages.personalKPIPage.getKPIName();
            kpi.KPIDate = pages.personalKPIPage.getKPIDate();
            kpi.KPIProgress = pages.personalKPIPage.getKPIProgress();
            
            return kpi;
        }*/
        public KPI getKPIFromTable()
        {
            KPI kpi = new KPI();
            kpi.KPIName = pages.personalKPIPage.getKPIName();
            kpi.KPIDate = pages.personalKPIPage.getKPIDate();
            kpi.KPIProgress = pages.personalKPIPage.getKPIProgress();
            kpi.KPIEmployee = pages.personalKPIPage.getKPIEmployee();

            return kpi;
        }

        public void openFirstKPI()
        {
            //получение информации о KPI
            pages.personalKPIPage.ensurePageLoaded();
            pages.personalKPIPage.openKPIPopup();

        }

        public void clearKPIPopup()
        {
            //Очистка полей попапа KPI
            pages.newKPIPopup.ensurePageLoaded();
            pages.newKPIPopup.clearName();
            pages.newKPIPopup.clearDate();
            //pages.newKPIPopup.clearEmployee();
            pages.newKPIPopup.clearDescription();
            pages.newKPIPopup.clearProgress();
            pages.newKPIPopup.clearMeasuring();
            pages.newKPIPopup.clearActions();
            

        
        }
       
    }
}
