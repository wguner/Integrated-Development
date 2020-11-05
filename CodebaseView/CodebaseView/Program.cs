using System;
using System.Collections.Generic;
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
            Application.Run(new Form1());

            GitParser parser = new GitParser();

            if (parser.doUpdate("this is where the database commit will go"))
            {
                string statement = SQL.createInsertStatement();
                SQL.execute(statement);
            }
        }
    }
}
