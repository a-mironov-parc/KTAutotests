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
    public class EditGeneralInfoTests : InternalPageTests
    {
       [SetUp]
        public void Login()
        {
            app.userHelper
                 .loginAs(app.userHelper.getUserByRole("pGeneralInfoRW"));
         
        }


        [Test, TestCaseSource(typeof(FileHelper), "employee")]
        public void Edit_GeneralInfo(Employee employee)

        {
            //Очистка основной информации
            app.employeeHelper.clearGeneralInfo();
            //Редактирование 
            app.employeeHelper.editGeneralInfo(employee);

            //создание тестового юзера для сравнения
            Employee testEmployee = app.employeeHelper.getGeneralInfo();
            
            //Проверка соответствия двух пользователей.

            Assert.IsTrue(app.employeeHelper.CompareGeneralInfo(employee, testEmployee));

        }
         [Test, TestCaseSource(typeof(FileHelper), "employeereq")]
        public void Edit_Employee_Validation(Employee invalidEmployee)
        {
            //Очистка основной информации
            app.employeeHelper.clearGeneralInfo();

            //Редактирование 
            app.employeeHelper.editGeneralInfo(invalidEmployee);
            //проверка текста валидации
            Assert.AreEqual(app.userHelper.EMPTYINPUTMSG, app.userHelper.getValidationMessage());

        }
      

       




  
    }
}
