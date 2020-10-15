using Microsoft.VisualBasic;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Text;

namespace GitCommandExecutionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Git Command Execution in C# Demo!");

            string directory = Directory.GetCurrentDirectory();

            string git = "git";
            string gitLogArg = @"log";

           Console.WriteLine(System.Diagnostics.Process.Start(git, gitLogArg))

            /*Collection<PSObject> results;
            using (PowerShell powershell = PowerShell.Create())
            {
                powershell.AddScript($"cd {directory}");

                powershell.AddScript(@"git init");
                powershell.AddScript(@"git log");
                results = powershell.Invoke();
            }

            foreach (PSObject ps in results)
            {
                Console.WriteLine(ps.ToString());
            }*/


        }
    }
}
