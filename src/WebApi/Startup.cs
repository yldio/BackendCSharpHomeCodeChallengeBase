namespace Yld.GamingApi.WebApi;

public sealed class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDefaultServices();
    }

    public void Configure(IApplicationBuilder app)
    {
        app.UseDefaultAppConfig();
    }

}
