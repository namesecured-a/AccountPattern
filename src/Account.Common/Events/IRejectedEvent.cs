﻿namespace Account.Common.Events
{
    public interface IRejectedEvent : IEvent
    {
        string Reason { get; }

        string Code { get; }
    }
}