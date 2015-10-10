﻿using System;
using NUnit.Framework;
using KeepTeamAutotests.AppLogic;

namespace KeepTeamTests
{
    [SetUpFixture]
    public class Finalizer
    {
        [OneTimeTearDown]
        public void RunInTheEndOfAll()
        {
            WebDriverFactory.DismissAll();
        }
    }
}
