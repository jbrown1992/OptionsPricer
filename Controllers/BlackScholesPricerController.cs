using Microsoft.AspNetCore.Mvc;

namespace OptionsPricer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlackScholesPricerController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<BlackScholesPricerController> _logger;

        public BlackScholesPricerController(ILogger<BlackScholesPricerController> logger)
        {
            _logger = logger;
        }

        //[HttpGet(Name = "PriceOption")]
        //public  Get()
        //{
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}
    }
}
