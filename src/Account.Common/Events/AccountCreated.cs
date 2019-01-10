using System;
using System.Collections.Generic;
using System.Text;

namespace Account.Common.Events
{
   public  class AccountCreated : EventBase, IAuthenticatedEvent
    {
        public Guid UserId { get; set; }
        public Guid Id { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }

        protected AccountCreated()
        {
            
        }

        public AccountCreated(Guid userId, Guid id, decimal amount, string description)
        {
            this.UserId = userId;
            this.Id = id;
            this.Amount = amount;
            this.Description = description;
        }
    }
}
