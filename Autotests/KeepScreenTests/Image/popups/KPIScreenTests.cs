using System;
using KeepTeamAutotests;
using KeepTeamAutotests.Model;
using NUnit.Framework;
using KeepTeamAutotests.AppLogic;

namespace KeepTeamTests
{
    [TestFixture()]
    public class KPIScreenTests : ImagePopupTests
    {

        [SetUp]
        public void Login()
        {
            app.userHelper
                .loginAs(app.userHelper.getUserByRole("pKPIRW"));

        }
      
        [Test()]
        public void Compare_Image_KPI()
        {
            //клик по кнопке добавления KPI
            app.userHelper.clickAddKPIButton();
            
            //Проверка соответствия скриншотов
            Assert.IsTrue(app.screenHelper.NewKPIPopupScreen());
        }
   

    }
}
