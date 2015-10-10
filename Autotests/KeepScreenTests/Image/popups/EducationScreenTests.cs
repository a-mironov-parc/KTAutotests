using System;
using KeepTeamAutotests;
using KeepTeamAutotests.Model;
using NUnit.Framework;
using KeepTeamAutotests.AppLogic;

namespace KeepTeamTests
{
    [TestFixture()]
    public class EducationScreenTests : ImagePopupTests
    {

        [SetUp]
        public void Login()
        {
            app.userHelper
                .loginAs(app.userHelper.getUserByRole("pEducationRW"));

        }
      

        [Test()]
        public void Compare_Image_Education()
        {

            //клик по кнопке добавления
            app.employeeHelper.openNewEducationPopup();
            //Проверка соответствия скриншотов
            Assert.IsTrue(app.screenHelper.NewEducationPopupScreen());
        }

        
       





    }
}
