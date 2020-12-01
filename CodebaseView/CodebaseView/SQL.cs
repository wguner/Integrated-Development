using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodebaseView
{
    public class SQL
    {
        private CodebaseView form;

        public SQL(CodebaseView form)
        {
            this.form = form;
        }

        // needs to return information somehow
        public string execute(string statement)
        {
            return statement;
        }
    }
 
}
