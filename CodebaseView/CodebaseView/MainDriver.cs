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


            GitStringParser parser = new GitStringParser();
            parser.init();
            parser.updateDatabase();


           
            CodebaseView form = new CodebaseView();
            Application.Run(form);
        }
    }
}
