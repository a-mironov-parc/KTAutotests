using System;
using KeepTeamAutotests;
using KeepTeamAutotests.Model;
using NUnit.Framework;
using KeepTeamAutotests.AppLogic;

namespace KeepTeamTests
{
    [TestFixture()]
    public class ImagePopupTests : InternalPageTests
    {

        [TearDown]
        public void close_popup()
        {
            app.userHelper.closePopup();
        }
      

    }
}
