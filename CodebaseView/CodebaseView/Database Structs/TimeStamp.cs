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
            if (dateTime.EndsWith("-"))
            {
                this.month = dateTime.Substring(0, 3);
                this.year = dateTime.Substring(15, 4);
                this.day = dateTime.Substring(4, 1);
                this.time = dateTime.Substring(6, 8);
            }
            else
            {
                this.month = dateTime.Substring(0, 3);
                this.year = dateTime.Substring(16, 4);
                this.day = dateTime.Substring(4, 2);
                this.time = dateTime.Substring(7, 8);
            }
        }

        public override string ToString()
        {
            return "TO_TIMESTAMP('" + year + "-" + month + "-" + day + " " + time + 
                "', 'YYYY-MON-DD HH24:MI:SS')";
        }
    }
}
