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
    public class FilterEmployeesTests : InternalPageTests
    {
       [SetUp]
        public void Login()
        {
           app.userHelper
               .loginAs(app.userHelper.getUserByRole("Filters"));
          // app.userHelper.setAllFilters(); 
         
        }
        [Ignore]
        // статус работает
        [Test()]
        public void Filter_Work_Employees()
        {
            //Установка значения фильтра
            app.filterHelper.setCheckBoxFilter("Работает", "Работает", "Любой статус");
            //Проверка  результата
            Employee testEmployee = app.employeeHelper.getEmployeefromTable();
            
            //Проверка статуса найденных пользователей.

           // Assert.IsTrue(app.employeeHelper.CompareStatus("Работает", testEmployee.status));
            Assert.AreEqual("Работает", testEmployee.status);
        }
        [Ignore]
        [Test()]
        //Фильтр по подразделению
        public void Filter_Department_Employees()
        {
            //Установка значения фильтра
            app.filterHelper.setCheckBoxFilter("Все подразделения", "Keepteam", "Все подразделения");
            //Проверка  результата
            Employee testEmployee = app.employeeHelper.getEmployeefromTable();
            Assert.AreEqual("Keepteam", testEmployee.department);
        }
     
        [Ignore]// надо решить как добавить фильтры, которых нету
        [Test, TestCaseSource(typeof(FileHelper), "maritalstatusfilter")]
        public void Maritalstatus_Employees_Filter(Filter maritalstatusfilter)
        {
            //Установка значения фильтра
            app.filterHelper.setCheckBoxFilter(0,maritalstatusfilter.CurrentText, maritalstatusfilter.ClearText);
            //Проверка  результата
            Employee testEmployee = app.employeeHelper.getEmployeefromTable();

            //Проверка статуса найденных пользователей.

            // Assert.IsTrue(app.employeeHelper.CompareStatus("Работает", testEmployee.status));
            Assert.AreEqual(maritalstatusfilter.CurrentText, testEmployee.maritalstatus);
        }
        [Ignore]
        [Test, TestCaseSource(typeof(FileHelper), "departmentfilter")]
        public void Department_Employees_Filter(Filter departmentfilter)
        {
            //Установка значения фильтра
            app.filterHelper.setCheckBoxFilter(0,departmentfilter.CurrentText, departmentfilter.ClearText);
            //Проверка  результата
            Employee testEmployee = app.employeeHelper.getEmployeefromTable();

            //Проверка статуса найденных пользователей.

            // Assert.IsTrue(app.employeeHelper.CompareStatus("Работает", testEmployee.status));
            Assert.AreEqual(departmentfilter.CurrentText, testEmployee.department);
        }
        [TearDown]
        public void ClearFilters()
        {
            //Нажатие на кнопку Сбросить после того как тесты завершены
            app.filterHelper.ClearFilters();
        }
        
       

       

     
    }
}
