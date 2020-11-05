using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodebaseView
{
    public class GitParser
    {
        private List<string> outputLines;
        private List<string> commits;

        public GitParser()
        {
            outputLines = new List<string>();
            init();
            initCommits();
        }

        private void init()
        {
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
                outputLines.Add(line);
            }
        }

        private void initCommits()
        {
            foreach (string line in outputLines)
            {
                if (line.StartsWith("commit"))
                {
                    commits.Add(line.Substring(7, 40));
                }
            }
        }

        public bool doUpdate(string commit)
        {
            return commits[0] == commit;
        }

    }
}
