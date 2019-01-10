using System;
using System.Collections.Generic;
using System.Text;

namespace Account.Common.Events
{
    public class UserCreated : IEvent
    {
        public string Name { get; } 
        public string Email { get; }

        protected UserCreated(string name, string email)
        {
            this.Name = name;
            this.Email = email;
        }
    }
}
