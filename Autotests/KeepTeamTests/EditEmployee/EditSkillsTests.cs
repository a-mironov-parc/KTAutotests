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
    public class EditSkillsTests : InternalPageTests
    {
       [SetUp]
        public void Login()
        {
                 app.userHelper
                     .loginAs(app.userHelper.getUserByRole("pSkillsRW"));
         
        }


        [Test, TestCaseSource(typeof(FileHelper), "skill")]
         // пока не исправлена бага
        public void Edit_Skills(Employee employee)
        {
            app.employeeHelper.clearSkills();
            //Редактирование 
            app.employeeHelper.editSkills(employee);

            //создание тестового юзера для сравнения
            Employee testEmployee = app.employeeHelper.getSkills();

            //Проверка соответствия двух пользователей.

            Assert.IsTrue(app.employeeHelper.CompareSkills(employee, testEmployee));
         
        }

        [Test()]
        public void Edit_Employee_Skills_Validation()
        {
            //Очистка основной информации
            app.employeeHelper.clearSkills();
            Employee invalidEmployee = new Employee();
            invalidEmployee.skillDescription = "abrakadabra";
            //Редактирование 
            app.employeeHelper.editSkills(invalidEmployee);
            //проверка текста валидации
            Assert.AreEqual(app.userHelper.EMPTYINPUTMSG, app.userHelper.getValidationMessage());

        }
       

      



  
    }
}
