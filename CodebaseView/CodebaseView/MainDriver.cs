using System;
using System.Data;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace CodebaseView
{
    static class MainDriver
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            
            

            GitParser parser = new GitParser();
            parser.init();

            string mostRecentCommitID = SQL.getMostRecentCommitID();
            if (parser.doUpdate(mostRecentCommitID))
            {
                parser.updateDatabase(mostRecentCommitID);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CodebaseView form = new CodebaseView();
            Application.Run(form);
        }
    }
}
