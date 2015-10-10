using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepTeamAutotests.Model
{
    public class Hint
    {
        public string id { get; set; }
        public string subject { get; set; }
        public string message { get; set; }
        
        public override string ToString()
        {
            return "id = " + id + ", заголовок = " + subject;
        }

        public void WriteToConsole()
        {
            Console.Out.WriteLine("=============================== Параметры подсказки ===============================");
            Console.Out.WriteLine("id  =                                                           " + id);
            Console.Out.WriteLine("subject  =                                                      " + subject);
            Console.Out.WriteLine("message  =                                                      " + message);
            
        }
    }
}
