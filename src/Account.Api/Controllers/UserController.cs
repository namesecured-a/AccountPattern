using Account.Common.Commands;
using Microsoft.AspNetCore.Mvc;
using RawRabbit;
using System.Threading.Tasks;

namespace Account.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IBusClient busClient;

        public UserController(IBusClient busClient)
        {
            this.busClient = busClient;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody]CreateUser createUserCommand)
        {
            await this.busClient.PublishAsync(createUserCommand);
            return Accepted();
        }
    }
}