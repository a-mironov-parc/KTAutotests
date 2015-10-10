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
    public class CreateCandidateTests : InternalPageTests
    {
       [SetUp]
        public void Login()
        {
                 app.userHelper
                     .loginAs(app.userHelper.getUserByRole("aCandidatesRW"));
        }

        
        [Test, TestCaseSource(typeof(FileHelper), "candidates")]
        public void Create_Candidate(Candidate candidate)
        {
            //клик по кнопке добавления кандидата
            app.userHelper.clickAddCandidateButton();
            //Добавление кандидата
            app.hiringHelper.createCandidate(candidate);
            //создание тестовой вакансии для сравнения
            Candidate testCandidate = app.hiringHelper.getCandidatePopup(candidate);
            //Проверка соответствия двух вакансий.
            Assert.IsTrue(app.hiringHelper.CompareCandidate(candidate, testCandidate));
        }
 

        [TearDown]
        public void DeleteCurrentCandidate()
        {
            app.hiringHelper.DeleteCurrentCandidate();

        }


    
    }
}
