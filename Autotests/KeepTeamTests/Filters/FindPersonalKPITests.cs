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
    public class FindKPIPersonalTests : InternalPageTests
    {
       [SetUp]
        public void Login()
        {
                 app.userHelper
                     .loginAs(app.userHelper.getUserByRole("pKPIRW"));
         
        }
        
        
        [Test()]
        public void Find_KPIPersonal()
        {
            //Установка значения поиска
            app.filterHelper.setFindText("KPI");
           //Проверка  результата
            KPI testKPI = app.kpiHelper.getKPIFromTable();
            
            Assert.AreEqual("KPI", testKPI.KPIName);
        }
        [TearDown]
        public void ClearFilter()
        {
            app.filterHelper.ClearSearchField();
        }
      
        
       

       

     
    }
}
