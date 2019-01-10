using System;
using System.Collections.Generic;
using System.Text;

namespace Account.Common.Events
{
   public  class AccountCreated : AuthenticatedEventBase
    {
        public Guid Id { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }

        protected AccountCreated()
        {
        }

        public AccountCreated(Guid userId, Guid id, decimal amount, string description) : base(userId)
        {
            this.Id = id;
            this.Amount = amount;
            this.Description = description;
        }
    }
}
