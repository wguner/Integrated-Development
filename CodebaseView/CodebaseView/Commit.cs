
namespace CodebaseView
{
    public struct Commit
    {
        public string commit_id { get; set; }
        public string commit_hash { get; set; }
        public string email { get; set; }
        public string author { get; set; }
        public string message { get; set; }
        public string repoName { get; set; }
        public TimeStamp timestamp { get; set; }
    }
}
