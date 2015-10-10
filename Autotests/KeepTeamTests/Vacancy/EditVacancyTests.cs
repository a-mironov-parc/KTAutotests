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
    public class EditVacancyTests : InternalPageTests
    {
       [SetUp]
        public void Login()
        {
            app.userHelper
                 .loginAs(app.userHelper.getUserByRole("aVacancyRW"));
         
        }

       
       [Test, TestCaseSource(typeof(FileHelper), "vacancies")]
       public void Edit_Vacancy(Vacancy vacancy)

        {
           //Открытие первой вакансии 
           app.hiringHelper.openFirstVacancy();
           //Очистка значений попапа
           app.hiringHelper.clearVacancyPopup();
           //Редактирование вакансии
           app.hiringHelper.editVacancy(vacancy);
           //создание тестовой вакансии для сравнения
           Vacancy testVacancy = app.hiringHelper.getVacancyPopup();
           //Проверка соответствия двух вакансий
           Assert.IsTrue(app.hiringHelper.CompareVacancy(vacancy, testVacancy));

        }



  
    }
}
