using System;
using System.Collections.Generic;
using System.Text;

namespace Account.Common.Events
{
    public class UserAuthenticated : AuthenticatedEventBase
    {
        protected UserAuthenticated()
        {
        }

        public UserAuthenticated(Guid userId, Guid Id) : base(userId)
        {

        }
    }
}
