using System;
using KeepTeamAutotests;
using KeepTeamAutotests.Model;
using NUnit.Framework;
using KeepTeamAutotests.AppLogic;

namespace KeepTeamTests
{
    [TestFixture()]
    public class VacancyScreenTests : ImagePopupTests
    {

        [SetUp]
        public void Login()
        {
            app.userHelper
                .loginAs(app.userHelper.getUserByRole("aVacancyRW"));

        }
      

        [Test()]
        public void Compare_Image_Vacancy()
        {
            //клик по кнопке добавления вакансии
            app.userHelper.clickAddVacancyButton();
            //Проверка соответствия скриншотов
            Assert.IsTrue(app.screenHelper.NewVacancyPopupScreen());
           
        }

        [Test()]
        public void Compare_Image_Vacancy_Comments()
        {
            //клик по кнопке добавления вакансии
            app.userHelper.clickAddVacancyButton();
            //переход на вкладку комментариев
            app.userHelper.clickTabByName("Комментарии");
            //Проверка соответствия скриншотов
            Assert.IsTrue(app.screenHelper.NewVacancyPopupCommentsScreen());

        }

        
       





    }
}
