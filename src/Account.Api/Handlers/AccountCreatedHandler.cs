using Account.Common.Events;
using System;
using System.Threading.Tasks;

namespace Account.Api.Handlers
{
    public class AccountCreatedHandler : IEventHandler<AccountCreated>
    {
        public Guid HandlerId { get; }

        public AccountCreatedHandler()
        {
            this.HandlerId = Guid.NewGuid();
        }

        public async Task HandleAsync(AccountCreated message)
        {   
            await Task.CompletedTask;
            Console.WriteLine($"event id: {message.Id} handled by handler id: {this.HandlerId}");
        }
    }
}
