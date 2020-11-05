using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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

            /*string directory = Directory.GetCurrentDirectory();

            string git = "git";
            string gitLogArg = @"log";

            Dictionary<int, string> commits = new Dictionary<int, string>();
            int index = 1;

            Process process = new Process();
            process.StartInfo.RedirectStandardOutput = true;
            process = Process.Start(git, gitLogArg);*/

            string output = "";
            List<string> lines = new List<string>();
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "git",
                    Arguments = "log",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            proc.Start();
            while (!proc.StandardOutput.EndOfStream)
            {
                string line = proc.StandardOutput.ReadLine();
                output += line + "\n";
                lines.Add(line);
            }
            Console.WriteLine(output);

            
            List<string> commits = new List<string>();
            foreach (string line in lines)
            {
                if (line.StartsWith("commit"))
                {
                    commits.Add(line.Substring(7, 40));
                }
            }
            commits.ForEach(commit => { Console.WriteLine("commit: " + commit); });
        }
    }
}
