using System;
using Microsoft.AspNetCore.Mvc;

namespace MyWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        // GET api/Health
        [HttpGet]
        public ActionResult<string> Get()
        {
            return $"Hello World from container: {Environment.MachineName}";
        }
    }
}