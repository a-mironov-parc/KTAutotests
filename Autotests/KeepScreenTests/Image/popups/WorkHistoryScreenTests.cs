using System;
using KeepTeamAutotests;
using KeepTeamAutotests.Model;
using NUnit.Framework;
using KeepTeamAutotests.AppLogic;

namespace KeepTeamTests
{
    [TestFixture()]
    public class WorkHistoryScreenTests : ImagePopupTests
    {

        [SetUp]
        public void Login()
        {
            app.userHelper
                .loginAs(app.userHelper.getUserByRole("pWorkHistoryRW"));

        }
      

        [Test, TestCaseSource(typeof(FileHelper), "workhistorytype")]
        public void Compare_Image_WorkHistory(SimpleString workHistoryType)
        {
            //клик по кнопке добавления
            app.employeeHelper.openNewWorkInfoPopup(workHistoryType.value);
            //Проверка соответствия скриншотов
            Assert.IsTrue(app.screenHelper.NewWorkInfoPopupScreen(workHistoryType.value));
           
        }

        
       





    }
}
