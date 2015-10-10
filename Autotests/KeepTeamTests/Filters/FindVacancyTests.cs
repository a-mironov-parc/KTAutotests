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
    public class VacancyFindTests : InternalPageTests
    {
       [SetUp]
        public void Login()
        {
                 app.userHelper
                     .loginAs(app.userHelper.getUserByRole("aVacancyRW"));
         
        }
        
        [Test()]
        public void Find_Vacancy()
        {
            //Установка значения поиска
            app.filterHelper.setFindText("Новая вакансия");
           //Проверка  результата
            Vacancy testVacancy = app.hiringHelper.getVacancyFromTable();
            Assert.AreEqual("Новая вакансия", testVacancy.VacName);
        }
        [TearDown]
        public void ClearFilter()
        {
            app.filterHelper.ClearSearchField();
        }
     
    }
}
