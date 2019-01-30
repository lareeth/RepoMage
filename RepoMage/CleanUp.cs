using System;
using Microsoft.Extensions.Logging;

namespace RepoMage
{
    class CleanUp
    {
        public ILogger _logger { get; set; }

        public CleanUp(ILoggerFactory logger)
        {
            _logger = logger.CreateLogger<CleanUp>();

            _logger.LogInformation("Starting RepoMage at {0}.", DateTime.Now.ToString("F"));

        }
    }
}
