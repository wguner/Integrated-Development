using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace CodebaseView
{
    public struct Commit
    {
        public string commit_id { get; set; }
        public string email { get; set; }
        public string author { get; set; }
        public string message { get; set; }
        public string month { get; set; }
        public string day { get; set; }
        public string year { get; set; }
        public string time { get; set; }

    }
}
