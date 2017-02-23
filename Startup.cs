using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApplication
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection servises)
        {
            servises.AddMvc();
        }

       public void Configure(IApplicationBuilder app)
       {
            app.UseMvcWithDefaultRoute();
       }
    }
}