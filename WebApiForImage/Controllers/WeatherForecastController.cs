using DataLayer;
using Microsoft.AspNetCore.Mvc;

namespace WebApiForImage.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {        
        private readonly IDataRepo dataRepo;

        public WeatherForecastController(IDataRepo dataRepo)
        {
            this.dataRepo = dataRepo;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return this.dataRepo.Get();
        }
    }
}