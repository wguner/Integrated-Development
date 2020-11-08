using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodebaseView
{
    public class SQL
    {
        private Form1 form;

        public SQL(Form1 form)
        {
            this.form = form;
        }
        public string execute(string statement)
        {
            return statement;
        }
    }
 
}
