using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodebaseView.Registry_Keys
{
    public class RegistryHandler
    {
        private const string APP_NAME = "CodeBaseView";
        private const string APP_DIRECTORY_REPOS = "RepositoryDirectories";


        public static void writeFileLocation(string repourl, string fileDirectory)
        {
            //key = repoURL
            //value = directory

            //
            //IF THIS FAILS YOU PROBABLY DIDNT RUN VISUAL STUDIO OR THE PROGRAM AS ADMIN
            //

            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", true);
            key.CreateSubKey(APP_NAME);
            key = key.OpenSubKey(APP_NAME, true);

            key.CreateSubKey(APP_DIRECTORY_REPOS);
            key = key.OpenSubKey(APP_DIRECTORY_REPOS, true);

            key.SetValue(repourl, fileDirectory);
        }

        public static string readFileLocation(string repourl)
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\" + APP_NAME + "\\" + APP_DIRECTORY_REPOS))
                {
                    if (key != null)
                    {
                        Object o = key.GetValue(repourl);
                        if (o != null)
                        {
                            string fileDirectory = o as string;
                            return fileDirectory;
                        }
                    }
                }
            }
            catch (Exception ex)  
            {
                Console.WriteLine(ex.Message.ToString());
                //IF THIS FAILS YOU PROBABLY DIDNT RUN VISUAL STUDIO OR THE PROGRAM AS ADMIN
                return null;
            }
            return null;
        }
    }
}
