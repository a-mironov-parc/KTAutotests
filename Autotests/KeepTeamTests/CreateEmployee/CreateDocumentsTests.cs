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
    public class CreateDocumentsTests : InternalPageTests
    {
       [SetUp]
        public void Login()
        {
                 app.userHelper
                     .loginAs(app.userHelper.getAdminUser());
        }


        [Test, TestCaseSource(typeof(FileHelper), "documents")]
        public void Create_Employee_Documents(Employee employee)
        {
            //клик по кнопке добавления
            app.userHelper.clickAddButton();
            //Добавление пользователя
            app.employeeHelper.createEmployeeDocuments(employee);
            //создание тестового юзера для сравнения
            Employee testEmployee = app.employeeHelper.getDocumentPopup(employee.typeDoc);
            //Проверка соответствия двух пользователей.
            Assert.IsTrue(app.employeeHelper.CompareDocuments(employee, testEmployee));

        }

      
      

        [TearDown]
        public void DeleteCurrentEmployee()
        {
            app.employeeHelper.DeleteCurrentEmployee();

        }


    
    }
}
