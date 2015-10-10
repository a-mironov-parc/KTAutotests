using System;
using KeepTeamAutotests;
using KeepTeamAutotests.Model;
using NUnit.Framework;
using KeepTeamAutotests.AppLogic;

namespace KeepTeamTests
{
    [TestFixture()]
    public class AssetScreenTests : ImagePopupTests
    {

        [SetUp]
        public void Login()
        {
            app.userHelper
                .loginAs(app.userHelper.getUserByRole("pAssetsRW"));

        }
      

        [Test()]
        public void Compare_Image_Assets()
        {
            //клик по кнопке добавления инвентаря
            app.userHelper.clickAddAssetsButton();
            
            //Проверка соответствия скриншотов
            Assert.IsTrue(app.screenHelper.NewAssetPopupScreen());
        }
        

        
       





    }
}
