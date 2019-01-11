using Account.Common.Events;
using System;
using System.Threading.Tasks;

namespace Account.Api.Handlers
{
    public class RawAccountCreatedHandler : IEventHandler<RawAccountCreated>
    {
        public async Task HandleAsync(RawAccountCreated message)
        {
            await Task.CompletedTask;
            Console.WriteLine("event handled");
        }
    }
}
