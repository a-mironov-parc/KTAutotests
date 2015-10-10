using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepTeamAutotests.Model
{
    public class Filter
    {

        public string DefaultText { get; set; }
        public string CurrentText { get; set; }
        public string ClearText { get; set; }
        
        public override string ToString()
        {
            return "CurrentText =  "+ CurrentText +" DefaultText + "  + DefaultText;
        }
        
      

    }
}
