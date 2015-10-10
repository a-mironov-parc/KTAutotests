using System;
using KeepTeamAutotests;
using KeepTeamAutotests.Model;
using NUnit.Framework;
using KeepTeamAutotests.AppLogic;

namespace KeepTeamTests
{
    [TestFixture()]
    public class DocumentScreenTests : ImagePopupTests
    {

        [SetUp]
        public void Login()
        {
            app.userHelper
                .loginAs(app.userHelper.getUserByRole("Администраторы"));

        }
      

        [Test, TestCaseSource(typeof(FileHelper), "documenttype")]
        public void Compare_Image_Documents(SimpleString docType)
        {

            //клик по кнопке добавления
            app.userHelper.clickAddButton();
            app.employeeHelper.openNewDocumentsPopup(docType.value);
            //Проверка соответствия скриншотов
            Assert.IsTrue(app.screenHelper.NewDocumentPopupScreen(docType.value));
        }

        
       





    }
}
