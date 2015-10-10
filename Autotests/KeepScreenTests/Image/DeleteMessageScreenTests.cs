using System;
using KeepTeamAutotests;
using KeepTeamAutotests.Model;
using NUnit.Framework;
using KeepTeamAutotests.AppLogic;

namespace KeepTeamTests
{
    [TestFixture()]
    public class DeleteMessageScreenTests : InternalPageTests
    {

        [SetUp]
        public void Login()
        {
            app.userHelper
                .loginAs(app.userHelper.getUserByRole("pAssetsRW"));

        }
      

        [Test()]
        public void Compare_Image_Assets_DeleteMessage()
        {
            //клик по кнопке добавления инвентаря
            app.assetHelper.openDeleteMessageFromThreeDots();
            //Проверка соответствия скриншотов
            Assert.IsTrue(app.screenHelper.DeleteMessageScreen());
        }

        
       





    }
}
