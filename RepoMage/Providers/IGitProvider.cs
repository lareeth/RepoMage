using System.Collections.Generic;
using RepoMage.Models;

namespace RepoMage.Providers
{
    public interface IGitProvider
    {
        IList<GitRepo> _repos { get; set; }

        void Setup(GitAccount account);
        IList<GitRepo> GetRepos();
        IList<GitRepo> GetOldRepos();
    }
}
