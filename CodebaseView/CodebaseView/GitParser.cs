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

        public List<string> initCodeChanges(string commit_hash, string location)
        { 
            return runGitCommandProcess("-C " + location + " show " + commit_hash);
        }

        public List<string> initCodeChanges(string commit_hash)
        {
            return runGitCommandProcess("show " + commit_hash);
        }
        public List<string> cloneNewRepo(string url, string folderlocation)
        {
            return this.runGitCommandProcess("clone " + url + " " + folderlocation);
        }

        public string parseNameFromURL(string url)
        {
            char[] repoURL = url.ToCharArray();

            List<char> templist = new List<char>();

            for (int i = repoURL.Length - 1; i >= 0; i--)
            {
                if (repoURL[i] == '/')
                {
                    break;
                }
                else
                {
                    templist.Add(repoURL[i]);
                }
            }

            char[] tempstarter = templist.ToArray();
            Array.Reverse(tempstarter);

            string repoName = new string(tempstarter).Replace(".git", "");
            return repoName;
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
                    commit.authorEmail = authorEmail.Substring(emailStart, emailEnd - emailStart);
                    commit.authorName = authorEmail.Substring(0, emailStart - 2);

                    TimeStamp timestamp = TimeStamp.parseSQLTimeStamp(dateline.Substring(12, 21));
                    commit.timestamp = timestamp;

                    StringBuilder message = new StringBuilder();
                    line = commitLines[i + messagelinestart];
                    int count = messagelinestart;
                    while (!line.StartsWith("commit"))
                    {
                        line = line.Trim(' ');
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

        public void initNewRepo(string param)
        {
            List<string> commitLines = runGitCommandProcess(param);
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
                    commit.authorEmail = authorEmail.Substring(emailStart, emailEnd - emailStart);
                    commit.authorName = authorEmail.Substring(0, emailStart - 2);

                    TimeStamp timestamp = TimeStamp.parseSQLTimeStamp(dateline.Substring(12, 21));
                    commit.timestamp = timestamp;

                    StringBuilder message = new StringBuilder();
                    line = commitLines[i + messagelinestart];
                    int count = messagelinestart;
                    while (!line.StartsWith("commit"))
                    {
                        line = line.Trim(' ');
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

        public string retrieveRepoURL()
        {

            return runGitCommandProcess("config --get remote.origin.url")[0];
        }
        /*
        public void getBranch()
        {
            List<string> branchNames = new List<string>();
            // for (int i = 0; i < branchName.)
            branchNames = runGitCommandProcess("branch -r");
            for (int i = 0; i < branchNames.Count; i++)
            {
                INSERTQueryBuilder branchInsert = new INSERTQueryBuilder().setTable("Branch");
                if (branchNames[i].Contains("origin/HEAD ->"))
                {
                    string head = branchNames[i].Replace("origin/HEAD ->", "");
                    branchInsert.addColumnValue("name", head);
                    branchInsert.addColumnValue("repo_id", )
                    SQL.execute(branchInsert.build());
                    
                }
                else if (branchNames[i].Contains("origin/"))
                {
                    string origin = branchNames[i].Replace("origin/", "");
                    branchInsert.addColumnValue("name", origin);
                    SQL.execute(branchInsert.build());
                }/*
                else if (i == branchNames.Count)
                {
                    branchInsert.addColumnValue("name", branchNames[i]);
                }
                
               // SQL.execute(branchInsert.build());
            }
            

        }*/

        public void updateDatabase()
        {
            if (doUpdate())
            {
                // REPOSITORY TABLE UPDATING
                //figure out what the hell repo we're in
                string repoURL;
                string branchInfo;
                repoURL = runGitCommandProcess("config --get remote.origin.url")[0];

                //see if that repo is in the db
                //if not, insert it
                bool repoExists = SQL.execute(new SELECTQueryBuilder()
                    .setTables("Repository").setColumns("*").setConditionals("repoURL = '" + repoURL + "'").build()).Rows.Count > 0;

                if (!repoExists)
                {
                    INSERTQueryBuilder repoInsert = new INSERTQueryBuilder().setTable("Repository");
                    repoInsert.addColumnValue("repoURL", repoURL);
                    SQL.execute(repoInsert.build());

                }
                //retrieve repo id
                string queryRepoID = new SELECTQueryBuilder().setTables("Repository")
                    .setColumns("repo_id").setConditionals("repoURL = '" + repoURL + "'").build();
                int repo_id = (int)SQL.execute(queryRepoID).Rows[0]["repo_id"];

                List<string> branchNames = new List<string>();
                // for (int i = 0; i < branchName.)
                branchNames = runGitCommandProcess("branch -r");
                for (int i = 0; i < branchNames.Count; i++)
                {
                    INSERTQueryBuilder branchInsert = new INSERTQueryBuilder().setTable("Branch");
                    if (branchNames[i].Contains(" origin/HEAD -> "))
                    {
                        string head = branchNames[i].Replace(" origin/HEAD -> ", "");
                        bool branchExists = SQL.execute(new SELECTQueryBuilder().setTables("Branch").setColumns("*").setConditionals("name = '" + head + "'").build()).Rows.Count > 0;
                        if (!branchExists)
                        {
                            branchInsert.addColumnValue("name", head);
                            branchInsert.addColumnValue("repo_id", repo_id.ToString());
                            SQL.execute(branchInsert.build());
                        }

                    }
                    else if (branchNames[i].Contains(" origin/"))
                    {
                        string origin = branchNames[i].Replace(" origin/", "");
                        bool originExists = SQL.execute(new SELECTQueryBuilder().setTables("Branch").setColumns("*").setConditionals("name = '" + origin + "'").build()).Rows.Count > 0;
                        if (!originExists)
                        {
                            branchInsert.addColumnValue("name", origin);
                            branchInsert.addColumnValue("repo_id", repo_id.ToString());
                            SQL.execute(branchInsert.build());
                        }
                    }
                    
                }
                    // COMMIT TABLE UPDATING
                    foreach (Commit commit in this.commits)
                {
                    // AUTHOR TABLE UPDATING
                    //if there's a new author not in the db, update the author table
                    bool authorExists = SQL.execute(new SELECTQueryBuilder()
                    .setTables("Author").setColumns("*").setConditionals("email = '" + commit.authorEmail + "'").build()).Rows.Count > 0;
                    if (!authorExists)
                    {
                        INSERTQueryBuilder authorInsert = new INSERTQueryBuilder().setTable("Author");
                        authorInsert.addColumnValue("name", commit.authorName);
                        authorInsert.addColumnValue("email", commit.authorEmail);
                        SQL.execute(authorInsert.build());
                    }

                    //query author id by email
                    string queryAuthorID = new SELECTQueryBuilder().setTables("Author")
                    .setColumns("author_id").setConditionals("email = '" + commit.authorEmail + "'").build();
                    int author_id = (int)SQL.execute(queryAuthorID).Rows[0]["author_id"];

                    //check if commit is in db first?
                    bool commitExists = SQL.execute(new SELECTQueryBuilder().setTables("Commit")
                        .setColumns("*").setConditionals("commit_hash = '" + commit.commit_hash + "'").build()).Rows.Count > 0;
                    if (!commitExists)
                    {
                        INSERTQueryBuilder commitInsert = new INSERTQueryBuilder().setTable("commit");
                        commitInsert.addColumnValue("commit_hash", commit.commit_hash);
                        commitInsert.addColumnValue("author_id", author_id + "");
                        commitInsert.addColumnValue("message", commit.message);
                        commitInsert.addColumnValue("datetime", commit.timestamp.ToInsertString());
                        commitInsert.addColumnValue("repo_id", repo_id + "");
                        string commitInsertQuery = commitInsert.build();
                        SQL.execute(commitInsertQuery);

                        string queryCommitID = new SELECTQueryBuilder().setTables("Commit")
                            .setColumns("commit_id").setConditionals("commit_hash = '" + commit.commit_hash + "'").build();
                        int commit_id = (int)SQL.execute(queryCommitID).Rows[0]["commit_id"];

                        // FILE TABLE UDPDATING
                        // run command for each commit hash to see which files it affected
                        // for each file, create and execute insert on file table
                        foreach (string file in getFiles(commit.commit_hash))
                        {
                            // check if file is in db
                            bool fileExists = SQL.execute(new SELECTQueryBuilder().setTables("File")
                                .setColumns("*").setConditionals("filename = '" + file).build() + "'").Rows.Count > 0;
                            int fileNameEnd = file.LastIndexOf('.');
                            if (!fileExists)
                            {
                                INSERTQueryBuilder fileInsert = new INSERTQueryBuilder().setTable("file");
                                fileInsert.addColumnValue("filename", file.Substring(0, fileNameEnd));
                                fileInsert.addColumnValue("file_extension", file.Substring(fileNameEnd));
                                fileInsert.addColumnValue("repo_id", repo_id + "");
                                string fileInsertQuery = fileInsert.build();
                                SQL.execute(fileInsertQuery);
                            }
                            // query file id
                            string queryFileID = new SELECTQueryBuilder().setTables("File")
                            .setColumns("file_id").setConditionals("filename = '" + file.Substring(0, fileNameEnd) + "'", "repo_id = '" + repo_id + "'").build();
                            int file_id = (int)SQL.execute(queryFileID).Rows[0]["file_id"];

                            // FILE_MAP_COMMIT UPDATING
                            INSERTQueryBuilder fileCommitMapInsert = new INSERTQueryBuilder().setTable("File_Map_Commit");
                            fileCommitMapInsert.addColumnValue("file_id", file_id + "");
                            fileCommitMapInsert.addColumnValue("commit_id", commit_id + "");
                            string insertFileCommitMap = fileCommitMapInsert.build();
                            SQL.execute(insertFileCommitMap);
                        }
                    }
                }
            }
        }

        //this is called when a new repo is cloned in %TEMP% on the C:// drive
        public void updateDatabaseTemp(string arguments, string repoURL)
        {

           
            //see if that repo is in the db
            //if not, insert it
            bool repoExists = SQL.execute(new SELECTQueryBuilder()
                .setTables("Repository").setColumns("*").setConditionals("repoURL = '" + repoURL + "'").build()).Rows.Count > 0;
            if (!repoExists)
            {
                INSERTQueryBuilder repoInsert = new INSERTQueryBuilder().setTable("Repository");
                repoInsert.addColumnValue("repoURL", repoURL);
                SQL.execute(repoInsert.build());
            }
            //retrieve repo id
            string queryRepoID = new SELECTQueryBuilder().setTables("Repository")
                .setColumns("repo_id").setConditionals("repoURL = '" + repoURL + "'").build();
            int repo_id = (int)SQL.execute(queryRepoID).Rows[0]["repo_id"];

            // COMMIT TABLE UPDATING
            foreach (Commit commit in this.commits)
            {
                // AUTHOR TABLE UPDATING
                //if there's a new author not in the db, update the author table
                bool authorExists = SQL.execute(new SELECTQueryBuilder()
                .setTables("Author").setColumns("*").setConditionals("email = '" + commit.authorEmail + "'").build()).Rows.Count > 0;
                if (!authorExists)
                {
                    INSERTQueryBuilder authorInsert = new INSERTQueryBuilder().setTable("Author");
                    authorInsert.addColumnValue("name", commit.authorName);
                    authorInsert.addColumnValue("email", commit.authorEmail);
                    SQL.execute(authorInsert.build());
                }

                //query author id by email
                string queryAuthorID = new SELECTQueryBuilder().setTables("Author")
                .setColumns("author_id").setConditionals("email = '" + commit.authorEmail + "'").build();
                int author_id = (int)SQL.execute(queryAuthorID).Rows[0]["author_id"];

                //check if commit is in db first?
                bool commitExists = SQL.execute(new SELECTQueryBuilder().setTables("Commit")
                    .setColumns("*").setConditionals("commit_hash = '" + commit.commit_hash + "'").build()).Rows.Count > 0;
                if (!commitExists)
                {
                    INSERTQueryBuilder commitInsert = new INSERTQueryBuilder().setTable("commit");
                    commitInsert.addColumnValue("commit_hash", commit.commit_hash);
                    commitInsert.addColumnValue("author_id", author_id + "");
                    commitInsert.addColumnValue("message", commit.message);
                    commitInsert.addColumnValue("datetime", commit.timestamp.ToInsertString());
                    commitInsert.addColumnValue("repo_id", repo_id + "");
                    string commitInsertQuery = commitInsert.build();
                    SQL.execute(commitInsertQuery);

                    string queryCommitID = new SELECTQueryBuilder().setTables("Commit")
                        .setColumns("commit_id").setConditionals("commit_hash = '" + commit.commit_hash + "'").build();
                    int commit_id = (int)SQL.execute(queryCommitID).Rows[0]["commit_id"];

                    // FILE TABLE UDPDATING
                    // run command for each commit hash to see which files it affected
                    // for each file, create and execute insert on file table
                    foreach (string file in getFiles(commit.commit_hash))
                    {
                        // check if file is in db
                        bool fileExists = SQL.execute(new SELECTQueryBuilder().setTables("File")
                            .setColumns("*").setConditionals("filename = '" + file).build() + "'").Rows.Count > 0;
                        int fileNameEnd = file.LastIndexOf('.');
                        if (!fileExists)
                        {
                            INSERTQueryBuilder fileInsert = new INSERTQueryBuilder().setTable("file");
                            fileInsert.addColumnValue("filename", file.Substring(0, fileNameEnd));
                            fileInsert.addColumnValue("file_extension", file.Substring(fileNameEnd));
                            fileInsert.addColumnValue("repo_id", repo_id + "");
                            string fileInsertQuery = fileInsert.build();
                            SQL.execute(fileInsertQuery);
                        }
                        // query file id
                        string queryFileID = new SELECTQueryBuilder().setTables("File")
                        .setColumns("file_id").setConditionals("filename = '" + file.Substring(0, fileNameEnd) + "'", "repo_id = '" + repo_id + "'").build();
                        int file_id = (int)SQL.execute(queryFileID).Rows[0]["file_id"];

                        // FILE_MAP_COMMIT UPDATING
                        INSERTQueryBuilder fileCommitMapInsert = new INSERTQueryBuilder().setTable("File_Map_Commit");
                        fileCommitMapInsert.addColumnValue("file_id", file_id + "");
                        fileCommitMapInsert.addColumnValue("commit_id", commit_id + "");
                        string insertFileCommitMap = fileCommitMapInsert.build();
                        SQL.execute(insertFileCommitMap);
                    }
                }
            }

        }

        private List<string> getFiles(string commit_hash)
        {
            List<string> files = runGitCommandProcess("diff-tree --no-commit-id --name-only -r " + commit_hash);
            List<string> returnFiles = new List<string>();
            foreach (string file in files)
            {
                if (!file.Contains('.'))
                {
                    returnFiles.Add(file + ".FILE");
                }
                else
                {
                    returnFiles.Add(file);
                }
            }
            return returnFiles;
        }

    }
}
