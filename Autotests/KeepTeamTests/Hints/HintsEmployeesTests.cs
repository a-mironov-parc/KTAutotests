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
    public class HintsEmployeesTests : InternalPageTests
    {
       [SetUp]
        public void Login()
        {
                 app.userHelper
                     .loginAs(app.userHelper.getUserByRole("aHintsRW"));
       
        }
        [Ignore("тест подсказок")]
       // тест для проверки первой подсказки
       [Test, TestCaseSource(typeof(FileHelper), "hints")]
       public void Hints_Employees(Hint hint)
       {
           //Переход на страницу Сотрудники
           //не требуется для админа
         //  app.hintHelper.moveToHint("Employees.MoreFilters");

           Hint testHint = app.hintHelper.getHint("Employees.MoreFilters");
           //Проверка соответствия двух отпусков.
           Assert.IsTrue(app.hintHelper.CompareHints(hint, testHint));
           
    


         }
       
    }
}
