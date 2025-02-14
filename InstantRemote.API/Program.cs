using Microsoft.AspNetCore;
using System.Drawing;


namespace InstantRemote.Api
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {

            AppContext.SetSwitch("System.Drawing.EnableUnixSupport", true);
            var builder = WebHost.CreateDefaultBuilder(args).UseStartup<Startup>()
                .ConfigureAppConfiguration((builderContext, config) =>
                {
                    config.AddJsonFile("serilog-config.json");
                });

            return builder;
        }
    }
}