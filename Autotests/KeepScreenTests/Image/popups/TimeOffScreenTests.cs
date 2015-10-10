using System;
using KeepTeamAutotests;
using KeepTeamAutotests.Model;
using NUnit.Framework;
using KeepTeamAutotests.AppLogic;

namespace KeepTeamTests
{
    [TestFixture()]
    public class TimeOffScreenTests : ImagePopupTests
    {

        [SetUp]
        public void Login()
        {
            app.userHelper
                .loginAs(app.userHelper.getUserByRole("pTimeOffsRW"));

        }
      
        [Test(), TestCaseSource(typeof(FileHelper), "timeofftype")]
        public void Compare_Image_NewTimeOff(SimpleString timeofftype)
        {

            //клик по кнопке добавления
            app.userHelper.clickNewTimeOffsButton();
            //выбор типа отпуска
            app.timeoffHelper.selectType(timeofftype.value);
            //Проверка скриншота
            Assert.IsTrue(app.screenHelper.NewTimeOffPopupScreen(timeofftype.value));
            
        }

        
       





    }
}
