using System;
using KeepTeamAutotests;
using KeepTeamAutotests.Model;
using KeepTeamAutotests.AppLogic;
using NUnit.Framework;

namespace KeepTeamTests
{
    [TestFixture()]
    public class CreateTimeOffsTests : InternalPageTests
    {

        [SetUp]
        public void Login()
        {
            app.userHelper
                .loginAs(app.userHelper.getUserByRole("pTimeOffsRW"));

        }
        
         [Test, TestCaseSource(typeof(FileHelper), "timeoffs")]

        public void Create_TimeOffs(TimeOff timeoff)
        {
            //клик по кнопке добавления
            app.userHelper.clickNewTimeOffsButton();
            //создание отпуска
            app.timeoffHelper.createTimeOff(timeoff);
            //создание тестового отпуска для сравнения
            TimeOff testTimeOff = app.timeoffHelper.getTimeOffPopupByType(timeoff.TOtype);
            //Проверка соответствия двух отпусков.
            Assert.IsTrue(app.timeoffHelper.CompareTimeOffs(timeoff, testTimeOff));
  
        }
        [TearDown]
        public void DeleteCurrentTimeOff()
        {
             app.timeoffHelper.DeleteCurrentTimeOff();
        }


    }
}
