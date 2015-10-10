using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepTeamAutotests.Model
{
    public class Email
    {
        public string login { get; set; }
        public string password { get; set; }
        public string port { get; set; }
        public string protocol { get; set; }
        
        public override string ToString()
        {
            return "адрес = " + login + ", порт = " + port;
        }

        public void WriteToConsole()
        {
            Console.Out.WriteLine("=============================== Параметры email ===============================");
            Console.Out.WriteLine("login  =                                                           " + login);
            Console.Out.WriteLine("password  =                                                       " + password);
            Console.Out.WriteLine("port  =                                                             " + port);
            Console.Out.WriteLine("protocol =                                                            " + protocol);
            

        }
    }
}
