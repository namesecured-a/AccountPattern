using System.Threading.Tasks;

namespace Account.Common.Events
{
    public interface IEventHandler<in T> where T : IEvent
    {
        Task HandleAsync(T message);
    }
}