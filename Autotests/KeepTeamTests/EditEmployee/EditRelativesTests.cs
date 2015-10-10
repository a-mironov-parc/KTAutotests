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
    public class EditRelativesTests : InternalPageTests
    {
       [SetUp]
        public void Login()
        {
                 app.userHelper
                     .loginAs(app.userHelper.getUserByRole("pFamilyRW"));
         
        }


        [Test, TestCaseSource(typeof(FileHelper),"relatives")]
        
        public void Edit_Relatives(Employee employee)

        {
            app.employeeHelper.clearRelatives();
            //Редактирование 
            app.employeeHelper.editRelatives(employee);

            //создание тестового юзера для сравнения
            Employee testEmployee = app.employeeHelper.getRelatives();

            //Проверка соответствия двух пользователей.

            Assert.IsTrue(app.employeeHelper.CompareRelatives(employee, testEmployee));
            employee.WriteToConsole();
            testEmployee.WriteToConsole();

        }
        [Test, TestCaseSource(typeof(FileHelper), "relativesreq")]
        public void Edit_Employee_Relatives_Validation(Employee invalidEmployee)
        {

            //Очистка основной информации
            app.employeeHelper.clearRelatives();
            //Редактирование 
            app.employeeHelper.editRelatives(invalidEmployee);
            //проверка текста валидации
            Assert.AreEqual(app.userHelper.EMPTYINPUTMSG, app.userHelper.getValidationMessage());

        }

      



  
    }
}
