using System;
using KeepTeamAutotests;
using KeepTeamAutotests.Model;
using NUnit.Framework;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using KeepTeamAutotests.AppLogic;

namespace KeepTeamTests
{
    [TestFixture()]
    public class EditKPITests : InternalPageTests
    {
       [SetUp]
        public void Login()
        {
            app.userHelper
                 .loginAs(app.userHelper.getUserByRole("pKPIRW"));
         
        }

       
       [Test, TestCaseSource(typeof(FileHelper), "kpi")]
       public void Edit_KPI(KPI kpi)

        {
            app.kpiHelper.openFirstKPI();
            //Очистка значений попапа
            app.kpiHelper.clearKPIPopup();
            //Редактирование KPI
            app.kpiHelper.editKPI(kpi);
            //создание тестового KPI для сравнения
            KPI testKPI = app.kpiHelper.getKPIPopup();

            //Проверка соответствия двух отпусков.
            Assert.IsTrue(app.kpiHelper.CompareKPI(kpi, testKPI));

        }



  
    }
}
