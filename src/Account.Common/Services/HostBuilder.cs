using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Hosting;
using RawRabbit;

namespace Account.Common.Services
{
    public class HostBuilder : BuilderBase
    {
        private readonly IWebHost webHost;

        private IBusClient busClient;

        public HostBuilder(IWebHost webHost)
        {
            this.webHost = webHost;
        }
        public override ServiceHost Build()
        {
            throw new NotImplementedException();
        }

        public BusBuilder UseRabbitMq()
        {
            this.busClient = (IBusClient)this.webHost.Services.GetService(typeof(IBusClient));
            return new BusBuilder(this.webHost, this.busClient);
        }
    }
}
