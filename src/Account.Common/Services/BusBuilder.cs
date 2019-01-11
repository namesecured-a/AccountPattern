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

        public BusBuilder SubscribeToCommand<TMessage>() where TMessage : ICommand
        {
            var handler =
                (ICommandHandler<TMessage>) this.webHost.Services.GetService(typeof(ICommandHandler<TMessage>));
            this.busClient.WithCommandHandlerAsync(handler);
            return this;
        }

        public BusBuilder SubscriteToEvent<TMessage>() where TMessage : IEvent
        {
            var handler = (IEventHandler<TMessage>) this.webHost.Services.GetService(typeof(IEventHandler<TMessage>));
            this.busClient.WithEventHandlerAsync(handler);
            return this;
        }
    }
}