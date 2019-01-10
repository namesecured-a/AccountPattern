using System;

namespace Account.Common.Events
{
    public abstract class AuthenticatedEventBase : EventBase, IAuthenticatedEvent
    {
        public Guid UserId { get; private set; }

        protected AuthenticatedEventBase()
        {
        }


        protected AuthenticatedEventBase(Guid userId)
        {
            this.UserId = userId;
        }
    }
}
