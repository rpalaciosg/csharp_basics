using Scalar.AspNetCore; 

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
}

/*
* este es el middleware:
* Redirije toda peticion HTTP a HTTPS
*/
app.UseHttpsRedirection();

// descripociones del clima
var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

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
