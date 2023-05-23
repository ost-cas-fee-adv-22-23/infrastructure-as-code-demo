var builder = WebApplication.CreateBuilder(args);
builder.WebHost.ConfigureKestrel(o => o.ListenAnyIP(int.Parse(Environment.GetEnvironmentVariable("PORT") ?? "8080")));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

await app.RunAsync();
