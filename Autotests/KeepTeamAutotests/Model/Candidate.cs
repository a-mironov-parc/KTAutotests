using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepTeamAutotests.Model
{
    public class Candidate
    {
        public string CanVacancy { get; set; }
        public string CanStatus { get; set; }
        public string CanLastName { get; set; }
        public string CanName { get; set; }
        public string CanPatronimyc { get; set; }
        public string CanDateBirhtday { get; set; }
        public string CanSex { get; set; }
        public string CanPayment { get; set; }
        public string CanCity { get; set; }
        public bool CanTrip { get; set; }
        public bool CanMove { get; set; }
        public int CanSkill { get; set; }
        public string CanDescription { get; set; }
        public string CanTypeOfContact { get; set; }
        public string CanContact { get; set; }
        public string CanFile { get; set; }
        public string CanFileDescription { get; set; }

        public override string ToString()
        {
            return "Фамилия = " + CanLastName + "Имя = " + CanName;
        }

        public void WriteToConsole(string id)
        {
        
            Console.Out.WriteLine("=============================== "+id+" ===============================");
            Console.Out.WriteLine("CanStatus   =                                                       " + CanStatus );
            Console.Out.WriteLine("CanVacancy   =                                                      " + CanVacancy );
            Console.Out.WriteLine("CanLastName   =                                                     " + CanLastName );
            Console.Out.WriteLine("CanName =                                                           " + CanName);
            Console.Out.WriteLine("CanPatronimyc   =                                                   " + CanPatronimyc);
            Console.Out.WriteLine("CanDateBirhtday  =                                                  " + CanDateBirhtday );
            Console.Out.WriteLine("CanSex  =                                                           " + CanSex );
            Console.Out.WriteLine("CanPayment  =                                                       " + CanPayment );
            Console.Out.WriteLine("CanCity   =                                                         " + CanCity );
            Console.Out.WriteLine("CanTrip   =                                                         " + CanTrip );
            Console.Out.WriteLine("CanMove    =                                                        " + CanMove  );
            Console.Out.WriteLine("CanSkill  =                                                         " + CanSkill );
            Console.Out.WriteLine("CanDescription   =                                                  " + CanDescription );
            Console.Out.WriteLine("CanContact   =                                                      " + CanContact);
            Console.Out.WriteLine("CanTypeOfContact   =                                                " + CanTypeOfContact);
            Console.Out.WriteLine("CanFile  =                                                          " + CanFile );
            Console.Out.WriteLine("CanFileDescription   =                                              " + CanFileDescription);

        }
       
    }
}
