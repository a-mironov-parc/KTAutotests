﻿using System;
using NUnit.Framework;
using KeepTeamAutotests.AppLogic;

namespace KeepTeamTests
{
    [SetUpFixture()]
    public class Finalizer
    {
        [TearDown]
        public void RunInTheEndOfAll()
        {
            WebDriverFactory.DismissAll();
        }
    }
}
