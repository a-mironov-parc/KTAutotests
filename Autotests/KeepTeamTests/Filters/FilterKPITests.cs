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
    public class FilterKPITests : InternalPageTests
    {
       [SetUp]
        public void Login()
        {
                 app.userHelper
                     .loginAs(app.userHelper.getUserByRole("aKPIRW"));
                 app.userHelper.clickMenu("KPI");
         
        }

        [Test()]
        //Фильтр по исполнителю
       public void Filter_Employee_KPI()
        {

            //Установка значения фильтра
            app.filterHelper.setCheckBoxFilter("Все исполнители", "Сотрудник Владелец", "Все исполнители");
            //Проверка  результата
            KPI testKPI = app.kpiHelper.getKPIFromTable();
            Assert.AreEqual("Сотрудник Владелец", testKPI.KPIEmployee);
        }

        [Test()]
        //Фильтр по подразделению
        public void Filter_Department_KPI()
        {
            //Установка значения фильтра
            app.filterHelper.setCheckBoxFilter("Все подразделения", "Keepteam", "Все подразделения");
            //Проверка  результата
            KPI testKPI = app.kpiHelper.getKPIFromTable();
            Assert.AreEqual("Сотрудник Владелец", testKPI.KPIEmployee);
        }
        [Test()]
        //Фильтр по должности
        public void Filter_Position_KPI()
        {
            //Установка значения фильтра
            app.filterHelper.setCheckBoxFilter("Все должности", "Бухгалтер", "Все должности");
            //Проверка  результата
            KPI testKPI = app.kpiHelper.getKPIFromTable();
            Assert.AreEqual("Сотрудник Владелец", testKPI.KPIEmployee);
        }
      
      
        [Test()]
        public void Filter_Filial_KPI()
        {
            //Установка значения фильтра
            app.filterHelper.setCheckBoxFilter("Все филиалы", "Филиал", "Все филиалы");
            //Проверка  результата
            KPI testKPI = app.kpiHelper.getKPIFromTable();
            Assert.AreEqual("Сотрудник Владелец", testKPI.KPIEmployee);

        }

        // фильтр по подразделениям
        [Test()]
        public void Filter_Status_KPI()
        {
            //Установка значения фильтра
            app.filterHelper.setCheckBoxFilter("Любой статус", "Завершенные", "Любой статус");
            //Проверка  результата
            KPI testKPI = app.kpiHelper.getKPIFromTable();
            Assert.AreEqual(100, testKPI.KPIProgress);
        }
        [TearDown]
        public void ClearFilter()
        {
            app.filterHelper.ClearFilters();

        }
      
        
       

       

     
    }
}
