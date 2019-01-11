using Account.Common.Events;
using System;
using System.Threading.Tasks;

namespace Account.Api.Handlers
{
    public class AccountCreatedHandler : IEventHandler<AccountCreated>
    {
        public async Task HandleAsync(AccountCreated message)
        {   
            await Task.CompletedTask;
            Console.WriteLine($"Account created. Id: {message.Id}");
        }
    }
}
