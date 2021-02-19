using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace CodebaseView
{
    public class Author
    {
        public string name { get; set; }
        public string email { get; set; }

        Dictionary<String, String> conditions = new Dictionary<string, string>();
        /*
        public string createAuthor(string name)
        {
            conditions.Add("author.name", name);
            SELECTQueryBuilder qe = new SELECTQueryBuilder();
            return qe.build(name);
        }*/
    }
}
