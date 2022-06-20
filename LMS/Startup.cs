namespace LMS
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        => services.AddDbContext<LMSContext>();

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
        }
    }
}