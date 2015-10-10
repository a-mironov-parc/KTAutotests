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
    public class CreateContactsTests : InternalPageTests
    {
       [SetUp]
        public void Login()
        {
                 app.userHelper
                     .loginAs(app.userHelper.getAdminUser());
        }


        [Test, TestCaseSource(typeof(FileHelper), "contacts")]
        public void Create_Employee_Contacts(Employee employee)
        {
            //клик по кнопке добавления
            app.userHelper.clickAddButton();
            //Добавление пользователя
            app.employeeHelper.createEmployeeContacts(employee);
        
            //создание тестового юзера для сравнения
            Employee testEmployee = app.employeeHelper.getContacts();
                   
            //Проверка соответствия двух пользователей.
           
            Assert.IsTrue(app.employeeHelper.CompareContacts(employee, testEmployee));

        }

      
       
        [TearDown]
        public void DeleteCurrentEmployee()
        {
            app.employeeHelper.DeleteCurrentEmployee();

        }


    
    }
}
