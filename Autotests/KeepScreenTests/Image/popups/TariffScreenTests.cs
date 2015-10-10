using System;
using KeepTeamAutotests;
using KeepTeamAutotests.Model;
using NUnit.Framework;
using KeepTeamAutotests.AppLogic;

namespace KeepTeamTests
{
    [TestFixture()]
    public class TariffScreenTests : ImagePopupTests
    {

        [SetUp]
        public void Login()
        {
            app.userHelper
                .loginAs(app.userHelper.getUserByRole("aGeneralSettingRW"));

        }
 
        [Test()]
        public void Compare_Image_Tariff()
        {
            //клик по кнопке улучшения
            app.userHelper.clickChangeTariff();
            //Проверка соответствия скриншотов
            Assert.IsTrue(app.screenHelper.NewTariffPopupScreen());
        }
   
    }
}
