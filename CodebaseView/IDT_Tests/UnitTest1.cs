using NUnit.Framework;
using System;
using CodebaseView;

namespace IDT_Tests
{
    public class Tests
    {
        public const string realRepoURL = "https://gitlab.eecs.wsu.edu/2019080728/cpts-421.git";
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void RepoURLTest()
        {
            GitParser gitparser = new GitParser();
            string repoURL = gitparser.retrieveRepoURL();
            Assert.AreEqual(repoURL, realRepoURL);


            Console.WriteLine(repoURL);
            //Assert.Pass();
        }
    }
}