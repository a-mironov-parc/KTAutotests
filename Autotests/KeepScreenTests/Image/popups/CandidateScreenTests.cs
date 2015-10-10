using System;
using KeepTeamAutotests;
using KeepTeamAutotests.Model;
using NUnit.Framework;
using KeepTeamAutotests.AppLogic;

namespace KeepTeamTests
{
    [TestFixture()]
    public class CandidateScreenTests : ImagePopupTests
    {

        [SetUp]
        public void Login()
        {
            app.userHelper
                .loginAs(app.userHelper.getUserByRole("aCandidatesRW"));

        }
      

        [Test()]
        public void Compare_Image_Candidate()
        {
            //клик по кнопке добавления кандидатов
            app.userHelper.clickAddCandidateButton();
            //Проверка соответствия скриншотов
            Assert.IsTrue(app.screenHelper.NewCandidatePopupScreen());
        }
        [Test()]
        public void Compare_Image_Candidate_Resume()
        {
            //клик по кнопке добавления кандидатов
            app.userHelper.clickAddCandidateButton();
            //переход на вкладку резюме
            app.userHelper.clickTabByName("Резюме");
            //Проверка соответствия скриншотов
            Assert.IsTrue(app.screenHelper.NewCandidatePopupResumeScreen());

        }

        [Test()]
        public void Compare_Image_Candidate_Comments()
        {
            //клик по кнопке добавления кандидатов
            app.userHelper.clickAddCandidateButton();
            //переход на вкладку комментариев
            app.userHelper.clickTabByName("Комментарии");
            //Проверка соответствия скриншотов
            Assert.IsTrue(app.screenHelper.NewCandidatePopupCommentsScreen());

        }
      

        
       





    }
}
