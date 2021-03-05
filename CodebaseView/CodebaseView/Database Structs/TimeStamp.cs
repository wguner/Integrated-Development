using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodebaseView
{
    public class TimeStamp
    {
        public string month { get; set; }
        public string year { get; set; }
        public string day { get; set; }
        public string time { get; set; }
    
        public TimeStamp()
        {
            
        }

        public TimeStamp(string year, string month, string day, string time)
        {
            if (time.StartsWith("{") && time.EndsWith("}"))
            {
                this.year = year;
                this.month = month;
                this.day = day;
                this.time = time.Substring(1, 8);
            }
            else
            {
                this.year = year;
                this.month = month;
                this.day = day;
                this.time = time;
            }
            
        }

        

        public override string ToString()
        {
            return year + "-" + month + "-" + day + " " + time;
        }

        public static TimeStamp parseSQLTimeStamp(string dateTime)
        {
            TimeStamp timeStamp = new TimeStamp();
            if (dateTime.EndsWith("-"))
            {
                timeStamp.month = dateTime.Substring(0, 3);
                timeStamp.year = dateTime.Substring(15, 4);
                timeStamp.day = dateTime.Substring(4, 1);
                timeStamp.time = dateTime.Substring(6, 8);
            }
            else
            {
                timeStamp.month = dateTime.Substring(0, 3);
                timeStamp.year = dateTime.Substring(16, 4);
                timeStamp.day = dateTime.Substring(4, 2);
                timeStamp.time = dateTime.Substring(7, 8);
            }
            return timeStamp;
        }

        public static TimeStamp parseWinFormsTimeStamp(string dateTime)
        {
            TimeStamp timeStamp = new TimeStamp();
            
            return timeStamp;
        }
    }
}
