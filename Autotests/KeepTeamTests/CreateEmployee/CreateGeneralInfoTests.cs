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
    public class CreateGeneralInfoTests : InternalPageTests
    {
       [SetUp]
        public void Login()
        {
                 app.userHelper
                     .loginAs(app.userHelper.getUserByRole("Администраторы"));
         
        }


        [Test, TestCaseSource(typeof(FileHelper), "employee")]
        public void Create_Employee(Employee employee)
        {
            //клик по кнопке добавления
            app.userHelper.clickAddButton();

            //Добавление пользователя
            app.employeeHelper.createEmployee(employee);
        
            //создание тестового юзера для сравнения
            Employee testEmployee = app.employeeHelper.getGeneralInfo();
           
            //Проверка соответствия двух пользователей.
            Assert.IsTrue(app.employeeHelper.CompareGeneralInfo(employee, testEmployee));
     
        }

       

        [TearDown]
        public void DeleteCurrentEmployee()
        {
            app.employeeHelper.DeleteCurrentEmployee();

        }

     
    }
}
