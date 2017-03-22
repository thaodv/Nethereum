
using System;
using System.Threading.Tasks;
using Nethereum.JsonRpc.Client;
using Nethereum.RPC.Eth;
using Nethereum.RPC.Tests;
using Xunit;

namespace Nethereum.Parity.Test.Testers
{
    public class ParityGasPriceHistogramTester : RPCRequestTester<string>, IRPCRequestTester
    {
        
        [Fact]
        public async void Should()
        {
            var result = await ExecuteAsync();
            Assert.True();
        }

        public override async Task<string> ExecuteAsync(IClient client)
        {
            var parityGasPriceHistogram = new ParityGasPriceHistogram(client);
            return await parityGasPriceHistogram.SendRequestAsync();
        }

        public override Type GetRequestType()
        {
            return typeof(ParityGasPriceHistogram);
        }
    }
}
        