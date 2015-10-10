using KeepTeamAutotests.Model;
using KeepTeamAutotests.Pages;
using Newtonsoft.Json;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KeepTeamAutotests.AppLogic
{
    public class HintHelper
    {
        private AppManager app;
        private PageManager pages;
        public HintHelper(AppManager app)
            
        {
            this.app = app;
            this.pages = app.Pages;
            
        }



        public void moveToHint(string id)
        {
            pages.employeesPage.moveToHint(id);
            
        }

        public Hint getHint(string id)
        {
            return pages.employeesPage.getHint(id);
        }

      
        public bool CompareHints(Hint H1, Hint H2)
        {
            H1.WriteToConsole();
            H2.WriteToConsole();
            return H1.id == H2.id &&
                H1.subject == H2.subject &&
                H1.message == H2.message;

        }
    }
}
