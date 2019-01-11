using Account.Common.Commands;
using Account.Common.Services;

namespace Account.Services.Business
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ServiceHost.Create<Startup>(args)
                 .UseRabbitMq()
                 .SubscribeToCommand<CreateAccount>()
                 .Build()
                 .Run();
        }
    }
}
