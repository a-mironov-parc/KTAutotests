using System;
using KeepTeamAutotests;
using KeepTeamAutotests.Model;
using KeepTeamAutotests.AppLogic;
using NUnit.Framework;

namespace KeepTeamTests
{
    [TestFixture()]
    public class CreateAssetsTests : InternalPageTests
    {

        [SetUp]
        public void Login()
        {
            app.userHelper
                .loginAs(app.userHelper.getUserByRole("pAssetsRW"));

        }

        [Test, TestCaseSource(typeof(FileHelper), "assets")]
        
        public void Create_Assets(Asset asset)
        {
            //клик по кнопке добавления
            app.userHelper.clickAddAssetsButton();
            //создание инвентаря
            app.assetHelper.createAsset(asset);

            //создание тестового инвентаря для сравнения
            Asset testAsset = app.assetHelper.getAssetPopup();
            
            //Проверка соответствия двух отпусков.
            Assert.IsTrue(app.assetHelper.CompareAssets(asset, testAsset));

         }
         [TearDown]
         public void DeleteCurrentAsset()
         {
             app.assetHelper.DeleteCurrentAsset();

         }


    }
}
