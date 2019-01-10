using System;
using System.Collections.Generic;
using System.Text;

namespace Account.Common.Events
{
    public class UserCreated : EventBase
    {
        public string Name { get; } 
        public string Email { get; }

        protected UserCreated() : base()
        {
        }
        
        public UserCreated(string name, string email) : base()
        {
            this.Name = name;
            this.Email = email;
        }
    }
}
