
namespace CodebaseView
{
    public struct Commit
    {
        public string commit_id { get; set; }
        public string commit_hash { get; set; }
        public string authorName { get; set; }
        public string authorEmail { get; set; }
        public string message { get; set; }
        public TimeStamp timestamp { get; set; }
    }
}
