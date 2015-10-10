using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepTeamAutotests.Model
{
    public class Vacancy
    {
        public string VacName { get; set; }
        public string VacDepartment { get; set; }
        //public string VacJobType { get; set; }
        public string VacFilial { get; set; }
        public string VacEmployees { get; set; }
       // public string VacLink { get; set; }
        public string VacResponsibilities { get; set; }
        public string VacConditions { get; set; }
        public string VacRequirements { get; set; }
        public string VacFile { get; set; }
        public string VacFileDescription { get; set; }
        public string VacStatus { get; set; }

        public override string ToString()
        {
            return "Название = " + VacName;
        }

        public void WriteToConsole()
        {
            Console.Out.WriteLine("=============================== Параметры вакансии ===============================");
            Console.Out.WriteLine("VacName  =                                                          " + VacName);
            Console.Out.WriteLine("VacDepartment  =                                                    " + VacDepartment);
           // Console.Out.WriteLine("VacJobType  =                                                       " + VacJobType);
            Console.Out.WriteLine("VacFilial =                                                         " + VacFilial);
            Console.Out.WriteLine("VacEmployees  =                                                     " + VacEmployees);
           
            Console.Out.WriteLine("VacRequirements =                                                   " + VacRequirements);
            Console.Out.WriteLine("VacConditions =                                                     " + VacConditions);
            Console.Out.WriteLine("VacResponsibilities =                                               " + VacResponsibilities);
            Console.Out.WriteLine("VacFile  =                                                          " + VacFile);
            Console.Out.WriteLine("VacFileDescription =                                                " + VacFileDescription);
            Console.Out.WriteLine("VacStatus =                                                         " + VacStatus);


        }
       
    }
}
