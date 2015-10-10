using System;
using KeepTeamAutotests;
using KeepTeamAutotests.Model;
using NUnit.Framework;
using KeepTeamAutotests.AppLogic;

namespace KeepTeamTests
{
    [TestFixture()]
    public class PersonalPopupScreenTests : InternalPageTests
    {

        [SetUp]
        public void Login()
        {
            app.userHelper
                .loginAs(app.userHelper.getUserByRole("Администраторы"));

        }
      
        [Test()]
        public void Compare_Image_DeleteUser()
        {
            //клик по кнопке добавления
            app.userHelper.clickAddButton();

            Employee employee = new Employee();
            employee.lastname = "Попап";
            employee.name = "Удаления";
            //Добавление пользователя
            app.employeeHelper.createEmployee(employee);

            //клик по кнопке удалить карточку сотрудника
            app.employeeHelper.openPersonalPopup("Удалить карточку сотрудника");
            
            //Проверка скриншота удалить карточку сотрудника
            Assert.IsTrue(app.screenHelper.DeleteEmployeePopupScreen());

        }
        [Test()]
        public void Compare_Image_OffUser()
        {
            //клик по кнопке добавления
            app.userHelper.clickAddButton();

            Employee employee = new Employee();
            employee.lastname = "Попап";
            employee.name = "Увольнения";
            //Добавление пользователя
            app.employeeHelper.createEmployee(employee);

            //клик по кнопке удалить карточку сотрудника
            app.employeeHelper.openPersonalPopup("Уволить сотрудника");
            //Проверка скриншота удалить карточку сотрудника
            Assert.IsTrue(app.screenHelper.OffEmployeePopupScreen());
            

        }
        [TearDown]
        public void DeleteCurrentEmployee()
        {
            app.userHelper.closePopup();
            app.employeeHelper.DeleteCurrentEmployee();

        }

      

    }
}
