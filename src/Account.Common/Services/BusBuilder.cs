using Microsoft.AspNetCore.Hosting;
using RawRabbit;

namespace Account.Common.Services
{
    public class BusBuilder : BuilderBase
    {
        private IWebHost webHost;
        private IBusClient busClient;

        public BusBuilder(IWebHost webHost, IBusClient busClient)
        {
            this.webHost = webHost;
            this.busClient = busClient;
        }

        public override ServiceHost Build()
        {
            return new ServiceHost(this.webHost);
        }
    }
}