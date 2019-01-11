using Account.Common.Commands;
using Microsoft.AspNetCore.Mvc;
using RawRabbit;
using System;
using System.Threading.Tasks;

namespace Account.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IBusClient busClient;

        public AccountController(IBusClient busClient)
        {
            this.busClient = busClient;
        }

        [HttpPost("")]
        public async Task<IActionResult> Post([FromBody]CreateAccount createAccountCommand)
        {
            createAccountCommand.Id = Guid.NewGuid();
            createAccountCommand.CreatedAt = DateTime.UtcNow;
            await this.busClient.PublishAsync(createAccountCommand);
            return Accepted($"accounts/{createAccountCommand.Id}");
        }
    }
}
