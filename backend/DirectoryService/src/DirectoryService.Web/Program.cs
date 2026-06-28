
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddHealthChecks();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapControllers();

app.MapHealthChecks("/health");

await app.RunAsync();