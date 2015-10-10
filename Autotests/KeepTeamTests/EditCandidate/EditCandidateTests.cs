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
    public class EditCandidateTests : InternalPageTests
    {
       [SetUp]
        public void Login()
        {
                 app.userHelper
                     .loginAs(app.userHelper.getUserByRole("aCandidatesRW"));
        }

        
        [Test, TestCaseSource(typeof(FileHelper), "candidates")]
        public void Edit_Candidate(Candidate candidate)
        {

            //клик по первому кандидату
            app.hiringHelper.openFirstCandidate();
            //Очистка кандидатов
            app.hiringHelper.clearCandidatePopup();
            //Редактирование кандидата
            app.hiringHelper.editCandidate(candidate);
            app.hiringHelper.closeCandidatePopup();
            //создание тестовой вакансии для сравнения
            Candidate testCandidate = app.hiringHelper.getCandidatePopup(candidate);
            //Проверка соответствия двух вакансий.
            Assert.IsTrue(app.hiringHelper.CompareCandidate(candidate, testCandidate));
        }
        
        [Test, TestCaseSource(typeof(FileHelper), "candidatesreq")]
        public void Edit_Candidate_Validation(Candidate invalidCandidate)
        {

            //клик по кнопке добавления кандидата
            app.userHelper.clickAddCandidateButton();
            //Очистка основной информации
            app.hiringHelper.createCandidate(invalidCandidate);
     
            //проверка текста валидации
            Assert.AreEqual(app.userHelper.EMPTYINPUTMSG, app.userHelper.getValidationMessage());

        }
        [Ignore]
        [Test, TestCaseSource(typeof(FileHelper), "comments")]
        public void Edit_Candidate_Comment(Comment comment)
        { 
            //клик по первому кандидату
            app.hiringHelper.openFirstCandidate();
            //переход на вкладку комментариев
            app.userHelper.clickTabByName("Комментарии");
            //добавление комментария
            app.commentHelper.addComment(comment);

            Comment testcomment = app.commentHelper.getComment();
            //Проверка соответствия двух комментариев.
            Assert.IsTrue(app.commentHelper.CompareComments(comment, testcomment));
          
        }
      
      



    
    }
}
