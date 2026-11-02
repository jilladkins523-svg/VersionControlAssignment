using Microsoft.AspNetCore.Mvc;

namespace VersionControlAssignment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        //jill adkins
        [HttpGet]

        public IActionResult Get()
        {
            return Ok(new { name = "Jill Adkins" });
        }
    }
}
