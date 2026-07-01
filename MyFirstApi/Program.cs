using Scalar.AspNetCore;
using HealthChecks.UI.Client; // para foramto json
using Microsoft.Extensions.Diagnostics.HealthChecks; // para verificaciones personalizadas del sistema

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
#region Health checks
// builder.Services.AddHealthChecks(); // basica
// Health checks con verificaciones personalizadas
builder.Services.AddHealthChecks()
    .AddCheck("Memory", () =>
        HealthCheckResult.Healthy("Memoria suficiente"),
        tags: new[] { "system" })
    .AddCheck("DiskSpace", () =>
    {
        var drive = new DriveInfo(OperatingSystem.IsWindows()
            ? Path.GetPathRoot(Environment.SystemDirectory) ?? "C:"
            : "/");
        var freeSpaceGB = drive.AvailableFreeSpace / 1024.0 / 1024.0 / 1024.0;
        if (freeSpaceGB < 1)
            return HealthCheckResult.Unhealthy($"Espacio en disco bajo: {freeSpaceGB:F2} GB");
        return HealthCheckResult.Healthy($"Espacio en disco: {freeSpaceGB:F2} GB");
    }, tags: new[] { "system" });

// Agregar UI para health checks
builder.Services.AddHealthChecksUI(setup =>
{
    setup.AddHealthCheckEndpoint("Mi API", "/health"); // Endpoint que monitoreará
})
.AddInMemoryStorage(); // Almacenamiento en memoria (para desarrollo)
#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{

    app.MapOpenApi();
    //Swagger Ui con Scalar (alternativa Moderna)
    app.MapScalarApiReference(options =>
    {
        options.Title = "Mi API de Clima";
        options.Theme = ScalarTheme.BluePlanet; // Opcional: cambia el tema
    });
    app.UseSwagger();
    app.UseSwaggerUI(); // Interfaz clásica en /swagger
    app.UseStaticFiles(); // Agregar antes de MapHealthChecksUI
    // Dashboard de health checks
    app.MapHealthChecksUI(options =>
    {
        options.UIPath = "/health-ui"; // Ruta del dashboard
        options.ApiPath = "/health-ui-api"; // API interna del dashboard
    });
}

/*
* este es el middleware:
* Redirije toda peticion HTTP a HTTPS
*/
app.UseHttpsRedirection();
app.UseStaticFiles(); //middleware para archivos staticos
//redireccionamiento
app.Use(async(context, next) => {
    if(context.Request.Path == "/")
    {
      context.Response.Redirect("/index.html");
    }
    else
    {
    await next();
    }
    });


// Mapear el endpoint de health checks
app.MapHealthChecks("/health", new Microsoft.AspNetCore.Diagnostics.HealthChecks.HealthCheckOptions
{
    ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse // Formato JSON detallado
});
// Endpoint específico para verificaciones de sistema
app.MapHealthChecks("/health/system", new Microsoft.AspNetCore.Diagnostics.HealthChecks.HealthCheckOptions
{
    Predicate = (check) => check.Tags.Contains("system"),
    ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
});


//genera un endpoint del verbo GET llamado /weatherforecast
app.MapGet("/weatherforecast", () =>
{
    var forecast =  Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast")
.WithDescription("Retorna un array de 5 dias de pronostico climatico.")
.WithSummary("Obtiene el pronostico del clima");
// .WithOpenApi(); //solo llamada simple sin lambda

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
