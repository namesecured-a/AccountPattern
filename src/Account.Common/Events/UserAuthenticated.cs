using System;
using System.Collections.Generic;
using System.Text;

namespace Account.Common.Events
{
    public class UserAuthenticated : AuthenticatedEventBase
    {
        public string Name { get; set; }
        public string Email { get; set; }
        protected UserAuthenticated()
        {
        }

        public UserAuthenticated(Guid userId, string name, string email) : base(userId)
        {
            this.Name = name;
            this.Email = email;
        }
    }
}
