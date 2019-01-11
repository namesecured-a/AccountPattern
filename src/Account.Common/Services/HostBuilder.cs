using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Hosting;

namespace Account.Common.Services
{
    public class HostBuilder : BuilderBase
    {
        private readonly IWebHost webHost;

        public HostBuilder(IWebHost webHost)
        {
            this.webHost = webHost;
        }
        public override ServiceHost Build()
        {
            throw new NotImplementedException();
        }
    }
}
