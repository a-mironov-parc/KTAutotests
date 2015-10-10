using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepTeamAutotests.Model
{
    public class Menu
    {

        public string MenuName { get; set; }
        public string URL { get; set; }

        public override string ToString()
        {
            return "MenuName="+MenuName+", URL="+ URL;
        }
        
     
      

    }
}
