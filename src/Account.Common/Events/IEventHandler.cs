using System;
using System.Threading.Tasks;

namespace Account.Common.Events
{
    public interface IEventHandler<in T> where T : IEvent
    {
        Guid HandlerId { get; }

        Task HandleAsync(T message);
    }
}