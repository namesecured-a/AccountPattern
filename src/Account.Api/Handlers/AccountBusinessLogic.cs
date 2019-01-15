using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Account.Api.Handlers
{
    public class AccountBusinessLogic
    {
        public AccountBusinessLogic()
        {
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get; }
    }
}
