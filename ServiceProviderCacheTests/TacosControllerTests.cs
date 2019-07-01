using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ServiceProviderCacheTests
{
    [TestClass]
    public class TacosControllerTests
    {
        private HttpClient _client;

        [TestInitialize]
        public void InitializeTest()
        {
            var factory = new TestApplicationFactory();
            _client = factory.CreateClient();
        }

        [TestMethod]
        public async Task Get_Tacos_1()
        {
            await _client.GetAsync($"tacos/{Guid.NewGuid()}");
        }

        [TestMethod]
        public async Task Get_Tacos_2()
        {
            await _client.GetAsync($"tacos/{Guid.NewGuid()}");
        }

        [TestMethod]
        public async Task Get_Tacos_3()
        {
            await _client.GetAsync($"tacos/{Guid.NewGuid()}");
        }

        [TestMethod]
        public async Task Get_Tacos_4()
        {
            await _client.GetAsync($"tacos/{Guid.NewGuid()}");
        }

        [TestMethod]
        public async Task Get_Tacos_5()
        {
            await _client.GetAsync($"tacos/{Guid.NewGuid()}");
        }

        [TestMethod]
        public async Task Get_Tacos_6()
        {
            await _client.GetAsync($"tacos/{Guid.NewGuid()}");
        }

        [TestMethod]
        public async Task Get_Tacos_7()
        {
            await _client.GetAsync($"tacos/{Guid.NewGuid()}");
        }

        [TestMethod]
        public async Task Get_Tacos_8()
        {
            await _client.GetAsync($"tacos/{Guid.NewGuid()}");
        }

        [TestMethod]
        public async Task Get_Tacos_9()
        {
            await _client.GetAsync($"tacos/{Guid.NewGuid()}");
        }

        [TestMethod]
        public async Task Get_Tacos_10()
        {
            await _client.GetAsync($"tacos/{Guid.NewGuid()}");
        }

        [TestMethod]
        public async Task Get_Tacos_11()
        {
            await _client.GetAsync($"tacos/{Guid.NewGuid()}");
        }
    }
}
