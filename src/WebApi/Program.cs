using Yld.GamingApi.WebApi;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddDefaultServices();

var app = builder.Build();

// Configure middleware
app.UseDefaultAppConfig();

app.Run();
