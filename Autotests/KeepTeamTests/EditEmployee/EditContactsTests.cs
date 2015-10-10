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
    public class EditContactsTests : InternalPageTests
    {
        [SetUp]
        public void Login()
        {
            app.userHelper
                .loginAs(app.userHelper.getUserByRole("pContactsRW"));

        }


        [Test, TestCaseSource(typeof(FileHelper), "contacts")]

        public void Edit_Contacts(Employee employee)
        {
            app.employeeHelper.clearContacts();
            //Редактирование 
            app.employeeHelper.editContacts(employee);

            //создание тестового юзера для сравнения
            Employee testEmployee = app.employeeHelper.getContacts();

            //Проверка соответствия двух пользователей.

            Assert.IsTrue(app.employeeHelper.CompareContacts(employee, testEmployee));


        }

        [Test, TestCaseSource(typeof(FileHelper), "contactsreq")]
        public void Edit_Employee_Contacts_Validation(Employee invalidEmployee)
        {
            //Очистка основной информации
            app.employeeHelper.clearContacts();
            //Редактирование 
            app.employeeHelper.editContacts(invalidEmployee);
            //проверка текста валидации
            Assert.AreEqual(app.userHelper.EMPTYINPUTMSG, app.userHelper.getValidationMessage());

        }
        [Test()]
        public void Edit_Employee_Contacts_Validation_Sudjest()
        {
            //Очистка основной информации
            app.employeeHelper.clearContacts();
            Employee test = new Employee();
            test.conType = "abrakadabra";
            //Редактирование 
            app.employeeHelper.editContacts(test);
            //проверка текста валидации
            Assert.AreEqual(app.userHelper.EMPTYSUDJESTMSG, app.userHelper.getValidationMessage());

        }






    }
}
