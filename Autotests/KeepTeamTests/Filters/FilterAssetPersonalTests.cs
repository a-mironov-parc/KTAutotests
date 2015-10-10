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
    public class FilterAssetPersonalTests : InternalPageTests
    {
       [SetUp]
        public void Login()
        {
                 app.userHelper
                     .loginAs(app.userHelper.getUserByRole("pAssetsRW"));
         
        }
        
        // фильтр категория, почему-то пока часто сбоит
        [Test()]
       public void Filter_Category_AssetPersonal()
        {
            //Установка значения фильтра
            app.filterHelper.setCheckBoxFilter("Все категории", "Компьютер", "Все категории");
            //Проверка  результата
            Asset testAsset = app.assetHelper.getAssetFromTable();
            
            Assert.AreEqual("Компьютер", testAsset.ASCategory);
        }
        [Ignore("фильтр в инвентаре")]
        [Test()]
        public void Filter_Date_AssetPersonal()
        {
            //Установка значения фильтра
            app.filterHelper.setCheckBoxFilter("Все категории", "Компьютер", "Все категории");
            //Проверка  результата
            Asset testAsset = app.assetHelper.getAssetFromTable();

            Assert.AreEqual("Компьютер", testAsset.ASCategory);
        }

        [TearDown]
        public void ClearFilter()
        {
            app.filterHelper.ClearFilters();

        }

      
        
       

       

     
    }
}
