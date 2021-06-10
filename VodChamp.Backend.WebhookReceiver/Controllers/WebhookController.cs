using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace VodChamp.Backend.WebhookReceiver.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WebhookController : ControllerBase
    {
        private readonly ILogger<WebhookController> _logger;

        public WebhookController(ILogger<WebhookController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public ActionResult Receive() => Ok();
    }
}
