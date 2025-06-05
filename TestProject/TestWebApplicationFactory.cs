using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using TestProject.mock;
using WebApplication2;
using WebApplication2.models;


namespace TestProject
{
    class TestWebApplicationFactory : WebApplicationFactory<Program>
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.UseSetting("https_port", "5001");
            builder.UseEnvironment("Testing");
            builder.ConfigureAppConfiguration(config => { });
            builder.ConfigureTestServices(service =>
            {
                service.AddSingleton<IChildService, MockChildService>();
            });
        }
    }
}
