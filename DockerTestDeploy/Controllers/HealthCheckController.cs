using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DockerTestDeploy.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HealthCheckController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
{
            "Health check successfully!"
        };

        [HttpGet(Name = "Health-Check")]
        public string Get()
        {
            return Summaries[0];
        }
    }
}
