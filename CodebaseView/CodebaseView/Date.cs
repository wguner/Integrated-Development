using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
namespace CodebaseView
{
    public class Date
    {
        public string commit_id { get; set; }
        public string month { get; set; }
        public string day { get; set; }
        public string year { get; set; }
        Dictionary<string, string> conditions = new Dictionary<string, string>();
        /*
        public string createDate(string commitID)
        {
            conditions.Add("date.commit_id", commitID);
            SELECTQueryBuilder qe = new SELECTQueryBuilder();
            return qe.build(commitID);
        }*/
    }
}
