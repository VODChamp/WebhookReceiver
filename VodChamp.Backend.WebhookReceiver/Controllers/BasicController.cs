using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace VodChamp.Backend.WebhookReceiver.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BasicController : ControllerBase
    {
        private readonly ILogger<BasicController> _logger;

        public BasicController(ILogger<BasicController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok();
        }
    }
}
