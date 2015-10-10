using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepTeamAutotests.Model
{
    public class TimeOff
    {
        public string TOtype { get; set; }
        public string TOstartDate { get; set; }
        public string TOendDate { get; set; }
        public string TODescription { get; set; }
        public string TODependsOn { get; set; }
        public string TOReason { get; set; }
        public string TONumber { get; set; }

        public override string ToString()
        {
            return "Тип = " + TOtype + ", Примечание" + TODescription;
        }

        public void WriteToConsole()
        {
            Console.Out.WriteLine("=============================== Параметры отпуска ===============================");
            Console.Out.WriteLine("TOtype  =                                                           " + TOtype);
            Console.Out.WriteLine("TOstartDate =                                                       " + TOstartDate);
            Console.Out.WriteLine("TOendDate  =                                                        " + TOendDate);
            Console.Out.WriteLine("TODescription =                                                     " + TODescription);
            Console.Out.WriteLine("TODependsOn  =                                                      " + TODependsOn);
            Console.Out.WriteLine("TOReason =                                                          " + TOReason);
            Console.Out.WriteLine("TONumber  =                                                         " + TONumber);

        }
    }
}
