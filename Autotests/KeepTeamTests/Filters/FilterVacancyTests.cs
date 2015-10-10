using System;
using KeepTeamAutotests;
using KeepTeamAutotests.Model;
using NUnit.Framework;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using KeepTeamAutotests.AppLogic;
using System.Threading;

namespace KeepTeamTests
{
    [TestFixture()]
    public class FilterVacancyTests : InternalPageTests
    {
       [SetUp]
        public void Login()
        {
                 app.userHelper
                     .loginAs(app.userHelper.getUserByRole("aVacancyRW"));
         
        }
        // фильтр по статусу
        [Test()]
       public void Filter_Status_Vacancy()
        {
            //Установка значения фильтра
            app.filterHelper.setCheckBoxFilter("Все вакансии", "Открытые", "Все вакансии");
            //Проверка  результата
            Vacancy testVacancy = app.hiringHelper.getVacancyFromTable();
            Assert.IsTrue(testVacancy.VacStatus == "Открыта");

        }

        [Test()]
        public void Filter_Department_Vacancy()
        {
            //Установка значения фильтра
            app.filterHelper.setCheckBoxFilter("Все подразделения","Casebook","Все подразделения");
            //Проверка  результата
            Vacancy testVacancy = app.hiringHelper.getVacancyFromTable();
            Assert.IsTrue(testVacancy.VacDepartment.Contains("Casebook"));
            
        }
        [Test()]
        public void Filter_Filial_Vacancy()
        {
            //Установка значения фильтра
            app.filterHelper.setCheckBoxFilter("Все филиалы", "Филиал", "Все филиалы");
            //Проверка  результата
            Vacancy testVacancy = app.hiringHelper.getVacancyFromTable();
            Assert.IsTrue(testVacancy.VacFilial.Contains("Филиал"));

        }
        [TearDown]
        public void ClearFilter()
        {
            app.filterHelper.ClearFilters();

        }
     
     
    }
}
