using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


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

            IServiceProvider services = new ServiceCollection()
                .AddOptions()
                .BuildServiceProvider();

            Console.WriteLine("Hello World!");

            Console.ReadLine();
        }
    }
}
