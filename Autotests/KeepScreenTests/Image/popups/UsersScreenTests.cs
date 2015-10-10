using System;
using KeepTeamAutotests;
using KeepTeamAutotests.Model;
using NUnit.Framework;
using KeepTeamAutotests.AppLogic;

namespace KeepTeamTests
{
    [TestFixture()]
    public class UsersScreenTests : ImagePopupTests
    {

        [SetUp]
        public void Login()
        {
            app.userHelper
                .loginAs(app.userHelper.getUserByRole("aUsersRW"));

        }
      

        [Test()]
        public void Compare_Image_Users()
        {
            //клик по кнопке добавления инвентаря
            app.userHelper.clickAddUserButton();
            //Проверка соответствия скриншотов
            Assert.IsTrue(app.screenHelper.NewUserPopupScreen());
        }
        

        
       





    }
}
