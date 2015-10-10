using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepTeamAutotests.Model
{
    public class User
    {
      
        public string login {get;set;}
        public string password { get; set; }
        public string role { get; set; }
        public string email { get; set; }

        public override string ToString()
        {
            return "login= " + login + " роль= " + role + ", password= " + password + ", email= " + email;
        }




    }
}
