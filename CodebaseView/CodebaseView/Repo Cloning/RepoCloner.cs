using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace CodebaseView.Repo_Cloning
{
    public class RepoCloner
    {
        public const string TEMP_FOLDER_NAME = "CodeBaseView";
        
        public static bool createTempDirectory()
        {
            //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-create-a-file-or-folder

            string path = System.IO.Path.GetTempPath() + TEMP_FOLDER_NAME;

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool isDirectoryCreated()
        {
            string path = System.IO.Path.GetTempPath() + TEMP_FOLDER_NAME;

            if (!Directory.Exists(path))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void cloneRepoIntoTemp(string repoURL)
        {
            createTempDirectory();

            GitParser gitParser = new GitParser();
            string repoName = gitParser.parseNameFromURL(repoURL);
            string directory = Path.GetTempPath() + TEMP_FOLDER_NAME + "\\" + repoName;

            if (Directory.Exists(directory))
            {
                //alert user to overwrite?
            }

            GitParser.cloneNewRepo(repoURL, directory);
            gitParser.initNewRepo("-C " + directory + " log --all");
            gitParser.updateDatabase(directory, repoURL);

            Registry_Keys.RegistryHandler.writeFileLocation(repoURL, directory);
        }

    }
}
