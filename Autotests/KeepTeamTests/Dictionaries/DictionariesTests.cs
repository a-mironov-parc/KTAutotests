using System;
using KeepTeamAutotests;
using KeepTeamAutotests.Model;
using KeepTeamAutotests.AppLogic;
using NUnit.Framework;
using System.Collections.Generic;

namespace KeepTeamTests
{
    [TestFixture()]
    public class DictionariesTests : InternalPageTests
    {

        [SetUp]
        public void Login()
        {
            app.userHelper
                .loginAs(app.userHelper.getUserByRole("aDictionariesRW"));

        }

        [Test()]

        public void Compare_List_Dictionaries()
        {
            //Проверка соответствия двух отпусков.
            Assert.IsTrue(app.userHelper.CompareList(app.userHelper.getListDictionaries(), FileHelper.dictionaries()));
        }
   

    }
}
