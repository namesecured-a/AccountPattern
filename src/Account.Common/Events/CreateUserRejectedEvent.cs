using System;
using System.Collections.Generic;
using System.Text;

namespace Account.Common.Events
{
    public class CreateUserRejectedEvent : RejectedEventBase
    {
        public string Email { get; private set; }

        protected CreateUserRejectedEvent()
        {
            
        }

        public CreateUserRejectedEvent(string email, string reason, string code) : base(reason, code)
        {
            this.Email = email;
        }
    }
}
