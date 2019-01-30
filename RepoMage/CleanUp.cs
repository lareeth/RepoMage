using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using RepoMage.Models;

namespace RepoMage
{
    class CleanUp
    {
        public ILogger _logger { get; set; }

        public CleanUp(ILoggerFactory logger, IOptions<List<GitAccount>> accounts)
        {
            _logger = logger.CreateLogger<CleanUp>();

            _logger.LogInformation("     __/\\__    | ___ \\               |  \\/  |                 ");
            _logger.LogInformation(". _  \\\\''//    | |_/ /___ _ __   ___ | .  . | __ _  __ _  ___ ");
            _logger.LogInformation("-( )-/_||_\\    |    // _ \\ '_ \\ / _ \\| |\\/| |/ _` |/ _` |/ _ \\");
            _logger.LogInformation(" .'. \\_()_/    | |\\ \\  __/ |_) | (_) | |  | | (_| | (_| |  __/");
            _logger.LogInformation("  |   | . \\    \\_| \\_\\___| .__/ \\___/\\_|  |_/\\__,_|\\__, |\\___|");
            _logger.LogInformation("  |   | .  \\             | |                        __/ |     ");
            _logger.LogInformation(" .'. ,\\_____'.           |_|                       |___/      ");

            _logger.LogInformation("Starting RepoMage at {0}.", DateTime.Now.ToString("F"));

            foreach (GitAccount account in accounts.Value.Where(x => x.Enabled))
            {
                _logger.LogInformation("======================================================");
                _logger.LogInformation("Name: {0}", account.Name);
                _logger.LogInformation("Platform: {0}", account.Platform);
                _logger.LogInformation("Max Age: {0} months", account.MaxAge);
                _logger.LogInformation("======================================================");
                _logger.LogInformation("");
            }
        }
    }
}
