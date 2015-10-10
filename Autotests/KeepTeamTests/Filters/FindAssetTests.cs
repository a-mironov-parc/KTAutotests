using System;
using KeepTeamAutotests;
using KeepTeamAutotests.Model;
using NUnit.Framework;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using KeepTeamAutotests.AppLogic;
using System.Threading;

namespace KeepTeamTests
{
    [TestFixture()]
    public class FindAssetTests : InternalPageTests
    {
       [SetUp]
        public void Login()
        {
                 app.userHelper
                     .loginAs(app.userHelper.getUserByRole("aAssetRW"));
                 app.userHelper.clickMenu("ИНВЕНТАРЬ");
        }
        
        //Поиск
        
        [Test]
        public void Find_Asset()
        {
            //Установка значения поиска
            app.filterHelper.setFindText("Полный инвентарь");
           //Проверка  результата
            Asset testAsset = app.assetHelper.getAssetFromTable();

            Assert.AreEqual("Полный инвентарь", testAsset.ASName);
        }
        [TearDown]
        public void ClearFilter()
        {
            app.filterHelper.ClearSearchField();
        }
      
        
       

       

     
    }
}
