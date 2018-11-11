using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System;

namespace Gerede.Hosting.Identity
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
            Console.Title = "IdentityServer";
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                   .UseStartup<Startup>();
    }
}
