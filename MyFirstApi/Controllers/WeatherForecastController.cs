using Microsoft.AspNetCore.Mvc;
namespace MyFirstApi.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class WeatherForecastController
{
  // descripociones del clima
  private string readonly string[] summaries = new[]
  {
      "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
  };
}
