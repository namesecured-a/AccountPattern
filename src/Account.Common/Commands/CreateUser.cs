using System;
using System.Collections.Generic;
using System.Text;

namespace Account.Common.Commands
{
    public class CreateUser : ICommand
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
