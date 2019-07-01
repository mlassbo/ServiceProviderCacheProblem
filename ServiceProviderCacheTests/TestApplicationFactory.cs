using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;

namespace ServiceProviderCacheTests
{
    public class TestApplicationFactory : WebApplicationFactory<Startup>
    {
        protected override IWebHostBuilder CreateWebHostBuilder()
        {
            var webHostBuilder = WebHost.CreateDefaultBuilder<Startup>(new string[0]);
            return webHostBuilder;
        }
    }
}
