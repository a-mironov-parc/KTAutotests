using System;
using KeepTeamAutotests;
using KeepTeamAutotests.Model;
using KeepTeamAutotests.AppLogic;
using NUnit.Framework;

namespace KeepTeamTests
{
    [TestFixture()]
    public class EmailTests : TestBase
    {

        [SetUp]
        public void LoginFromEmail()
        {
            app.userHelper
                  .loginAs(app.userHelper.getUserByRole("pTimeOffsRW"));

        }
        [Ignore("Тест email")]
        [Test, TestCaseSource(typeof(FileHelper), "emailtimeoffs")]
        public void Email_Create_TimeOffs(TimeOff timeoff)
        {
            //клик по кнопке добавления
            app.userHelper.clickNewTimeOffsButton();
            //создание отпуска
            app.timeoffHelper.createTimeOff(timeoff);
            //подключение к почтовому ящику и получение писем
            app.emailHeper.getEmail("testkeepteammail@yandex.ru", "testmail");
            //Проверка соответствия двух отпусков.
            Assert.IsTrue(app.emailHeper.TimeOffEmail());

        }
        [TearDown]
        public void DeleteCurrentEmail()
        {
            app.emailHeper.DeleteCurrentMessage();
        }

    }
}
