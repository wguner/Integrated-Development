using NUnit.Framework;
using System;
using CodebaseView;
using System.Reflection;

namespace IDT_Tests
{
    public class Tests
    {
        public const string realRepoURL = "https://gitlab.eecs.wsu.edu/2019080728/cpts-421.git";
        public const string repoName = "cpts-421";

        [Test]
        public void RepoURLTest()
        {
            GitParser gitparser = new GitParser();
            string repoURL = gitparser.retrieveRepoURL();
            Assert.AreEqual(repoURL, realRepoURL);
        }

        [Test]
        public void repoNameTest()
        {
            GitParser gitParser = new GitParser();
            string parsedName = gitParser.parseNameFromURL(realRepoURL);
            Assert.AreEqual(repoName, parsedName);
        }

        [Test]
        public void SelectQuery1()
        {
            string testQuery = "SELECT commit_id FROM Commit";
            string query = new SELECTQueryBuilder()
                .setColumns("commit_id").setTables("Commit").build();
            Assert.AreEqual(query, testQuery);
        }

        [Test]
        public void SelectQuery2()
        {
            string testQuery = "SELECT author_id FROM Author";
            string queryAuthorID = new SELECTQueryBuilder().setTables("Author")
                .setColumns("author_id").build();
            Assert.AreEqual(queryAuthorID, testQuery);
        }

        [Test]
        public void SelectQuery3()
        {
            string testQuery = "SELECT commit_id FROM Commit";
            string queryCommitID = new SELECTQueryBuilder().setTables("Commit")
                        .setColumns("commit_id").build();
            Assert.AreEqual(queryCommitID, testQuery);
        }

        [Test]
        public void SelectQuery4()
        {
            string testQuery = "SELECT branch_id FROM Branch";
            string queryBranchID = new SELECTQueryBuilder().setTables("Branch")
                            .setColumns("branch_id").build();
            Assert.AreEqual(queryBranchID, testQuery);
        }

        [Test]
        public void SelectQuery5()
        {
            string testQuery = "SELECT file_id FROM File";
            string queryFileID = new SELECTQueryBuilder().setTables("File")
                            .setColumns("file_id").build();
            Assert.AreEqual(queryFileID, testQuery);
        }

        [Test]
        public void InsertQuery1()
        {
            string testQuery = "INSERT INTO Repository() VALUES ()";
            INSERTQueryBuilder repoInsert = new INSERTQueryBuilder().setTable("Repository");
            string insertQuery = repoInsert.build();
            Assert.AreEqual(insertQuery, testQuery);
        }

        [Test]
        public void InsertQuery2()
        {
            string testQuery = "INSERT INTO Author() VALUES ()";
            INSERTQueryBuilder authorInsert = new INSERTQueryBuilder().setTable("Author");
            string insertQuery = authorInsert.build();
            Assert.AreEqual(testQuery, insertQuery);
        }

        [Test]
        public void InsertQuery3()
        {
            string testQuery = "INSERT INTO Commit_Map_Branch() VALUES ()";
            INSERTQueryBuilder branchCommitMapInsert = new INSERTQueryBuilder().setTable("Commit_Map_Branch");
            string insertBranchCommitMap = branchCommitMapInsert.build();
            Assert.AreEqual(testQuery, insertBranchCommitMap);
        }        
    }
}