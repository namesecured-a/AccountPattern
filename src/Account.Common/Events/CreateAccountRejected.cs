using System;
using System.Collections.Generic;
using System.Text;

namespace Account.Common.Events
{
    public class CreateAccountRejected : RejectedEventBase
    {
        public decimal Amount { get; set; }
        public string Description { get; set; }

        protected CreateAccountRejected()
        {
        }

        public CreateAccountRejected(decimal amount, string description)
        {
            this.Amount = amount;
            this.Description = description;
            }
    }
}
