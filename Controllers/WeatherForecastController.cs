using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Requests_and_Responses.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet("header")]
        public IActionResult GetHeader()
        {
            var headers = base.Request.Headers;
            Console.WriteLine(headers);
            return base.Ok(headers);
        }
        [HttpGet("query")]
        public IActionResult GetQuery()
        {
            var queries  = base.Request.Query;
            Console.WriteLine(queries);
            return base.Ok(queries);
        }
    }
}
