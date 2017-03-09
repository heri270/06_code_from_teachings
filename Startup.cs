using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ConsoleApplication
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection servises)
        {
            servises.AddMvc();
        }

       public void Configure(IApplicationBuilder app, ILoggerFactory logger)
       {
           // Log to the Console
           logger.AddConsole();
            app.UseMvcWithDefaultRoute();
       }
    }
}