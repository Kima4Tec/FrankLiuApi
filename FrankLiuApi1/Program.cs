
/*
Opretter og konfigurerer en applikationsbuilder, som bruges til at bygge og konfigurere en webapplikation
- Læser og behandler kommandolinjeargumenter (args) – fx fra dotnet run.
- Konfigurerer:
    - Konfigurationskilder(fx appsettings.json, miljøvariabler osv.)
    - Logging
    - Dependency Injection (DI-container)
    - WebHost
*/
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

// Add services to the container.
var app = builder.Build();

// Configure the HTTP request pipeline.

//All that starts with use are middleware component and part of the pipeline

//Middleware components
app.UseHttpsRedirection();
//app.UseRouting();
//app.UseAuthentication();
//app.UseAuthorization();

//// Routing to endpoints
//// ""/shirts"

app.MapControllers();


//app.MapGet("/shirts", () =>
//{
//    return "Reading all the shirts";
//});

//app.MapGet("/shirts/{id}", (int id) =>
//{
//    return $"Reading shirt with id: {id}";
//});

//app.MapPost("shirts/", () =>
//{
//    return "Creating a shirt";
//});

//app.MapPut("/shirts/{id}", (int id) =>
//{
//    return $"Updating shirt with id: {id}";

//});

//app.MapDelete("/shirts/{id}", (int id) =>
//{
//    return $"Deleting shirt with id: {id}";
//});

app.Run();


