using Account.Common.Commands;
using Account.Common.Events;
using Microsoft.AspNetCore.Hosting;
using RawRabbit;
using Account.Common.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace Account.Common.Services
{
    public class BusBuilder : BuilderBase
    {
        private IWebHost webHost;
        private IBusClient busClient;

        public BusBuilder(IWebHost webHost, IBusClient busClient)
        {
            this.webHost = webHost;
            this.busClient = busClient;
        }

        public override ServiceHost Build()
        {
            return new ServiceHost(this.webHost);
        }

        public BusBuilder SubscribeToCommand<TCommand>() where TCommand : ICommand
        {
            using(var scope = this.webHost.Services.CreateScope())
            {
                var serviceProvider = scope.ServiceProvider;
                var handler =
                (ICommandHandler<TCommand>)serviceProvider.GetRequiredService(typeof(ICommandHandler<TCommand>));
                this.busClient.WithCommandHandlerAsync(handler);
            }            
            return this;
        }

        public BusBuilder SubscriteToEvent<TEvent>() where TEvent : IEvent
        {
            using(var scope = this.webHost.Services.CreateScope())
            {
                var serviceProvider = scope.ServiceProvider;
                var handler = (IEventHandler<TEvent>)serviceProvider.GetRequiredService(typeof(IEventHandler<TEvent>));
                this.busClient.WithEventHandlerAsync(handler);
            }
            return this;
        }
    }
}