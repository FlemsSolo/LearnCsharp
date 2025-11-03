using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;


//namespace MinimalWebAPI;

var builder = WebApplication.CreateBuilder(args);

// Configure Kestrel to listen on http://localhost:88
builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenLocalhost(88); // binds to 127.0.0.1:88
});

var app = builder.Build();

// Test GET endpoint
app.MapGet("/", () => "Hello, Minimal API!");

app.Run();
