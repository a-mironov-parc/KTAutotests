using KeepTeamAutotests.Model;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageMagick;
using KeepTeamAutotests.Pages;
using Newtonsoft.Json;
using System.IO;

namespace KeepTeamAutotests.AppLogic
{
    public class FileHelper
    {
        //private AppManager app;
        //private PageManager pages;
        public FileHelper(AppManager app)
            
        {
           /* this.app = app;
            this.pages = app.Pages;*/
        }

        

        public static IEnumerable<Employee> addressregistration()
        {
            return JsonConvert.DeserializeObject<List<Employee>>(
                File.ReadAllText(@"data\personalinfo\addressregistration.json"));
        }

        public static IEnumerable<Employee> documents()
        {
            return JsonConvert.DeserializeObject<List<Employee>>(
                File.ReadAllText(@"data\personalinfo\documents.json"));
        }
        public static IEnumerable<User> user()
        {
            return JsonConvert.DeserializeObject<List<User>>(
                File.ReadAllText(@"data\user.json"));
        }
        public static IEnumerable<User> loginincorrect()
        {
            return JsonConvert.DeserializeObject<List<User>>(
                File.ReadAllText(@"data\login\loginincorrect.json"));
        }
        public static IEnumerable<User> logincorrect()
        {
            return JsonConvert.DeserializeObject<List<User>>(
                File.ReadAllText(@"data\login\logincorrect.json"));
        }
        
        public static IEnumerable<Employee> employee()
        {
            return JsonConvert.DeserializeObject<List<Employee>>(
                File.ReadAllText(@"data\employee.json"));
        }
        public static IEnumerable<Employee> employeereq()
        {
            return JsonConvert.DeserializeObject<List<Employee>>(
                File.ReadAllText(@"data\employeereq.json"));
        }

        public static IEnumerable<Employee> relatives()
        {
            return JsonConvert.DeserializeObject<List<Employee>>(
                File.ReadAllText(@"data\personalinfo\relatives.json"));
        }
        public static IEnumerable<Employee> relativesreq()
        {
            return JsonConvert.DeserializeObject<List<Employee>>(
                File.ReadAllText(@"data\personalinfo\relativesreq.json"));
        }
        public static IEnumerable<Employee> contacts()
        {
            return JsonConvert.DeserializeObject<List<Employee>>(
                File.ReadAllText(@"data\personalinfo\contacts.json"));
        }
        public static IEnumerable<Employee> contactsreq()
        {
            return JsonConvert.DeserializeObject<List<Employee>>(
                File.ReadAllText(@"data\personalinfo\contactsreq.json"));
        }

        public static IEnumerable<Employee> education()
        {
            return JsonConvert.DeserializeObject<List<Employee>>(
                File.ReadAllText(@"data\personalinfo\education.json"));
        }
        public static IEnumerable<Employee> skill()
        {
            return JsonConvert.DeserializeObject<List<Employee>>(
                File.ReadAllText(@"data\personalinfo\skills.json"));
        }

        public static IEnumerable<Menu> menu()
        {
            return JsonConvert.DeserializeObject<List<Menu>>(
                File.ReadAllText(@"data\menu\menu.json"));
        }

        public static IEnumerable<Menu> settingmenu()
        {
            return JsonConvert.DeserializeObject<List<Menu>>(
                File.ReadAllText(@"data\menu\settingmenu.json"));
        }
        public static IEnumerable<Menu> internalmenu()
        {
            return JsonConvert.DeserializeObject<List<Menu>>(
                File.ReadAllText(@"data\menu\internalmenu.json"));
        }
        public static IEnumerable<TimeOff> timeoffs()
        {
            return JsonConvert.DeserializeObject<List<TimeOff>>(
                File.ReadAllText(@"data\timeoffs.json"));
        }
        public static IEnumerable<Asset> assets()
        {
            return JsonConvert.DeserializeObject<List<Asset>>(
                File.ReadAllText(@"data\assets.json"));
        }
        public static IEnumerable<Filter> workfilter()
        {
            return JsonConvert.DeserializeObject<List<Filter>>(
                File.ReadAllText(@"data\filters\workfilter.json"));
        }
        public static IEnumerable<Filter> maritalstatusfilter()
        {
            return JsonConvert.DeserializeObject<List<Filter>>(
                File.ReadAllText(@"data\filters\maritalstatusfilter.json"));
        }
        public static IEnumerable<Filter> departmentfilter()
        {
            return JsonConvert.DeserializeObject<List<Filter>>(
                File.ReadAllText(@"data\filters\departmentfilter.json"));
        }
        public static IEnumerable<SimpleString> documenttype()
        {
            return JsonConvert.DeserializeObject<List<SimpleString>>(
                File.ReadAllText(@"data\personalinfo\documentstype.json"));
        }
        public static IEnumerable<SimpleString> timeofftype()
        {
            return JsonConvert.DeserializeObject<List<SimpleString>>(
                File.ReadAllText(@"data\timeofftype.json"));
        }
        public static IEnumerable<SimpleString> workhistorytype()
        {
            return JsonConvert.DeserializeObject<List<SimpleString>>(
                File.ReadAllText(@"data\workinfo\workhistorytype.json"));
        }
        public static List<string> dictionaries()
        {
            return JsonConvert.DeserializeObject<List<string>>(
                File.ReadAllText(@"data\dictionaries\dictionaries.json"));
        }
        public static IEnumerable<Vacancy> vacancies()
        {
            return JsonConvert.DeserializeObject<List<Vacancy>>(
                File.ReadAllText(@"data\vacancy.json"));
        }
        public static IEnumerable<Candidate> candidates()
        {
            return JsonConvert.DeserializeObject<List<Candidate>>(
                File.ReadAllText(@"data\candidates\candidate.json"));
        }
        public static IEnumerable<Candidate> candidatesreq()
        {
            return JsonConvert.DeserializeObject<List<Candidate>>(
                File.ReadAllText(@"data\candidates\candidatereq.json"));
        }
        public static IEnumerable<Email> emails()
        {
            return JsonConvert.DeserializeObject<List<Email>>(
                File.ReadAllText(@"data\emails.json"));
        }
        public static IEnumerable<KPI> kpi()
        {
            return JsonConvert.DeserializeObject<List<KPI>>(
                File.ReadAllText(@"data\kpi.json"));
        }
        public static IEnumerable<SimpleString> candidatesDirectories()
        {
            return JsonConvert.DeserializeObject<List<SimpleString>>(
               File.ReadAllText(@"data\candidates\directoriesname.json"));
            
        }
        public static IEnumerable<Hint> hints()
        {
            return JsonConvert.DeserializeObject<List<Hint>>(
               File.ReadAllText(@"data\hints.json"));

        }
        public static IEnumerable<Comment> comments()
        {
            return JsonConvert.DeserializeObject<List<Comment>>(
               File.ReadAllText(@"data\comments.json"));

        }
        
        
 
    }
}
