using Account.Common.Events;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace Account.Api.Handlers
{
    public class AccountCreatedHandler : IEventHandler<AccountCreated>
    {
        private readonly IServiceScopeFactory serviceScopeFactory;

        public Guid HandlerId { get; }

        public AccountCreatedHandler(IServiceScopeFactory serviceScopeFactory)
        {
            this.HandlerId = Guid.NewGuid();
            this.serviceScopeFactory = serviceScopeFactory;
        }

        public async Task HandleAsync(AccountCreated message)
        {   
            await Task.CompletedTask;
            using(var scope = this.serviceScopeFactory.CreateScope())
            {
                Console.WriteLine("scope is created");
                var bl1 = scope.ServiceProvider.GetRequiredService<AccountBusinessLogic>();
                Console.WriteLine($"bl1: {bl1.Id}");
                var bl2 = scope.ServiceProvider.GetRequiredService<AccountBusinessLogic>();
                Console.WriteLine($"bl2: {bl2.Id}");
            }
            Console.WriteLine($"event id: {message.Id} handled by handler id: {this.HandlerId}");
        }
    }
}
