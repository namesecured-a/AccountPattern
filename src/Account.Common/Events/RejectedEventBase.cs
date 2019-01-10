using System;
using System.Collections.Generic;
using System.Text;

namespace Account.Common.Events
{
    public class RejectedEventBase : EventBase, IRejectedEvent
    {
        public string Reason { get; private set; }

        public string Code { get; private set; }

        protected RejectedEventBase()
        {
            
        }

        protected RejectedEventBase(string reason, string code)
        {
            this.Reason = reason;
            this.Code = code;
        }
    }
}
