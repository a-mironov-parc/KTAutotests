using System;
using KeepTeamAutotests;
using KeepTeamAutotests.Model;
using KeepTeamAutotests.AppLogic;
using NUnit.Framework;

namespace KeepTeamTests
{
    [TestFixture()]
    public class CreateKPITests : InternalPageTests
    {

        [SetUp]
        public void Login()
        {
            app.userHelper
                .loginAs(app.userHelper.getUserByRole("pKPIRW"));

        }

        [Test, TestCaseSource(typeof(FileHelper), "kpi")]
        public void Create_KPI(KPI kpi)
        {
            //клик по кнопке добавления
            app.userHelper.clickAddKPIButton();
            //создание KPI
            app.kpiHelper.createKPI(kpi);

            //создание тестового KPI для сравнения
            KPI testKPI = app.kpiHelper.getKPIPopup();
            //Проверка соответствия двух отпусков.
            Assert.IsTrue(app.kpiHelper.CompareKPI(kpi, testKPI));
        }
        [TearDown]
        public void DeleteCurrentKPI()
        {
            app.kpiHelper.DeleteCurrentKPI();

        }


    }
}
