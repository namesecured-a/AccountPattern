using System;
using System.Threading.Tasks;
using Account.Common.Commands;
using Account.Common.Events;
using RawRabbit;

namespace Account.Services.Business.Handlers
{
    public class CreateAccountHandler : ICommandHandler<CreateAccount>
    {
        private readonly IBusClient busClient;

        public CreateAccountHandler(IBusClient busClient)
        {
            this.busClient = busClient;
        }
        public async Task HandleAsync(CreateAccount command)
        {
            Console.WriteLine($"Creating account amount: {command.Amount}");

            var @event = new AccountCreated(command.UserId, command.Id, command.Amount, command.Description);
            await this.busClient.PublishAsync(@event);
            Console.WriteLine($"Account created. Id: {@event.Id}");
        }
    }
}