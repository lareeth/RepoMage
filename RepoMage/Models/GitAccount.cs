namespace RepoMage.Models
{
    public class GitAccount
    {
        public string Name { get; set; }
        public bool Enabled { get; set; }
        public Platform Platform { get; set; }
        public string GithubToken { get; set; }
        public string BitbucketKey { get; set; }
        public string BitbucketSecretKey { get; set; }
        public string AccountName { get; set; }
        public int MaxAge { get; set; }
        public bool DryRun { get; set; }

        public GitAccount()
        {
            DryRun = false;
        }
    }

    public enum Platform
    {
        Github,
        BitBucket,
        Mocked
    }
}
