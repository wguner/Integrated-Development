using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace CodebaseView
{
    public class Commit
    {
        public string commit_id { get; set; }
        public string email { get; set; }
        public string author { get; set; }
        public string message { get; set; }
        Dictionary<string, string> condition = new Dictionary<string, string>();

        /*
        public string createCommit(string commitID)
        {
            condition.Add("commit.commit_id", commitID);
            SELECTQueryBuilder qe = new SELECTQueryBuilder();
            return qe.build(commitID);
        }*/
    }
}
