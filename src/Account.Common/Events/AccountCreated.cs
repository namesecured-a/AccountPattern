using System;
using System.Collections.Generic;
using System.Text;

namespace Account.Common.Events
{
   public  class AccountCreated : IAuthenticatedEvent
    {
        public Guid UserId { get; set; }
        public Guid Id { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
