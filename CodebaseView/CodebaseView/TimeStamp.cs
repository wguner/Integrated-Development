using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodebaseView
{
    public struct TimeStamp
    {
        public string month { get; set; }
        public string year { get; set; }
        public string day { get; set; }
        public string time { get; set; }
    
        public TimeStamp(string dateTime)
        {
            this.month = dateTime.Substring(0, 3);
            this.year = dateTime.Substring(18, 4);
            this.day = dateTime.Substring(4, 2);
            this.time = dateTime.Substring(8, 8);
        }

        public string toString()
        {
            return "TO_TIMESTAMP(" + year + "-" + month + "-" + day + "-" + time + 
                ", 'YYYY-MM-DD HH24:MI:SS')";
        }
    }
}
