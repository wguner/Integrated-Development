using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodebaseView
{
    static class MainDriver
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CodebaseView form = new CodebaseView();
            

            SQL sql = new SQL(form);

            GitParser parser = new GitParser();
            parser.init();

            if (parser.doUpdate(getMostRecentCommit(sql)))
            {
                // update database
                
                foreach (string commitID in parser.getCommitIDs())
                {
                    if (!parser.doUpdate(commitID)) break;
                    INSERTQueryBuilder insertQueryBuilder = new INSERTQueryBuilder().setTable("commit");
                    insertQueryBuilder.addColumnValue("commitID", "1234");
                    sql.execute(insertQueryBuilder.build());
                }

                
            }

            //form.output.Text = doQuery(sql);
            Application.Run(form);
        }

        public static string doQuery(SQL sql)
        {
            // query database and update selection
            return sql.execute(new SELECTQueryBuilder().setColumns("commit_id", "name").setTables("commits").build());
        }

        public static string getMostRecentCommit(SQL sql)
        {
            return sql.execute(new SELECTQueryBuilder().setColumns("commitID", "MAX(date)").setTables("commit").setGroupBy("date").build());
        }
    }
}
