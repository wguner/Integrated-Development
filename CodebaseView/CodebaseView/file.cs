using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
namespace CodebaseView
{
    public class file
    {
        public string commit_id { get; set; }
        public string filename { get; set; }
        public string file_extension { get; set; }

        Dictionary<string, string> conditions = new Dictionary<string, string>();

        /*
        public string createFile(string commitID)
        {
            conditions.Add("file.commit_id", commitID);
            SELECTQueryBuilder qe = new SELECTQueryBuilder();
            return qe.build(commitID);
        }*/
     }
}
