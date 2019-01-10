using System;

namespace Account.Common.Events
{
    public interface IEvent
    {
        DateTime CreatedAt { get; }
    }
}