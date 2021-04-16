using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodebaseView.Git_REST_API
{
    public class GitAPIURLBuilder
    {
        private const string BASE_URL = "https://api.github.com";
        private string repoName;
        private string owner;
        private string branch;
        private string author;
        private string commit;
        

        public GitAPIURLBuilder()
        {
            this.repoName = string.Empty;
            this.branch = string.Empty;
            this.branch = string.Empty;
            this.commit = string.Empty;
        }

        public GitAPIURLBuilder setRepo(string owner, string repo)
        {
            this.owner = owner;
            this.repoName = repo;
            return this;
        }

        public GitAPIURLBuilder setBranch(string branch)
        {
            this.branch = branch;
            return this;
        }

        public GitAPIURLBuilder setAuthor(string author)
        {
            this.author = author;
            return this;
        }

        public GitAPIURLBuilder setCommit(string commit)
        {
            this.commit = commit;
            return this;
        }

        private string build()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(BASE_URL);

            if (owner != string.Empty && owner != string.Empty)
            {
                builder.Append("/repos/" + owner + "/" + repoName);
                string url = builder.ToString();

                return url;
            }

            return null;
        }

        public string buildRepo()
        {
            return build();
        }

        public string buildCommits()
        {
            string pre = build();
            StringBuilder builder = new StringBuilder();
            builder.Append(pre);
            builder.Append("/commits");

            string url = builder.ToString();

            return url;
        }


        public string buildSingleCommit(string commitRef)
        {
            string pre = buildCommits();
            StringBuilder builder = new StringBuilder();
            builder.Append(pre);
            builder.Append("/" + commitRef);

            string url = builder.ToString();
            return url;
        }

        public string buildBranches()
        {
            string pre = build();
            StringBuilder builder = new StringBuilder();
            builder.Append(pre);
            builder.Append("/branches");

            string url = builder.ToString();

            return url;
        }

        public string buildSingleBranch(string branchName)
        {
            string pre = buildBranches();
            StringBuilder builder = new StringBuilder();
            builder.Append(pre);
            builder.Append("/" + branchName);

            string url = builder.ToString();
            return url;
        }


    }
}
