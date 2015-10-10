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
    public class CreateVacancyTests : InternalPageTests
    {
       [SetUp]
        public void Login()
        {
                 app.userHelper
                     .loginAs(app.userHelper.getUserByRole("aVacancyRW"));
        }

        
        [Test, TestCaseSource(typeof(FileHelper), "vacancies")]
        public void Create_Vacancy(Vacancy vacancy)
        {
            //клик по кнопке добавления
            app.userHelper.clickAddButton();
            //Добавление пользователя
            app.hiringHelper.createVacancy(vacancy);
            //создание тестовой вакансии для сравнения
            Vacancy testVacancy = app.hiringHelper.getVacancyPopup();
            //Проверка соответствия двух вакансий.
            Assert.IsTrue(app.hiringHelper.CompareVacancy(vacancy, testVacancy));
        }

      
      

        [TearDown]
        public void DeleteCurrentAsset()
        {
            app.hiringHelper.DeleteCurrentVacancy();

        }


    
    }
}
