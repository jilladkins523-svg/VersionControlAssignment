using Microsoft.AspNetCore.Mvc;

namespace VersionControlAssignment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Jill Adkins";
        }
    }
}
