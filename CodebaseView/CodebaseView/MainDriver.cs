using System;
using System.Windows.Forms;

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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            GitParser parser = new GitParser();
            parser.init();

            string mostRecentCommitID = SQL.getMostRecentCommitID();
            if (parser.doUpdate(mostRecentCommitID))
            {
                parser.updateDatabase(mostRecentCommitID);
            }

           
            CodebaseView form = new CodebaseView();
            Application.Run(form);
        }
    }
}
