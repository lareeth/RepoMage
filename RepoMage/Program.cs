using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using RepoMage.Models;
using Serilog;

namespace RepoMage
{
    class Program
    {
        static void Main(string[] args)
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("settings.json")
                .Build();

            Serilog.ILogger logger = new LoggerConfiguration()
               .WriteTo.Console()
               .MinimumLevel.Debug()
               .CreateLogger();

            ILoggerFactory loggerFactory = new LoggerFactory()
                .AddSerilog(logger);

            IServiceProvider services = new ServiceCollection()
                .AddLogging()
                .AddOptions()
                .Configure<List<GitAccount>>(config.GetSection("accounts"))
                .AddSingleton<ILoggerFactory>(loggerFactory)
                .AddSingleton<CleanUp>()
                .BuildServiceProvider();

            services.GetRequiredService<CleanUp>();
        }
    }
}
