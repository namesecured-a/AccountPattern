
using System.Reflection;

using System.Threading.Tasks;
using Account.Common.Commands;
using Account.Common.Events;
using RawRabbit;

namespace Account.Common.Extensions
{
    public static class BusClientExtension
    {
        public static Task WithCommandHandlerAsync<TMessage>(this IBusClient busClient,
            ICommandHandler<TMessage> handler) where TMessage : ICommand
            => busClient.SubscribeAsync<TMessage>(msg => handler.HandleAsync(msg),
                ctx => ctx.UseSubscribeConfiguration(cfg =>
                    cfg.FromDeclaredQueue(q => q.WithName(GetQueueName<TMessage>()))));

        public static Task WithEventHandlerAsync<TMessage>(this IBusClient busClient,
            IEventHandler<TMessage> handler) where TMessage : IEvent
            => busClient.SubscribeAsync<TMessage>(msg => handler.HandleAsync(msg),
                ctx => ctx.UseSubscribeConfiguration(cfg =>
                    cfg.FromDeclaredQueue(q => q.WithName(GetQueueName<TMessage>()))));

        private static string GetQueueName<T>() => $"{Assembly.GetEntryAssembly().GetName()}/{typeof(T).Name}";
    }
}
