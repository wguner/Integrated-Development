using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodebaseView
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form = new Form1();
            

            SQL sql = new SQL(form);

            GitParser parser = new GitParser();
            parser.init();

            if (parser.doUpdate("pass in most recent database commit"))
            {
                // update database
                string statement = "the update database statement built by an insert statement builder";
                sql.execute(statement);
            }

            form.output.Text = doQuery(sql);
            Application.Run(form);
        }

        public static string doQuery(SQL sql)
        {
            // query database and update selection
            return sql.execute(new SELECTQueryBuilder().setColumns("commit_id", "name").setTables("commits").build());
        }
    }
}
