using System;

namespace Account.Common.Events
{
    public interface IAuthenticatedEvent :IEvent
    {
        Guid UserId { get; }
    }
}