using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepTeamAutotests.Model
{
    public class KPI
    {
        public string KPIName { get; set; }
        public string KPIDate { get; set; }
        public string KPIEmployee { get; set; }
        public string KPIDescription { get; set; }
        public int KPIProgress { get; set; }
        public string KPIMeasuring { get; set; }
        public string KPIActions { get; set; }
        public override string ToString()
        {
            return "Название = " + KPIName + ", Дата = " + KPIDate;
        }

        public void WriteToConsole()
        {
            Console.Out.WriteLine("=============================== Параметры KPI ===============================");
            Console.Out.WriteLine("KPIName  =                                                           " + KPIName);
            Console.Out.WriteLine("KPIDate  =                                                           " + KPIDate);
            Console.Out.WriteLine("KPIEmployee  =                                                       " + KPIEmployee);
            Console.Out.WriteLine("KPIDescription =                                                     " + KPIDescription);
            Console.Out.WriteLine("KPIProgress  =                                                       " + KPIProgress);
            Console.Out.WriteLine("KPIMeasuring =                                                       " + KPIMeasuring);
            Console.Out.WriteLine("KPIActions =                                                         " + KPIActions);


        }
    }
}
