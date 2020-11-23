using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace FirstConsoleApp
{
    public class Startup
    {
        public void ConfigurationServices(IServiceCollection service)
        {

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment host)
        {
            app.UseRouting();
            app.UseEndpoints(endPoints =>
                endPoints.MapGet("/", async context =>
                    await context.Response.WriteAsync("Hello From Koushik")
                )
            );
        }
    }
}