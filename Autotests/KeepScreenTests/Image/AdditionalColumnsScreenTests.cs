using System;
using KeepTeamAutotests;
using KeepTeamAutotests.Model;
using NUnit.Framework;

namespace KeepTeamTests
{
    [TestFixture()]
    public class AdditionalColumnsScreenTests : InternalPageTests
    {

        [SetUp]
        public void Login()
        {
            app.userHelper
                .loginAs(app.userHelper.getUserByRole("Администраторы"));

        }
        [Ignore]
        [Test()]
        public void Compare_Image_Employees()
        {
            //клик по кнопке добавления
            app.userHelper.clickAdditionalColumnsButton();
            //Проверка соответствия скриншотов
            Assert.IsTrue(app.screenHelper.AdditionalColumnsScreen());
      
        }


    }
}
