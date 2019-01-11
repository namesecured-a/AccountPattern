using Microsoft.AspNetCore.Mvc;

namespace Account.Api.Controllers
{
    [Route("")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet("")]
        public IActionResult Get() => Content("Hello from API");
    }
}
