using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepTeamAutotests.Model
{
    public class Asset
    {
        public string ASName { get; set; }
        public string ASCategory { get; set; }
        public string ASID { get; set; }
        public string ASDate { get; set; }
        public string ASEmployee { get; set; }
        public string ASDescription { get; set; }
        public string TONumber { get; set; }

        public override string ToString()
        {
            return "Категория = " + ASCategory + ", Название = " + ASName;
        }

        public void WriteToConsole()
        {
            Console.Out.WriteLine("=============================== Параметры инвентаря ===============================");
            Console.Out.WriteLine("ASName  =                                                           " + ASName);
            Console.Out.WriteLine("ASCategory  =                                                       " + ASCategory);
            Console.Out.WriteLine("ASID  =                                                             " + ASID);
            Console.Out.WriteLine("ASDate =                                                            " + ASDate);
            Console.Out.WriteLine("ASEmployee  =                                                       " + ASEmployee);
            Console.Out.WriteLine("ASDescription =                                                     " + ASDescription);

        }
    }
}
