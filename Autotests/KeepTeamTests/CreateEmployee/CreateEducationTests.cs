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
    public class CreateEducationTests : InternalPageTests
    {
       [SetUp]
        public void Login()
        {
                 app.userHelper
                     .loginAs(app.userHelper.getAdminUser());
        }

        
        [Test, TestCaseSource(typeof(FileHelper), "education")]
        public void Create_Employee_Education(Employee employee)
        {
            //клик по кнопке добавления
            app.userHelper.clickAddButton();
            //Добавление пользователя
            app.employeeHelper.createEmployeeEducation(employee);
      
            //создание тестового юзера для сравнения
            Employee testEmployee = app.employeeHelper.getEducation();
                   
            //Проверка соответствия двух пользователей.
            Assert.IsTrue(app.employeeHelper.CompareEducations(employee, testEmployee));
            
        }
           

        [TearDown]
        public void DeleteCurrentEmployee()
        {
            app.employeeHelper.DeleteCurrentEmployee();

        }


    
    }
}
