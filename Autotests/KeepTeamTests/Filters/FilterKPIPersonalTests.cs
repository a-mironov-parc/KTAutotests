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
    public class FilterKPIPersonalTests : InternalPageTests
    {
       [SetUp]
        public void Login()
        {
                 app.userHelper
                     .loginAs(app.userHelper.getUserByRole("pKPIRW"));
         
        }
        // фильтр по подразделениям
        [Test()]
       public void Filter_Status_KPIPersonal()
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
