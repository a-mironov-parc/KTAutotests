using KeepTeamAutotests.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace KeepTeamAutotests.AppLogic
{
    public class AppManager
    {
        private string ImageStorage = "..\\img\\FireFox\\33.03\\";


        public AppManager(ICapabilities capabilities, string baseUrl, string hubUrl)
        {
            Pages = new PageManager(capabilities, baseUrl, hubUrl);
            
            userHelper = new UserHelper(this);
            employeeHelper = new EmployeeHelper(this);
            timeoffHelper = new TimeOffHelper(this);
            imageHelper = new ImageHelper(this);
            screenHelper = new ScreenHelper(this);
            assetHelper = new AssetHelper(this);
            filterHelper = new FilterHelper(this);
            hiringHelper = new HiringHelper(this);
            emailHeper = new EmailHelper(this);
            kpiHelper = new KPIHelper(this);
            hintHelper = new HintHelper(this);
            commentHelper = new CommentHelper(this);
            
        }

        public UserHelper userHelper { get; set; }
        public CommentHelper commentHelper { get; set; }
        public EmployeeHelper employeeHelper {get; set; }
        public TimeOffHelper timeoffHelper {get; set; }

        public ImageHelper imageHelper{get; set;}
        public ScreenHelper screenHelper { get; set; }
        public AssetHelper assetHelper { get; set; }
        public FileHelper fileHelper { get; set; }
        public FilterHelper filterHelper { get; set; }
        public HiringHelper hiringHelper { get; set; }
        public EmailHelper emailHeper { get; set; }
        public KPIHelper kpiHelper { get; set; }
        public HintHelper hintHelper { get; set; }
        public PageManager Pages { get; set; }

              
        
       /*
        public void TakeScreenshot(string saveLocation)
        {
            ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
            Screenshot screenshot = screenshotDriver.GetScreenshot();
            screenshot.SaveAsFile(saveLocation, ImageFormat.Png);
        }

        public void TakeScreenshot(IWebElement element, string saveLocation)
        {
            ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
            Screenshot screenshot = screenshotDriver.GetScreenshot();
            screenshot.SaveAsFile(saveLocation, ImageFormat.Png);
        }
        */

        public string getImageStorage()
        {
            return ImageStorage;
        }

      
    }
}
