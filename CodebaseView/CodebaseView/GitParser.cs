using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodebaseView
{
    public class GitParser
    {
        private List<Commit> commits;
        //private List<file> files;
        private string newestCommitID;

        public GitParser()
        {
            this.commits = new List<Commit>();
            //this.files = new List<file>();
        }

        public void init()
        {
            initCommits();
            initNewestCommit();
        }

        private List<string> runGitCommandProcess(string args)
        {
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "git",
                    Arguments = args,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };
            proc.Start();

            List<string> outputLines = new List<string>();
            while (!proc.StandardOutput.EndOfStream)
            {
                string line = proc.StandardOutput.ReadLine();
                outputLines.Add(line);
            }
            return outputLines;
        }

        private void initNewestCommit()
        {
            List<string> lines = runGitCommandProcess("log --all -1");
            this.newestCommitID = lines[0].Substring(7, 40);

        }

        private void initCommits()
        {
            List<string> commitLines = runGitCommandProcess("log --all");
            for (int i = 0; i < commitLines.Count; i++)
            {
                string line = commitLines[i];
                if (line.StartsWith("commit"))
                {
                    Commit commit = new Commit();
                    commit.commit_hash = line.Substring(7, 40);

                    string authorline;
                    string dateline;
                    int messagelinestart;

                    if (commitLines[i + 1].StartsWith("Merge:"))
                    {
                        authorline = commitLines[i + 2];
                        dateline = commitLines[i + 3];
                        messagelinestart = 5;
                    }
                    else
                    {
                        authorline = commitLines[i + 1];
                        dateline = commitLines[i + 2];
                        messagelinestart = 4;
                    }

                    string authorEmail = authorline.Substring(8);
                    int emailStart = authorEmail.IndexOf('<') + 1;
                    int emailEnd = authorEmail.IndexOf('>');
                    commit.email = authorEmail.Substring(emailStart, emailEnd - emailStart - 1);
                    commit.author = authorEmail.Substring(0, emailStart - 2);

                    TimeStamp timestamp = new TimeStamp(dateline.Substring(12, 22));
                    commit.timestamp = timestamp;

                    StringBuilder message = new StringBuilder();
                    line = commitLines[i + messagelinestart];
                    int count = messagelinestart;
                    while (!line.StartsWith("commit"))
                    {
                        message.Append(line);
                        count++;
                        if ((i + count) < commitLines.Count)
                            line = commitLines[i + count];
                        else
                            break;
                    }
                    commit.message = message.ToString();

                    this.commits.Add(commit);
                }
            }
        }


        private bool doUpdate()
        {
            //query db to see if it contains newestCommitID
            string query = new SELECTQueryBuilder()
                .setColumns("commit_id").setTables("Commit").build();

            DataTable dt = SQL.execute(query);

            return !dt.Columns.Contains(newestCommitID);
        }

        public void updateDatabase()
        {
            if (doUpdate())
            {
                foreach (Commit commit in this.commits)
                {
                    INSERTQueryBuilder insertQuery = new INSERTQueryBuilder().setTable("commit");
                    //insertQuery.addColumnValue("commit_id", commit.commit_id);
                    insertQuery.addColumnValue("commit_hash", commit.commit_hash);
                    insertQuery.addColumnValue("email", commit.email);
                    insertQuery.addColumnValue("author", commit.author);
                    insertQuery.addColumnValue("message", commit.message);
                    insertQuery.addColumnValue("datetime", commit.timestamp.toString());
                    insertQuery.addColumnValue("repoName", commit.repoName);
                    if (!SQL.executeInsert(insertQuery.build())) break;

                    // run command for each commit hash to see which files it affected
                    // for each file, create and execute insert on file table
                    foreach (string file in getFiles(commit.commit_hash))
                    {
                        INSERTQueryBuilder fileInsert = new INSERTQueryBuilder().setTable("file");
                        int fileNameEnd = file.LastIndexOf('.');
                        fileInsert.addColumnValue("filename", file.Substring(0, fileNameEnd));
                        fileInsert.addColumnValue("file_extension", file.Substring(fileNameEnd));
                        SQL.executeInsert(fileInsert.build());
                    }
                }
            }
        }

        private List<string> getFiles(string commit_hash)
        {
            return runGitCommandProcess("git diff-tree --no-commit-id --name-only -r " + commit_hash);
        }
    }
}
