using System;
using KeepTeamAutotests;
using KeepTeamAutotests.Model;
using KeepTeamAutotests.AppLogic;
using NUnit.Framework;

namespace KeepTeamTests
{
    [TestFixture()]
    public class CalendarTimeOffsTests : InternalPageTests
    {

        [SetUp]
        public void Login()
        {
            app.userHelper
                .loginAs(app.userHelper.getUserByRole("aTimeOffsRW"));

        }

        [Test()]
        public void Compare_Image_Calendar_Vacation()
        {
            //переход по url к периоду отпусков для сравнения
            app.timeoffHelper.goToCalendarFromURL("/#/time_offs/list?mode=calendar&Date.Start=2014-01-01&Date.End=2014-03-31");
            //клик по кнопке добавления
            Assert.IsTrue(app.screenHelper.CalendarScreen("Отпуск"));
            
        }
        [Test()]
        public void Compare_Image_Calendar_Sick()
        {
            //переход по url к периоду отпусков для сравнения
            app.timeoffHelper.goToCalendarFromURL("/#/time_offs/list?mode=calendar&Date.Start=2003-01-01&Date.End=2003-03-31");
            //клик по кнопке добавления
            Assert.IsTrue(app.screenHelper.CalendarScreen("Больничный"));

        }
        [Test()]
        public void Compare_Image_Calendar_Compensotary()
        {
            //переход по url к периоду отпусков для сравнения
            app.timeoffHelper.goToCalendarFromURL("/#/time_offs/list?mode=calendar&Date.Start=2001-01-01&Date.End=2001-03-31");
            //клик по кнопке добавления
            Assert.IsTrue(app.screenHelper.CalendarScreen("Отпуск за свой счет"));

        }
        [Test()]
        public void Compare_Image_Calendar_CustomType()
        {
            //переход по url к периоду отпусков для сравнения
            app.timeoffHelper.goToCalendarFromURL("/#/time_offs/list?mode=calendar&Date.Start=2000-01-01&Date.End=2000-03-31");
            //клик по кнопке добавления
            Assert.IsTrue(app.screenHelper.CalendarScreen("Настраиваемый тип"));

        }
        [Test()]
        public void Compare_Image_Calendar_CustomType_small()
        {
            //переход по url к периоду отпусков для сравнения
            app.timeoffHelper.goToCalendarFromURL("/#/time_offs/list?mode=calendar&Date.Start=2002-01-01&Date.End=2002-03-31");
            //клик по кнопке добавления
            Assert.IsTrue(app.screenHelper.CalendarScreen("Настраиваемый короткий тип"));

        }


    }
}
