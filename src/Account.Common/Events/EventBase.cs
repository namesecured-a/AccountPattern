using System;
using System.Collections.Generic;
using System.Text;

namespace Account.Common.Events
{
    public abstract class EventBase : IEvent
    {
        public DateTime CreatedAt { get; }

        protected EventBase()
        {
            this.CreatedAt = DateTime.UtcNow;
        }
    }
}