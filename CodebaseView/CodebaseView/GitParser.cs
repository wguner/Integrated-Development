using Npgsql;
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
        private List<Commit> commits;

        public GitParser()
        {
            this.outputLines = new List<string>();
            this.commits = new List<Commit>();
            
        }

        public List<string> getCommitIDs()
        {
            List<string> commitIDs = new List<string>();
            foreach (Commit commit in this.commits)
            {
                commitIDs.Add(commit.commit_id);
            }
            return commitIDs;
        }

        public void init()
        {
            initProcess();
            initCommits();
        }

        private void initProcess()
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
                this.outputLines.Add(line);
            }
        }

        private void initCommits()
        {
            for (int i = 0; i < this.outputLines.Count; i++)
            {
                string line = this.outputLines[i];
                if (line.StartsWith("commit"))
                {
                    Commit commit = new Commit();
                    commit.commit_id = line.Substring(7, 40);

                    string authorline;
                    string dateline;
                    int messagelinestart;

                    if (outputLines[i + 1].StartsWith("Merge:"))
                    {
                        authorline = outputLines[i + 2];
                        dateline = outputLines[i + 3];
                        messagelinestart = 5;
                    }
                    else
                    {
                        authorline = outputLines[i + 1];
                        dateline = outputLines[i + 2];
                        messagelinestart = 4;
                    }

                    string authorEmail = authorline.Substring(8);
                    int emailStart = authorEmail.IndexOf('<') + 1;
                    int emailEnd = authorEmail.IndexOf('>');
                    commit.email = authorEmail.Substring(emailStart, emailEnd - emailStart - 1);
                    commit.author = authorEmail.Substring(0, emailStart - 2);

                    string dateTime = dateline.Substring(12, 22);
                    commit.month = dateTime.Substring(0, 3);
                    commit.year = dateTime.Substring(18, 4);
                    commit.day = dateTime.Substring(4, 2);
                    commit.time = dateTime.Substring(8, 8);

                    StringBuilder message = new StringBuilder();
                    line = outputLines[i + messagelinestart];
                    int count = messagelinestart;
                    while (!line.StartsWith("commit"))
                    {
                        message.Append(line);
                        count++;
                        if ((i + count) < this.outputLines.Count)
                            line = outputLines[i + count];
                        else
                            break;
                    }
                    commit.message = message.ToString();

                    this.commits.Add(commit);
                }
            }
        }


        public bool doUpdate(string commit)
        {
            return !commits[0].commit_id.Equals(commit);
        }

        public void updateDatabase(string startingCommitID)
        {
            foreach (Commit commit in this.commits)
            {
                if (commit.commit_id.Equals(startingCommitID)) return;

                INSERTQueryBuilder insertQuery = new INSERTQueryBuilder().setTable("commit");
                insertQuery.addColumnValue("commit_id", commit.commit_id);
                insertQuery.addColumnValue("email", commit.email);
                insertQuery.addColumnValue("author", commit.author);
                insertQuery.addColumnValue("message", commit.message);
                SQL.execute(insertQuery.build());
            }
        }
    }
}
