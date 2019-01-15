using Account.Common.Commands;
using Microsoft.AspNetCore.Mvc;
using RawRabbit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Account.Services.Business.Controllers
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

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateAccount createAccount)
        {
            createAccount.Id = Guid.NewGuid();
            createAccount.UserId = Guid.NewGuid();

            await this.busClient.PublishAsync(createAccount);
            return Accepted();
        }
    }
}
