var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/compute", () => "#42!Fortytwo");
app.Run();
