﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Account.Common.Commands
{
    public interface IAuthenticatedCommand : ICommand
    {
        Guid UserId { get; set; }
    }
}
