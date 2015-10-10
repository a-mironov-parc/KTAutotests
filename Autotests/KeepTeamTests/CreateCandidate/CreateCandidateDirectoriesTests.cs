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
    public class CreateCandidateDirectoriesTests : InternalPageTests
    {
       [SetUp]
        public void Login()
        {
                 app.userHelper
                     .loginAs(app.userHelper.getUserByRole("aCandidatesRW"));
        }

        
        [Test, TestCaseSource(typeof(FileHelper), "candidatesDirectories")]
        public void Create_CandidateDirectories(SimpleString directories)
        {
            //добавление новой папки
            app.hiringHelper.createCandidateDirectories(directories);

            Assert.AreEqual(directories.value,app.hiringHelper.getDirectoryName());
        }

      
      

        [TearDown]
        public void DeleteCurrentCandidate()
        {
            app.hiringHelper.DeleteLastCandidateDirecories();
        }


    
    }
}
