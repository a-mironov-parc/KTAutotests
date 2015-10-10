using System;
using KeepTeamAutotests;
using KeepTeamAutotests.Model;
using NUnit.Framework;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using KeepTeamAutotests.AppLogic;

namespace KeepTeamTests
{
    [TestFixture()]
    public class EditAssetsTests : InternalPageTests
    {
       [SetUp]
        public void Login()
        {
            app.userHelper
                 .loginAs(app.userHelper.getUserByRole("pAssetsRW"));
         
        }


        [Test, TestCaseSource(typeof(FileHelper), "assets")]
       public void Edit_Assets(Asset asset)

        {
            app.assetHelper.openFirstAsset();
            //Очистка значений попапа
            app.assetHelper.clearAssetPopup();
            //Редактирование инвентаря
            app.assetHelper.editAsset(asset);
            //создание тестового инвентаря для сравнения
            Asset testAsset = app.assetHelper.getAssetPopup();
            //Проверка соответствия двух отпусков.
            Assert.IsTrue(app.assetHelper.CompareAssets(asset, testAsset));

        }



  
    }
}
