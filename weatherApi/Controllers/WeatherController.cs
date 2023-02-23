using Microsoft.AspNetCore.Mvc;
using Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace weatherApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private readonly IWeatherService _weatherService;
        public WeatherController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }
        [HttpGet("{city}")]
        public async Task<string> GetWeatherByCityAsync(string city)
        {
            return await _weatherService.GetWeatherByCityAsync(city);
        }

        [HttpGet("3days/{city}")]
        public async Task<string> GetWeatherFor3DaysByCityAsynce(string city)
        {
            return await _weatherService.GetWeatherFor3DaysByCityAsynce(city);
        }
    }
}
