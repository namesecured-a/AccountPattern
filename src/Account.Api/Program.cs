using Account.Common.Events;
using Account.Common.Services;

namespace Account.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ServiceHost.Create<Startup>(args)
                .UseRabbitMq()
                .SubscriteToEvent<AccountCreated>()
                .Build()
                .Run();
        }
    }
}
