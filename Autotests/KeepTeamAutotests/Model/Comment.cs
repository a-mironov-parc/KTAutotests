using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepTeamAutotests.Model
{
    public class Comment
    {
        public string id { get; set; }
        public string author { get; set; }
        public string message { get; set; }
        
        public override string ToString()
        {
            return "id = " + id + ", заголовок = " + message;
        }

        public void WriteToConsole()
        {
            Console.Out.WriteLine("=============================== Параметры комментариев ===============================");
            Console.Out.WriteLine("id  =                                                           " + id);
            Console.Out.WriteLine("author  =                                                      " + author);
            Console.Out.WriteLine("message  =                                                      " + message);
            
        }
    }
}
