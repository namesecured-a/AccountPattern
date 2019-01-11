using System;
using System.Collections.Generic;
using System.Text;

namespace Account.Common.Events
{
    public class RawAccountCreated : IEvent
    {
        public DateTime CreatedAt { get; }

        protected RawAccountCreated()
        {
            this.CreatedAt = DateTime.UtcNow;
        }       
    }
}
