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
    public class EditAddressRegistationTests : InternalPageTests
    {
       [SetUp]
        public void Login()
        {
                 app.userHelper
                     .loginAs(app.userHelper.getUserByRole("pRegistrationAddressRW"));
         
        }


        [Test, TestCaseSource(typeof(FileHelper), "addressregistration")]
         // пока не исправлена бага
        public void Edit_AddressRegistration(Employee employee)
        {
            app.employeeHelper.clearAddressRegistration();
            //Редактирование 
            app.employeeHelper.editAddressRegistration(employee);
            //создание тестового юзера для сравнения
            Employee testEmployee = app.employeeHelper.getAddressRegistration();
            //Проверка соответствия двух пользователей.
            Assert.IsTrue(app.employeeHelper.CompareAddressRegistration(employee, testEmployee));
         
        }

      



  
    }
}
