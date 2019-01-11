using Account.Common.Commands;
using Account.Common.Events;
using Microsoft.AspNetCore.Hosting;
using RawRabbit;
using Account.Common.Extensions;

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
            var handler =
                (ICommandHandler<TCommand>) this.webHost.Services.GetService(typeof(ICommandHandler<TCommand>));
            this.busClient.WithCommandHandlerAsync(handler);
            return this;
        }

        public BusBuilder SubscriteToEvent<TEvent>() where TEvent : IEvent
        {
            var serviceProvider = this.webHost.Services;
            var handler = (IEventHandler<TEvent>) this.webHost.Services.GetService(typeof(IEventHandler<TEvent>));
            this.busClient.WithEventHandlerAsync(handler);
            return this;
        }
    }
}